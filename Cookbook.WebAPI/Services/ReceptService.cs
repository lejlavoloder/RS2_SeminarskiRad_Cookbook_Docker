using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class ReceptService : BaseCRUDService<Model.Recept, ReceptSearchRequest, Database.Recept, ReceptUpsertRequest, ReceptUpsertRequest>
    {
        public ReceptService(CookbookContext db, IMapper mapper) : base(db, mapper)
        {

        }
        public override List<Model.Recept> Get(ReceptSearchRequest search)
        {
            var q = _context.Set<Database.Recept>().AsQueryable();
            if (search?.SlozenostId.HasValue == true) {
                if (search?.KategorijaId.HasValue == true)
                {
                    q = q.Where(s => s.SlozenostId == search.SlozenostId && s.KategorijaId == search.KategorijaId);
                }
                else if (search?.GrupaJelaId.HasValue == true)
                {
                    q = q.Where(s => s.SlozenostId == search.SlozenostId && s.GrupaJelaId == search.GrupaJelaId);
                } 
            }
           else if (search?.GrupaJelaId.HasValue == true) { 
                  if (search?.KategorijaId.HasValue == true)
                {
                    q = q.Where(s => s.GrupaJelaId == search.GrupaJelaId && s.KategorijaId == search.KategorijaId);
                }
            }
            else
            {
                if (search?.SlozenostId.HasValue == true)
                {
                    q = q.Where(s => s.Slozenost.SlozenostId == search.SlozenostId);
                }
                else if(search?.KategorijaId.HasValue == true)
                {
                    q = q.Where(s => s.Kategorija.KategorijaId == search.KategorijaId);
                }
                else
                {
                    q = q;
                }

            }
            var list = q.ToList();
            var list1= _mapper.Map<List<Model.Recept>>(list);
            foreach(var ocjena in list1)
            {
                ocjena.Ocjena=_context.Ocjena.Where(b=>b.ReceptId==ocjena.ReceptId)
                    .Average(x => (decimal?)x.ocjena) ?? new decimal(0);
            }
            return list1;
        }

    }

}

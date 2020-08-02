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
        public List<Model.Recept> Get(ReceptSearchRequest search)
        {
            var q = _context.Set<Database.Recept>().AsQueryable();
            if ((!string.IsNullOrEmpty(search?.Naziv) && search?.GrupaJelaId.HasValue == true) 
                || (!string.IsNullOrEmpty(search?.Naziv) && search?.KategorijaId.HasValue == true))
            {
                q = q.Where(s => s.Naziv.Equals(search.Naziv) && (s.GrupaJelaId == search.GrupaJelaId || s.KategorijaId==search.KategorijaId));
            }
           
            if ((!string.IsNullOrEmpty(search?.Naziv) && search?.SlozenostId.HasValue == true)||(search.KategorijaId.HasValue == true && search?.GrupaJelaId.HasValue == true))
            {
                q = q.Where(s => s.Naziv.Equals(search.Naziv) && s.SlozenostId == search.SlozenostId || (s.KategorijaId==search.KategorijaId && s.SlozenostId==search.SlozenostId));
            }
            if (search.KategorijaId.HasValue==true && search?.GrupaJelaId.HasValue == true || (search?.GrupaJelaId.HasValue == true && search?.SlozenostId.HasValue == true))
            {
                q = q.Where(s => s.KategorijaId==search.KategorijaId&& s.GrupaJelaId == search.GrupaJelaId || (s.SlozenostId == search.SlozenostId && s.GrupaJelaId == search.GrupaJelaId));
            } 
           if (!string.IsNullOrEmpty(search?.Naziv))
                {
                    q = q.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv) || x.Naziv.ToUpper().StartsWith(search.Naziv));
                }
           if (search?.SlozenostId.HasValue == true || search?.GrupaJelaId.HasValue == true || search?.KategorijaId.HasValue == true)
                {
                    q = q.Where(s => s.Slozenost.SlozenostId == search.SlozenostId || s.GrupaJela.GrupaJelaId == search.GrupaJelaId||s.Kategorija.KategorijaId == search.KategorijaId);
                }
            var list = q.ToList();
            return _mapper.Map<List<Model.Recept>>(list);
        }

    }

}

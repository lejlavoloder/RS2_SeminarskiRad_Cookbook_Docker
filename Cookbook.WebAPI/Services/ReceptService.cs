using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
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
            var q = _context.Set<Recept>()
                .Include(x => x.Kategorija)
                .Include(x => x.Slozenost)
                .Include(x => x.GrupaJela)
                .Include(x => x.Ocjena)
                .Include(x => x.Korisnik)
                .AsQueryable();
            if (search?.SlozenostId.HasValue == true && search?.SlozenostId>0) {
                if (search?.KategorijaId.HasValue == true && search?.KategorijaId>0)
                {
                    q = q.Where(s => s.SlozenostId == search.SlozenostId && s.KategorijaId == search.KategorijaId);
                }
                else if (search?.GrupaJelaId.HasValue == true && search?.GrupaJelaId>0)
                {
                    q = q.Where(s => s.SlozenostId == search.SlozenostId && s.GrupaJelaId == search.GrupaJelaId);
                } 
            }
           else if (search?.GrupaJelaId.HasValue == true && search?.GrupaJelaId>0) { 
                  if (search?.KategorijaId.HasValue == true && search.KategorijaId>0)
                {
                    q = q.Where(s => s.GrupaJelaId == search.GrupaJelaId && s.KategorijaId == search.KategorijaId);
                }
            }
            else
            {
                if (search?.SlozenostId.HasValue == true && search?.SlozenostId>0)
                {
                    q = q.Where(s => s.Slozenost.SlozenostId == search.SlozenostId);
                }
                else if(search?.KategorijaId.HasValue == true && search?.KategorijaId>0)
                {
                    q = q.Where(s => s.Kategorija.KategorijaId == search.KategorijaId);
                }
                else
                {
                    q = q;
                }

            }
            var list = q.ToList();
            var list1 = _mapper.Map<List<Model.Recept>>(list);
       
            foreach(var ocjena in list1)
            {
                ocjena.Ocjena = _context.Ocjena.Where(b => b.ReceptId == ocjena.ReceptId)
                    .Average(x => (decimal?)x.ocjena) ?? new decimal(0); 
            }
            return list1;
        }
        public override Model.Recept GetById(int id)
        {
            return _mapper.Map<Model.Recept>(_context.Recept.Include(b => b.Slozenost)
                .Include(b => b.Kategorija)
                .Include(b => b.GrupaJela)
                .Include(b => b.Korisnik)
                .Include(b => b.Ocjena).FirstOrDefault(b => b.ReceptId == id));
        }
    }
}

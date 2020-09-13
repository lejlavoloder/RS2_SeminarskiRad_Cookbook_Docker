using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class ReceptSastojakService:BaseCRUDService<Model.ReceptSastojak,ReceptSastojakSearchRequest,Database.ReceptSastojak,
        ReceptSastojakUpsertRequest,ReceptSastojakUpsertRequest>
    {
      public ReceptSastojakService(CookbookContext db, IMapper mapper):base(db,mapper) { }
        public override List<Model.ReceptSastojak> Get(ReceptSastojakSearchRequest search)
        {
            var q = _context.Set<Database.ReceptSastojak>()
                .Include(x => x.Recept)
                .Include(x => x.MjernaJedinica)
                .Include(x => x.MjernaKolicina)
                .Include(x => x.Sastojak)
                .AsQueryable();

            if (search?.ReceptId.HasValue == true)
            {
                q = q.Where(s => s.Recept.ReceptId == search.ReceptId);
            }
            if (search?.SastojakId.HasValue == true)
            {
                q = q.Where(s => s.Sastojak.SastojakId == search.SastojakId);
            }

            var list = q.ToList();
            return _mapper.Map<List<Model.ReceptSastojak>>(list);
        }

        public override Model.ReceptSastojak GetById(int id)
        {
            return _mapper.Map<Model.ReceptSastojak>(_context.ReceptSastojak
                .Include(x => x.Recept)
                .Include(x => x.MjernaJedinica)
                .Include(x => x.MjernaKolicina)
                .Include(x => x.Sastojak)
                .FirstOrDefault(x => x.ReceptSastojakId == id));
        }

    }
}

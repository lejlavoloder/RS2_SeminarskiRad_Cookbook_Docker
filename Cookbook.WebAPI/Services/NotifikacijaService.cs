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
    public class NotifikacijaService:BaseCRUDService<Model.Notifikacija, NotifikacijaSearchRequest,Database.Notifikacija, NotifikacijaUpsertRequest, NotifikacijaUpsertRequest>
    {
        public NotifikacijaService(CookbookContext context, IMapper mapper):base(context,mapper) { 
        }

        public override List<Model.Notifikacija> Get(NotifikacijaSearchRequest search)
        {
            return _mapper.Map<List<Model.Notifikacija>>(_context.Notifikacija.Include(x => x.Recept).ToList());
        }

        public override Model.Notifikacija GetById(int id)
        {
            return _mapper.Map<Model.Notifikacija>(_context.Notifikacija.Include(x => x.Recept).FirstOrDefault(x => x.NotifikacijaId == id));
        }
    }
}

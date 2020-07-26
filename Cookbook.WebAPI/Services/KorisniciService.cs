using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Cookbook.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly CookbookContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(CookbookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnik> Get()
        {
            var list=_context.Korisnik.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu!");
            }
            _context.Korisnik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}

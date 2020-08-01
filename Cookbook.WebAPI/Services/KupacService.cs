using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{

    public class KupacService : IKupacService
    {
        private readonly CookbookContext _context;
        private readonly IMapper _mapper;
        public KupacService(CookbookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.Korisnik AuthenticirajKupca(string username, string pass)
        {
            var user = _context.Korisnik.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }

        public List<Model.Posjetilac> Get(PosjetilacSearchRequest search)
        {
            var query = _context.Posjetilac .AsQueryable();
         
            var list = query.ToList();
            return _mapper.Map<List<Model.Posjetilac>>(list);
        }

        public Model.Posjetilac GetById(int id)
        {
            var entity = _context.Posjetilac.Find(id);

            return _mapper.Map<Model.Posjetilac>(entity);
        }


        public Model.Korisnik Insert(PosjetilacUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnik.Add(entity);
            _context.SaveChanges();

            // -------- dodano posebno 
            var kupac = new Model.Korisnik()
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                KorisnickoIme = request.KorisnickoIme,
                Email = request.Email,
                Telefon = request.Telefon
            };
            //-----
            _context.SaveChanges();

            var entity1 = _mapper.Map<Database.Posjetilac>(request);
            entity1.KorisnikId = entity.KorisnikId;
            entity1.DatumRegistracije = DateTime.Now;

            _context.Posjetilac.Add(entity1);
            _context.SaveChanges();

            var entity2 = _mapper.Map<Database.KorisnikUloga>(request);
            entity2.KorisnikId = entity.KorisnikId;
            entity2.UlogaId = 2;
            entity2.DatumIzmjene = DateTime.Now;

            _context.KorisnikUloga.Add(entity2);
            _context.SaveChanges();
            // return _mapper.Map<Model.Kupac>(entity);
            return kupac;
        }

        public Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            var entity = _context.Korisnik.Find(id);
            _context.Korisnik.Attach(entity);
            _context.Korisnik.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }


    }

}
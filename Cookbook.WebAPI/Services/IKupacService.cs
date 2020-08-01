using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
  public  interface IKupacService
    {
        List<Model.Posjetilac> Get(PosjetilacSearchRequest request);

        Model.Posjetilac GetById(int id);

        Model.Korisnik Insert(PosjetilacUpsertRequest request);

        Model.Korisnik Update(int id, KorisnikInsertRequest request);

        Model.Korisnik AuthenticirajKupca(string username, string pass);

    }
}

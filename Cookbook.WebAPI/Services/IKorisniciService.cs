using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
namespace Cookbook.WebAPI.Services
{
 public interface IKorisniciService
    {
        List<Model.Korisnik> Get();
        Model.Korisnik Insert(KorisniciInsertRequest request);
    }
}

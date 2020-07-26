using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisniciService _service;
       public KorisnikController(IKorisniciService service) {

            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Korisnik>> Get()
        {
            return _service.Get();
        }
        [HttpPost]
        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}

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
    public class ClanakController :BaseCRUDController<Model.Clanak,ClanakSearchRequest,ClanakInsertRequest,ClanakInsertRequest>
    {
        private CookbookContext context;

        public ClanakController(ICRUDService<Model.Clanak, ClanakSearchRequest,ClanakInsertRequest,ClanakInsertRequest>service, CookbookContext context):base(service)
        {
            this.context = context;
        }

        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return Ok(context.Clanak.Select(x => new { x.ClanakId, x.Naziv, x.Tekst}).ToList());
        }
    }
}
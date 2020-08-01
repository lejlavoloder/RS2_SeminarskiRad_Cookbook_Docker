using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
    public class ClanakInsertRequest
    {
        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumObjave { get; set; }
        public int VrstaClankaId { get; set; }
        public int KorisnikId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class KorisnikUloga
    {
        public int KorisnikUlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Uloga Uloga { get; set; }
    }
}

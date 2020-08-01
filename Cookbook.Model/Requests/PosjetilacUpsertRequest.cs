using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
  public  class PosjetilacUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }
    }
}

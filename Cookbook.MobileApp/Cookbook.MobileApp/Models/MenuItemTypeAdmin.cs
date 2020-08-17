using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.MobileApp.Models
{
   public enum MenuItemTypeAdmin
    {
        Kategorija,
        Slozenost,  
        GrupaJela,
        MjernaJedinica,
        MjernaKolicina,
        Sastojak,
        Recept,
        Komentar,
        VrstaClanka,
        Članak,
        Odjava,
        OdobriRecepte,
        UrediProfil,
       MojiFavoriti
    }
    public class HomeMenuItemAdmin
    {
        public MenuItemTypeAdmin Id { get; set; }
        public string Title { get; set; }
    }
}

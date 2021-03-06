﻿using System;
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
        Temp,
        Komentar,
        VrstaClanka,
        Članak,
        Odjava,
        OdobriRecepte,
        PrikazRegistrovanihPosjetilaca,
        UrediProfil,
       MojiFavoriti
    }
    public class HomeMenuItemAdmin
    {
        public MenuItemTypeAdmin Id { get; set; }
        public string Title { get; set; }
    }
}

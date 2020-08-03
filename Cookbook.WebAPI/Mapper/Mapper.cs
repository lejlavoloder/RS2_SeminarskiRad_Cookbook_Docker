using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.Model.Requests;

namespace Cookbook.WebAPI.Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
           
            CreateMap<Database.Sastojak, Model.Sastojak>();
            CreateMap<Database.Sastojak, SastojakInsertRequest>().ReverseMap();

            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Kategorija, KategorijaInsertRequest>().ReverseMap();

            CreateMap<Database.MjernaJedinica, Model.MjernaJedinica>();
            CreateMap<Database.MjernaJedinica, MjernaJedinicaInsertRequest>().ReverseMap();

            CreateMap<Database.GrupaJela, Model.GrupaJela>();
            CreateMap<Database.GrupaJela, GrupaJelaUpsertRequest>().ReverseMap();

            CreateMap<Database.Slozenost, Model.Slozenost>();
            CreateMap<Database.Slozenost, SlozenostUpsertRequest>().ReverseMap();

            CreateMap<Database.MjernaKolicina, Model.MjernaKolicina>();
            CreateMap<Database.MjernaKolicina, MjernaKolicinaUpsertRequest>().ReverseMap();

            CreateMap<Database.VrstaClanka, Model.VrstaClanka>();
            CreateMap<Database.VrstaClanka, VrstaClankaInsertRequest>().ReverseMap();

            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, KorisnikInsertRequest>().ReverseMap();

            CreateMap<Database.Uloga, Model.Uloga>();

            CreateMap<Database.KorisnikUloga, Model.KorisnikUloga>();

            CreateMap<Database.Korisnik, Model.KorisnikLogin>();
            
            CreateMap<Database.Posjetilac, Model.Posjetilac>();
            CreateMap<Database.Posjetilac, PosjetilacUpsertRequest>().ReverseMap();

            CreateMap<Database.Clanak, Model.Clanak>();
            CreateMap<Database.Clanak, ClanakInsertRequest>().ReverseMap();

            CreateMap<Database.Recept, Model.Recept>();
            CreateMap<Database.Recept, ReceptUpsertRequest>().ReverseMap();

            CreateMap<Database.ReceptSastojak, Model.ReceptSastojak>();
            CreateMap<Database.ReceptSastojak, ReceptSastojakUpsertRequest>().ReverseMap();

            CreateMap<Database.ReceptSastojak, Model.ReceptSastojak>()
          .ForMember(s =>s.Recept, a =>
          a.MapFrom(b => new Database.CookbookContext().Recept.Find(b.ReceptId).Naziv))
          .ForMember(s=>s.Sastojak,a=>
          a.MapFrom(b=>new Database.CookbookContext().Sastojak.Find(b.SastojakId).Naziv))
          .ForMember(s=>s.MjernaJedinica, a=>
          a.MapFrom(b=>new Database.CookbookContext().MjernaJedinica.Find(b.MjernaJedinicaId).Naziv))
          .ForMember(s=>s.MjernaKolicina, a=>
          a.MapFrom(b=>new Database.CookbookContext().MjernaKolicina.Find(b.MjernaKolicinaId).Kolicina));
        }
    }
}

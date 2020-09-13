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

            CreateMap<Database.Notifikacija, Model.Notifikacija>();
            CreateMap<Database.Notifikacija, NotifikacijaUpsertRequest>().ReverseMap();


            CreateMap<Database.Recept, Model.Recept>();
            CreateMap<Database.Recept, ReceptUpsertRequest>().ReverseMap();

            CreateMap<Database.ReceptSastojak, Model.ReceptSastojak>();
            CreateMap<Database.ReceptSastojak, ReceptSastojakUpsertRequest>().ReverseMap();


            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Ocjena, OcjenaUpsertRequest>().ReverseMap();
           
            CreateMap<Database.Dokument, Model.Dokument>();
            CreateMap<Database.Dokument, DokumentUpsertRequest>().ReverseMap();

            CreateMap<Database.Favoriti, Model.Favoriti>();
            CreateMap<Database.Favoriti, FavoritiUpsertRequest>().ReverseMap();
            CreateMap<Database.Komentar, Model.Komentar>();
            CreateMap<Database.Komentar, KomentarUpsertRequest>().ReverseMap();

            CreateMap<Database.ReceptSastojak, Model.ReceptSastojak>()
          .ForMember(s =>s.Recept, a =>
          a.MapFrom(b => b.Recept.Naziv))
          .ForMember(s=>s.Sastojak,a=>
          a.MapFrom(b=> b.Sastojak.Naziv))
          .ForMember(s=>s.MjernaJedinica, a=>
          a.MapFrom(b=>b.MjernaJedinica.Naziv))
          .ForMember(s=>s.MjernaKolicina, a=>
          a.MapFrom(b=>b.MjernaKolicina.Kolicina));

            CreateMap<Database.Notifikacija, Model.Notifikacija>()
                 .ForMember(s => s.Recept, a =>
                   a.MapFrom(b => b.Recept.Naziv));

            CreateMap<Database.Posjetilac, Model.Posjetilac>()
                .ForMember(s => s.KorisnickoIme, a => a.MapFrom(b => b.Korisnik.KorisnickoIme))
                .ForMember(s => s.Telefon, a => a.MapFrom(b => b.Korisnik.Telefon))
               .ForMember(s => s.Email, a => a.MapFrom(b => b.Korisnik.Email))
               .ForMember(s => s.Ime, a => a.MapFrom(b => b.Korisnik.Ime))
                .ForMember(s => s.Prezime, a => a.MapFrom(b => b.Korisnik.Prezime));

            CreateMap<Database.Ocjena, Model.Ocjena>()
                .ForMember(s => s.Recept, a =>
                  a.MapFrom(b => b.Recept.Naziv));

            CreateMap<Database.Komentar,Model.Komentar>()
                .ForMember(s=>s.NazivRecepta, a=>
                a.MapFrom(b=>b.Recept.Naziv))
                .ForMember(s=>s.Posjetioc, a=>
                a.MapFrom(b=>$"{b.Korisnik.Ime} {b.Korisnik.Prezime}"));
              
            CreateMap<Database.Favoriti, Model.Favoriti>()
                .ForMember(s => s.Recept, a =>
                  a.MapFrom(b =>b.Recept.Naziv));

            CreateMap<Database.Clanak, Model.Clanak>()
                .ForMember(s => s.VrstaClanka, a =>
                  a.MapFrom(b =>b.VrstaClanka.Naziv));

            CreateMap<Database.Recept, Model.Recept>()
                .ForMember(s => s.Slozenost, a =>
                  a.MapFrom(b => b.Slozenost.Naziv))
                .ForMember(s => s.Kategorija, a =>
                  a.MapFrom(b => b.Kategorija.Naziv))
                .ForMember(s => s.GrupaJela, a =>
                  a.MapFrom(b => b.GrupaJela.Naziv))
                .ForMember(s => s.Ocjena, a =>
                 a.MapFrom(b => b.Ocjena.Any() ? b.Ocjena.First().ocjena : 0))
                .ForMember(s => s.Korisnik, a =>
                  a.MapFrom(b => $"{b.Korisnik.Ime} {b.Korisnik.Prezime}"));
                
     }
    }
}

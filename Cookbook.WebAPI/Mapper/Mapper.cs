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
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Korisnik, KorisniciInsertRequest>().ReverseMap();

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
        }
    }
}

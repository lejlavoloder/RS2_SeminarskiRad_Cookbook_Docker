﻿using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
   public class ReceptDetaljiViewModel:BaseViewModel
    {
        public APIService _api = new APIService("ReceptSastojak");
        public APIService _apiRecept = new APIService("Recept");
        public ReceptDetaljiViewModel()
        {
        }
        public ReceptDetaljiViewModel(Recept r) : base()
        {
            _recept = r;
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public ObservableCollection<ReceptSastojak> ReceptSastojakList { get; set; } = new ObservableCollection<ReceptSastojak>();
        public Recept _recept { get; set; } = new Recept();
        public string Naziv => _recept.Naziv;
        public string Tekst => _recept.Tekst;
        public async Task Init()
        {
            var list = await _api.Get<List<ReceptSastojak>>(null);
            ReceptSastojakList.Clear();

            foreach (var g in list)
            {
                if (g.ReceptId == _recept.ReceptId)
                {
                    ReceptSastojakList.Add(g);
                }
            };

        }
    }
}

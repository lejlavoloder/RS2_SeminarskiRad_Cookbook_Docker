using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikazRecepataPage : ContentPage
    {
        ReceptViewModel vm = null;
        public APIService _apiRecept = new APIService("Recept");
        public APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        public APIService _apiKomentar = new APIService("Komentar");
        public APIService _apiOcjena = new APIService("Ocjena");
        public APIService _apiFavoriti = new APIService("Favoriti");




        public PrikazRecepataPage()
        {
            InitializeComponent();
            BindingContext = vm = new ReceptViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazRecepataPage();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;

            await Navigation.PushAsync(new DetaljiReceptaPage(item));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;

            await Navigation.PushAsync(new UrediReceptPage(item));
        }

        private  async void Button_Clicked_2(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;
            FavoritiViewModel model = new FavoritiViewModel();
            model.r = item;
            await model.Init();
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;

            var p = item.ReceptId;

            KomentarSearchRequest komentar = new KomentarSearchRequest();
            OcjenaSearchRequest ocjena = new OcjenaSearchRequest();
            ReceptSastojakSearchRequest sastojak = new ReceptSastojakSearchRequest();
            FavoritiSearchRequest favoriti = new FavoritiSearchRequest();
            komentar.ReceptId = p;
            ocjena.ReceptId = p;
            sastojak.ReceptId = p;
            favoriti.ReceptId = p;

            var listakomentara = await _apiKomentar.Get<IEnumerable<Komentar>>(komentar);
            var listaocjena = await _apiOcjena.Get<IEnumerable<Ocjena>>(ocjena);
            var listareceptsastojaka = await _apiReceptSastojak.Get<IEnumerable<ReceptSastojak>>(sastojak);
            var listafavorita = await _apiFavoriti.Get<IEnumerable<Favoriti>>(favoriti);
            foreach (var y in listakomentara)
            {
                await _apiKomentar.Delete<Komentar>(y.KomentarId);
            }
            foreach (var y in listaocjena)
            {
                await _apiOcjena.Delete<Ocjena>(y.OcjenaId);
            }
            foreach (var y in listareceptsastojaka)
            {
                await _apiReceptSastojak.Delete<ReceptSastojak>(y.ReceptSastojakId);
            }
            foreach (var y in listafavorita)
            {
                await _apiFavoriti.Delete<Favoriti>(y.FavoritiId);
            }
            await _apiRecept.Delete<Recept>(item.ReceptId);
            await DisplayAlert("OK", "Uspješno ste izbrisali recept", "OK");
            await Navigation.PushAsync(new PrikazRecepataPage());
        }
    }
}
using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
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
    public partial class DetaljiReceptaPage : ContentPage
    {
        ReceptDetaljiViewModel model =null;
        public DetaljiReceptaPage(Recept r)
        {
            InitializeComponent();
            BindingContext = model = new ReceptDetaljiViewModel(r);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
           
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as ReceptSastojak;

            await Navigation.PushAsync(new UrediReceptSastojke(item));
        }
    }
}
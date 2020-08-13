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
    public partial class PrikazRecepataPage : ContentPage
    {
        ReceptViewModel vm = null;
        public APIService ApiClanak = new APIService("Recept");
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
    }
}
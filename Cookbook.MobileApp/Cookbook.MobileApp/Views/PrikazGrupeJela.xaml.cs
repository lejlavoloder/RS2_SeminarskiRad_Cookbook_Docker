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
    public partial class PrikazGrupeJela : ContentPage
    {
        public APIService _service = new APIService("GrupaJela");

        GrupaJelaViewModel vm = null;
        public PrikazGrupeJela()
        {
            InitializeComponent();
            BindingContext = vm = new GrupaJelaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazGrupeJela();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as GrupaJela;

            await Navigation.PushAsync(new UrediGrupuJela(item));

        }
    }
}
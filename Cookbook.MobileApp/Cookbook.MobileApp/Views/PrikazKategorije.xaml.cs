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
    public partial class PrikazKategorije : ContentPage
    {
        public APIService _service = new APIService("Kategorija");

        KategorijaViewModel vm = null;
        public PrikazKategorije()
        {
            InitializeComponent();
            BindingContext = vm = new KategorijaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazKategorije();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Kategorija;

         await Navigation.PushAsync(new UrediKategorijuPage(item));

        }

    }
}
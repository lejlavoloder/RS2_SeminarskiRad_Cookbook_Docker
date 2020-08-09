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
    public partial class PrikazSastojaka : ContentPage
    {
        public APIService _service = new APIService("Sastojak");

        SastojakViewModel vm = null;
        public PrikazSastojaka()
        {
            InitializeComponent();
            BindingContext = vm = new SastojakViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazSastojaka();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Sastojak;

            await Navigation.PushAsync(new UrediSastojakPage(item));

        }
    }
}
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
    public partial class PrikazVrsteClanka : ContentPage
    {
        public APIService _service = new APIService("VrstaClanka");

        VrstaClankaViewModel vm = null;
        public PrikazVrsteClanka()
        {
            InitializeComponent();
            BindingContext = vm = new VrstaClankaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazVrsteClanka();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as VrstaClanka;

            await Navigation.PushAsync(new UrediVrstuClanka(item));

        }
    }
}
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
    public partial class PrikazSlozenosti : ContentPage
    {
        public APIService _service = new APIService("Slozenost");
        SlozenostViewModel vm = null;
        public PrikazSlozenosti()
        {
            InitializeComponent();
            BindingContext = vm = new SlozenostViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazSlozenosti();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Slozenost;
           
        await Navigation.PushAsync(new UrediSlozenostPage(item));

        }
    }
}
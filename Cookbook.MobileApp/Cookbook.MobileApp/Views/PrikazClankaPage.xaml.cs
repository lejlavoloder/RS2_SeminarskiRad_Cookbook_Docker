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
    public partial class PrikazClankaPage : ContentPage
    {
        ClanakViewModel vm = null;
        public PrikazClankaPage()
        {  
            InitializeComponent();
            BindingContext = vm = new ClanakViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazClanaka();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Clanak;

            await Navigation.PushAsync(new UrediClanak(item));

        }
    }
}
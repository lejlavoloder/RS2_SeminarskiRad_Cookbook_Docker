using Cookbook.MobileApp.ViewModels;
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
    public partial class PretragaRecepataPage : ContentPage
    {
        ReceptViewModel model = null;
        public PretragaRecepataPage()
        {
            InitializeComponent();
            BindingContext = model = new ReceptViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PretragaRecepata();
        }
    }
}
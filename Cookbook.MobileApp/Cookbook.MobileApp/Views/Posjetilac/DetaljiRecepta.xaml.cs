using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiRecepta : ContentPage
    {
        ReceptDetaljiViewModel model = null;
        public DetaljiRecepta(Recept r)
        {
            InitializeComponent();
            BindingContext = model = new ReceptDetaljiViewModel(r);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}
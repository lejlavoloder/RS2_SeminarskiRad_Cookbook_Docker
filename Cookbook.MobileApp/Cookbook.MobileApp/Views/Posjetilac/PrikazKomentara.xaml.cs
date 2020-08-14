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
    public partial class PrikazKomentara : ContentPage
    {
        public KomentarViewModel model;
        public PrikazKomentara(Recept recept)
        {
            InitializeComponent();
            BindingContext = model = new KomentarViewModel(recept);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PrikazKomentara();
        }
    }
}
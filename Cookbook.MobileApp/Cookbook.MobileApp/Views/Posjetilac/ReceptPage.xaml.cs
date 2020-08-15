﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceptPage : ContentPage
    {
        public ReceptPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PretragaRecepata());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrikazRecepata());
        }
    }
}
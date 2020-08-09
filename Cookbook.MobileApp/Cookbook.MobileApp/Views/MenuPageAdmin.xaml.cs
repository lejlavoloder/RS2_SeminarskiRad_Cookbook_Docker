using Cookbook.MobileApp.Models;
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
    public partial class MenuPageAdmin : ContentPage
    {
        MainPageAdmin RootPage { get => Application.Current.MainPage as MainPageAdmin; }
        List<HomeMenuItemAdmin> menuItems;
        public MenuPageAdmin()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItemAdmin>
            {
                //new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Browse, Title="Browse" },
                //new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.About, Title="About" },

                new HomeMenuItemAdmin { Id = MenuItemTypeAdmin.Kategorija, Title = "Kategorija" },
                new HomeMenuItemAdmin{  Id  =  MenuItemTypeAdmin.Slozenost, Title="Slozenost"},
                new HomeMenuItemAdmin{  Id  =  MenuItemTypeAdmin.MjernaJedinica, Title="Mjerna jedinica"},
                 new HomeMenuItemAdmin{  Id  =  MenuItemTypeAdmin.GrupaJela, Title="Grupa jela"},
            };
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItemAdmin)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}
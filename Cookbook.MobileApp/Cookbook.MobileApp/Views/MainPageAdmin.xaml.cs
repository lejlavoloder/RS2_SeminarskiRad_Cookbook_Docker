using Cookbook.MobileApp.Models;
using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPageAdmin : MasterDetailPage
    { public APIService _apiService = new APIService("Korisnik");

        Dictionary<int, NavigationPage> MenuPagesAdmin = 
            new Dictionary<int, NavigationPage>();
        public MainPageAdmin()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }
        public MainPageAdmin(MenuItemType type)
        {

            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            _ = NavigateFromMenu((int)type);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPagesAdmin.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemTypeAdmin.Kategorija:
                     MenuPagesAdmin.Add(id, new NavigationPage(new KategorijaPage()));
                        break;
                    case (int)MenuItemTypeAdmin.Slozenost:
                        MenuPagesAdmin.Add(id, new NavigationPage(new SlozenostPage()));
                        break;
                    case (int)MenuItemTypeAdmin.MjernaJedinica:
                        MenuPagesAdmin.Add(id, new NavigationPage(new MjernaJedinicaPage()));
                        break;
                    case (int)MenuItemTypeAdmin.MjernaKolicina:
                        MenuPagesAdmin.Add(id, new NavigationPage(new MjernaKolicinaPage()));
                        break;
                    case (int)MenuItemTypeAdmin.GrupaJela:
                        MenuPagesAdmin.Add(id, new NavigationPage(new GrupaJelaPage()));
                        break;
                    case (int)MenuItemTypeAdmin.Sastojak:
                        MenuPagesAdmin.Add(id, new NavigationPage(new SastojakPage()));
                        break;
                    case (int)MenuItemTypeAdmin.VrstaClanka:
                        MenuPagesAdmin.Add(id, new NavigationPage(new VrstaClankaPage()));
                        break;
                    case (int)MenuItemTypeAdmin.Članak:
                        MenuPagesAdmin.Add(id, new NavigationPage(new ClanakPage()));
                        break;
                    case (int)MenuItemTypeAdmin.Komentar:
                        MenuPagesAdmin.Add(id, new NavigationPage(new PrikazKomentaraPage()));
                        break;
                    case (int)MenuItemTypeAdmin.Odjava:
                             MenuPagesAdmin.Add(id, new NavigationPage(new LoginPage()));
                             break;
                    case (int)MenuItemTypeAdmin.UrediProfil:
                        Korisnik korisnik = new Korisnik();
                        var username = APIService.Username;
                        List<Korisnik> lista = await _apiService.Get<List<Korisnik>>(null);
                        foreach (var k in lista)
                        {
                            if (k.KorisnickoIme == username)
                            {
                                korisnik = k;
                                break;
                            }
                        }
                        MenuPagesAdmin.Add(id, new NavigationPage(new UrediProfilPage(korisnik)));
                        break;
                }
                 
                }
                var newPage = MenuPagesAdmin[id];

                if (newPage != null && Detail != newPage)
                {
                    Detail = newPage;

                    if (Device.RuntimePlatform == Device.Android)
                        await Task.Delay(100);

                    IsPresented = false;
                }
            }
        }
    }

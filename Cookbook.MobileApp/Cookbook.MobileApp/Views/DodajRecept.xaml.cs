using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajRecept : ContentPage
    {
        APIService _apiKorisnik = new APIService("Korisnik");
        ReceptDodajViewModel model = null;
        List<ReceptSastojak> ReceptSastojakList = new List<ReceptSastojak>();
        public DodajRecept()
        {
            InitializeComponent();
            BindingContext = model = new ReceptDodajViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Tekst.Text, @"^[a-zA-Z ]+$") && this.Tekst.Text.Length < 10)
            {
                await DisplayAlert("Greška", "Tekst se sastoji samo od slova", "OK");
            }
            else if (this.GrupaJelaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati grupu jela", "OK");
            }
            else if (this.KategorijaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati kategoriju jela", "OK");
            }
            else if (this.SlozenostPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati slozenost jela", "OK");
            }
            else if (!Regex.IsMatch(this.BrojLjudi.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Broj ljudi se označava brojem", "OK");
            }

            else if (!Regex.IsMatch(this.VrijemePripreme.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Vrijeme pripreme se piše u minutama", "OK");
            }
            else if (!Regex.IsMatch(this.VrijemeKuhanja.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Vrijeme kuhanja se piše u minutama", "OK");
            }
            else
            {
                try
                {
                    Korisnik korisnik = new Korisnik();
                    var username = APIService.Username;
                    List<Korisnik> lista = await _apiKorisnik.Get<List<Korisnik>>(null);
                    foreach (var k in lista)
                    {
                        if (k.KorisnickoIme == username)
                        {
                            korisnik = k;
                            break;
                        }
                    }
                    model.Naziv = this.Naziv.Text;
                    model.Tekst = this.Tekst.Text;
                    GrupaJela grupajela = this.GrupaJelaPicker.SelectedItem as GrupaJela;
                    model.GrupaJelaId = grupajela.GrupaJelaId;
                    Kategorija kategorija = this.KategorijaPicker.SelectedItem as Kategorija;
                    model.KategorijaId = kategorija.KategorijaId;
                    Slozenost slozenost = this.SlozenostPicker.SelectedItem as Slozenost;
                    model.SlozenostId = slozenost.SlozenostId;
                    model.DatumVrijemeObjave = DateTime.Now;
                    model.VrijemeKuhanja = Convert.ToInt32(this.VrijemeKuhanja.Text);
                    model.VrijemePripreme = Convert.ToInt32(this.VrijemePripreme.Text);
                    model.BrojLjudi = Convert.ToInt32(this.BrojLjudi.Text);
                    await model.DodajRecept();
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste pohranili recept", "OK");
                    await Navigation.PushAsync(new PrikazRecepataPage());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }


        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert(" ", "Format slike nije podržan!", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            Stream stream = file.GetStream();

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                model.Slika = ms.ToArray();
            }

        }

        private void ChangeGrid_Click(object sender, EventArgs e)
        {
            List<ReceptSastojak> sastojaks = new List<ReceptSastojak>();




            if (CrveniGrid.IsVisible)
            {
                CrveniGrid.IsVisible = false;
                ZutiGrid.IsVisible = true;
            }
            else
            {
                ZutiGrid.IsVisible = false;
                CrveniGrid.IsVisible = true;
            }
        }
    }

}
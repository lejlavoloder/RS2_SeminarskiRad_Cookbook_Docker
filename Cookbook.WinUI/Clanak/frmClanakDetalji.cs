using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Clanak
{
    public partial class frmClanakDetalji : Form
    {
        private readonly APIService _clanak = new APIService("Clanak");
        private readonly APIService _vrstaclanka = new APIService("VrstaClanka");
        public frmClanakDetalji()
        {
            InitializeComponent();
        }

        private async void frmClanakDetalji_Load(object sender, EventArgs e)
        {
                await LoadClanci();
            }
        private async Task LoadClanci()
        {
                var result = await _vrstaclanka.Get<List<Model.VrstaClanka>>(null);
                cmbVrstaClanka.DisplayMember = "Naziv";
                cmbVrstaClanka.ValueMember = "VrstaClankaId";
                cmbVrstaClanka.SelectedItem = null;
                cmbVrstaClanka.SelectedText = "--Odaberite--";
                cmbVrstaClanka.DataSource = result;
            }
 
        ClanakInsertRequest request = new ClanakInsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
          
                if (ValidateChildren())
                {
                    var idObj = cmbVrstaClanka.SelectedValue;
                    if (int.TryParse(idObj.ToString(), out int VrstaClankaId))
                    {
                    request.VrstaClankaId = VrstaClankaId;
                    request.Naziv = txtNaziv.Text;
                    request.Tekst = richTextBtxtTekstox1.Text;
                    request.DatumObjave = dtObjave.Value;
                    request.KorisnikId = 1; 
                    var entity = await _clanak.Insert<Model.Clanak>(request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operacija nije uspjela");
                    this.Close();
                }
            }
        }
    }
    }
   

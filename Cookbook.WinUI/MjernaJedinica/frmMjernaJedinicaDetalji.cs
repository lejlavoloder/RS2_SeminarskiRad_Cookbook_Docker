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

namespace Cookbook.WinUI.MjernaJedinica
{
    public partial class frmMjernaJedinicaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("MjernaJedinica");
        private int? _id = null;
        public frmMjernaJedinicaDetalji(int? MjernaJedinicaId = null)
        {
            InitializeComponent();
            _id = MjernaJedinicaId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new MjernaJedinicaInsertRequest()
                {
                    Naziv = txtNaziv.Text
                };
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.MjernaJedinica>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.MjernaJedinica>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci");
                this.Close();
            }
        }

        private async void frmMjernaJedinicaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var mjernajedinica = await _apiService.GetById<Model.MjernaJedinica>(_id);
                txtNaziv.Text = mjernajedinica.Naziv;
            }
        }
    }
}

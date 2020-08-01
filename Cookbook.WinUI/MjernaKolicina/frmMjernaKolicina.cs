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

namespace Cookbook.WinUI.MjernaKolicina
{
    public partial class frmMjernaKolicina : Form
    {
        private readonly APIService _apiService = new APIService("MjernaKolicina");
        public frmMjernaKolicina()
        {
            InitializeComponent();
        }
   
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            MjernaKolicinaSearchRequest request = new MjernaKolicinaSearchRequest
            {
                Kolicina = txtNaziv.Text
            };
            double n = double.Parse(request.Kolicina);
            var result = await _apiService.Get<List<Model.MjernaKolicina>>(n);

            dgvMjernaKolicina.DataSource = result;
        }
    }
}

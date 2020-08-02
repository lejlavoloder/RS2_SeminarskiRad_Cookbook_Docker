using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Recept
{
    public partial class frmRecept : Form
    {
        private readonly APIService _grupajela = new APIService("GrupaJela");
        private readonly APIService _slozenost = new APIService("Slozenost");
        private readonly APIService _kategorija = new APIService("Kategorija");
        private readonly APIService _recept = new APIService("Recept");
        public frmRecept()
        {
            InitializeComponent();
        }

        private async void frmRecept_Load(object sender, EventArgs e)
        {
            await LoadGrupaJela();
            await LoadKategorija();
            await LoadSlozenost();
        }
        private async Task LoadGrupaJela()
        {
            var result = await _grupajela.Get<List<Model.GrupaJela>>(null);
            cmbGrupaJela.DisplayMember = "Naziv";
            cmbGrupaJela.ValueMember = "GrupaJelaId";
            result.Insert(0, new Model.GrupaJela());
            cmbGrupaJela.DataSource = result;
        }
        private async Task LoadKategorija()
        {
            var result = await _kategorija.Get<List<Model.Kategorija>>(null);
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            result.Insert(0, new Model.Kategorija());
            cmbKategorija.DataSource = result;
        }
        private async Task LoadSlozenost()
        {
            var result = await _slozenost.Get<List<Model.Slozenost>>(null);
            cmbSlozenost.DisplayMember = "Naziv";
            cmbSlozenost.ValueMember = "SlozenostId";
            result.Insert(0, new Model.Slozenost());
            cmbSlozenost.DataSource = result;
        }
        ImageConverter imgConverter = new ImageConverter();
        ReceptUpsertRequest request = new ReceptUpsertRequest();

        private void btnSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtInputSlike.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int.TryParse(txtBrojLjudi.Text, out var n);
                double.TryParse(txtVrijemeKuhanja.Text, out var m);
                double.TryParse(txtVrijemePripreme.Text, out var mm);

                var idObj = cmbGrupaJela.SelectedValue;
                var idObj1 = cmbKategorija.SelectedValue;
                var idObj2 = cmbSlozenost.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int GrupaJelaId) && (int.TryParse(idObj1.ToString(), out int KategorijaId)) &&
                    (int.TryParse(idObj2.ToString(), out int SlozenostId)))
                {
                    ReceptUpsertRequest request = new ReceptUpsertRequest()
                    {
                        GrupaJelaId = GrupaJelaId,
                        KategorijaId = KategorijaId,
                        SlozenostId = SlozenostId,
                        Naziv = txtNaziv.Text,
                        Tekst = richTextBtxtTekstox1.Text,
                        DatumObjave = dtObjave.Value,
                        BrojLjudi = n,
                        VrijemeKuhanja = m,
                        VrijemePripreme = mm,
                        Odobren = true,
                        Slika = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]")),
                        KorisnikId = 1
                    };
                    var entity = await _recept.Insert<Model.Recept>(request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();
                }
            }
        }
    }
}
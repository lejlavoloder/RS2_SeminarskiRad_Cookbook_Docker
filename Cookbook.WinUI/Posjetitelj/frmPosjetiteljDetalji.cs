﻿using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Posjetitelj
{
    public partial class frmPosjetiteljDetalji : Form
    {
        APIService _service = new APIService("Korisnik");
        APIService _posjetilac = new APIService("Posjetilac");
        APIService _ulogeService = new APIService("Uloga");

        private int? _id = null;
        public frmPosjetiteljDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var roleList = clbRole.CheckedItems.Cast<Model.Uloga>().Select(x => x.UlogaId).ToList();

                var request = new KorisnikInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda = txtPassPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = roleList
                };
               if (!_id.HasValue)
                {
                    try
                    {
                     var  entity = await _service.Insert<Model.Korisnik>(request);
                        if (entity != null)
                        {
                            await _posjetilac.Insert<Model.Posjetilac>(new PosjetilacUpsertRequest
                            {
                                DatumRegistracije = DateTime.Now,
                                KorisnikId = entity.KorisnikId
                            });
                        }

                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        await _service.Update<Model.Korisnik>(_id.Value, request);
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }
        }

        private async void frmPosjetiteljDetalji_Load(object sender, EventArgs e)
        {
            var ulogeList = await _ulogeService.Get<List<Model.Uloga>>(null);

            clbRole.DataSource = ulogeList;
            clbRole.DisplayMember = "Naziv";


            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Korisnik>(_id);
                txtEmail.Text = entity.Email;
                txtIme.Text = entity.Ime;
                txtKorisnickoIme.Text = entity.KorisnickoIme;
                txtPrezime.Text = entity.Prezime;
                txtTelefon.Text = entity.Telefon;

            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtPassPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassPotvrda.Text))
            {
                errorProvider.SetError(txtPassPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPassPotvrda.Text != txtPassword.Text)
            {
                errorProvider.SetError(txtPassPotvrda, "Passwordi se ne poklapaju");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassPotvrda, null);
            }

        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona je: +123 45 678 910");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }
    }
}

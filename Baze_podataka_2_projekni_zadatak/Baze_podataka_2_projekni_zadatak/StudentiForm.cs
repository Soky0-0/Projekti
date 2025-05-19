using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Baze_podataka_2_projekni_zadatak
{
    public partial class StudentiForm : Form
    {
        private StudentsDomDBEntities db;

        public StudentiForm()
        {
            InitializeComponent();
            db = new StudentsDomDBEntities();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewStudenti.DataSource = db.Student.ToList();

            // Sakrij stupce Podnesena i Kreira
            if (dataGridViewStudenti.Columns["Podnesena"] != null)
            {
                dataGridViewStudenti.Columns["Podnesena"].Visible = false;
            }
            if (dataGridViewStudenti.Columns["Kreira"] != null)
            {
                dataGridViewStudenti.Columns["Kreira"].Visible = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int id;
                if (!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("Unesite ispravan ID.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (db.Student.Any(s => s.ID_studenta == id))
                {
                    MessageBox.Show("ID već postoji. Unesite jedinstven ID.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var student = new Student
                {
                    ID_studenta = id,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Kontakt = txtKontakt.Text,
                    Email = txtEmail.Text
                };
                db.Student.Add(student);
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudenti.CurrentRow != null && ValidateInputs())
            {
                int id = (int)dataGridViewStudenti.CurrentRow.Cells["ID_studenta"].Value;
                var student = db.Student.Find(id);
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.Kontakt = txtKontakt.Text;
                student.Email = txtEmail.Text;
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudenti.CurrentRow != null)
            {
                int id = (int)dataGridViewStudenti.CurrentRow.Cells["ID_studenta"].Value;
                var student = db.Student.Find(id);
                db.Student.Remove(student);
                db.SaveChanges();
                LoadData();
                ClearInputs();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudenti.CurrentRow != null && ValidateInputs())
            {
                int id = (int)dataGridViewStudenti.CurrentRow.Cells["ID_studenta"].Value;
                var student = db.Student.Find(id);

                if (student != null)
                {
                    student.Ime = txtIme.Text;
                    student.Prezime = txtPrezime.Text;
                    student.Kontakt = txtKontakt.Text;
                    student.Email = txtEmail.Text;
                    db.SaveChanges();
                    LoadData();
                    ClearInputs();
                }
            }
        }

        private void dataGridViewStudenti_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudenti.CurrentRow != null)
            {
                txtID.Text = dataGridViewStudenti.CurrentRow.Cells["ID_studenta"].Value.ToString();
                txtIme.Text = dataGridViewStudenti.CurrentRow.Cells["Ime"].Value.ToString();
                txtPrezime.Text = dataGridViewStudenti.CurrentRow.Cells["Prezime"].Value.ToString();
                txtKontakt.Text = dataGridViewStudenti.CurrentRow.Cells["Kontakt"].Value.ToString();
                txtEmail.Text = dataGridViewStudenti.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtKontakt.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Unesite ispravan email.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtKontakt.Text, @"^\d+$"))
            {
                MessageBox.Show("Kontakt mora sadržavati samo brojeve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtKontakt.Clear();
            txtEmail.Clear();
        }

        private void StudentiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Definirajte metodu txtIme_TextChanged ako je potrebna
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            // Vaš kod ovdje
        }
    }

    // Uklonite duplicirane definicije svojstava iz ručno napisane klase Student
    public partial class Student
    {
        // Svojstva su već definirana u generiranoj klasi
    }
}
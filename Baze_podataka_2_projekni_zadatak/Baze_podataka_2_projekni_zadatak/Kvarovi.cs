using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Baze_podataka_2_projekni_zadatak
{
    public partial class Kvarovi : Form
    {
        private StudentsDomDBEntities db;

        public Kvarovi()
        {
            InitializeComponent();
            db = new StudentsDomDBEntities();
        }

        private void Kvarovi_Load(object sender, EventArgs e)
        {
            LoadKvarovi();
        }

        private void LoadKvarovi()
        {
            var kvarovi = db.Kvar.Include(k => k.Smjestajna_jedinica).ToList();
            dataGridViewKvarovi.DataSource = kvarovi.Select(k => new
            {
                k.ID_kvara,
                k.Opis,
                k.Datum_prijave,
                k.Status,
                k.Smjestajna_jedinica.Broj_sobe
            }).ToList();
        }

        private void btnOznaciRijesenim_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewKvarovi.SelectedRows.Count > 0)
                {
                    int idKvara = (int)dataGridViewKvarovi.SelectedRows[0].Cells["ID_kvara"].Value;
                    var kvar = db.Kvar.Find(idKvara);

                    if (kvar != null)
                    {
                        kvar.Status = "riješen";
                        db.SaveChanges();

                        MessageBox.Show("Kvar označen kao riješen.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKvarovi();
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite kvar za označavanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do pogreške: {ex.Message}\n{ex.StackTrace}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
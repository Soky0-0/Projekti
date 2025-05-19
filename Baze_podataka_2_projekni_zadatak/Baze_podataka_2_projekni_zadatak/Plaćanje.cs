using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Baze_podataka_2_projekni_zadatak
{
    public partial class Plaćanje : Form
    {
        private StudentsDomDBEntities db;

        public Plaćanje()
        {
            InitializeComponent();
            db = new StudentsDomDBEntities();
        }

        private void Plaćanje_Load(object sender, EventArgs e)
        {
            LoadRezervacije();
            LoadNacinPlacanja();
        }

        private void LoadRezervacije()
        {
            var rezervacije = db.Rezervacija.Include(r => r.Smjestajna_jedinica).ToList();
            dataGridViewRezervacije.DataSource = rezervacije.Select(r => new
            {
                r.ID_rezervacije,
                r.Datum_rezervacije,
                r.Datum_pocetka,
                r.Datum_zavrsetka,
                r.Smjestajna_jedinica.Broj_sobe,
                r.Smjestajna_jedinica.Tip_smjestaja.Cijena_po_nocenju,
                Placeno = db.Placanje.Any(p => p.ID_rezervacije == r.ID_rezervacije) ? "Da" : "Ne"
            }).ToList();
        }

        private void LoadNacinPlacanja()
        {
            // Pretpostavimo da su načini plaćanja definirani u CHECK ograničenju u bazi podataka
            cmbNacinPlacanja.Items.AddRange(new object[] { "Gotovina", "Kartica", "Online" });
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRezervacije.SelectedRows.Count > 0 && cmbNacinPlacanja.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtIdPlacanja.Text))
                {
                    int idRezervacije = (int)dataGridViewRezervacije.SelectedRows[0].Cells["ID_rezervacije"].Value;
                    string nacinPlacanja = cmbNacinPlacanja.SelectedItem.ToString();
                    int idPlacanja = int.Parse(txtIdPlacanja.Text);

                    var placanje = db.Placanje.Find(idPlacanja);
                    if (placanje == null)
                    {
                        MessageBox.Show("ID plaćanja ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    placanje.Nacin_placanja = nacinPlacanja;
                    db.SaveChanges();

                    MessageBox.Show("Rezervacija je plaćena.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRezervacije();
                }
                else
                {
                    MessageBox.Show("Odaberite rezervaciju, način plaćanja i unesite ID plaćanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do pogreške: {ex.Message}\n{ex.StackTrace}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
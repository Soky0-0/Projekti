using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Baze_podataka_2_projekni_zadatak
{
    public partial class Rezervacije : Form
    {
        private StudentsDomDBEntities db;

        public Rezervacije()
        {
            InitializeComponent();
            db = new StudentsDomDBEntities();

            // Postavite Cue Banner tekst za TextBox kontrole
            SetCueBanner(txtDatumRezervacije, "Datum rezervacije");
            SetCueBanner(txtDatumPocetka, "Datum početka");
            SetCueBanner(txtDatumZavrsetka, "Datum završetka");
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            OslobodiZavrseneSobe();
            LoadSmjestajneJedinice();
            LoadJediniceStatus();
        }

        private void LoadSmjestajneJedinice()
        {
            var jedinice = db.Smjestajna_jedinica.ToList();
            cmbSmjestajnaJedinica.DataSource = jedinice;
            cmbSmjestajnaJedinica.DisplayMember = "Broj_sobe";
            cmbSmjestajnaJedinica.ValueMember = "ID_jedinice";
        }

        private void LoadJediniceStatus()
        {
            var jedinice = db.Smjestajna_jedinica.ToList();
            dataGridViewJedinice.DataSource = jedinice.Select(j => new
            {
                j.ID_jedinice,
                j.Broj_sobe,
                j.Status
            }).ToList();

            foreach (DataGridViewRow row in dataGridViewJedinice.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "zauzeto")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    int idJedinice = (int)cmbSmjestajnaJedinica.SelectedValue;
                    var jedinica = db.Smjestajna_jedinica.Find(idJedinice);

                    if (jedinica.Status == "zauzeto")
                    {
                        MessageBox.Show("Soba je već zauzeta. Odaberite drugu sobu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Pronađite postojeću rezervaciju prema primarnom ključu
                    var rezervacija = db.Rezervacija.Find(idJedinice);
                    if (rezervacija == null)
                    {
                        MessageBox.Show("Rezervacija nije pronađena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ažurirajte podatke rezervacije
                    rezervacija.Datum_rezervacije = DateTime.Parse(txtDatumRezervacije.Text);
                    rezervacija.Datum_pocetka = DateTime.Parse(txtDatumPocetka.Text);
                    rezervacija.Datum_zavrsetka = DateTime.Parse(txtDatumZavrsetka.Text);
                    rezervacija.ID_jedinice = idJedinice;

                    db.Entry(rezervacija).State = EntityState.Modified;
                    db.SaveChanges();

                    // Ažuriraj status smještajne jedinice
                    jedinica.Status = "zauzeto";
                    db.SaveChanges();

                    // Izračunaj ukupnu cijenu
                    var brojDana = (rezervacija.Datum_zavrsetka - rezervacija.Datum_pocetka).Days;
                    var cijenaPoNocenju = jedinica.Tip_smjestaja.Cijena_po_nocenju;
                    var ukupnaCijena = brojDana * cijenaPoNocenju;

                    MessageBox.Show($"Rezervacija potvrđena. Ukupna cijena: {ukupnaCijena} kn", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadJediniceStatus();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do pogreške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtDatumRezervacije.Text) ||
                string.IsNullOrWhiteSpace(txtDatumPocetka.Text) ||
                string.IsNullOrWhiteSpace(txtDatumZavrsetka.Text) ||
                cmbSmjestajnaJedinica.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime datumRezervacije, datumPocetka, datumZavrsetka;
            if (!DateTime.TryParse(txtDatumRezervacije.Text, out datumRezervacije) ||
                !DateTime.TryParse(txtDatumPocetka.Text, out datumPocetka) ||
                !DateTime.TryParse(txtDatumZavrsetka.Text, out datumZavrsetka))
            {
                MessageBox.Show("Unesite ispravne datume.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (datumRezervacije < DateTime.Now || datumPocetka < DateTime.Now || datumZavrsetka < DateTime.Now)
            {
                MessageBox.Show("Datumi moraju biti u budućnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (datumPocetka >= datumZavrsetka)
            {
                MessageBox.Show("Datum početka mora biti prije datuma završetka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtDatumRezervacije.Clear();
            txtDatumPocetka.Clear();
            txtDatumZavrsetka.Clear();
            cmbSmjestajnaJedinica.SelectedIndex = -1;
        }

        private void OslobodiZavrseneSobe()
        {
            var danasnjiDatum = DateTime.Now;
            var zavrseneRezervacije = db.Rezervacija.Where(r => r.Datum_zavrsetka < danasnjiDatum).ToList();

            foreach (var rezervacija in zavrseneRezervacije)
            {
                var jedinica = db.Smjestajna_jedinica.Find(rezervacija.ID_jedinice);
                if (jedinica != null)
                {
                    jedinica.Status = "slobodno";
                }
            }

            db.SaveChanges();
        }

        // P/Invoke deklaracija za SendMessage funkciju
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, [MarshalAs(UnmanagedType.LPWStr)] string lp);

        private const int EM_SETCUEBANNER = 0x1501;

        // Metoda za postavljanje Cue Banner teksta
        private void SetCueBanner(TextBox textBox, string cueText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, cueText);
        }
    }
}
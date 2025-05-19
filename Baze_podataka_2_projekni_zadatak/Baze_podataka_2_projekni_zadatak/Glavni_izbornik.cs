using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Baze_podataka_2_projekni_zadatak
{
    public partial class Glavni_izbornik : Form
    {
        public Glavni_izbornik()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Create a panel
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panel);

            // Create buttons
            Button btnStudenti = new Button
            {
                Text = "Studenti",
                Location = new Point(50, 50),
                Size = new Size(100, 50)
            };
            btnStudenti.Click += BtnStudenti_Click;
            panel.Controls.Add(btnStudenti);

            Button btnRezervacije = new Button
            {
                Text = "Rezervacije",
                Location = new Point(50, 120),
                Size = new Size(100, 50)
            };
            btnRezervacije.Click += BtnRezervacije_Click;
            panel.Controls.Add(btnRezervacije);

            Button btnPlacanja = new Button
            {
                Text = "Plaćanja",
                Location = new Point(50, 190),
                Size = new Size(100, 50)
            };
            btnPlacanja.Click += BtnPlacanja_Click;
            panel.Controls.Add(btnPlacanja);

            Button btnKvarovi = new Button
            {
                Text = "Kvarovi",
                Location = new Point(50, 260),
                Size = new Size(100, 50)
            };
            btnKvarovi.Click += BtnKvarovi_Click;
            panel.Controls.Add(btnKvarovi);
        }

        private void SetBackgroundImage()
        {
            // Set the background image
            this.BackgroundImage = Image.FromFile("C:\\Users\\38599\\source\\repos\\Baze_podataka_2_projekni_zadatak\\Baze_podataka_2_projekni_zadatak\\Resursi\\Logo.png");
            this.BackgroundImageLayout = ImageLayout.Stretch; // Adjust the layout as needed
        }

        private void BtnStudenti_Click(object sender, EventArgs e)
        {
            // Open StudentiForm
            StudentiForm studentiForm = new StudentiForm();
            studentiForm.Show();
        }

        private void BtnRezervacije_Click(object sender, EventArgs e)
        {
            Rezervacije rezervacijeForm = new Rezervacije();
            rezervacijeForm.Show();
        }

        private void BtnPlacanja_Click(object sender, EventArgs e)
        {
            Plaćanje placanjeForm = new Plaćanje();
            placanjeForm.Show(); 
        }

        private void BtnKvarovi_Click(object sender, EventArgs e)
        {
            Kvarovi kvaroviForm = new Kvarovi();
            kvaroviForm.Show(); 
        }

        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {
            SetBackgroundImage();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
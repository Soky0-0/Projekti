namespace Baze_podataka_2_projekni_zadatak
{
    partial class Glavni_izbornik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni_izbornik));
            this.panel = new System.Windows.Forms.Panel();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnPlacanja = new System.Windows.Forms.Button();
            this.btnKvarovi = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnStudenti);
            this.panel.Controls.Add(this.btnRezervacije);
            this.panel.Controls.Add(this.btnPlacanja);
            this.panel.Controls.Add(this.btnKvarovi);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1067, 554);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnStudenti
            // 
            this.btnStudenti.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnStudenti.Location = new System.Drawing.Point(196, 464);
            this.btnStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(133, 62);
            this.btnStudenti.TabIndex = 0;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.UseVisualStyleBackColor = true;
            this.btnStudenti.Click += new System.EventHandler(this.BtnStudenti_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(369, 464);
            this.btnRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(133, 62);
            this.btnRezervacije.TabIndex = 1;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.BtnRezervacije_Click);
            // 
            // btnPlacanja
            // 
            this.btnPlacanja.Location = new System.Drawing.Point(556, 464);
            this.btnPlacanja.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlacanja.Name = "btnPlacanja";
            this.btnPlacanja.Size = new System.Drawing.Size(133, 62);
            this.btnPlacanja.TabIndex = 2;
            this.btnPlacanja.Text = "Plaćanja";
            this.btnPlacanja.UseVisualStyleBackColor = true;
            this.btnPlacanja.Click += new System.EventHandler(this.BtnPlacanja_Click);
            // 
            // btnKvarovi
            // 
            this.btnKvarovi.Location = new System.Drawing.Point(735, 464);
            this.btnKvarovi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKvarovi.Name = "btnKvarovi";
            this.btnKvarovi.Size = new System.Drawing.Size(133, 62);
            this.btnKvarovi.TabIndex = 3;
            this.btnKvarovi.Text = "Kvarovi";
            this.btnKvarovi.UseVisualStyleBackColor = true;
            this.btnKvarovi.Click += new System.EventHandler(this.BtnKvarovi_Click);
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Glavni_izbornik";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.Glavni_izbornik_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnPlacanja;
        private System.Windows.Forms.Button btnKvarovi;
    }
}
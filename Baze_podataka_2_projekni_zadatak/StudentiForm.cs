namespace Baze_podataka_2_projekni_zadatak
{
    partial class StudentiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridViewStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.PlaceholderText = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.PlaceholderText = "Prezime";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(12, 64);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(200, 20);
            this.txtKontakt.TabIndex = 2;
            this.txtKontakt.PlaceholderText = "Kontakt";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.PlaceholderText = "Email";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(93, 116);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeni.TabIndex = 5;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(174, 116);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridViewStudenti
            // 
            this.dataGridViewStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudenti.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewStudenti.Name = "dataGridViewStudenti";
            this.dataGridViewStudenti.Size = new System.Drawing.Size(776, 293);
            this.dataGridViewStudenti.TabIndex = 7;
            this.dataGridViewStudenti.SelectionChanged += new System.EventHandler(this.dataGridViewStudenti_SelectionChanged);
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStudenti);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "StudentiForm";
            this.Text = "Upravljanje Studentima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridViewStudenti;
    }
}

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
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(16, 65);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(265, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(16, 97);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(265, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(16, 129);
            this.txtKontakt.Margin = new System.Windows.Forms.Padding(4);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(265, 22);
            this.txtKontakt.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(16, 193);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(124, 193);
            this.btnIzmijeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(100, 28);
            this.btnIzmijeni.TabIndex = 5;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(232, 193);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 28);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridViewStudenti
            // 
            this.dataGridViewStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudenti.Location = new System.Drawing.Point(16, 242);
            this.dataGridViewStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudenti.Name = "dataGridViewStudenti";
            this.dataGridViewStudenti.RowHeadersWidth = 51;
            this.dataGridViewStudenti.Size = new System.Drawing.Size(1035, 297);
            this.dataGridViewStudenti.TabIndex = 7;
            this.dataGridViewStudenti.SelectionChanged += new System.EventHandler(this.dataGridViewStudenti_SelectionChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 22);
            this.txtID.TabIndex = 8;
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridViewStudenti);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentiForm";
            this.Text = "Upravljanje Studentima";
            this.Load += new System.EventHandler(this.StudentiForm_Load);
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
        private System.Windows.Forms.TextBox txtID;
    }
}
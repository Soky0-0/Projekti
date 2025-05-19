namespace Baze_podataka_2_projekni_zadatak
{
    partial class Rezervacije
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
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.txtDatumPocetka = new System.Windows.Forms.TextBox();
            this.txtDatumZavrsetka = new System.Windows.Forms.TextBox();
            this.cmbSmjestajnaJedinica = new System.Windows.Forms.ComboBox();
            this.dataGridViewJedinice = new System.Windows.Forms.DataGridView();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJedinice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Location = new System.Drawing.Point(16, 15);
            this.txtDatumRezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(265, 22);
            this.txtDatumRezervacije.TabIndex = 0;
            // 
            // txtDatumPocetka
            // 
            this.txtDatumPocetka.Location = new System.Drawing.Point(16, 47);
            this.txtDatumPocetka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumPocetka.Name = "txtDatumPocetka";
            this.txtDatumPocetka.Size = new System.Drawing.Size(265, 22);
            this.txtDatumPocetka.TabIndex = 1;
            // 
            // txtDatumZavrsetka
            // 
            this.txtDatumZavrsetka.Location = new System.Drawing.Point(16, 79);
            this.txtDatumZavrsetka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumZavrsetka.Name = "txtDatumZavrsetka";
            this.txtDatumZavrsetka.Size = new System.Drawing.Size(265, 22);
            this.txtDatumZavrsetka.TabIndex = 2;
            // 
            // cmbSmjestajnaJedinica
            // 
            this.cmbSmjestajnaJedinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmjestajnaJedinica.FormattingEnabled = true;
            this.cmbSmjestajnaJedinica.Location = new System.Drawing.Point(16, 111);
            this.cmbSmjestajnaJedinica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSmjestajnaJedinica.Name = "cmbSmjestajnaJedinica";
            this.cmbSmjestajnaJedinica.Size = new System.Drawing.Size(265, 24);
            this.cmbSmjestajnaJedinica.TabIndex = 3;
            // 
            // dataGridViewJedinice
            // 
            this.dataGridViewJedinice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJedinice.Location = new System.Drawing.Point(16, 144);
            this.dataGridViewJedinice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewJedinice.Name = "dataGridViewJedinice";
            this.dataGridViewJedinice.RowHeadersWidth = 51;
            this.dataGridViewJedinice.Size = new System.Drawing.Size(668, 249);
            this.dataGridViewJedinice.TabIndex = 4;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(16, 401);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(267, 28);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Potvrdi rezervaciju";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 456);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.dataGridViewJedinice);
            this.Controls.Add(this.cmbSmjestajnaJedinica);
            this.Controls.Add(this.txtDatumZavrsetka);
            this.Controls.Add(this.txtDatumPocetka);
            this.Controls.Add(this.txtDatumRezervacije);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.Rezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJedinice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDatumRezervacije;
        private System.Windows.Forms.TextBox txtDatumPocetka;
        private System.Windows.Forms.TextBox txtDatumZavrsetka;
        private System.Windows.Forms.ComboBox cmbSmjestajnaJedinica;
        private System.Windows.Forms.DataGridView dataGridViewJedinice;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}
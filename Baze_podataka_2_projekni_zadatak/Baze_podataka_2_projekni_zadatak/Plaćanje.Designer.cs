namespace Baze_podataka_2_projekni_zadatak
{
    partial class Plaćanje
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
            this.dataGridViewRezervacije = new System.Windows.Forms.DataGridView();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.btnPlati = new System.Windows.Forms.Button();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.txtIdPlacanja = new System.Windows.Forms.TextBox();
            this.lblIdPlacanja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.RowHeadersWidth = 51;
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(1060, 300);
            this.dataGridViewRezervacije.TabIndex = 0;
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(16, 340);
            this.cmbNacinPlacanja.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(265, 24);
            this.cmbNacinPlacanja.TabIndex = 1;
            // 
            // btnPlati
            // 
            this.btnPlati.Location = new System.Drawing.Point(16, 422);
            this.btnPlati.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(265, 28);
            this.btnPlati.TabIndex = 2;
            this.btnPlati.Text = "Plati";
            this.btnPlati.UseVisualStyleBackColor = true;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(16, 320);
            this.lblNacinPlacanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(97, 16);
            this.lblNacinPlacanja.TabIndex = 3;
            this.lblNacinPlacanja.Text = "Način plaćanja";
            // 
            // txtIdPlacanja
            // 
            this.txtIdPlacanja.Location = new System.Drawing.Point(16, 398);
            this.txtIdPlacanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPlacanja.Name = "txtIdPlacanja";
            this.txtIdPlacanja.Size = new System.Drawing.Size(265, 22);
            this.txtIdPlacanja.TabIndex = 4;
            // 
            // lblIdPlacanja
            // 
            this.lblIdPlacanja.AutoSize = true;
            this.lblIdPlacanja.Location = new System.Drawing.Point(16, 378);
            this.lblIdPlacanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPlacanja.Name = "lblIdPlacanja";
            this.lblIdPlacanja.Size = new System.Drawing.Size(76, 16);
            this.lblIdPlacanja.TabIndex = 5;
            this.lblIdPlacanja.Text = "ID Plaćanja";
            // 
            // Plaćanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 482);
            this.Controls.Add(this.lblIdPlacanja);
            this.Controls.Add(this.txtIdPlacanja);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.btnPlati);
            this.Controls.Add(this.cmbNacinPlacanja);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plaćanje";
            this.Text = "Plaćanje";
            this.Load += new System.EventHandler(this.Plaćanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewRezervacije;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.Button btnPlati;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.TextBox txtIdPlacanja;
        private System.Windows.Forms.Label lblIdPlacanja;
    }
}
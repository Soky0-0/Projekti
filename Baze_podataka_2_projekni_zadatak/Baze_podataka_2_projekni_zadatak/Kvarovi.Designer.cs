namespace Baze_podataka_2_projekni_zadatak
{
    partial class Kvarovi
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
            this.dataGridViewKvarovi = new System.Windows.Forms.DataGridView();
            this.btnOznaciRijesenim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKvarovi
            // 
            this.dataGridViewKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKvarovi.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewKvarovi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKvarovi.Name = "dataGridViewKvarovi";
            this.dataGridViewKvarovi.RowHeadersWidth = 51;
            this.dataGridViewKvarovi.Size = new System.Drawing.Size(842, 300);
            this.dataGridViewKvarovi.TabIndex = 0;
            // 
            // btnOznaciRijesenim
            // 
            this.btnOznaciRijesenim.Location = new System.Drawing.Point(16, 323);
            this.btnOznaciRijesenim.Margin = new System.Windows.Forms.Padding(4);
            this.btnOznaciRijesenim.Name = "btnOznaciRijesenim";
            this.btnOznaciRijesenim.Size = new System.Drawing.Size(842, 28);
            this.btnOznaciRijesenim.TabIndex = 1;
            this.btnOznaciRijesenim.Text = "Označi kao riješen";
            this.btnOznaciRijesenim.UseVisualStyleBackColor = true;
            this.btnOznaciRijesenim.Click += new System.EventHandler(this.btnOznaciRijesenim_Click);
            // 
            // Kvarovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 364);
            this.Controls.Add(this.btnOznaciRijesenim);
            this.Controls.Add(this.dataGridViewKvarovi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kvarovi";
            this.Text = "Kvarovi";
            this.Load += new System.EventHandler(this.Kvarovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKvarovi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridViewKvarovi;
        private System.Windows.Forms.Button btnOznaciRijesenim;
    }
}
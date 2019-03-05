namespace GestionaleWindows
{
    partial class ModificaFattura
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sceglifilebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nomefile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fatturaControllo1 = new GestionaleWindows.FatturaControllo();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sceglifilebutton
            // 
            this.sceglifilebutton.Location = new System.Drawing.Point(3, 12);
            this.sceglifilebutton.Name = "sceglifilebutton";
            this.sceglifilebutton.Size = new System.Drawing.Size(284, 41);
            this.sceglifilebutton.TabIndex = 0;
            this.sceglifilebutton.Text = "Seleziona fattura da modificare";
            this.sceglifilebutton.UseVisualStyleBackColor = true;
            this.sceglifilebutton.Click += new System.EventHandler(this.sceglifile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nomefile
            // 
            this.nomefile.AutoSize = true;
            this.nomefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomefile.Location = new System.Drawing.Point(313, 18);
            this.nomefile.Name = "nomefile";
            this.nomefile.Size = new System.Drawing.Size(203, 24);
            this.nomefile.TabIndex = 1;
            this.nomefile.Text = "Nessun file selezionato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // fatturaControllo1
            // 
            this.fatturaControllo1.Location = new System.Drawing.Point(0, 59);
            this.fatturaControllo1.Name = "fatturaControllo1";
            this.fatturaControllo1.Size = new System.Drawing.Size(1315, 342);
            this.fatturaControllo1.TabIndex = 4;
            // 
            // ModificaFattura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fatturaControllo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomefile);
            this.Controls.Add(this.sceglifilebutton);
            this.Name = "ModificaFattura";
            this.Size = new System.Drawing.Size(1436, 709);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sceglifilebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label nomefile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private FatturaControllo fatturaControllo1;
    }
}

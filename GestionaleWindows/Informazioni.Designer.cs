﻿namespace GestionaleWindows
{
    partial class Informazioni
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagridinformazioni = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridinformazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informazioni Azienda";
            // 
            // datagridinformazioni
            // 
            this.datagridinformazioni.AllowUserToAddRows = false;
            this.datagridinformazioni.AllowUserToDeleteRows = false;
            this.datagridinformazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridinformazioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridinformazioni.Location = new System.Drawing.Point(0, 55);
            this.datagridinformazioni.Name = "datagridinformazioni";
            this.datagridinformazioni.Size = new System.Drawing.Size(1517, 150);
            this.datagridinformazioni.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1517, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvainformazioni);
            // 
            // Informazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridinformazioni);
            this.Controls.Add(this.label1);
            this.Name = "Informazioni";
            this.Size = new System.Drawing.Size(1517, 789);
            ((System.ComponentModel.ISupportInitialize)(this.datagridinformazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridinformazioni;
        private System.Windows.Forms.Button button1;
    }
}

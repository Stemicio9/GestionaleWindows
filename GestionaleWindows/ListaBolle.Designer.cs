namespace GestionaleWindows
{
    partial class ListaBolle
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
            this.datagridbolle = new System.Windows.Forms.DataGridView();
            this.datagridrighe = new System.Windows.Forms.DataGridView();
            this.bollefatturatecheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxfiltrobolle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbolle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridrighe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Bolle";
            // 
            // datagridbolle
            // 
            this.datagridbolle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbolle.Location = new System.Drawing.Point(0, 129);
            this.datagridbolle.MultiSelect = false;
            this.datagridbolle.Name = "datagridbolle";
            this.datagridbolle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridbolle.Size = new System.Drawing.Size(736, 585);
            this.datagridbolle.TabIndex = 1;
            this.datagridbolle.SelectionChanged += new System.EventHandler(this.bollaselezionata);
            // 
            // datagridrighe
            // 
            this.datagridrighe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridrighe.Location = new System.Drawing.Point(804, 129);
            this.datagridrighe.Name = "datagridrighe";
            this.datagridrighe.Size = new System.Drawing.Size(648, 585);
            this.datagridrighe.TabIndex = 2;
            // 
            // bollefatturatecheck
            // 
            this.bollefatturatecheck.AutoSize = true;
            this.bollefatturatecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bollefatturatecheck.Location = new System.Drawing.Point(10, 45);
            this.bollefatturatecheck.Name = "bollefatturatecheck";
            this.bollefatturatecheck.Size = new System.Drawing.Size(229, 29);
            this.bollefatturatecheck.TabIndex = 3;
            this.bollefatturatecheck.Text = "BOLLE FATTURATE";
            this.bollefatturatecheck.UseVisualStyleBackColor = true;
            this.bollefatturatecheck.CheckedChanged += new System.EventHandler(this.checkboxcliccata);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Righe bolla selezionata";
            // 
            // textboxfiltrobolle
            // 
            this.textboxfiltrobolle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxfiltrobolle.Location = new System.Drawing.Point(0, 80);
            this.textboxfiltrobolle.Name = "textboxfiltrobolle";
            this.textboxfiltrobolle.Size = new System.Drawing.Size(736, 31);
            this.textboxfiltrobolle.TabIndex = 5;
            this.textboxfiltrobolle.TextChanged += new System.EventHandler(this.testocambiato);
            // 
            // ListaBolle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textboxfiltrobolle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bollefatturatecheck);
            this.Controls.Add(this.datagridrighe);
            this.Controls.Add(this.datagridbolle);
            this.Controls.Add(this.label1);
            this.Name = "ListaBolle";
            this.Size = new System.Drawing.Size(1433, 894);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbolle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridrighe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridbolle;
        private System.Windows.Forms.DataGridView datagridrighe;
        private System.Windows.Forms.CheckBox bollefatturatecheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxfiltrobolle;
    }
}

namespace GestionaleWindows
{
    partial class Articoli
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
            this.datagridarticoli = new System.Windows.Forms.DataGridView();
            this.datagridprezziadhoc = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridarticoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprezziadhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articoli";
            // 
            // datagridarticoli
            // 
            this.datagridarticoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridarticoli.Location = new System.Drawing.Point(13, 134);
            this.datagridarticoli.MultiSelect = false;
            this.datagridarticoli.Name = "datagridarticoli";
            this.datagridarticoli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridarticoli.Size = new System.Drawing.Size(577, 511);
            this.datagridarticoli.TabIndex = 1;
            this.datagridarticoli.SelectionChanged += new System.EventHandler(this.selezionecambiata);
            // 
            // datagridprezziadhoc
            // 
            this.datagridprezziadhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridprezziadhoc.Location = new System.Drawing.Point(639, 134);
            this.datagridprezziadhoc.Name = "datagridprezziadhoc";
            this.datagridprezziadhoc.Size = new System.Drawing.Size(446, 511);
            this.datagridprezziadhoc.TabIndex = 2;
            this.datagridprezziadhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridprezziadhoc_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.testocambiato);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1072, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salva tutto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvatutto);
            // 
            // Articoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagridprezziadhoc);
            this.Controls.Add(this.datagridarticoli);
            this.Controls.Add(this.label1);
            this.Name = "Articoli";
            this.Size = new System.Drawing.Size(1418, 712);
            ((System.ComponentModel.ISupportInitialize)(this.datagridarticoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprezziadhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridarticoli;
        private System.Windows.Forms.DataGridView datagridprezziadhoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

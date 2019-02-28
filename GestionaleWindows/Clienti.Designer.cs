namespace GestionaleWindows
{
    partial class Clienti
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
            this.datagridclienti = new System.Windows.Forms.DataGridView();
            this.datagriddestinazioni = new System.Windows.Forms.DataGridView();
            this.datagridpartitaiva = new System.Windows.Forms.DataGridView();
            this.datagridemail = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridclienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddestinazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpartitaiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridemail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clienti";
            // 
            // datagridclienti
            // 
            this.datagridclienti.AllowUserToOrderColumns = true;
            this.datagridclienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridclienti.Location = new System.Drawing.Point(5, 124);
            this.datagridclienti.MultiSelect = false;
            this.datagridclienti.Name = "datagridclienti";
            this.datagridclienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridclienti.Size = new System.Drawing.Size(519, 644);
            this.datagridclienti.TabIndex = 1;
            this.datagridclienti.SelectionChanged += new System.EventHandler(this.selezionecambiata);
            // 
            // datagriddestinazioni
            // 
            this.datagriddestinazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddestinazioni.Location = new System.Drawing.Point(559, 124);
            this.datagriddestinazioni.Name = "datagriddestinazioni";
            this.datagriddestinazioni.Size = new System.Drawing.Size(869, 171);
            this.datagriddestinazioni.TabIndex = 2;
            // 
            // datagridpartitaiva
            // 
            this.datagridpartitaiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridpartitaiva.Location = new System.Drawing.Point(559, 330);
            this.datagridpartitaiva.Name = "datagridpartitaiva";
            this.datagridpartitaiva.Size = new System.Drawing.Size(869, 256);
            this.datagridpartitaiva.TabIndex = 3;
            // 
            // datagridemail
            // 
            this.datagridemail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridemail.Location = new System.Drawing.Point(559, 628);
            this.datagridemail.Name = "datagridemail";
            this.datagridemail.Size = new System.Drawing.Size(869, 137);
            this.datagridemail.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.testocambiato);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 812);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1423, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salva tutto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvatutto);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagridemail);
            this.Controls.Add(this.datagridpartitaiva);
            this.Controls.Add(this.datagriddestinazioni);
            this.Controls.Add(this.datagridclienti);
            this.Controls.Add(this.label1);
            this.Name = "Clienti";
            this.Size = new System.Drawing.Size(1464, 888);
            ((System.ComponentModel.ISupportInitialize)(this.datagridclienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddestinazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpartitaiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridemail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridclienti;
        private System.Windows.Forms.DataGridView datagriddestinazioni;
        private System.Windows.Forms.DataGridView datagridpartitaiva;
        private System.Windows.Forms.DataGridView datagridemail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

namespace GestionaleWindows
{
    partial class Bolle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaarticoliscelti = new System.Windows.Forms.DataGridView();
            this.textboxcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.destinazionetextbox = new System.Windows.Forms.TextBox();
            this.textboxnumerocolli = new System.Windows.Forms.TextBox();
            this.textboxaspettobeni = new System.Windows.Forms.TextBox();
            this.textboxpeso = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxpartitaiva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listacheck = new System.Windows.Forms.CheckedListBox();
            this.datascelta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxnumerobolla = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ultimabollacreatalabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaarticoliscelti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(500, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 40);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.testocambiato);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tastopremutosucodicearticolo);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(500, 215);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(172, 40);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitapress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codice articolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantità";
            // 
            // listaarticoliscelti
            // 
            this.listaarticoliscelti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaarticoliscelti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listaarticoliscelti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaarticoliscelti.Location = new System.Drawing.Point(693, 68);
            this.listaarticoliscelti.Name = "listaarticoliscelti";
            this.listaarticoliscelti.Size = new System.Drawing.Size(595, 421);
            this.listaarticoliscelti.TabIndex = 7;
            // 
            // textboxcliente
            // 
            this.textboxcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxcliente.Location = new System.Drawing.Point(173, 3);
            this.textboxcliente.Name = "textboxcliente";
            this.textboxcliente.Size = new System.Drawing.Size(574, 40);
            this.textboxcliente.TabIndex = 8;
            this.textboxcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selezionato);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente";
            // 
            // destinazionetextbox
            // 
            this.destinazionetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinazionetextbox.Location = new System.Drawing.Point(-1, 545);
            this.destinazionetextbox.Name = "destinazionetextbox";
            this.destinazionetextbox.Size = new System.Drawing.Size(322, 38);
            this.destinazionetextbox.TabIndex = 10;
            // 
            // textboxnumerocolli
            // 
            this.textboxnumerocolli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnumerocolli.Location = new System.Drawing.Point(-1, 609);
            this.textboxnumerocolli.Name = "textboxnumerocolli";
            this.textboxnumerocolli.Size = new System.Drawing.Size(322, 38);
            this.textboxnumerocolli.TabIndex = 11;
            // 
            // textboxaspettobeni
            // 
            this.textboxaspettobeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxaspettobeni.Location = new System.Drawing.Point(0, 757);
            this.textboxaspettobeni.Name = "textboxaspettobeni";
            this.textboxaspettobeni.Size = new System.Drawing.Size(322, 38);
            this.textboxaspettobeni.TabIndex = 12;
            // 
            // textboxpeso
            // 
            this.textboxpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxpeso.Location = new System.Drawing.Point(-1, 680);
            this.textboxpeso.Name = "textboxpeso";
            this.textboxpeso.Size = new System.Drawing.Size(322, 38);
            this.textboxpeso.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "INDIRIZZO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "NUMERO COLLI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "PESO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 736);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "ASPETTO BENI";
            // 
            // textboxpartitaiva
            // 
            this.textboxpartitaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxpartitaiva.Location = new System.Drawing.Point(837, 3);
            this.textboxpartitaiva.Name = "textboxpartitaiva";
            this.textboxpartitaiva.Size = new System.Drawing.Size(347, 40);
            this.textboxpartitaiva.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(753, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Partita iva";
            // 
            // listacheck
            // 
            this.listacheck.CheckOnClick = true;
            this.listacheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listacheck.FormattingEnabled = true;
            this.listacheck.Items.AddRange(new object[] {
            "cedente",
            "vettore"});
            this.listacheck.Location = new System.Drawing.Point(371, 545);
            this.listacheck.Name = "listacheck";
            this.listacheck.Size = new System.Drawing.Size(174, 88);
            this.listacheck.TabIndex = 21;
            this.listacheck.SelectedIndexChanged += new System.EventHandler(this.checkselezionato);
            // 
            // datascelta
            // 
            this.datascelta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datascelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datascelta.Location = new System.Drawing.Point(768, 626);
            this.datascelta.Name = "datascelta";
            this.datascelta.Size = new System.Drawing.Size(416, 40);
            this.datascelta.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 92);
            this.button1.TabIndex = 23;
            this.button1.Text = "SALVA BOLLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvabolla);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(765, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "DATA BOLLA";
            // 
            // textboxnumerobolla
            // 
            this.textboxnumerobolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnumerobolla.Location = new System.Drawing.Point(768, 545);
            this.textboxnumerobolla.Name = "textboxnumerobolla";
            this.textboxnumerobolla.Size = new System.Drawing.Size(416, 40);
            this.textboxnumerobolla.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(765, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "NUMERO BOLLA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(937, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "ULTIMA CREATA : ";
            // 
            // ultimabollacreatalabel
            // 
            this.ultimabollacreatalabel.AutoSize = true;
            this.ultimabollacreatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimabollacreatalabel.Location = new System.Drawing.Point(1079, 524);
            this.ultimabollacreatalabel.Name = "ultimabollacreatalabel";
            this.ultimabollacreatalabel.Size = new System.Drawing.Size(0, 18);
            this.ultimabollacreatalabel.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 44);
            this.button2.TabIndex = 29;
            this.button2.Text = "crea PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 386);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 53);
            this.button3.TabIndex = 30;
            this.button3.Text = "crea PDF\r\ne esporta datagridview1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bolle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ultimabollacreatalabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textboxnumerobolla);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datascelta);
            this.Controls.Add(this.listacheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxpartitaiva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxpeso);
            this.Controls.Add(this.textboxaspettobeni);
            this.Controls.Add(this.textboxnumerocolli);
            this.Controls.Add(this.destinazionetextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxcliente);
            this.Controls.Add(this.listaarticoliscelti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bolle";
            this.Size = new System.Drawing.Size(1580, 912);
            this.Load += new System.EventHandler(this.Bolle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaarticoliscelti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listaarticoliscelti;
        private System.Windows.Forms.TextBox textboxcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox destinazionetextbox;
        private System.Windows.Forms.TextBox textboxnumerocolli;
        private System.Windows.Forms.TextBox textboxaspettobeni;
        private System.Windows.Forms.MaskedTextBox textboxpeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxpartitaiva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox listacheck;
        private System.Windows.Forms.DateTimePicker datascelta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textboxnumerobolla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ultimabollacreatalabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

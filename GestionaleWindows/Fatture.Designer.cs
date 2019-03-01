namespace GestionaleWindows
{
    partial class Fatture
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
            this.differitaradio = new System.Windows.Forms.RadioButton();
            this.accompagnatoriaradio = new System.Windows.Forms.RadioButton();
            this.creditoradio = new System.Windows.Forms.RadioButton();
            this.debitoradio = new System.Windows.Forms.RadioButton();
            this.pannellofatture = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatture";
            // 
            // differitaradio
            // 
            this.differitaradio.AutoSize = true;
            this.differitaradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differitaradio.Location = new System.Drawing.Point(13, 86);
            this.differitaradio.Name = "differitaradio";
            this.differitaradio.Size = new System.Drawing.Size(175, 29);
            this.differitaradio.TabIndex = 1;
            this.differitaradio.Text = "Fattura differita";
            this.differitaradio.UseVisualStyleBackColor = true;
            this.differitaradio.CheckedChanged += new System.EventHandler(this.differitaradio_CheckedChanged);
            // 
            // accompagnatoriaradio
            // 
            this.accompagnatoriaradio.AutoSize = true;
            this.accompagnatoriaradio.Checked = true;
            this.accompagnatoriaradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accompagnatoriaradio.Location = new System.Drawing.Point(215, 86);
            this.accompagnatoriaradio.Name = "accompagnatoriaradio";
            this.accompagnatoriaradio.Size = new System.Drawing.Size(269, 29);
            this.accompagnatoriaradio.TabIndex = 2;
            this.accompagnatoriaradio.TabStop = true;
            this.accompagnatoriaradio.Text = "Fattura accompagnatoria";
            this.accompagnatoriaradio.UseVisualStyleBackColor = true;
            this.accompagnatoriaradio.CheckedChanged += new System.EventHandler(this.accompagnatoriaradio_CheckedChanged);
            // 
            // creditoradio
            // 
            this.creditoradio.AutoSize = true;
            this.creditoradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditoradio.Location = new System.Drawing.Point(507, 86);
            this.creditoradio.Name = "creditoradio";
            this.creditoradio.Size = new System.Drawing.Size(146, 29);
            this.creditoradio.TabIndex = 3;
            this.creditoradio.TabStop = true;
            this.creditoradio.Text = "Nota credito";
            this.creditoradio.UseVisualStyleBackColor = true;
            this.creditoradio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // debitoradio
            // 
            this.debitoradio.AutoSize = true;
            this.debitoradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitoradio.Location = new System.Drawing.Point(707, 86);
            this.debitoradio.Name = "debitoradio";
            this.debitoradio.Size = new System.Drawing.Size(140, 29);
            this.debitoradio.TabIndex = 4;
            this.debitoradio.Text = "Nota debito";
            this.debitoradio.UseVisualStyleBackColor = true;
            this.debitoradio.CheckedChanged += new System.EventHandler(this.debitoradio_CheckedChanged);
            // 
            // pannellofatture
            // 
            this.pannellofatture.Location = new System.Drawing.Point(0, 133);
            this.pannellofatture.Name = "pannellofatture";
            this.pannellofatture.Size = new System.Drawing.Size(1475, 666);
            this.pannellofatture.TabIndex = 5;
            // 
            // Fatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pannellofatture);
            this.Controls.Add(this.debitoradio);
            this.Controls.Add(this.creditoradio);
            this.Controls.Add(this.accompagnatoriaradio);
            this.Controls.Add(this.differitaradio);
            this.Controls.Add(this.label1);
            this.Name = "Fatture";
            this.Size = new System.Drawing.Size(1458, 752);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton differitaradio;
        private System.Windows.Forms.RadioButton accompagnatoriaradio;
        private System.Windows.Forms.RadioButton creditoradio;
        private System.Windows.Forms.RadioButton debitoradio;
        private System.Windows.Forms.Panel pannellofatture;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleWindows
{
    public partial class Fatture : UserControl
    {
        public Fatture()
        {
            InitializeComponent();
            spostasufatturaaccompagnatoria();
        }

        FatturaControllo fattura = new FatturaControllo();
        NotaCreditoControllo notacredito = new NotaCreditoControllo();
        NotaDebitoControllo notadebito = new NotaDebitoControllo();

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            spostasunotacredito();
        }

        public void spostasunotacredito()
        {
            this.pannellofatture.Controls.Clear();
            this.pannellofatture.Controls.Add(notacredito);
        }

        private void differitaradio_CheckedChanged(object sender, EventArgs e)
        {
 
            spostasufattura();
        }


        public void spostasufattura()
        {

        }

        private void accompagnatoriaradio_CheckedChanged(object sender, EventArgs e)
        {

            spostasufatturaaccompagnatoria();
        }

        public void spostasufatturaaccompagnatoria()
        {
            this.pannellofatture.Controls.Clear();
            this.pannellofatture.Controls.Add(fattura);
        }

        private void debitoradio_CheckedChanged(object sender, EventArgs e)
        {
            spostasunotadebito();
        }

        public void spostasunotadebito()
        {
            this.pannellofatture.Controls.Clear();
            this.pannellofatture.Controls.Add(notadebito);
        }
    }
}

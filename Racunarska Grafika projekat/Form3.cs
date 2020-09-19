using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racunarska_Grafika_projekat
{
    public partial class Form3 : Form
    {
        public Form1 forma;
        public Form3(Form1 forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forma.poluprecnikKruga.Add(Convert.ToDouble(poluprecnikKruga.Text));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void poluprecnikKruga_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(poluprecnikKruga.Text, out result))
            {
                okButton.Enabled = true;
            }
            else okButton.Enabled = false;
        }

       
    }
}

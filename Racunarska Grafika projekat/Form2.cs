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
    public partial class Form2 : Form
    {
        Form1 forma;
        public Form2(Form1 forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            forma.sirina_Pravougaonika = Convert.ToDouble(duzinaStranice.Text);
            forma.visina_Pravougaonika = Convert.ToDouble(visinaPravougaonika.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void duzinaStranice_TextChanged(object sender, EventArgs e)
        {
                double result;
            if (Double.TryParse(duzinaStranice.Text, out result) && Double.TryParse(visinaPravougaonika.Text,out result))
            {
                okButton.Enabled = true;
            }
            else okButton.Enabled = false;
        }

        
    }
}

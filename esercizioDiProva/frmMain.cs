using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizioDiProva
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgiungi_Click(object sender, EventArgs e)
        {
            int nPizze;
            switch (cmbTipoDiPizza.Text)
            {
                case "Margherita":
                    lstVisualizzazione.Items.Add("Margherita(" + txtQuantita.Text+")");
                    nPizze = Convert.ToInt32(lblMargherita.Text);
                    break;

                case "Verdure":
                    lstVisualizzazione.Items.Add("Verdure(" + txtQuantita.Text + ")");
                    nPizze = Convert.ToInt32(lblVerdura.Text);
                    break;

                case "4 stagioni":
                    lstVisualizzazione.Items.Add("Margherita(" + txtQuantita.Text + ")");
                    nPizze = Convert.ToInt32(lblStagioni.Text);
                    break;



            }
        }
    }
}

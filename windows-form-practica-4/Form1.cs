using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkMonitor.Checked == true)
            {
                total += 250;
            }

            if (chkTeclado.Checked == true)
            {
                total += 15;
            }

            if (chkMouse.Checked == true)
            {
                total += 20;
            }

            MessageBox.Show("El total es: " + total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
            {
                lblMensaje.Text = "Monitor";
            }
            else
            {
                lblMensaje.Text = "";
            }
        }
    }
}

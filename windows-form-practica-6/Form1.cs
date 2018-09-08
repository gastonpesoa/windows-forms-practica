﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo!!");
            //MessageBox.Show("Hola a todos", "Mi MessageBox");
            DialogResult r = MessageBox.Show("Probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

            if (r == DialogResult.Abort)
            {
                lblMensaje.Text = "Anular";
            }

            if (r == DialogResult.Retry)
            {
                lblMensaje.Text = "Reintentar";
            }

            if (r == DialogResult.Ignore)
            {
                lblMensaje.Text = "Omitir";
            }
        }
    }
}

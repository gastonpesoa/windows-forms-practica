﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola Mundo!";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hasta Luego!";
            this.Text = "Bye!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}

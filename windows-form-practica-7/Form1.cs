﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miForma = new Form2();

            //miForma.Show();
            miForma.ShowDialog();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?","Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
<<<<<<< HEAD
                e.Cancel = false;
            else
                e.Cancel = true;
=======
                e.Cancel = true;
            else
                e.Cancel = false;
>>>>>>> 4bb68e1c27fdfbbc00e1f96b3c8042963b5d3b6e
        }
    }
}

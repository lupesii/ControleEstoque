using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não programado", "SE ACALME HOMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta;
            Resposta = MessageBox.Show("Realmente deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (Resposta)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro telaCadastro = new frmCadastro();
            telaCadastro.Show();
        }

    }
}

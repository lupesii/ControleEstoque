using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoque.Formularios;
using MySql.Data.MySqlClient;

namespace ControleEstoque
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value++;
            }
            else
            {
                timer.Enabled = false;
                this.Visible = false;


                frmLogin telaLogin = new frmLogin();
                telaLogin.Show();
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleEstoque.Formularios
{
    public partial class frmCadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSql;

        public frmCadastro()
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;port=3306;user id=root;database=bd_SistemaLogin;");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado");
            }
            catch
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        public void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
            txtEmail.Focus();
        }

        public frmCadastro()
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;port=3306;user id=root;database=bd_SistemaLogin;");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                strSql = "SELECT * FROM Usuarios WHERE Email = @ParEmail";
                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ParEmail", txtEmail.Text);
                conexao.Open();
                reader = comando.ExecuteReader();

                if (!reader.HasRows && txtSenha.Text == txtConfSenha.Text)
                {
                    comando = null;
                    conexao.Close();

                    strSql = "INSERT INTO Usuarios (Email, Senha) VALUES (@ParEmail, @ParSenha)";
                    comando = new MySqlCommand(strSql, conexao);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ParEmail", txtEmail.Text);
                    comando.Parameters.AddWithValue("@ParSenha", txtSenha.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Cadastro não pode ser completado","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (MySqlException Erro)
            {
                MessageBox.Show("Erro -> " + Erro.Message);
                Application.Exit();
            }
            finally
            {
                LimparCampos();
                conexao.Close();
                comando = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmLogin : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string strSQL;

        public void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
        }

        public frmLogin()
        {
            InitializeComponent();
            conexao = new MySqlConnection("server=localhost;port=3306;user id=root;database=bd_SistemaLogin;");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "SELECT Senha FROM Usuarios WHERE Email = @ParEmail";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ParEmail", txtEmail.Text);
                conexao.Open();
                comando.ExecuteScalar();

                if(comando.ExecuteScalar() == null)
                {
                    MessageBox.Show("Usuário não encontrado, Verifique as informações");
                }
                else if(Convert.ToString(comando.ExecuteScalar()) != txtSenha.Text)
                {
                    MessageBox.Show("A senha incorreta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Visible = false;
                    frmPrincipal objTelaPrincipal = new frmPrincipal();
                    objTelaPrincipal.ShowDialog();
                }
            }
            catch (MySqlException Erro)
            {
                MessageBox.Show("Erro -> " + Erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                conexao.Close();
                comando = null;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == false)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro telaCadastro = new frmCadastro();
            telaCadastro.Show();
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

    }
}

using MySql.Data.MySqlClient;
using Projeto1.Properties;
using System;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmCadastroUsuario : Form
    {
        Conexao con = new Conexao();
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadUsuario.Text == "" && txtCadsenha.Text == "")
            {
                MessageBox.Show("Os campos não podem estar vazios");
                txtCadUsuario.Focus();
            }
            else
            {

            }           
            try {
                string sql = "insert into tbLogin(usuario,senha) values (@user,@senha)";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtCadUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtCadsenha.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados cadastrados com sucesso");
                con.DesConnectarBD();

            }
            catch(Exception error) 
            { 
                MessageBox.Show(error.Message);
            }
        }
    }
}

using MySql.Data.MySqlClient;
using Projeto1.Properties;
using System;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmLogin : Form
    {
        //instanciando a sting de conexão
        Conexao con = new Conexao();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "") {
                MessageBox.Show("Usuário e senha inválidos");
            }
            //Se as caixas de texto estiverem vazias, são invalidas.
            try
            {
                string sql = "select * from tbLogin where usuario=@user and senha = @senha";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                MySqlDataReader dados;
                dados = cmd.ExecuteReader();
                
                if (dados.HasRows)
                {
                    MessageBox.Show("Seja bem-vindo ao sistema");
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.Show();
                }
                else{
                    txtUsuario.Clear();
                    txtSenha.Clear();   
                    txtUsuario.Focus();
                }
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally{
                con.DesConnectarBD();
            }

        }
    }
}

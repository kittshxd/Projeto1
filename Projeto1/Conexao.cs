using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Projeto1.Properties
{

    class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto;user=root;pwd=12345678");
        public static string msg;
        public MySqlConnection ConnectarBD()
        {
            //tratamento de erros
            try
            {
                //abre banco de dados
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                //fecha banco de dados
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se desconectar" + erro.Message;
            }
            return con;
        }
    }
}












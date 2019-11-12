using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AppMySqlMvDAO
{
    class ConexaoDB
    {
        private static ConexaoDB objConexaoDB = null;
        private readonly MySqlConnection Conexao;

        private ConexaoDB()
        {
            Conexao = new MySqlConnection("server=localhost; user id=root; password=1234567; database=dbECOMMERCE");
        }

        public static ConexaoDB ConexaoStatus()
        {
            if(objConexaoDB == null)
            {
                objConexaoDB = new ConexaoDB();
            }
            return objConexaoDB;
        }

        public MySqlConnection ConexaoPegar()
        {
            return Conexao;
        }

        public void ConexaoFechar()
        {
            objConexaoDB = null;
        }
    }
}

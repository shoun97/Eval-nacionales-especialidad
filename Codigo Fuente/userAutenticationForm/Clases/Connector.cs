using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace userAutenticationForm.Clases
{
    class Connector
    {
        private string hostname = "localhost";
        private string data_base = "ENEDB";
        private string user = "root";
        private string pass = "blanquita"; //por favor cambiar clave a su usuario

        MySqlConnection link;
        MySqlCommand command;
        MySqlDataReader lector;

        public void Connect()
        {
            string string_conection = "server=" + hostname + "; uid=" + user + "; pwd=" + pass + "; database=" + data_base;
            link = new MySqlConnection(string_conection);
            command = new MySqlCommand();
            command.Connection = link;
            link.Open();
        }

        public void commandSQL(string _SQLSentence)
        {

            Connect();
            command.CommandText = _SQLSentence;
            command.Prepare();
            
            
        }

        public DataTable execute_select()
        {

            DataTable table = new DataTable();

            MySqlDataReader resultado;

            resultado = command.ExecuteReader();

            table.Load(resultado);

            return table;

        }

        public void setCommandSql(string sql)
        {
            
            Connect();
            command.CommandText = sql;
            command.Prepare();
            lector = command.ExecuteReader();
        }

        public MySqlConnection getConnection()
        {
            string conexionDir = "server=" + hostname + "; uid=" + user + "; pwd=" + pass + "; database=" + data_base;
            MySqlConnection MyConn2 = new MySqlConnection(conexionDir);
            MyConn2.Open();
            return MyConn2;
        }
    }
}

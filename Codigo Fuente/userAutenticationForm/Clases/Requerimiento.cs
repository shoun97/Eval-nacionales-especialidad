using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userAutenticationForm.Clases;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace userAutenticationForm.Clases
{
    class Requerimiento
    {
        Connector conexion = new Connector();

        public void setRequerimiento(string _reqType, string _reqDescr, string _userAsig, string _reqPriority)
        {
            string sentencia;


            sentencia = "call addReq('" + _reqType + "','" + _reqDescr + "','" + _userAsig + "','" + _reqPriority + "');";


            conexion.setCommandSql(sentencia);

        }

        public DataTable getRequerimiento(string _tipo, string _prioridad, string _estado)
        {
            Connector conexion = new Connector();
            String comando = "call showReq('" + _tipo + "','" + _prioridad + "','" + _estado + "');";

            MySqlCommand comando2 = new MySqlCommand(comando, conexion.getConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MyAdapter.SelectCommand = comando2;
            MyAdapter.Fill(table);


            return table;

        }
        public DataTable getRequerimientoAll()
        {
            Connector conexion = new Connector();
            String comando = "call showReqAll();";

            MySqlCommand comando2 = new MySqlCommand(comando, conexion.getConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MyAdapter.SelectCommand = comando2;
            MyAdapter.Fill(table);


            return table;

        }

        public void editRequerimiento(int _id)
        {
            string sentencia;


            sentencia = "call editEstadoReq(" + _id + ");";


            conexion.setCommandSql(sentencia);

        }

        public void reload(string _tipo, string _prioridad, string _estado)
        {
            Connector conexion = new Connector();
            String comando = "call showReq('" + _tipo + "','" + _prioridad + "','" + _estado + "');";

            MySqlCommand comando2 = new MySqlCommand(comando, conexion.getConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MyAdapter.SelectCommand = comando2;
            MyAdapter.Fill(table);
        } 

        public void delReq(int _id)
        {
            string sentencia;


            sentencia = "call delReq(" + _id + ");";


            conexion.setCommandSql(sentencia);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using userAutenticationForm.Clases;
using System.Threading.Tasks;


namespace userAutenticationForm.Clases
{
    class Usuario
    {

        public bool check_user(string _name, string _pawd)
        {
            Connector conexion = new Connector();
            string consulta = "call check_user('"+_name+"','"+_pawd+"');" ;
            
            conexion.commandSQL(consulta);
            if (conexion.execute_select().Rows.Count > 0) {
                return true; }
            else { return false; }

            
        }
    }

    
}

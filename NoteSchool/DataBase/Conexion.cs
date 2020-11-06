using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteSchool {

    class Conexion {

        public static MySqlConnection conexion() {

            //Variables
            String servidor = "localhost";
            String bd = "bduser";
            String user = "root";
            String password = "2509";

            //Variable para entrar a la base de datos.
            String cadenaConexion 
                = "Database=" + bd 
                + ";Data Source=" + servidor 
                + ";User Id=" + user
                + ";Password=" + password + "";

            try{

                MySqlConnection conexionBd = new MySqlConnection(cadenaConexion); //Conexion a la base de datos.
                return conexionBd;
                
            }catch(MySqlException e){

                Console.WriteLine("Error: " + e.Message);
                return null;

            }

        }
    }
}

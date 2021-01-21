using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.DataBase {

    class Usuario {

        //Metodo para guardar el usuario en la base de datos.
        public void guardarUsuario(Form sc, Form scL,TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String userName = tbUserName.Text;
            String userPassword = Encriptacion.GetSHA256(tbPassword.Text);

            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO users (userName, userpassword) VALUES ('"+ userName + "', '" + userPassword + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado.");

                sc.Visible = false; //Ocultamos el layout.
                scL.Show(); //Mostramos el login.

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.
            }

        }

        //Metodo para validar usuario y contraseña.
        public void validarUsuario(Form scL, Form scH, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String id;
            String userName = tbUserName.Text;
            String password = Encriptacion.GetSHA256(tbPassword.Text);
            String bdPassword;
            String bdUserName;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM users WHERE userName= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                bdUserName = lec["userName"].ToString();
                bdPassword = lec["userPassword"].ToString();

                //Verificamos que los datos esten correctos.
                if (userName == bdUserName && password == bdPassword) {

                    conexionBd.Close(); //Cerramos la base de datos.
                    scL.Dispose(); //Cerramos el login 
                    scH.Show(); //Abrimos el home.

                } else {
                    
                    MessageBox.Show("Usuario y contraseña no coinciden."); //Contraseña incorrecta
                
                }

            } else {

                MessageBox.Show("Usuario no registrado."); //Usuario sin registrar.

            }

        }

        //Metodo para validar si existe el usuario.
        public void validarUsuarioExistente(Form sc, Form scL, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String userName = tbUserName.Text;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT userName FROM users WHERE userName= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() != true) {

                guardarUsuario(sc, scL, tbUserName, tbPassword); //Metodo para registrar al usuario en la base de datos.
    
            } else {
                
                MessageBox.Show("Usuario ya existente.\nRegistre otro nombre.");
            
            }

        }

        //Metodo para validar si existe el usuario y editar la contraseña.
        public void validarUsuarioExistenteContraseña(Form sc, Form scL, TextBox tbUserName, TextBox tbPassword) {

            //Variables
            String userName = tbUserName.Text;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT userName FROM users WHERE userName= '" + userName + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                cambiarContraseña(sc, scL, tbUserName, tbPassword); //Metodo para registrar al usuario en la base de datos.
    
            } else {
                
                MessageBox.Show("Usuario no existente.");
            
            }

        }

        //Metodo para modificar la contraseña.
        public void cambiarContraseña(Form scL, Form scH, TextBox tbUserName, TextBox tbPassword) {
            

            //Variables
            String user = tbUserName.Text;
            String password = Encriptacion.GetSHA256(tbPassword.Text);

            //Comando de en que tabla insertar que datos.
            String sql = "UPDATE users SET userName= '"+ user + "', userPassword='"+ password + "' WHERE userName='"+ user + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.


            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario editado con exito.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.
                scL.Dispose();
                scH.Show();
            }
        }

    }
}

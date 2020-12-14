using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.DataBase {
    class Horario {

        //Estilo de color.
        public void colorStyle(DataGridView dataGridView) {

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31,31,31);
            dataGridView.GridColor = Color.FromArgb(41, 41, 41);
        }

        //Metodo para cargar el horario en el DGV.
        public void cargarHorario(DataGridView dataGridView, String tabla) {
            
            colorStyle(dataGridView); //Estilo para el DGV.
            dataGridView.AllowUserToAddRows = false; //Desactva añadir una fila.
            
            //Estilo de texto para la tabla.
            dataGridView.ForeColor = Color.White;
            dataGridView.BackgroundColor = Color.FromArgb(21,21,21);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(21,21,21);
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando para recuperar los datos de la bd.
            MySqlCommand cm = new MySqlCommand("SELECT * FROM bduser." + tabla + ";", conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cm); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dataGridView.DataSource = dt; //Asigna al DGV la fuente de datos.

            DataGridViewColumn Column = dataGridView.Columns[0]; //guarda la primer columna.  
            Column.Visible = false; //Evita que se muestre la primer columna.

            DataGridViewColumn cLink = dataGridView.Columns[3]; //Guardamos la tercer columna.
            cLink.Width = 395; //Tamaño del link.

        }
        
        //Metodo para ejecutar el link del aula.
        public void abrirAula(DataGridView dataGridView) {

            try {
                
                String link = dataGridView.CurrentRow.Cells["Aula"].Value.ToString();
                System.Diagnostics.Process.Start(link);

            } catch (Exception err) {

                MessageBox.Show("Ingrese un link valido.");

            }
        }

        //Metodo para crear una clase y guardarla en la base de datos.
        public void crearClase(Form Sc, String dia,  TextBox tbMateria, TextBox tbHora, TextBox tbLink) {

            //Variables
            String tDia = dia;
            String materia = tbMateria.Text;
            String hora = tbHora.Text;
            String link = tbLink.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO horario_" + tDia + " (Materia, Hora, Aula) VALUES ('"+ materia + "', '" + hora + "', '"+ link + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Clase registrada.");
                Sc.Dispose();

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

        //Metodo para editar la clase.
        public void editarClase(String id, Form Sc, String dia, TextBox tbMateria, TextBox tbHora, TextBox tbLink ) {
            
            //Variables
            String tDia = dia;
            String tId = id;
            String materia = tbMateria.Text;
            String hora = tbHora.Text;
            String link = tbLink.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "UPDATE horario_" + tDia + " SET Materia= '"+ materia + "', Hora='"+ hora + "', Aula='"+ link + "' WHERE idhorario_" + tDia + "='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Clase actualizada.");
                Sc.Dispose();

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }
        }

        //Metodo para eliminar la clase.
        public void eliminarClase(string id, String dia) {
            
            //Variables
            String tDia = dia;
            String tId = id;

            //Comando de en que tabla insertar que datos.
            String sql = "DELETE FROM horario_" + tDia + " WHERE idhorario_" + tDia + "='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Clase eliminada.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }
        }

        //Abrimos el dia en la ventana del editor de horario.
        public void abrirHorario(String id, String dia, TextBox tbMateria, TextBox tbHora, TextBox tbLink) {

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            //("SELECT * FROM notas WHERE idnotas= '" + id + "'");
            com.CommandText = ("SELECT * FROM horario_" + dia + " WHERE idhorario_" + dia + "= '" + id + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                tbMateria.Text = lec["Materia"].ToString();
                tbHora.Text = lec["Hora"].ToString();
                tbLink.Text = lec["Aula"].ToString();

            } else {

                MessageBox.Show("No existe la nota");
            
            }

        }

    }
}

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

        //Metodo para cargar el horario en el DGV.
        public void cargarHorario(DataGridView dataGridView, String tabla) {
            
            dataGridView.AllowUserToAddRows = false; //Desactva añadir una fila.
            
            //Estilo de texto para la tabla.
            dataGridView.ForeColor = Color.White;
            dataGridView.BackgroundColor = Color.FromArgb(21,21,21);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(21,21,21);

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

        }
        
        //Metodo para ejecutar el link del aula.
        public void abrirAula(DataGridView dataGridView) {

            String link = dataGridView.CurrentRow.Cells["Aula"].Value.ToString();
            System.Diagnostics.Process.Start(link);

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

    }
}

using MySql.Data.MySqlClient;
using NoteSchool.Layout.Tarea;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.DataBase {

    class Tarea {

        //Variables
        public String id;

        //Guarda una nota totalmente nueva.
        public void crearTarea(TextBox tbTitulo, TextBox tbFechaDeEntrega, RichTextBox rtDescripcion, ComboBox cbEstado) {

            //Variables
            String titulo = tbTitulo.Text;
            String fecha = tbFechaDeEntrega.Text;
            String descripcion = rtDescripcion.Text;
            String estado = cbEstado.Text;


            //String sql = "INSERT INTO users (userName, userpassword) VALUES ('"+ userName + "', '" + userPassword + "')";
            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO tareas (Titulo, Descripcion, Fecha_de_entrega, Estado) VALUES ('"+ titulo + "', '" + descripcion + "', '"+ fecha + "' , '"+ estado + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();

                MessageBox.Show("Tarea creada exitosamente."); //Confirmar resultado.
                
                //Guardar el id creado.
                id = comando.LastInsertedId.ToString();

                //Objetos
                ScVerTarea scVerTarea = new ScVerTarea();
                scVerTarea.setId(id);

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }
            
        }

        //Muestra las tareas en un DataGridView.
        public void cargarTarea(DataGridView dataGridView) {
            
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
            MySqlCommand cm = new MySqlCommand("SELECT * FROM bduser." + "tareas" + ";", conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cm); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dataGridView.DataSource = dt; //Asigna al DGV la fuente de datos.

            DataGridViewColumn Column = dataGridView.Columns[0]; //guarda la primer columna.  
            Column.Visible = false; //Evita que se muestre la primer columna.

            DataGridViewColumn cDescripcion = dataGridView.Columns[2]; //guardamos la columna del cuerpo.
            cDescripcion.Width = 291; //Ancho de la celda para el cuerpo.

            DataGridViewColumn cFecha = dataGridView.Columns[3]; //guardamos la columna del cuerpo.
            cFecha.Width = 120; //Ancho de la celda para el cuerpo.
            cFecha.HeaderText = "Fecha de entrega";
        }

        //Eliminamos la nota seleccionada.
        public void eliminarTarea(String id) {
            
            String tId = id; //Guardamos el id.

            //Comando de en que tabla insertar que datos.
            String sql = "DELETE FROM tareas WHERE idtareas='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Tarea eliminada.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

        //Abrimos la nota en la ventana del editor de texto.
        public void abrirTarea(String id, TextBox tbTitulo, TextBox tbFechaDeEntrega, RichTextBox rtDescripcion, ComboBox cbEstado) {

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM tareas WHERE idtareas= '" + id + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                tbTitulo.Text = lec["Titulo"].ToString();
                tbFechaDeEntrega.Text = lec["Fecha_de_entrega"].ToString();
                rtDescripcion.Text = lec["Descripcion"].ToString();
                cbEstado.Text = lec["Estado"].ToString();
            
            } else {

                MessageBox.Show("No existe la tarea");
            
            }

        }

        public void editarTarea(String id, TextBox tbTitulo, TextBox tbFechaDeEntrega, RichTextBox rtDescripcion, ComboBox cbEstado) {

            //Variables
            String tId = id;
            String titulo = tbTitulo.Text;
            String fecha = tbFechaDeEntrega.Text;
            String descripcion = rtDescripcion.Text;
            String estado = cbEstado.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "UPDATE tareas SET Titulo= '"+ titulo + "', Fecha_de_entrega='"+ fecha + "', Descripcion='"+ descripcion + "', Estado='"+ estado + "' WHERE idtareas='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Tarea editada con exito.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }


        }





    }
}

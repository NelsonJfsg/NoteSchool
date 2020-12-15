using MySql.Data.MySqlClient;
using NoteSchool.Layout.Notas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.DataBase {

    class Nota {

        //Estilo de color.
        public void colorStyle(DataGridView dataGridView) {

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31,31,31);
            dataGridView.GridColor = Color.FromArgb(41, 41, 41);

        }

        //Variables
        public String id;

        //Guarda una nota totalmente nueva.
        public void crearNota(TextBox tbTitulo, TextBox tbFecha, RichTextBox rtCuerpo) {

            //Variables
            String titulo = tbTitulo.Text;
            String fecha = tbFecha.Text;
            String cuerpo = rtCuerpo.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO notas (Titulo, Fecha, Cuerpo) VALUES ('"+ titulo + "', '" + fecha + "', '"+ cuerpo + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();

                MessageBox.Show("Nota creada exitosamente."); //Confirmar resultado.
                
                //Guardar el id creado.
                id = comando.LastInsertedId.ToString();
                
                //Objetos
                ScNotas scNotas = new ScNotas();
                scNotas.setId(id);

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }
        }

        //Muestra las notas en un DataGridView.
        public void cargarNotas(DataGridView dataGridView) {

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
            MySqlCommand cm = new MySqlCommand("SELECT * FROM bduser." + "notas" + ";", conexionBd);

            MySqlDataAdapter da = new MySqlDataAdapter(cm); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dataGridView.DataSource = dt; //Asigna al DGV la fuente de datos.

            DataGridViewColumn Column = dataGridView.Columns[0]; //guarda la primer columna.  
            Column.Visible = false; //Evita que se muestre la primer columna.

            DataGridViewColumn cLink = dataGridView.Columns[3]; //guardamos la columna del cuerpo.
            cLink.Width = 395; //Ancho de la celda para el cuerpo.

        }

        //Abrimos la nota en la ventana del editor de texto.
        public void abrirNota(String id, TextBox tbTitulo, TextBox tbFecha, RichTextBox rtCuerpo) {

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBd;
            com.CommandText = ("SELECT * FROM notas WHERE idnotas= '" + id + "'");
            
            MySqlDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if (lec.Read() == true) {

                tbTitulo.Text = lec["Titulo"].ToString();
                tbFecha.Text = lec["Fecha"].ToString();
                rtCuerpo.Text = lec["Cuerpo"].ToString();
            
            } else {

                MessageBox.Show("No existe la nota");
            
            }

        }

        //Eliminamos la nota seleccionada.
        public void eliminarNota(String id) {
            
            String tId = id; //Guardamos el id.

            //Comando de en que tabla insertar que datos.
            String sql = "DELETE FROM notas WHERE idnotas='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Nota eliminada.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

        //Modificar una nota ya existente.
        public void editarNota(String id, TextBox tbTitulo, TextBox tbFecha, RichTextBox rtCuerpo) {

            //Variables
            String tId = id;
            String titulo = tbTitulo.Text;
            String fecha = tbFecha.Text;
            String cuerpo = rtCuerpo.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "UPDATE notas SET Titulo= '"+ titulo + "', Fecha='"+ fecha + "', Cuerpo='"+ cuerpo + "' WHERE idnotas='"+ tId + "'";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Nota editada con exito.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }

        }

    }
}

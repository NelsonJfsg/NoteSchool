using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.DataBase;

namespace NoteSchool.Layout.Horario {
    public partial class ScRegistrarClase : Form {

        //Constructor.
        public ScRegistrarClase() {
            InitializeComponent();
            
        }

        //Variables
        String dia;

        //Objetos.
        DataBase.Horario hr = new DataBase.Horario();
        
        //setDia
        public String setDia(String text) {
            dia = text;
            return dia;
        }

        //Boton para registrar la clase.
        private void butRegistrarClase_Click(object sender, EventArgs e) {

            hr.crearClase(this, lDia.Text, tbMateria, tbHora, tbLink);
            
            /*
            //Variables
            String materia = tbMateria.Text;
            String hora = tbHora.Text;
            String link = tbLink.Text;

            //Comando de en que tabla insertar que datos.
            String sql = "INSERT INTO horario_lunes (Materia, Hora, Aula) VALUES ('"+ materia + "', '" + hora + "', '"+ link + "')";

            MySqlConnection conexionBd = Conexion.conexion(); //Objeto para llamar la conexion.
            conexionBd.Open(); //Abrir conexion con la base de datos.

            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Clase registrada.");
                

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.
                this.Dispose();
            }
            */
            
        }

        private void ScRegistrarClase_Load(object sender, EventArgs e) {
            lDia.Text = dia;
        }
    }
}

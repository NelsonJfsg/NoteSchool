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
    public partial class ScHorario : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        
        //Constructor
        public ScHorario() {
            InitializeComponent();
        }

        //Objetos
        DataBase.Horario hr = new DataBase.Horario();
        
        //Abrir ventana para registrar una nueva clase.
        private void butRegistrarClase_Click(object sender, EventArgs e) {
            ScRegistrarClase scRegistrarClase = new ScRegistrarClase();
            
            scRegistrarClase.setDia(lDia.Text);
            scRegistrarClase.Show();
        }

        //Abre el horario del lunes de forma predeterminada.
        private void ScHorario_Load(object sender, EventArgs e) {
            hr.cargarHorario(dataGVHorario, "horario_lunes");
        }

        //Evento doble click para ir a el aula.
        private void dataGVHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            hr.abrirAula(dataGVHorario);
        }

        //Evento click para el toolStrip del lunes.
        private void lunesToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("lunes", dataGVHorario);
        }

        //Evento click para el toolStrip del martes.
        private void martesToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("martes", dataGVHorario);
        }

        //Evento click para el toolStrip del miercoles.
        private void miercolesToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("miercoles", dataGVHorario);
        }
        
        //Evento click para el toolStrip del jueves.
        private void sabadoToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("jueves", dataGVHorario);
        }
        
        //Evento click para el toolStrip del viernes.
        private void viernesToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("viernes", dataGVHorario);
        }
        
        //Evento click para el toolStrip del sabado.
        private void sabadoToolStripMenuItem1_Click(object sender, EventArgs e) {
            cambiarHorario("sabado", dataGVHorario);
        }
        
        //Evento click para el toolStrip del domingo.
        private void domingoToolStripMenuItem_Click(object sender, EventArgs e) {
            cambiarHorario("domingo", dataGVHorario);
        }

        //Metodo general para cambiar el horario en el DGV.
        public void cambiarHorario(String dia, DataGridView dataGridView) {

            lDia.Text = dia;
            hr.cargarHorario(dataGVHorario, "horario_" + dia);

        }

        //Evento click para mostrar el layout de editar clase.
        private void butEditarClase_Click(object sender, EventArgs e) {

            //Objeto
            ScEditarClase scEditarClase = new ScEditarClase();

            //Obtener el id del dia.
            if (dataGVHorario.CurrentRow != null) {

               String id = dataGVHorario.CurrentRow.Cells["idhorario_" + lDia.Text].Value.ToString();
                
               //Metodo para settear el parametro dia y el id.
               scEditarClase.setDia(lDia.Text);
               scEditarClase.setId(id);

               scEditarClase.Show(); //Mostrar el form para editar.

            } else {

                MessageBox.Show("Selecciona una clase.");
            
            }
            
        }

        //Evento click para eliminar la clase.
        private void butEliminarClase_Click(object sender, EventArgs e) {

            if (dataGVHorario.CurrentRow != null) {

               String id = dataGVHorario.CurrentRow.Cells["idhorario_" + lDia.Text].Value.ToString();
               hr.eliminarClase(id, lDia.Text);

            } else {

                MessageBox.Show("Selecciona una clase.");
            
            }

        }

        //Evento click para actualizar la base de datos.
        private void butActualizar_Click(object sender, EventArgs e) {
            hr.cargarHorario(dataGVHorario, "horario_" + lDia.Text);
        }

    }
}

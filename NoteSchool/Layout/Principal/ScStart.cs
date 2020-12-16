using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout {

    public partial class ScStart : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor.
        public ScStart() {
            InitializeComponent();
        }
        
        //Estilo de color.
        public void colorStyle(DataGridView dataGridView) {

             dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31,31,31);

        }

        //Metodo para actualizar el DGV de Horario y de Tareas.
        public void cargarHyT(DataGridView dataGridViewT, DataGridView dataGridViewH, ComboBox cbDia) {

            //Estilos
            colorStyle(dataGridViewT);
            colorStyle(dataGridViewH);

            //Objetos
            DataBase.Tarea tarea = new DataBase.Tarea();
            DataBase.Horario horario = new DataBase.Horario();

            //Variables
            cbDia.Text = "lunes";

            tarea.cargarTareaIncompleta(dataGridViewT);
            horario.cargarHorario(dataGridViewH, "horario_" + cbDia.Text);

            DataGridViewColumn Column = dataGridViewT.Columns[4]; //guarda la primer columna.  
            Column.Visible = false; //Evita que se muestre la ultima columna.

            DataGridViewColumn cTitulo = dataGridViewT.Columns[1];
            cTitulo.Width = 229; //Ancho de la celda para el cuerpo.

            DataGridViewColumn cLink = dataGridViewH.Columns[3];
            cLink.Width = 313;
        }

        //Metodo load para cargar todas las opciones.
        private void ScStart_Load(object sender, EventArgs e) {

            cargarHyT(dataGVTareas, dataGVHorario, cbDia);
        
        }

        //Cambiar el dia para el horario.
        private void cbDia_SelectedIndexChanged(object sender, EventArgs e) {
            
            //Objetos
            DataBase.Horario horario = new DataBase.Horario();

            horario.cargarHorario(dataGVHorario, "horario_" + cbDia.Text);
            
            //Cambiar tamaño para el link.
            DataGridViewColumn cLink = dataGVHorario.Columns[3];
            cLink.Width = 313;

        }

        //Actualizar los DGV.
        private void pbActualizar_Click(object sender, EventArgs e) {

            cargarHyT(dataGVTareas, dataGVHorario, cbDia);

        }

        //Evento doble click para abrir el link.
        private void dataGVHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            //Objetos
            DataBase.Horario horario = new DataBase.Horario();

            horario.abrirAula(dataGVHorario);
        }

        //Evento para saber si el form se activó.
        private void ScStart_VisibleChanged(object sender, EventArgs e) {
            
            cargarHyT(dataGVTareas, dataGVHorario, cbDia);

        }
    }
}

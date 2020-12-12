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

namespace NoteSchool.Layout.Tarea {

    public partial class ScTarea : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor.
        public ScTarea() {
            InitializeComponent();
        }

        //Objetos
        DataBase.Tarea tarea = new DataBase.Tarea();
        
        //Evento click para abrir el registro de tareas.
        private void pbCrearTarea_Click(object sender, EventArgs e) {

            ScVerTarea scVerTarea = new ScVerTarea();
            scVerTarea.Show();

        }

        //Evento load para cargar la tarea en el DGV.
        private void ScTarea_Load(object sender, EventArgs e) {
            
            tarea.cargarTarea(dataGVTarea);
            
            DataGridViewColumn cTitulo = dataGVTarea.Columns[1];
            cTitulo.Width = 118; //Ancho de la celda para el titulo.

        }

        //Evento click para actualizar el DGV.
        private void pbActualizar_Click(object sender, EventArgs e) {

            tarea.cargarTarea(dataGVTarea);
        
        }

        //Evento click para eliminar la tarea.
        private void pbEliminarTarea_Click(object sender, EventArgs e) {
            
            //Validamos que el DGV no esté vacío.
            if (dataGVTarea.CurrentRow != null) {

                //Guardamos el id.
                String id = dataGVTarea.CurrentRow.Cells["idtareas"].Value.ToString();

                tarea.eliminarTarea(id); //Eliminamos la nota.

            } else {

                MessageBox.Show("Selecciona una tarea");

            }
        }

        //Evento click para editar la tarea.
        private void pbEditarTarea_Click(object sender, EventArgs e) {

            //Validamos que el DGV no esté vacío.
            if (dataGVTarea.CurrentRow != null) {
                
                //Objetos
                ScVerTarea scVerTarea = new ScVerTarea();

                //Obtenemos el id de la nota seleccionada.
                String id = dataGVTarea.CurrentRow.Cells["idtareas"].Value.ToString();
                
                //Guardamos el id y el estado.
                scVerTarea.setId(id);
                scVerTarea.setEstado(true);
                scVerTarea.Show(); //Mostramos la ventana del editor de texto.

            } else {

                MessageBox.Show("Selecciona una tarea");

            }

            
        }
    
    }
}

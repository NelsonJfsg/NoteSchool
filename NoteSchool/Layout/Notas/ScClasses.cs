using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout.Notas;
using NoteSchool.DataBase;

namespace NoteSchool.Layout {
    public partial class ScClasses : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public ScClasses() {
            InitializeComponent();
        }

        //Objetos
        Nota nota = new Nota();

        //Evento load para cargar las notas en el DGV.
        private void ScClasses_Load(object sender, EventArgs e) {

            nota.cargarNotas(dataGVNotas); //Cargamos las notas en el DGV.

            DataGridViewColumn cTitulo = dataGVNotas.Columns[1];
            cTitulo.Width = 134; //Ancho de la celda para el cuerpo.

        }

        //Evento click para abrir la ventana del editor de texto.
        private void pbCrearNota_Click(object sender, EventArgs e) {

            ScNotas scNotas = new ScNotas();
            scNotas.Show();

        }

        //Evento click para abrir una nota y poder editarla.
        private void pbEditarNota_Click(object sender, EventArgs e) {

            //Validamos que el DGV no esté vacío.
            if (dataGVNotas.CurrentRow != null) {
                    
                //Objetos
                ScNotas scNotas = new ScNotas();

                //Obtenemos el id de la nota seleccionada.
                String id = dataGVNotas.CurrentRow.Cells["idnotas"].Value.ToString();
                
                //Guardamos el id y el estado.
                scNotas.setId(id);
                scNotas.setEstado(true);

                scNotas.Show(); //Mostramos la ventana del editor de texto.

            } else {

                MessageBox.Show("Selecciona una nota");

            }

        }

        //Evento click para eliminar la nota seleccionada.
        private void pbEliminarNota_Click(object sender, EventArgs e) {

            //Validamos que el DGV no esté vacío.
            if (dataGVNotas.CurrentRow != null) {

                //Variables
                DialogResult result = MessageBox.Show("¿Desea eliminar la nota?", "Eliminar nota.", MessageBoxButtons.YesNo);

                //Confirmar la eliminacion de la nota.
                if (result == DialogResult.Yes) {

                    //Guardamos el id.
                    String id = dataGVNotas.CurrentRow.Cells["idnotas"].Value.ToString();

                    nota.eliminarNota(id); //Eliminamos la nota.

                }

                
            } else {

                MessageBox.Show("Selecciona una nota");

            }
            
        }

        //Evento click para actualizar las notas mostradas en el DGV.
        private void pbActualizar_Click(object sender, EventArgs e) {

            nota.cargarNotas(dataGVNotas);
        
        }

    }
}

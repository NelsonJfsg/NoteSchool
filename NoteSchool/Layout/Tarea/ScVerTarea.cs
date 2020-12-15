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

    public partial class ScVerTarea : Form {

        //Constructor.
        public ScVerTarea() {
            InitializeComponent();
        }

        //Variables
        String id;
        bool tEstado;
        DataGridView tDGV;

        //Objetos
        DataBase.Tarea tarea = new DataBase.Tarea();

        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        //setId.
        public String setId(String text) {
            id = text;
            return id;
        }

        //setEstado.
        public bool setEstado(bool estado) {
            tEstado = estado;
            return estado;
        }

        //Metodo load para editar la tarea seleccionada.
        private void ScVerTarea_Load(object sender, EventArgs e) {
            
            //Verificamos si es una tarea nueva o ya existente.
            if (tEstado == true) {
       
                //Abrimos la tarea.
                tarea.abrirTarea(id, tbTitulo, tbFechaDeEntrega, rtDescripcion, cbEstado);
            
            }

        }

        //Metodo para guardar la tarea.
        private void butGuardarTarea_Click_1(object sender, EventArgs e) {
            
            //Verificamos que el estado sea verdadero para crear la nota.
            if (tEstado != true) {
                
                //Crea la nota.
                tarea.crearTarea(tbTitulo, tbFechaDeEntrega, rtDescripcion, cbEstado);
                tarea.cargarTarea(tDGV); //Cargamos el horario
                tEstado = true;

            } else {

                //Editamos con el id de la nota antes creada.
                tarea.editarTarea(id, tbTitulo, tbFechaDeEntrega, rtDescripcion, cbEstado);
                tarea.cargarTarea(tDGV); //Cargamos el horario
            }

            //Cerramos la ventana.
            this.Dispose();

        }

    }
}

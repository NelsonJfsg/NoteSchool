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

namespace NoteSchool.Layout.Notas {
    public partial class ScNotas : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor.
        public ScNotas() {
            InitializeComponent();
        }

        //Variables.
        String id;
        bool tEstado; //Define si es una nota nueva o ya creada.

        //Objetos.
        Nota nota = new Nota();

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

        //Evento click para guardar la nota.
        private void butGuardarNota_Click(object sender, EventArgs e) {

            //Verificamos que el estado sea verdadero para crear la nota.
            if (tEstado != true) {
                
                //Crea la nota.
                nota.crearNota(tbTitulo, tbFecha, rtCuerpo);
                tEstado = true;

            } else {

                if (nota.id == null) {

                    //Editamos con el id de la nota antes creada.
                    nota.editarNota(id, tbTitulo, tbFecha, rtCuerpo);

                } else {

                    //Editamos con el id de la nota nueva.
                    nota.editarNota(nota.id, tbTitulo, tbFecha, rtCuerpo);

                }
            }

        }

        //Evento load para abrir la nota.
        private void ScNotas_Load(object sender, EventArgs e) {

            if (tEstado == true) {
       
                Nota nota = new Nota();
                nota.abrirNota(id, tbTitulo, tbFecha, rtCuerpo);

            }

        }

        //Evento closing para guardar el valor al estado.
        private void ScNotas_FormClosing(object sender, FormClosingEventArgs e) {

            setEstado(false);

        }

    }
}

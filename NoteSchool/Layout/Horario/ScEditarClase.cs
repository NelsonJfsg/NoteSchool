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

    public partial class ScEditarClase : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public ScEditarClase() {
            InitializeComponent();
        }

        //Variables
        String dia;
        String id;

        //setDia
        public String setDia(String text) {
            dia = text;
            return dia;
        }

        //setId
        public String setId(String text) {
            id = text;
            return id;
        }

        //Evento click para editar en la base de datos los nuevos valores.
        private void butEditarClase_Click(object sender, EventArgs e) {

            //Objeto.
            DataBase.Horario hr = new DataBase.Horario();

            //Metodo para actualizar los valores en la base de datos.
            hr.editarClase(id, this, dia, tbMateria, tbHora, tbLink);

        }

        //Metodo para cargar los datos en los TextBox.
        private void ScEditarClase_Load(object sender, EventArgs e) {
            lDia.Text = dia;
        }
    
    }
}

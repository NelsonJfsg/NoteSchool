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
    }
}

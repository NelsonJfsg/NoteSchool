using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout.Horario;

namespace NoteSchool.Layout.Horario {
    public partial class ScRegistrarClase : Form {
        public ScRegistrarClase() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            
            ScHorario scHorario = new ScHorario();

            //Variables
            String materia = "TAP";
            String hora = "7am";
            String link = "www.google.com";

            materia = tbMateria.Text;
            scHorario.link(materia, hora, link);

            
        }
    }
}

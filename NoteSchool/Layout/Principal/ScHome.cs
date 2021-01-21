using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout;
using NoteSchool.Layout.Tarea;
using NoteSchool.Layout.Horario;

namespace NoteSchool.Layout {

    public partial class ScHome : Form {
    
        //Constructor del ScHome.
        public ScHome() {
            InitializeComponent();
        }

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Cerrar programa.
        private void ScHome_FormClosing(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }

        //Instancias para los layouts
        public static ScInfo scInfo = new ScInfo();
        public static ScClasses scClasses = new ScClasses();
        public static ScTools scTools = new ScTools();
        public static ScStart scStart = new ScStart();
        public static ScTarea scTarea = new ScTarea();
        public static ScHorario scHorario = new ScHorario();
        
        //Metodo para abrir y cerrar los paneles.
        public void openAndClose(Panel panel1, Form sc) {
            panel1.Controls.Clear();
            sc.TopLevel = false;
            sc.TopMost = true;
            panel1.Controls.Add(sc);
            sc.Show();
        }

        //Eventos click para abrir los paneles.
        private void lHome_Click(object sender, EventArgs e) {
            openAndClose(panel1, scStart);
        }

        private void lNotes_Click(object sender, EventArgs e) {
            openAndClose(panel1, scClasses);
        }

        private void pbInfo_Click(object sender, EventArgs e) {
            openAndClose(panel1, scInfo);
        }

        private void ScHome_Load(object sender, EventArgs e) {
            openAndClose(panel1,scStart);
        }

        private void lTareas_Click(object sender, EventArgs e) {
            openAndClose(panel1, scTarea);
        }

        private void lHorario_Click(object sender, EventArgs e) {
            openAndClose(panel1, scHorario);
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            openAndClose(panel1, scStart);
        }

        private void pbNota_Click(object sender, EventArgs e) {
            openAndClose(panel1, scClasses);
        }

        private void pbTarea_Click(object sender, EventArgs e) {
            openAndClose(panel1, scTarea);
        }

        private void pbHorario_Click(object sender, EventArgs e) {
            openAndClose(panel1, scHorario);
        }

        private void pbMaterial_Click(object sender, EventArgs e) {
            openAndClose(panel1,scTools);
        }

        private void lMaterial_Click(object sender, EventArgs e) {
            openAndClose(panel1,scTools);
        }
        //Fin Eventos click.

    }
}

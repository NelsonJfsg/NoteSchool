using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout.Herramientas;
using NoteSchool.Layout.Tools;

namespace NoteSchool.Layout {

    public partial class ScTools : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        
        //Constructor.
        public ScTools() {
            InitializeComponent();
        }

        //Evento click para abrir la calculadora.
        private void pbCalculator_Click(object sender, EventArgs e) {
            ScCalculator scCalculator = new ScCalculator();
            scCalculator.Show();
        }

        private void pbTemperatura_Click(object sender, EventArgs e) {
            ScGrados scGrados = new ScGrados();
            scGrados.Show();
        }

        private void pbMoneda_Click(object sender, EventArgs e) {
            ScMoneda scMoneda = new ScMoneda();
            scMoneda.Show();
        }

        private void pbMetros_Click(object sender, EventArgs e) {
            ScMetros scMetros = new ScMetros();
            scMetros.Show();
        }

        private void pbTiempo_Click(object sender, EventArgs e) {
            ScTiempo scTiempo = new ScTiempo();
            scTiempo.Show();
        }
    }
}

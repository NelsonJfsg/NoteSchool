using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Horario {
    public partial class ScHorario : Form {
        public ScHorario() {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            MessageBox.Show(this.Text);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
        }


        public void link(String materia, String hora, String link) {
            dataGridView1.CurrentCell.Value = materia;
            
            System.Diagnostics.Process.Start(link);
        }


        private void button1_Click(object sender, EventArgs e) {
            
            //Variables
            String materia;
            String hora;
            String link;

            ScRegistrarClase scRegistrarClase = new ScRegistrarClase();
            scRegistrarClase.Show();

        }
    }
}

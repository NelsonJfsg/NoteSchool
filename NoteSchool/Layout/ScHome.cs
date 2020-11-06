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

        private void label1_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            ScClasses f2 = new ScClasses();
            f2.TopLevel = false;
            f2.TopMost = true;
            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e) {
            
            panel1.Controls.Clear();
            ScTools scTools = new ScTools();

            scTools.TopLevel = false;
            scTools.TopMost = true;
            panel1.Controls.Add(scTools);
            scTools.Show();
        }

        private void label1_Click_1(object sender, EventArgs e) {
            panel1.Controls.Clear();
            ScStart scStart = new ScStart();
            
            scStart.TopLevel = false;
            scStart.TopMost = true;
            panel1.Controls.Add(scStart);
            scStart.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            
        }

        private void ScHome_Load(object sender, EventArgs e) {
            ScStart scStart = new ScStart();

            scStart.TopLevel = false;
            scStart.TopMost = true;
            panel1.Controls.Add(scStart);
            scStart.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            ScInfo scInfo = new ScInfo();
            
            scInfo.TopLevel = false;
            scInfo.TopMost = true;
            panel1.Controls.Add(scInfo);
            scInfo.Show();
        }
    }
}

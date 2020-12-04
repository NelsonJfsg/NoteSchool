using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout {

    public partial class ScLoad : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Reloj interno.
        Timer clock = new Timer();

        //Constructor del Layout.
        public ScLoad() {
            InitializeComponent();
        }

        //Declaracion del reloj interno para ScLoad.
        private void ScLoad_Load(object sender, EventArgs e) {
            clock.Interval = 2000;
            clock.Tick += Task;
            clock.Start();
        }        

        //Tarea para el reloj interno.
        private void Task(object sender, EventArgs e) {
            this.Visible = false;
            ScLogin scLogin = new ScLogin();
            scLogin.Show();
            clock.Stop();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout.Tools;

namespace NoteSchool.Layout {
    public partial class ScTools : Form {
        public ScTools() {
            InitializeComponent();
        }

        private void pbCalculator_Click(object sender, EventArgs e) {
            ScCalculator scCalculator = new ScCalculator();
            scCalculator.Show();
        }
    }
}

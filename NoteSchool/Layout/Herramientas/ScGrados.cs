using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Herramientas {

    public partial class ScGrados : Form {

        //Constructor.
        public ScGrados() {
            InitializeComponent();
        }

        //Variables
        String op;

        //Metodo para calcular Celsius a Farenheit.
        public static double cToF(double grados) {

            return (grados * (1.8)) + 32;

        }

        //Metodo para calcular Farenheit a Celsius.
        public static double fToC(double grados) {
            return (grados - 32) * 5/9;
        }

        //Evento click para realizar la conversion.
        private void butConvertir_Click(object sender, EventArgs e) {

            //Variables
            double gradees;

            //Verificamos el valor de los grados.
            try {

                gradees = Double.Parse(tbDegrees.Text); //Guardamos los grados.
                
                //Validar que opcion será realizada.
                foreach (RadioButton rb in gbDegrees.Controls) {

                    if (rb.Checked) {
                        op = rb.Text;    
                    }
                }

                //Operar.
                switch (op) {

                    case "Celsius a fahrenheit":
                    
                        tbResult.Text = cToF(gradees).ToString();
                        break;

                    case "Fahrenheit a celsius":

                        tbResult.Text = fToC(gradees).ToString();
                        break;

                }

            } catch (Exception err) {

                MessageBox.Show("Ingrese los grados a convertir.");
                
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Tools {
    public partial class ScCalculator : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor.
        public ScCalculator() {
            InitializeComponent();
        }

        //Variables
        Double p1;
        Double p2;
        String Op = null;

        //Evento click para insertar uno.
        private void but1_Click_1(object sender, EventArgs e) {
             tbResultado.Text = tbResultado.Text + but1.Text;
        }

        //Evento click para insertar dos.
        private void but2_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but2.Text;
        }

        //Evento click para insertar tres.
        private void but3_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but3.Text;
        }

        //Evento click para insertar cuatro.
        private void but4_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but4.Text;
        }

        //Evento click para insertar cinco.
        private void but5_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but5.Text;
        }

        //Evento click para insertar seis.
        private void but6_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but6.Text;
        }

        //Evento click para insertar siete.
        private void but7_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but7.Text;
        }

        //Evento click para insertar ocho.
        private void but8_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but8.Text;
        }

        //Evento click para insertar nueve.
        private void but9_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but9.Text;
        }

        //Evento click para insertar cero.
        private void but0_Click_1(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + but0.Text;
        }

        //Evento click para limpiar pantalla.
        private void butAC_Click_1(object sender, EventArgs e) {
            tbResultado.Text = "";
        }

        //Operacion.
        private void butMas_Click(object sender, EventArgs e) {
            p1 = Double.Parse(tbResultado.Text);
            Op = butMas.Text;
            lEstado.Text = "Sumando.";
            tbResultado.Text = "";
        }

        //Operacion.
        private void butMenos_Click(object sender, EventArgs e) {
            p1 = Double.Parse(tbResultado.Text);
            Op = butMenos.Text;
            lEstado.Text = "Restando.";
            tbResultado.Text = "";
        }

        //Operacion.
        private void butMult_Click(object sender, EventArgs e) {
            p1 = Double.Parse(tbResultado.Text);
            Op = butMult.Text;
            lEstado.Text = "Multiplicando.";
            tbResultado.Text = "";
        }

        //Operacion.
        private void butDiv_Click_1(object sender, EventArgs e) {
            p1 = Double.Parse(tbResultado.Text);
            Op = butDiv.Text;
            lEstado.Text = "Dividiendo.";
            tbResultado.Text = "";
        }

        //Verificamos la operacion.
        private void butCalcular_Click(object sender, EventArgs e) {

            //Verificamos que el valor dos sea numerico.
            try {
                p2 = Double.Parse(tbResultado.Text);
            } catch (Exception err) {
                MessageBox.Show("Operacion incompleta.");
            }

            //Realizamos la operacion.
            operacion(Op, p1, p2);
            
        }

        //Evento click para insertar punto.
        private void butDot_Click(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text + butDot.Text;
        }

        //Suma
        public Double suma(double p1, double p2) {
            return (p1 + p2);
        }

        //Division
        public Double div(double p1, double p2) {
            return (p1 / p2);
        }

        //Multiiplicacion
        public Double mult(double p1, double p2) {
            return (p1 * p2);
        }

        //Resta
        public Double resta(double p1, double p2) {
            return (p1 - p2);
        }

        //Metodop para ver que operacion se realizara.
        public void operacion(String Op, Double p1, Double p2) {

            //Variables de resultado
            Double Div;

            switch (Op) {
                case "+":
                    tbResultado.Text = suma(p1, p2).ToString();
                    break;
                case "-":
                    tbResultado.Text = resta(p1, p2).ToString();
                    break;
                case "*":
                    tbResultado.Text = mult(p1, p2).ToString();
                    break;
                case "/":
                    Div = div(p1, p2); ;
                    if (Div != 0) {
                        tbResultado.Text = Div.ToString();
                    } else {
                        MessageBox.Show("No se puede dividir entre 0.");
                    }

                    break;
            }

            lEstado.Text = "";
        }
        
    }
}

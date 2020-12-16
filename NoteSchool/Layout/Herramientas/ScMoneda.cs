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

    public partial class ScMoneda : Form {

        //Variables del dolar.
        Double dolar = 21.13;
        public Double cantidadTotal = 0;

        //Constructor.
        public ScMoneda() {
            InitializeComponent();
        }

        //Metodo para calcular la conversion de pesos a dolares.
        public void CalcularDivisaPtoD(Double cantidad) {
            cantidadTotal = cantidad / dolar;
        }

        //Metodo para calcular la conversion de dolares a pesos.
        public void CalcularDivisaDtoP(Double cantidad) {
           cantidadTotal = cantidad * dolar;
        }

        //Evento click para convertir la moneda.
        private void butConvertir_Click(object sender, EventArgs e) {
            
            //Variables
            String option = null;
            Double cantidad = 0;
            
            //Revisar que tipo de conversion será
            foreach (RadioButton rb in GroupBoxOption.Controls) {
                if (rb.Checked) {
                    option = rb.Text;
                }
            }
            
            //Recojer valores.
            try {
                
                cantidad = Double.Parse(TextBoxCantidad.Text);
            
                //Validar opcion.
                switch (option) {

                    case "Pesos a dolares.":
                        CalcularDivisaPtoD(cantidad);
                        TextBoxCambioTotal.Text = cantidadTotal.ToString();
                        break;

                    case "Dolares a pesos.":

                        CalcularDivisaDtoP(cantidad);
                        TextBoxCambioTotal.Text = cantidadTotal.ToString();
                        break;
                }

            } catch (Exception err) {

                MessageBox.Show("Ingresa la cantidad a convertir.");

            }
        }

    }    
}

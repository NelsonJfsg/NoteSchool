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

    public partial class ScMetros : Form {

        //Constructor.
        public ScMetros() {
            InitializeComponent();
        }

        //Variables
        double unidadNum1 = 0;
        double unidadResultado = 0;
        String rbUnidad1 = null;
        String rbUnidad2 = null;

        //Evento click para convertir las medidas.
        private void butConvertir_Click(object sender, EventArgs e) {

            try {
                
                //Variables
                unidadNum1 = Double.Parse(TbUnidad.Text);
                
                //Validar que RadioButton está seleccionado Gb1.
                foreach (RadioButton rb in Gb1.Controls) {
                    if (rb.Checked) {
                        rbUnidad1 = rb.Text;
                    }
                }
   
                //Validar que RadioButton está seleccionado Gb2.
                foreach (RadioButton rb in Gb2.Controls) {
                    if (rb.Checked) {
                        rbUnidad2 = rb.Text;
                    }
                }

                //Evaluar el caso.
                switch (rbUnidad1) {

                //Rb1 igual a milimetros
                case "Milimetros":

                    //Posibles combinaciones.
                    if (rbUnidad2 == "Centimetros"){
                        conversionDiv(unidadResultado, unidadNum1, TbResultado, 10);
                    }else{
                        if (rbUnidad2 == "Metros"){
                            conversionDiv(unidadResultado, unidadNum1, TbResultado, 1000);
                        }else {
                            if (rbUnidad2 == "Kilometros")
                            {
                                conversionDiv(unidadResultado, unidadNum1, TbResultado, 1000000);
                            }else{
                                if (rbUnidad2 == "Milimetros"){
                                    conversionDiv(unidadResultado, unidadNum1, TbResultado, 1);
                                }
                            }
                        }
                    }
                    break;

                //Rb1 igual a centimetro.
                case "Centimetros":

                    //Posibles combinaciones.
                    if (rbUnidad2 == "Centimetros"){
                        conversionDiv(unidadResultado, unidadNum1, TbResultado, 1);
                    }else{
                        if (rbUnidad2 == "Metros"){
                            conversionDiv(unidadResultado, unidadNum1, TbResultado, 100);
                        }else {
                            if (rbUnidad2 == "Kilometros")
                            {
                                conversionDiv(unidadResultado, unidadNum1, TbResultado, 100000);
                            }else{
                                if (rbUnidad2 == "Milimetros"){
                                    conversionMult(unidadResultado, unidadNum1, TbResultado, 10);
                                }
                            }
                        }
                    }

                    break;

                //Rb1 igual a metros.
                case "Metros":

                    //Posibles combinaciones.
                    if (rbUnidad2 == "Centimetros"){
                        conversionMult(unidadResultado, unidadNum1, TbResultado, 100);
                    }else{
                        if (rbUnidad2 == "Metros"){
                            conversionDiv(unidadResultado, unidadNum1, TbResultado, 1);
                        }else {
                            if (rbUnidad2 == "Kilometros")
                            {
                                conversionDiv(unidadResultado, unidadNum1, TbResultado, 1000);
                            }else{
                                if (rbUnidad2 == "Milimetros"){
                                    conversionMult(unidadResultado, unidadNum1, TbResultado, 1000);
                                }
                            }
                        }
                    }

                    break;
                
                //Rb1 igual a kilometros.
                case "Kilometros":

                    //Posibles combinaciones.
                    if (rbUnidad2 == "Centimetros"){
                        conversionMult(unidadResultado, unidadNum1, TbResultado, 100000);
                    }else{
                        if (rbUnidad2 == "Metros"){
                            conversionMult(unidadResultado, unidadNum1, TbResultado, 1000);
                        }else {
                            if (rbUnidad2 == "Kilometros"){
                                conversionDiv(unidadResultado, unidadNum1, TbResultado, 1);
                            }else{
                                if (rbUnidad2 == "Milimetros"){
                                    conversionMult(unidadResultado, unidadNum1, TbResultado, 1000000);
                                }
                            }
                        }
                    }

                    break;
            }//Fin del Switch

            }catch(Exception err){
                MessageBox.Show("Ingrese la medida a convertir.");
            }

        }

        //Metodo en caso de que la conversion sea dividiendo.
        public void conversionDiv(double unidadResultado, double unidadNum1,TextBox TbResultado, int relacion){
            unidadResultado = (unidadNum1 / relacion);
            TbResultado.Text = unidadResultado.ToString();
        }

        //Metodo en caso de que la conversion sea multiplicando.
        public void conversionMult(double unidadResultado, double unidadNum1,TextBox TbResultado, int relacion){
            unidadResultado = (unidadNum1 * relacion);
            TbResultado.Text = unidadResultado.ToString();
        }

    }
}

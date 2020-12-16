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

    public partial class ScTiempo : Form {

        //Constructor.
        public ScTiempo() {
            InitializeComponent();
        }

         //Variables
        double unidadNum1 = 0;
        double unidadResultado = 0;
        String rbUnidad1 = null;
        String rbUnidad2 = null;

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

        //Evento click para convertir.
        private void butConvertir_Click(object sender, EventArgs e) {

            try {

                //Variables
                unidadNum1 = Double.Parse(TbUnidad.Text);

                //Validar que RadioButton está seleccionado Gb1.
                foreach (RadioButton rb in Gb1.Controls){
                    if (rb.Checked){
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
                    case "Milisegundos":

                        //Posibles combinaciones.
                        if (rbUnidad2 == "Milisegundos"){
                            conversionMult(unidadResultado, unidadNum1, TbResultado, 1);
                        }else{
                            if (rbUnidad2 == "Segundos"){
                                conversionDiv(unidadResultado, unidadNum1, TbResultado, 1000);
                            }else {
                                if (rbUnidad2 == "Minutos")
                                {
                                    conversionDiv(unidadResultado, unidadNum1, TbResultado, 60000);
                                }else{
                                    if (rbUnidad2 == "Horas"){
                                        conversionDiv(unidadResultado, unidadNum1, TbResultado, 3600000);
                                    }
                                }
                            }
                        }
                        break;

                    //Rb1 igual a centimetro.
                    case "Segundos":

                        //Posibles combinaciones.
                        if (rbUnidad2 == "Milisegundos"){
                            conversionMult(unidadResultado, unidadNum1, TbResultado, 1000);
                        }else{
                            if (rbUnidad2 == "Segundos"){
                                conversionMult(unidadResultado, unidadNum1, TbResultado, 1);
                            }else {
                                if (rbUnidad2 == "Minutos")
                                {
                                    conversionDiv(unidadResultado, unidadNum1, TbResultado, 60);
                                }else{
                                    if (rbUnidad2 == "Horas"){
                                        conversionMult(unidadResultado, unidadNum1, TbResultado, 3600);
                                    }
                                }
                            }
                        }

                        break;

                    //Rb1 igual a metros.
                    case "Minutos":

                        //Posibles combinaciones.
                        if (rbUnidad2 == "Milisegundos"){
                            conversionMult(unidadResultado, unidadNum1, TbResultado, 60000);
                        }else{
                            if (rbUnidad2 == "Segundos"){
                                conversionMult(unidadResultado, unidadNum1, TbResultado, 60);
                            }else {
                                if (rbUnidad2 == "Minutos")
                                {
                                    conversionMult(unidadResultado, unidadNum1, TbResultado, 1);
                                }else{
                                    if (rbUnidad2 == "Horas"){
                                        conversionDiv(unidadResultado, unidadNum1, TbResultado, 60);
                                    }
                                }
                            }
                        }

                        break;
                
                    //Rb1 igual a kilometros.
                    case "Horas":

                        //Posibles combinaciones.
                        if (rbUnidad2 == "Milisegundos"){
                            conversionMult(unidadResultado, unidadNum1, TbResultado, 3600000);
                        }else{
                            if (rbUnidad2 == "Segundos"){
                                conversionMult(unidadResultado, unidadNum1, TbResultado, 3600);
                            }else {
                                if (rbUnidad2 == "Minutos"){
                                    conversionMult(unidadResultado, unidadNum1, TbResultado, 60);
                                }else{
                                    if (rbUnidad2 == "Horas"){
                                        conversionMult(unidadResultado, unidadNum1, TbResultado, 1);
                                    }
                                }
                            }
                        }

                        break;
                } //Fin del Switch

            } catch (Exception err) {
                MessageBox.Show("Ingrese el tiempo a convertir.");
            }

        }

    }
}

using MySql.Data.MySqlClient;
using NoteSchool.DataBase;
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

    public partial class ScSignIn : Form {

        //Variables globales.
        String userText = "Nombre de usuario";
        String passwordText = "Contraseña";

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get{
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public ScSignIn() {
            InitializeComponent();
        }

        //Guardar el usuario en la base de datos.
        private void butSignIn_Click(object sender, EventArgs e) {

            //Objetos
            Usuario usario = new Usuario();
            ScLogin scLogin = new ScLogin();

            //Guardar usuario en la base de datos.
            usario.validarUsuarioExistente(this, scLogin, tbUserName, tbPassword);
            
        }

        //Regresar a el login.
        private void pbPreviuos_Click(object sender, EventArgs e) {
            ScLogin scLogin = new ScLogin();
            scLogin.Show();
            this.Visible = false;
        }

        //Reiniciar el tbUserName.
        private void tbUserName_Leave(object sender, EventArgs e) {
            reinicarTexto(tbUserName, userText);
        }
        
        //Reiniciar el tbPassword.
        private void tbPassword_Leave(object sender, EventArgs e) {
            reinicarTexto(tbPassword, passwordText);
        }

        //Cambiar el control a resaltar.
        private void ScSignIn_Load(object sender, EventArgs e) {
            this.ActiveControl = lTittle;
        }

        //Limpiar textBox user.
        private void tbUserName_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbUserName, userText);
        }

        //Reiniciar tbPassword.
        private void tbPassword_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbPassword, passwordText);
        }
    
        //Metodo para reinicar los textos por defecto.
        public void reinicarTexto(TextBox tb, String text) {

            //Verificamos que el TB esté vacio.
            if(tb.Text == ""){
                
                tb.ForeColor = (Color.Gray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.
            
            }

        }

        //Metodo para cambiar el color y limpiar el TB.
        public void cambiarColorTexto(TextBox tb, String text) {

            //Verificamos que los textos sean iguales.
            if (tb.Text == text) {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.
            
            }

        }

        //Evento para conocer la tecla presionada.
        private void tbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbPassword, passwordText);
            }

        }

        //Evento para conocer la tecla presionada.
        private void lTittle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText);
            }

        }

        //Evento para conocer la tecla presionada.
        private void butSignIn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText);
            }

        }

        //Verificamos si se presiona el enter.
        private void tbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            if (e.KeyData == Keys.Enter) {
                //Objetos
                Usuario usario = new Usuario();
                ScLogin scLogin = new ScLogin();

                //Guardar usuario en la base de datos.
                usario.validarUsuarioExistente(this, scLogin, tbUserName, tbPassword);
            
                tbPassword.Text = "";
            }

        }
    }
}

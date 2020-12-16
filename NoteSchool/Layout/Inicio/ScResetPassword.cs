using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.DataBase;

namespace NoteSchool.Layout.Inicio {
    public partial class ScResetPassword : Form {

        //Variables globales.
        String userText = "Nombre de usuario";
        String passwordText = "Nueva contraseña";

        //Objetos
        Usuario usuario = new Usuario();

        //Constructor.
        public ScResetPassword() {
            InitializeComponent();
        }

        //Metodo para reinicar los textos por defecto.
        public void reinicarTexto(TextBox tb, String text) {

            //Verificamos que el TB esté vacio.
            if(tb.Text == ""){
                tb.PasswordChar = '\0';
                tb.ForeColor = (Color.DarkGray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.
            
            }

        }

        //Metodo para cambiar el color y limpiar el TB.
        public void cambiarColorTexto(TextBox tb, String text) {

            //Verificamos que los textos sean iguales.
            if (tb.Text == text) {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.

                if (text == passwordText) {
                    tb.PasswordChar = '·'; 
                }
            }

        }


        //Eventos para el TB de contraseña.

        //Evento click para cambiar el color y limpiar el TB
        private void tbPassword_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbPassword, passwordText);   
        }

        //Evento leave para resetear los valores del TB.
        private void tbPassword_Leave(object sender, EventArgs e) {
            reinicarTexto(tbPassword, passwordText);
        }

        /////////////////////////////////////////////////////////////

        private void tbUserName_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbUserName, userText);
        }

        private void tbUserName_Leave(object sender, EventArgs e) {
            reinicarTexto(tbUserName, userText);
        }

        private void tbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            
            //Verificamos si se preciono la tecla TAB.
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbPassword, passwordText); 
            }
        }

        private void lTittle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            //Verificamos si se preciono la tecla TAB.
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText); 
            }
        }

        private void butSignIn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            //Verificamos si se preciono la tecla TAB.
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText); 
            }
        }

        private void pbPreviuos_Click(object sender, EventArgs e) {
            ScLogin scLogin = new ScLogin();
            this.Dispose();
            scLogin.Show();
        }

        private void ScResetPassword_Load(object sender, EventArgs e) {
            this.ActiveControl = lTittle;
        }

        private void butSignIn_Click(object sender, EventArgs e) {

            ScLogin scLogin = new ScLogin();
            usuario.validarUsuarioExistenteContraseña(this, scLogin, tbUserName, tbPassword);
        }

        //Verificamos que el enter se haya presionado.
        private void tbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                ScLogin scLogin = new ScLogin();
                usuario.validarUsuarioExistenteContraseña(this, scLogin, tbUserName, tbPassword);
                tbPassword.Text = "";
            }
        }
    }
}

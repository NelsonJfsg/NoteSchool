using MySql.Data.MySqlClient;
using NoteSchool.DataBase;
using NoteSchool.Layout.Inicio;
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

    public partial class ScLogin : Form {

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
        
        //Constructor.
        public ScLogin() {
            InitializeComponent();
            
        }

        //Cerrar aplicacion.
        private void pbExit_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        //Limpiar textBox usuario
        private void tbUserName_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbUserName, userText);
        }

        //Reiniciar el tbUserName.
        private void tbUserName_Leave(object sender, EventArgs e) {

            reinicarTexto(tbUserName, userText);

        }
        
        //Limpiar textBox password.
        private void tbPassword_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbPassword, passwordText);
        }

        //Reiniciar el tbPassword.
        private void tbPassword_Leave(object sender, EventArgs e) {
            reinicarTexto(tbPassword, passwordText);
        }

        //Verificar usuario y contraseña.
        private void butLogin_Click(object sender, EventArgs e) {

            //Objetos
            Usuario usuario = new Usuario();
            ScHome scHome = new ScHome();
            
            //Metodo para validar la contraseña y el usuario.
            usuario.validarUsuario(this, scHome, tbUserName, tbPassword);

        }

        //Abrir menu para registrarse.
        private void pbSingIn_Click(object sender, EventArgs e) {

            ScSignIn scSignIn = new ScSignIn();
            scSignIn.Show();
            this.Visible = false;
        
        }

        //Cambiar el control a resaltar.
        private void ScLogin_Load(object sender, EventArgs e) {
            this.ActiveControl = lTittle;
        }

        //Verificamos que la tecla TAB sea presionada.
        private void tbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            
            //Verificamos si se preciono la tecla TAB.
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbPassword, passwordText); 
            }

        }
        
        //Verificamos que la tecla TAB sea presionada.
        private void lTittle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            //Verificamos si se preciono la tecla TAB.
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText);
            }

        }

        //Metodo para reinicar los textos por defecto.
        public void reinicarTexto(TextBox tb, String text) {

            //Verificamos que el TB esté vacio.
            if(tb.Text == ""){
                
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
            
            }

        }

        //Verificamos que la tecla TAB sea presionada.
        private void butLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbUserName, userText);
            }
        }

        //Evento click para reiniciar la contraseña.
        private void lReinicarContraseña_Click(object sender, EventArgs e) {
            
            ScResetPassword scResetPassword = new ScResetPassword();
            scResetPassword.Show();
            this.Visible = false;
        }

        //Verificamos que se haya presionado el enter.
        private void tbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            if (e.KeyData == Keys.Enter) {
                //Objetos
                Usuario usuario = new Usuario();
                ScHome scHome = new ScHome();
            
                //Metodo para validar la contraseña y el usuario.
                usuario.validarUsuario(this, scHome, tbUserName, tbPassword);
                tbPassword.Text = "";
            }

        }
    } 
}

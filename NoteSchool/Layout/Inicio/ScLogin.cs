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
            if (tbUserName.Text == userText) {
                tbUserName.Text = ("");
                tbUserName.ForeColor = Color.White;
            }
        }

        //Reiniciar el tbUserName.
        private void tbUserName_Leave(object sender, EventArgs e) {

            if(tbUserName.Text == ""){
                tbUserName.ForeColor = (Color.Gray);
                tbUserName.Text = (userText);
            }
        }
        
        //Limpiar textBox password.
        private void tbPassword_Click(object sender, EventArgs e) {
            if (tbPassword.Text == passwordText) {
                tbPassword.Text = ("");
                tbPassword.ForeColor = Color.White;
            }
        }

        //Reiniciar el tbPassword.
        private void tbPassword_Leave(object sender, EventArgs e) {
            if(tbPassword.Text == ""){
                tbPassword.ForeColor = (Color.Gray);
                tbPassword.Text = (passwordText);
            }
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
    
    }
}

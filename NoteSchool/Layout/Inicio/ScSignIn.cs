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
            if(tbUserName.Text == ""){
                tbUserName.ForeColor = (Color.Gray);
                tbUserName.Text = (userText);
            }
        }
        
        //Reiniciar el tbPassword.
        private void tbPassword_Leave(object sender, EventArgs e) {
            if(tbPassword.Text == ""){
                tbPassword.ForeColor = (Color.Gray);
                tbPassword.Text = (passwordText);
            }
        }

        //Cambiar el control a resaltar.
        private void ScSignIn_Load(object sender, EventArgs e) {
            this.ActiveControl = lTittle;
        }

        //Limpiar textBox user.
        private void tbUserName_Click(object sender, EventArgs e) {
            if (tbUserName.Text == userText) {
                tbUserName.Text = ("");
                tbUserName.ForeColor = Color.White;
            }
        }

        //Reiniciar tbPassword.
        private void tbPassword_Click(object sender, EventArgs e) {
            if (tbPassword.Text == passwordText) {
                tbPassword.Text = ("");
                tbPassword.ForeColor = Color.White;
            }
        }
    
    }
}

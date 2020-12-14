namespace NoteSchool.Layout {
    partial class ScLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScLogin));
            this.lTittle = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.pbSignIn = new System.Windows.Forms.PictureBox();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pbTittle = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lReinicarContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTittle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTittle.ForeColor = System.Drawing.Color.White;
            this.lTittle.Location = new System.Drawing.Point(68, 95);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(248, 25);
            this.lTittle.TabIndex = 1;
            this.lTittle.Text = "¡Bienvendio a NoteSchool!";
            this.lTittle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lTittle_PreviewKeyDown);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.Location = new System.Drawing.Point(73, 312);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(243, 29);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.Text = "Nombre de usuario";
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserName.Click += new System.EventHandler(this.tbUserName_Click);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            this.tbUserName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbUserName_PreviewKeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(73, 347);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '·';
            this.tbPassword.Size = new System.Drawing.Size(243, 29);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // butLogin
            // 
            this.butLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(116, 397);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(161, 27);
            this.butLogin.TabIndex = 5;
            this.butLogin.Text = "Entrar";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            this.butLogin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.butLogin_PreviewKeyDown);
            // 
            // pbSignIn
            // 
            this.pbSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSignIn.Image = ((System.Drawing.Image)(resources.GetObject("pbSignIn.Image")));
            this.pbSignIn.Location = new System.Drawing.Point(336, 415);
            this.pbSignIn.Name = "pbSignIn";
            this.pbSignIn.Size = new System.Drawing.Size(36, 34);
            this.pbSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSignIn.TabIndex = 9;
            this.pbSignIn.TabStop = false;
            this.pbSignIn.Click += new System.EventHandler(this.pbSingIn_Click);
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = global::NoteSchool.Properties.Resources.UserImage;
            this.pbUserIcon.Location = new System.Drawing.Point(92, 136);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(205, 161);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserIcon.TabIndex = 8;
            this.pbUserIcon.TabStop = false;
            // 
            // pbTittle
            // 
            this.pbTittle.Image = global::NoteSchool.Properties.Resources.NoteSchool_logo;
            this.pbTittle.Location = new System.Drawing.Point(97, 12);
            this.pbTittle.Name = "pbTittle";
            this.pbTittle.Size = new System.Drawing.Size(200, 50);
            this.pbTittle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTittle.TabIndex = 10;
            this.pbTittle.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(336, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(36, 34);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // lReinicarContraseña
            // 
            this.lReinicarContraseña.AutoSize = true;
            this.lReinicarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lReinicarContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReinicarContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.lReinicarContraseña.Location = new System.Drawing.Point(118, 427);
            this.lReinicarContraseña.Name = "lReinicarContraseña";
            this.lReinicarContraseña.Size = new System.Drawing.Size(157, 17);
            this.lReinicarContraseña.TabIndex = 11;
            this.lReinicarContraseña.Text = "¿Olvidaste tu contraseña?";
            this.lReinicarContraseña.Click += new System.EventHandler(this.lReinicarContraseña_Click);
            // 
            // ScLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lReinicarContraseña);
            this.Controls.Add(this.pbSignIn);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.pbTittle);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lTittle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScLogin";
            this.Load += new System.EventHandler(this.ScLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTittle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTittle;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbTittle;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.PictureBox pbSignIn;
        private System.Windows.Forms.Label lReinicarContraseña;
    }
}
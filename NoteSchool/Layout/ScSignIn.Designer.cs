namespace NoteSchool.Layout {
    partial class ScSignIn {
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
            this.pbPreviuos = new System.Windows.Forms.PictureBox();
            this.pbTittle = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.butSignIn = new System.Windows.Forms.Button();
            this.lTittle = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviuos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTittle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPreviuos
            // 
            this.pbPreviuos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPreviuos.Image = global::NoteSchool.Properties.Resources.Previous;
            this.pbPreviuos.Location = new System.Drawing.Point(336, 12);
            this.pbPreviuos.Name = "pbPreviuos";
            this.pbPreviuos.Size = new System.Drawing.Size(36, 34);
            this.pbPreviuos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreviuos.TabIndex = 10;
            this.pbPreviuos.TabStop = false;
            this.pbPreviuos.Click += new System.EventHandler(this.pbPreviuos_Click);
            // 
            // pbTittle
            // 
            this.pbTittle.Image = global::NoteSchool.Properties.Resources.NoteSchool_logo;
            this.pbTittle.Location = new System.Drawing.Point(97, 12);
            this.pbTittle.Name = "pbTittle";
            this.pbTittle.Size = new System.Drawing.Size(200, 50);
            this.pbTittle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTittle.TabIndex = 11;
            this.pbTittle.TabStop = false;
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
            this.tbUserName.TabIndex = 12;
            this.tbUserName.Text = "Nombre de usuario";
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserName.Click += new System.EventHandler(this.tbUserName_Click);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
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
            this.tbPassword.TabIndex = 13;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // butSignIn
            // 
            this.butSignIn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSignIn.ForeColor = System.Drawing.Color.White;
            this.butSignIn.Location = new System.Drawing.Point(116, 397);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(161, 27);
            this.butSignIn.TabIndex = 14;
            this.butSignIn.Text = "Registrar";
            this.butSignIn.UseVisualStyleBackColor = false;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTittle.ForeColor = System.Drawing.Color.White;
            this.lTittle.Location = new System.Drawing.Point(68, 95);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(277, 25);
            this.lTittle.TabIndex = 15;
            this.lTittle.Text = "Crea tu cuenta de NoteSchool";
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = global::NoteSchool.Properties.Resources.UserImage;
            this.pbUserIcon.Location = new System.Drawing.Point(92, 136);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(205, 161);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserIcon.TabIndex = 16;
            this.pbUserIcon.TabStop = false;
            // 
            // ScSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.lTittle);
            this.Controls.Add(this.butSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.pbTittle);
            this.Controls.Add(this.pbPreviuos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingIn";
            this.Load += new System.EventHandler(this.ScSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviuos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTittle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPreviuos;
        private System.Windows.Forms.PictureBox pbTittle;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button butSignIn;
        private System.Windows.Forms.Label lTittle;
        private System.Windows.Forms.PictureBox pbUserIcon;
    }
}
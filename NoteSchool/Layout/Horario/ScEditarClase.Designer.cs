﻿
namespace NoteSchool.Layout.Horario {
    partial class ScEditarClase {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScEditarClase));
            this.butEditarClase = new System.Windows.Forms.Button();
            this.lDia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butEditarClase
            // 
            this.butEditarClase.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butEditarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEditarClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEditarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEditarClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditarClase.ForeColor = System.Drawing.Color.White;
            this.butEditarClase.Location = new System.Drawing.Point(104, 369);
            this.butEditarClase.Name = "butEditarClase";
            this.butEditarClase.Size = new System.Drawing.Size(161, 27);
            this.butEditarClase.TabIndex = 17;
            this.butEditarClase.Text = "Editar clase";
            this.butEditarClase.UseVisualStyleBackColor = false;
            this.butEditarClase.Click += new System.EventHandler(this.butEditarClase_Click);
            // 
            // lDia
            // 
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(195, 89);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(60, 37);
            this.lDia.TabIndex = 25;
            this.lDia.Text = "Dia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.Calendar;
            this.pictureBox1.Location = new System.Drawing.Point(28, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(177, 318);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(174, 20);
            this.tbLink.TabIndex = 23;
            this.tbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(177, 263);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(174, 20);
            this.tbHora.TabIndex = 22;
            this.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Link de la clase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hora: ";
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(177, 204);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Size = new System.Drawing.Size(174, 20);
            this.tbMateria.TabIndex = 19;
            this.tbMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de la clase: ";
            // 
            // ScEditarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(368, 422);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butEditarClase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScEditarClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edita tu clase";
            this.Load += new System.EventHandler(this.ScEditarClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butEditarClase;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMateria;
        private System.Windows.Forms.Label label2;
    }
}

namespace NoteSchool.Layout.Horario {
    partial class ScRegistrarClase {
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
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(190, 79);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Size = new System.Drawing.Size(100, 20);
            this.tbMateria.TabIndex = 0;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(190, 121);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(100, 20);
            this.tbHora.TabIndex = 1;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(190, 167);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(100, 20);
            this.tbLink.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar clase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScRegistrarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.tbMateria);
            this.Name = "ScRegistrarClase";
            this.Text = "ScRegistrarClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMateria;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button button1;
    }
}

namespace NoteSchool.Layout.Notas {
    partial class ScNotas {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtCuerpo = new System.Windows.Forms.RichTextBox();
            this.butGuardarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbTitulo.ForeColor = System.Drawing.Color.White;
            this.tbTitulo.Location = new System.Drawing.Point(78, 13);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(255, 20);
            this.tbTitulo.TabIndex = 2;
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbFecha.ForeColor = System.Drawing.Color.White;
            this.tbFecha.Location = new System.Drawing.Point(403, 13);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(255, 20);
            this.tbFecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desarrollo:";
            // 
            // rtCuerpo
            // 
            this.rtCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rtCuerpo.ForeColor = System.Drawing.Color.White;
            this.rtCuerpo.Location = new System.Drawing.Point(16, 88);
            this.rtCuerpo.Name = "rtCuerpo";
            this.rtCuerpo.Size = new System.Drawing.Size(772, 294);
            this.rtCuerpo.TabIndex = 5;
            this.rtCuerpo.Text = "";
            // 
            // butGuardarNota
            // 
            this.butGuardarNota.Location = new System.Drawing.Point(710, 404);
            this.butGuardarNota.Name = "butGuardarNota";
            this.butGuardarNota.Size = new System.Drawing.Size(78, 23);
            this.butGuardarNota.TabIndex = 6;
            this.butGuardarNota.Text = "Guardar nota";
            this.butGuardarNota.UseVisualStyleBackColor = true;
            this.butGuardarNota.Click += new System.EventHandler(this.butGuardarNota_Click);
            // 
            // ScNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butGuardarNota);
            this.Controls.Add(this.rtCuerpo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScNotas";
            this.Text = "ScNotas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScNotas_FormClosing);
            this.Load += new System.EventHandler(this.ScNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtCuerpo;
        private System.Windows.Forms.Button butGuardarNota;
    }
}

namespace NoteSchool.Layout.Herramientas {
    partial class ScTiempo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScTiempo));
            this.butConvertir = new System.Windows.Forms.Button();
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gb2 = new System.Windows.Forms.GroupBox();
            this.rbHoras2 = new System.Windows.Forms.RadioButton();
            this.rbMinutos2 = new System.Windows.Forms.RadioButton();
            this.rbSegundos2 = new System.Windows.Forms.RadioButton();
            this.rbMilisegundos2 = new System.Windows.Forms.RadioButton();
            this.TbUnidad = new System.Windows.Forms.TextBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubTitulo = new System.Windows.Forms.Label();
            this.Gb1 = new System.Windows.Forms.GroupBox();
            this.rbHoras1 = new System.Windows.Forms.RadioButton();
            this.rbMinutos1 = new System.Windows.Forms.RadioButton();
            this.rbSegundos1 = new System.Windows.Forms.RadioButton();
            this.rbMilisegundos1 = new System.Windows.Forms.RadioButton();
            this.Gb2.SuspendLayout();
            this.Gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butConvertir
            // 
            this.butConvertir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConvertir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConvertir.ForeColor = System.Drawing.Color.White;
            this.butConvertir.Location = new System.Drawing.Point(207, 133);
            this.butConvertir.Name = "butConvertir";
            this.butConvertir.Size = new System.Drawing.Size(83, 27);
            this.butConvertir.TabIndex = 33;
            this.butConvertir.Text = "Convertir";
            this.butConvertir.UseVisualStyleBackColor = false;
            this.butConvertir.Click += new System.EventHandler(this.butConvertir_Click);
            // 
            // TbResultado
            // 
            this.TbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TbResultado.ForeColor = System.Drawing.Color.White;
            this.TbResultado.Location = new System.Drawing.Point(382, 194);
            this.TbResultado.Multiline = true;
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.ReadOnly = true;
            this.TbResultado.Size = new System.Drawing.Size(97, 24);
            this.TbResultado.TabIndex = 32;
            this.TbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "-->";
            // 
            // Gb2
            // 
            this.Gb2.Controls.Add(this.rbHoras2);
            this.Gb2.Controls.Add(this.rbMinutos2);
            this.Gb2.Controls.Add(this.rbSegundos2);
            this.Gb2.Controls.Add(this.rbMilisegundos2);
            this.Gb2.ForeColor = System.Drawing.Color.White;
            this.Gb2.Location = new System.Drawing.Point(296, 67);
            this.Gb2.Name = "Gb2";
            this.Gb2.Size = new System.Drawing.Size(183, 121);
            this.Gb2.TabIndex = 26;
            this.Gb2.TabStop = false;
            this.Gb2.Text = "Unidad de tiempo";
            // 
            // rbHoras2
            // 
            this.rbHoras2.AutoSize = true;
            this.rbHoras2.Location = new System.Drawing.Point(7, 89);
            this.rbHoras2.Name = "rbHoras2";
            this.rbHoras2.Size = new System.Drawing.Size(53, 17);
            this.rbHoras2.TabIndex = 3;
            this.rbHoras2.TabStop = true;
            this.rbHoras2.Text = "Horas";
            this.rbHoras2.UseVisualStyleBackColor = true;
            // 
            // rbMinutos2
            // 
            this.rbMinutos2.AutoSize = true;
            this.rbMinutos2.Location = new System.Drawing.Point(7, 66);
            this.rbMinutos2.Name = "rbMinutos2";
            this.rbMinutos2.Size = new System.Drawing.Size(62, 17);
            this.rbMinutos2.TabIndex = 2;
            this.rbMinutos2.TabStop = true;
            this.rbMinutos2.Text = "Minutos";
            this.rbMinutos2.UseVisualStyleBackColor = true;
            // 
            // rbSegundos2
            // 
            this.rbSegundos2.AutoSize = true;
            this.rbSegundos2.Location = new System.Drawing.Point(7, 43);
            this.rbSegundos2.Name = "rbSegundos2";
            this.rbSegundos2.Size = new System.Drawing.Size(73, 17);
            this.rbSegundos2.TabIndex = 1;
            this.rbSegundos2.TabStop = true;
            this.rbSegundos2.Text = "Segundos";
            this.rbSegundos2.UseVisualStyleBackColor = true;
            // 
            // rbMilisegundos2
            // 
            this.rbMilisegundos2.AutoSize = true;
            this.rbMilisegundos2.Location = new System.Drawing.Point(7, 20);
            this.rbMilisegundos2.Name = "rbMilisegundos2";
            this.rbMilisegundos2.Size = new System.Drawing.Size(86, 17);
            this.rbMilisegundos2.TabIndex = 0;
            this.rbMilisegundos2.TabStop = true;
            this.rbMilisegundos2.Text = "Milisegundos";
            this.rbMilisegundos2.UseVisualStyleBackColor = true;
            // 
            // TbUnidad
            // 
            this.TbUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TbUnidad.ForeColor = System.Drawing.Color.White;
            this.TbUnidad.Location = new System.Drawing.Point(86, 194);
            this.TbUnidad.Multiline = true;
            this.TbUnidad.Name = "TbUnidad";
            this.TbUnidad.Size = new System.Drawing.Size(115, 24);
            this.TbUnidad.TabIndex = 28;
            this.TbUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(97, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(328, 30);
            this.LTitulo.TabIndex = 27;
            this.LTitulo.Text = "Cambio de unidades temporales";
            // 
            // LSubTitulo
            // 
            this.LSubTitulo.AutoSize = true;
            this.LSubTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubTitulo.ForeColor = System.Drawing.Color.White;
            this.LSubTitulo.Location = new System.Drawing.Point(161, 39);
            this.LSubTitulo.Name = "LSubTitulo";
            this.LSubTitulo.Size = new System.Drawing.Size(171, 25);
            this.LSubTitulo.TabIndex = 25;
            this.LSubTitulo.Text = "Unidad a convertir";
            // 
            // Gb1
            // 
            this.Gb1.Controls.Add(this.rbHoras1);
            this.Gb1.Controls.Add(this.rbMinutos1);
            this.Gb1.Controls.Add(this.rbSegundos1);
            this.Gb1.Controls.Add(this.rbMilisegundos1);
            this.Gb1.ForeColor = System.Drawing.Color.White;
            this.Gb1.Location = new System.Drawing.Point(18, 67);
            this.Gb1.Name = "Gb1";
            this.Gb1.Size = new System.Drawing.Size(183, 121);
            this.Gb1.TabIndex = 24;
            this.Gb1.TabStop = false;
            this.Gb1.Text = "Unidad de tiempo";
            // 
            // rbHoras1
            // 
            this.rbHoras1.AutoSize = true;
            this.rbHoras1.Location = new System.Drawing.Point(7, 89);
            this.rbHoras1.Name = "rbHoras1";
            this.rbHoras1.Size = new System.Drawing.Size(53, 17);
            this.rbHoras1.TabIndex = 3;
            this.rbHoras1.TabStop = true;
            this.rbHoras1.Text = "Horas";
            this.rbHoras1.UseVisualStyleBackColor = true;
            // 
            // rbMinutos1
            // 
            this.rbMinutos1.AutoSize = true;
            this.rbMinutos1.Location = new System.Drawing.Point(7, 66);
            this.rbMinutos1.Name = "rbMinutos1";
            this.rbMinutos1.Size = new System.Drawing.Size(62, 17);
            this.rbMinutos1.TabIndex = 2;
            this.rbMinutos1.TabStop = true;
            this.rbMinutos1.Text = "Minutos";
            this.rbMinutos1.UseVisualStyleBackColor = true;
            // 
            // rbSegundos1
            // 
            this.rbSegundos1.AutoSize = true;
            this.rbSegundos1.Location = new System.Drawing.Point(7, 43);
            this.rbSegundos1.Name = "rbSegundos1";
            this.rbSegundos1.Size = new System.Drawing.Size(73, 17);
            this.rbSegundos1.TabIndex = 1;
            this.rbSegundos1.TabStop = true;
            this.rbSegundos1.Text = "Segundos";
            this.rbSegundos1.UseVisualStyleBackColor = true;
            // 
            // rbMilisegundos1
            // 
            this.rbMilisegundos1.AutoSize = true;
            this.rbMilisegundos1.Location = new System.Drawing.Point(7, 20);
            this.rbMilisegundos1.Name = "rbMilisegundos1";
            this.rbMilisegundos1.Size = new System.Drawing.Size(86, 17);
            this.rbMilisegundos1.TabIndex = 0;
            this.rbMilisegundos1.TabStop = true;
            this.rbMilisegundos1.Text = "Milisegundos";
            this.rbMilisegundos1.UseVisualStyleBackColor = true;
            // 
            // ScTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(500, 252);
            this.Controls.Add(this.butConvertir);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gb2);
            this.Controls.Add(this.TbUnidad);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.LSubTitulo);
            this.Controls.Add(this.Gb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScTiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de tiempo";
            this.Gb2.ResumeLayout(false);
            this.Gb2.PerformLayout();
            this.Gb1.ResumeLayout(false);
            this.Gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConvertir;
        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gb2;
        private System.Windows.Forms.RadioButton rbHoras2;
        private System.Windows.Forms.RadioButton rbMinutos2;
        private System.Windows.Forms.RadioButton rbSegundos2;
        private System.Windows.Forms.RadioButton rbMilisegundos2;
        private System.Windows.Forms.TextBox TbUnidad;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubTitulo;
        private System.Windows.Forms.GroupBox Gb1;
        private System.Windows.Forms.RadioButton rbHoras1;
        private System.Windows.Forms.RadioButton rbMinutos1;
        private System.Windows.Forms.RadioButton rbSegundos1;
        private System.Windows.Forms.RadioButton rbMilisegundos1;
    }
}
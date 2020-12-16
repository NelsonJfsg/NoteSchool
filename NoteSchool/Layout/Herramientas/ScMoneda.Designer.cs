
namespace NoteSchool.Layout.Herramientas {
    partial class ScMoneda {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScMoneda));
            this.GroupBoxOption = new System.Windows.Forms.GroupBox();
            this.RbDtoP = new System.Windows.Forms.RadioButton();
            this.RbPtoD = new System.Windows.Forms.RadioButton();
            this.LabelDolares = new System.Windows.Forms.Label();
            this.TextBoxCambioTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPesos = new System.Windows.Forms.Label();
            this.TextBoxCantidad = new System.Windows.Forms.TextBox();
            this.butConvertir = new System.Windows.Forms.Button();
            this.GroupBoxOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxOption
            // 
            this.GroupBoxOption.Controls.Add(this.RbDtoP);
            this.GroupBoxOption.Controls.Add(this.RbPtoD);
            this.GroupBoxOption.ForeColor = System.Drawing.Color.White;
            this.GroupBoxOption.Location = new System.Drawing.Point(268, 25);
            this.GroupBoxOption.Name = "GroupBoxOption";
            this.GroupBoxOption.Size = new System.Drawing.Size(200, 65);
            this.GroupBoxOption.TabIndex = 12;
            this.GroupBoxOption.TabStop = false;
            this.GroupBoxOption.Text = "Orden de conversion";
            // 
            // RbDtoP
            // 
            this.RbDtoP.AutoSize = true;
            this.RbDtoP.Location = new System.Drawing.Point(7, 43);
            this.RbDtoP.Name = "RbDtoP";
            this.RbDtoP.Size = new System.Drawing.Size(104, 17);
            this.RbDtoP.TabIndex = 1;
            this.RbDtoP.Text = "Dolares a pesos.";
            this.RbDtoP.UseVisualStyleBackColor = true;
            // 
            // RbPtoD
            // 
            this.RbPtoD.AutoSize = true;
            this.RbPtoD.Checked = true;
            this.RbPtoD.Location = new System.Drawing.Point(7, 20);
            this.RbPtoD.Name = "RbPtoD";
            this.RbPtoD.Size = new System.Drawing.Size(103, 17);
            this.RbPtoD.TabIndex = 0;
            this.RbPtoD.TabStop = true;
            this.RbPtoD.Text = "Pesos a dolares.";
            this.RbPtoD.UseVisualStyleBackColor = true;
            // 
            // LabelDolares
            // 
            this.LabelDolares.AutoSize = true;
            this.LabelDolares.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDolares.ForeColor = System.Drawing.Color.White;
            this.LabelDolares.Location = new System.Drawing.Point(8, 73);
            this.LabelDolares.Name = "LabelDolares";
            this.LabelDolares.Size = new System.Drawing.Size(89, 17);
            this.LabelDolares.TabIndex = 11;
            this.LabelDolares.Text = "Cambio total:";
            // 
            // TextBoxCambioTotal
            // 
            this.TextBoxCambioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TextBoxCambioTotal.ForeColor = System.Drawing.Color.White;
            this.TextBoxCambioTotal.Location = new System.Drawing.Point(103, 70);
            this.TextBoxCambioTotal.Name = "TextBoxCambioTotal";
            this.TextBoxCambioTotal.ReadOnly = true;
            this.TextBoxCambioTotal.Size = new System.Drawing.Size(157, 20);
            this.TextBoxCambioTotal.TabIndex = 10;
            this.TextBoxCambioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dolar: 21.13$";
            // 
            // LabelPesos
            // 
            this.LabelPesos.AutoSize = true;
            this.LabelPesos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPesos.ForeColor = System.Drawing.Color.White;
            this.LabelPesos.Location = new System.Drawing.Point(8, 39);
            this.LabelPesos.Name = "LabelPesos";
            this.LabelPesos.Size = new System.Drawing.Size(65, 17);
            this.LabelPesos.TabIndex = 8;
            this.LabelPesos.Text = "Cantidad:";
            // 
            // TextBoxCantidad
            // 
            this.TextBoxCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TextBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.TextBoxCantidad.Location = new System.Drawing.Point(79, 36);
            this.TextBoxCantidad.Name = "TextBoxCantidad";
            this.TextBoxCantidad.Size = new System.Drawing.Size(181, 20);
            this.TextBoxCantidad.TabIndex = 7;
            this.TextBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butConvertir
            // 
            this.butConvertir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConvertir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConvertir.ForeColor = System.Drawing.Color.White;
            this.butConvertir.Location = new System.Drawing.Point(286, 101);
            this.butConvertir.Name = "butConvertir";
            this.butConvertir.Size = new System.Drawing.Size(161, 27);
            this.butConvertir.TabIndex = 14;
            this.butConvertir.Text = "Convertir moneda";
            this.butConvertir.UseVisualStyleBackColor = false;
            this.butConvertir.Click += new System.EventHandler(this.butConvertir_Click);
            // 
            // ScMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(488, 150);
            this.Controls.Add(this.butConvertir);
            this.Controls.Add(this.GroupBoxOption);
            this.Controls.Add(this.LabelDolares);
            this.Controls.Add(this.TextBoxCambioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPesos);
            this.Controls.Add(this.TextBoxCantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de moneda.";
            this.GroupBoxOption.ResumeLayout(false);
            this.GroupBoxOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBoxOption;
        private System.Windows.Forms.RadioButton RbDtoP;
        private System.Windows.Forms.RadioButton RbPtoD;
        private System.Windows.Forms.Label LabelDolares;
        private System.Windows.Forms.TextBox TextBoxCambioTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPesos;
        private System.Windows.Forms.TextBox TextBoxCantidad;
        private System.Windows.Forms.Button butConvertir;
    }
}
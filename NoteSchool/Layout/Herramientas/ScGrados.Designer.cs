
namespace NoteSchool.Layout.Herramientas {
    partial class ScGrados {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScGrados));
            this.lResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbDegrees = new System.Windows.Forms.GroupBox();
            this.rbFtoC = new System.Windows.Forms.RadioButton();
            this.rbCtoF = new System.Windows.Forms.RadioButton();
            this.lTittle = new System.Windows.Forms.Label();
            this.lDegrees = new System.Windows.Forms.Label();
            this.tbDegrees = new System.Windows.Forms.TextBox();
            this.butConvertir = new System.Windows.Forms.Button();
            this.gbDegrees.SuspendLayout();
            this.SuspendLayout();
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.ForeColor = System.Drawing.Color.White;
            this.lResult.Location = new System.Drawing.Point(16, 93);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(76, 17);
            this.lResult.TabIndex = 14;
            this.lResult.Text = "Conversión:";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbResult.ForeColor = System.Drawing.Color.White;
            this.tbResult.Location = new System.Drawing.Point(98, 90);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(121, 20);
            this.tbResult.TabIndex = 13;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbDegrees
            // 
            this.gbDegrees.Controls.Add(this.rbFtoC);
            this.gbDegrees.Controls.Add(this.rbCtoF);
            this.gbDegrees.ForeColor = System.Drawing.Color.White;
            this.gbDegrees.Location = new System.Drawing.Point(225, 46);
            this.gbDegrees.Name = "gbDegrees";
            this.gbDegrees.Size = new System.Drawing.Size(200, 64);
            this.gbDegrees.TabIndex = 12;
            this.gbDegrees.TabStop = false;
            this.gbDegrees.Text = "Opciones de conversión";
            // 
            // rbFtoC
            // 
            this.rbFtoC.AutoSize = true;
            this.rbFtoC.ForeColor = System.Drawing.Color.White;
            this.rbFtoC.Location = new System.Drawing.Point(18, 43);
            this.rbFtoC.Name = "rbFtoC";
            this.rbFtoC.Size = new System.Drawing.Size(119, 17);
            this.rbFtoC.TabIndex = 1;
            this.rbFtoC.TabStop = true;
            this.rbFtoC.Text = "Fahrenheit a celsius";
            this.rbFtoC.UseVisualStyleBackColor = true;
            // 
            // rbCtoF
            // 
            this.rbCtoF.AutoSize = true;
            this.rbCtoF.ForeColor = System.Drawing.Color.White;
            this.rbCtoF.Location = new System.Drawing.Point(18, 20);
            this.rbCtoF.Name = "rbCtoF";
            this.rbCtoF.Size = new System.Drawing.Size(117, 17);
            this.rbCtoF.TabIndex = 0;
            this.rbCtoF.TabStop = true;
            this.rbCtoF.Text = "Celsius a fahrenheit";
            this.rbCtoF.UseVisualStyleBackColor = true;
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTittle.ForeColor = System.Drawing.Color.White;
            this.lTittle.Location = new System.Drawing.Point(12, 9);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(175, 21);
            this.lTittle.TabIndex = 10;
            this.lTittle.Text = "Conversión de grados";
            // 
            // lDegrees
            // 
            this.lDegrees.AutoSize = true;
            this.lDegrees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDegrees.ForeColor = System.Drawing.Color.White;
            this.lDegrees.Location = new System.Drawing.Point(15, 56);
            this.lDegrees.Name = "lDegrees";
            this.lDegrees.Size = new System.Drawing.Size(54, 17);
            this.lDegrees.TabIndex = 9;
            this.lDegrees.Text = "Grados:";
            // 
            // tbDegrees
            // 
            this.tbDegrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbDegrees.ForeColor = System.Drawing.Color.White;
            this.tbDegrees.Location = new System.Drawing.Point(75, 53);
            this.tbDegrees.Name = "tbDegrees";
            this.tbDegrees.Size = new System.Drawing.Size(144, 20);
            this.tbDegrees.TabIndex = 8;
            this.tbDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butConvertir
            // 
            this.butConvertir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConvertir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConvertir.ForeColor = System.Drawing.Color.White;
            this.butConvertir.Location = new System.Drawing.Point(243, 124);
            this.butConvertir.Name = "butConvertir";
            this.butConvertir.Size = new System.Drawing.Size(161, 27);
            this.butConvertir.TabIndex = 15;
            this.butConvertir.Text = "Realizar conversión";
            this.butConvertir.UseVisualStyleBackColor = false;
            this.butConvertir.Click += new System.EventHandler(this.butConvertir_Click);
            // 
            // ScGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(441, 167);
            this.Controls.Add(this.butConvertir);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.gbDegrees);
            this.Controls.Add(this.lTittle);
            this.Controls.Add(this.lDegrees);
            this.Controls.Add(this.tbDegrees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScGrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de grados.";
            this.gbDegrees.ResumeLayout(false);
            this.gbDegrees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.GroupBox gbDegrees;
        private System.Windows.Forms.RadioButton rbFtoC;
        private System.Windows.Forms.RadioButton rbCtoF;
        private System.Windows.Forms.Label lTittle;
        private System.Windows.Forms.Label lDegrees;
        private System.Windows.Forms.TextBox tbDegrees;
        private System.Windows.Forms.Button butConvertir;
    }
}
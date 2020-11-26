
namespace NoteSchool.Layout.Tools {
    partial class ScCalculator {
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
            this.calculadoraLayout1 = new ComponenteCalculadora.CalculadoraLayout();
            this.SuspendLayout();
            // 
            // calculadoraLayout1
            // 
            this.calculadoraLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.calculadoraLayout1.Location = new System.Drawing.Point(2, -1);
            this.calculadoraLayout1.Name = "calculadoraLayout1";
            this.calculadoraLayout1.Size = new System.Drawing.Size(317, 247);
            this.calculadoraLayout1.TabIndex = 0;
            // 
            // ScCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(318, 246);
            this.Controls.Add(this.calculadoraLayout1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ScCalculator";
            this.Text = "ScCalculator";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponenteCalculadora.CalculadoraLayout calculadoraLayout1;
    }
}
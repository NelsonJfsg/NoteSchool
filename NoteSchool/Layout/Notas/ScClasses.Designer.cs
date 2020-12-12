namespace NoteSchool.Layout {
    partial class ScClasses {
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
            this.dataGVNotas = new System.Windows.Forms.DataGridView();
            this.pbEliminarNota = new System.Windows.Forms.PictureBox();
            this.pbEditarNota = new System.Windows.Forms.PictureBox();
            this.pbCrearNota = new System.Windows.Forms.PictureBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bloc de notas - NoteSchool";
            // 
            // dataGVNotas
            // 
            this.dataGVNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dataGVNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVNotas.Location = new System.Drawing.Point(18, 53);
            this.dataGVNotas.Name = "dataGVNotas";
            this.dataGVNotas.RowHeadersVisible = false;
            this.dataGVNotas.Size = new System.Drawing.Size(632, 227);
            this.dataGVNotas.TabIndex = 8;
            this.dataGVNotas.VirtualMode = true;
            // 
            // pbEliminarNota
            // 
            this.pbEliminarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminarNota.Image = global::NoteSchool.Properties.Resources.Close;
            this.pbEliminarNota.Location = new System.Drawing.Point(486, 295);
            this.pbEliminarNota.Name = "pbEliminarNota";
            this.pbEliminarNota.Size = new System.Drawing.Size(164, 142);
            this.pbEliminarNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarNota.TabIndex = 7;
            this.pbEliminarNota.TabStop = false;
            this.pbEliminarNota.Click += new System.EventHandler(this.pbEliminarNota_Click);
            // 
            // pbEditarNota
            // 
            this.pbEditarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarNota.Image = global::NoteSchool.Properties.Resources.Edit;
            this.pbEditarNota.Location = new System.Drawing.Point(253, 295);
            this.pbEditarNota.Name = "pbEditarNota";
            this.pbEditarNota.Size = new System.Drawing.Size(164, 142);
            this.pbEditarNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarNota.TabIndex = 6;
            this.pbEditarNota.TabStop = false;
            this.pbEditarNota.Click += new System.EventHandler(this.pbEditarNota_Click);
            // 
            // pbCrearNota
            // 
            this.pbCrearNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCrearNota.Image = global::NoteSchool.Properties.Resources.Add_document;
            this.pbCrearNota.Location = new System.Drawing.Point(18, 295);
            this.pbCrearNota.Name = "pbCrearNota";
            this.pbCrearNota.Size = new System.Drawing.Size(164, 142);
            this.pbCrearNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrearNota.TabIndex = 5;
            this.pbCrearNota.TabStop = false;
            this.pbCrearNota.Click += new System.EventHandler(this.pbCrearNota_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbActualizar.Image = global::NoteSchool.Properties.Resources.actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(18, 9);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(42, 38);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 9;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // ScClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(672, 458);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.dataGVNotas);
            this.Controls.Add(this.pbEliminarNota);
            this.Controls.Add(this.pbEditarNota);
            this.Controls.Add(this.pbCrearNota);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScClasses";
            this.Text = "ScClasses";
            this.Load += new System.EventHandler(this.ScClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCrearNota;
        private System.Windows.Forms.PictureBox pbEditarNota;
        private System.Windows.Forms.PictureBox pbEliminarNota;
        private System.Windows.Forms.DataGridView dataGVNotas;
        private System.Windows.Forms.PictureBox pbActualizar;
    }
}
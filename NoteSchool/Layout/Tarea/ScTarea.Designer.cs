
namespace NoteSchool.Layout.Tarea {
    partial class ScTarea {
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
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.dataGVTarea = new System.Windows.Forms.DataGridView();
            this.pbEliminarTarea = new System.Windows.Forms.PictureBox();
            this.pbEditarTarea = new System.Windows.Forms.PictureBox();
            this.pbCrearTarea = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // pbActualizar
            // 
            this.pbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbActualizar.Image = global::NoteSchool.Properties.Resources.actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(17, 9);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(42, 38);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 15;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // dataGVTarea
            // 
            this.dataGVTarea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dataGVTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTarea.Location = new System.Drawing.Point(17, 53);
            this.dataGVTarea.Name = "dataGVTarea";
            this.dataGVTarea.ReadOnly = true;
            this.dataGVTarea.RowHeadersVisible = false;
            this.dataGVTarea.Size = new System.Drawing.Size(632, 227);
            this.dataGVTarea.TabIndex = 14;
            this.dataGVTarea.VirtualMode = true;
            // 
            // pbEliminarTarea
            // 
            this.pbEliminarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminarTarea.Image = global::NoteSchool.Properties.Resources.Close;
            this.pbEliminarTarea.Location = new System.Drawing.Point(485, 295);
            this.pbEliminarTarea.Name = "pbEliminarTarea";
            this.pbEliminarTarea.Size = new System.Drawing.Size(164, 142);
            this.pbEliminarTarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarTarea.TabIndex = 13;
            this.pbEliminarTarea.TabStop = false;
            this.pbEliminarTarea.Click += new System.EventHandler(this.pbEliminarTarea_Click);
            // 
            // pbEditarTarea
            // 
            this.pbEditarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarTarea.Image = global::NoteSchool.Properties.Resources.Open_book;
            this.pbEditarTarea.Location = new System.Drawing.Point(252, 295);
            this.pbEditarTarea.Name = "pbEditarTarea";
            this.pbEditarTarea.Size = new System.Drawing.Size(164, 142);
            this.pbEditarTarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarTarea.TabIndex = 12;
            this.pbEditarTarea.TabStop = false;
            this.pbEditarTarea.Click += new System.EventHandler(this.pbEditarTarea_Click);
            // 
            // pbCrearTarea
            // 
            this.pbCrearTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCrearTarea.Image = global::NoteSchool.Properties.Resources.Book;
            this.pbCrearTarea.Location = new System.Drawing.Point(17, 295);
            this.pbCrearTarea.Name = "pbCrearTarea";
            this.pbCrearTarea.Size = new System.Drawing.Size(164, 142);
            this.pbCrearTarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrearTarea.TabIndex = 11;
            this.pbCrearTarea.TabStop = false;
            this.pbCrearTarea.Click += new System.EventHandler(this.pbCrearTarea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tareas - NoteSchool";
            // 
            // ScTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(672, 458);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.dataGVTarea);
            this.Controls.Add(this.pbEliminarTarea);
            this.Controls.Add(this.pbEditarTarea);
            this.Controls.Add(this.pbCrearTarea);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScTarea";
            this.Text = "ScTarea";
            this.Load += new System.EventHandler(this.ScTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearTarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.DataGridView dataGVTarea;
        private System.Windows.Forms.PictureBox pbEliminarTarea;
        private System.Windows.Forms.PictureBox pbEditarTarea;
        private System.Windows.Forms.PictureBox pbCrearTarea;
        private System.Windows.Forms.Label label2;
    }
}
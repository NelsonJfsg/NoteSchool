namespace NoteSchool.Layout {
    partial class ScStart {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGVHorario = new System.Windows.Forms.DataGridView();
            this.lHorario = new System.Windows.Forms.Label();
            this.lTareas = new System.Windows.Forms.Label();
            this.dataGVTareas = new System.Windows.Forms.DataGridView();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVHorario
            // 
            this.dataGVHorario.AllowUserToOrderColumns = true;
            this.dataGVHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVHorario.ColumnHeadersHeight = 21;
            this.dataGVHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGVHorario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dataGVHorario.Location = new System.Drawing.Point(17, 235);
            this.dataGVHorario.Name = "dataGVHorario";
            this.dataGVHorario.ReadOnly = true;
            this.dataGVHorario.RowHeadersVisible = false;
            this.dataGVHorario.RowTemplate.Height = 21;
            this.dataGVHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVHorario.Size = new System.Drawing.Size(516, 201);
            this.dataGVHorario.TabIndex = 31;
            this.dataGVHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHorario_CellDoubleClick);
            // 
            // lHorario
            // 
            this.lHorario.AutoSize = true;
            this.lHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lHorario.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHorario.ForeColor = System.Drawing.Color.White;
            this.lHorario.Location = new System.Drawing.Point(14, 209);
            this.lHorario.Name = "lHorario";
            this.lHorario.Size = new System.Drawing.Size(72, 20);
            this.lHorario.TabIndex = 29;
            this.lHorario.Text = "Horario ";
            // 
            // lTareas
            // 
            this.lTareas.AutoSize = true;
            this.lTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lTareas.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTareas.ForeColor = System.Drawing.Color.White;
            this.lTareas.Location = new System.Drawing.Point(13, 17);
            this.lTareas.Name = "lTareas";
            this.lTareas.Size = new System.Drawing.Size(141, 20);
            this.lTareas.TabIndex = 27;
            this.lTareas.Text = "Tareas pendientes";
            // 
            // dataGVTareas
            // 
            this.dataGVTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dataGVTareas.Location = new System.Drawing.Point(17, 41);
            this.dataGVTareas.Name = "dataGVTareas";
            this.dataGVTareas.ReadOnly = true;
            this.dataGVTareas.RowHeadersVisible = false;
            this.dataGVTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVTareas.Size = new System.Drawing.Size(643, 157);
            this.dataGVTareas.TabIndex = 32;
            // 
            // cbDia
            // 
            this.cbDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDia.ForeColor = System.Drawing.Color.White;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "lunes",
            "martes",
            "miercoles",
            "jueves",
            "viernes",
            "sabado",
            "domingo"});
            this.cbDia.Location = new System.Drawing.Point(539, 235);
            this.cbDia.Name = "cbDia";
            this.cbDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDia.Size = new System.Drawing.Size(121, 25);
            this.cbDia.TabIndex = 34;
            this.cbDia.Text = "Dia";
            this.cbDia.SelectedIndexChanged += new System.EventHandler(this.cbDia_SelectedIndexChanged);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbActualizar.Image = global::NoteSchool.Properties.Resources.actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(634, 11);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(26, 24);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 35;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // ScStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(672, 458);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.dataGVTareas);
            this.Controls.Add(this.dataGVHorario);
            this.Controls.Add(this.lHorario);
            this.Controls.Add(this.lTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScStart";
            this.Text = "ScStart";
            this.Load += new System.EventHandler(this.ScStart_Load);
            this.VisibleChanged += new System.EventHandler(this.ScStart_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVHorario;
        private System.Windows.Forms.Label lHorario;
        private System.Windows.Forms.Label lTareas;
        private System.Windows.Forms.DataGridView dataGVTareas;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.PictureBox pbActualizar;
    }
}
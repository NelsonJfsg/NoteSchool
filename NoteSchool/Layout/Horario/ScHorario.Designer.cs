
namespace NoteSchool.Layout.Horario {
    partial class ScHorario {
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
            this.butRegistrarClase = new System.Windows.Forms.Button();
            this.dataGVHorario = new System.Windows.Forms.DataGridView();
            this.lDia = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.martesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miercolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viernesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.domingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butEditarClase = new System.Windows.Forms.Button();
            this.butEliminarClase = new System.Windows.Forms.Button();
            this.butActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHorario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HORARIO ESCOLAR";
            // 
            // butRegistrarClase
            // 
            this.butRegistrarClase.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butRegistrarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butRegistrarClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butRegistrarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegistrarClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegistrarClase.ForeColor = System.Drawing.Color.White;
            this.butRegistrarClase.Location = new System.Drawing.Point(499, 411);
            this.butRegistrarClase.Name = "butRegistrarClase";
            this.butRegistrarClase.Size = new System.Drawing.Size(161, 27);
            this.butRegistrarClase.TabIndex = 6;
            this.butRegistrarClase.Text = "Registrar clase";
            this.butRegistrarClase.UseVisualStyleBackColor = false;
            this.butRegistrarClase.Click += new System.EventHandler(this.butRegistrarClase_Click);
            // 
            // dataGVHorario
            // 
            this.dataGVHorario.AllowUserToResizeColumns = false;
            this.dataGVHorario.AllowUserToResizeRows = false;
            this.dataGVHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dataGVHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVHorario.GridColor = System.Drawing.Color.White;
            this.dataGVHorario.Location = new System.Drawing.Point(12, 94);
            this.dataGVHorario.Name = "dataGVHorario";
            this.dataGVHorario.ReadOnly = true;
            this.dataGVHorario.Size = new System.Drawing.Size(637, 298);
            this.dataGVHorario.TabIndex = 7;
            this.dataGVHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHorario_CellDoubleClick);
            // 
            // lDia
            // 
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(12, 55);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(59, 25);
            this.lDia.TabIndex = 8;
            this.lDia.Text = "lunes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lunesToolStripMenuItem,
            this.martesToolStripMenuItem,
            this.miercolesToolStripMenuItem,
            this.sabadoToolStripMenuItem,
            this.viernesToolStripMenuItem,
            this.sabadoToolStripMenuItem1,
            this.domingoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lunesToolStripMenuItem
            // 
            this.lunesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lunesToolStripMenuItem.Name = "lunesToolStripMenuItem";
            this.lunesToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.lunesToolStripMenuItem.Text = "lunes";
            this.lunesToolStripMenuItem.Click += new System.EventHandler(this.lunesToolStripMenuItem_Click);
            // 
            // martesToolStripMenuItem
            // 
            this.martesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.martesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.martesToolStripMenuItem.Name = "martesToolStripMenuItem";
            this.martesToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.martesToolStripMenuItem.Text = "Martes";
            this.martesToolStripMenuItem.Click += new System.EventHandler(this.martesToolStripMenuItem_Click);
            // 
            // miercolesToolStripMenuItem
            // 
            this.miercolesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miercolesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.miercolesToolStripMenuItem.Name = "miercolesToolStripMenuItem";
            this.miercolesToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.miercolesToolStripMenuItem.Text = "Miercoles";
            this.miercolesToolStripMenuItem.Click += new System.EventHandler(this.miercolesToolStripMenuItem_Click);
            // 
            // sabadoToolStripMenuItem
            // 
            this.sabadoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabadoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sabadoToolStripMenuItem.Name = "sabadoToolStripMenuItem";
            this.sabadoToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.sabadoToolStripMenuItem.Text = "Jueves";
            this.sabadoToolStripMenuItem.Click += new System.EventHandler(this.sabadoToolStripMenuItem_Click);
            // 
            // viernesToolStripMenuItem
            // 
            this.viernesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viernesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viernesToolStripMenuItem.Name = "viernesToolStripMenuItem";
            this.viernesToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.viernesToolStripMenuItem.Text = "Viernes";
            this.viernesToolStripMenuItem.Click += new System.EventHandler(this.viernesToolStripMenuItem_Click);
            // 
            // sabadoToolStripMenuItem1
            // 
            this.sabadoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabadoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.sabadoToolStripMenuItem1.Name = "sabadoToolStripMenuItem1";
            this.sabadoToolStripMenuItem1.Size = new System.Drawing.Size(65, 21);
            this.sabadoToolStripMenuItem1.Text = "Sabado";
            this.sabadoToolStripMenuItem1.Click += new System.EventHandler(this.sabadoToolStripMenuItem1_Click);
            // 
            // domingoToolStripMenuItem
            // 
            this.domingoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domingoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.domingoToolStripMenuItem.Name = "domingoToolStripMenuItem";
            this.domingoToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.domingoToolStripMenuItem.Text = "Domingo";
            this.domingoToolStripMenuItem.Click += new System.EventHandler(this.domingoToolStripMenuItem_Click);
            // 
            // butEditarClase
            // 
            this.butEditarClase.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butEditarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEditarClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEditarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEditarClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditarClase.ForeColor = System.Drawing.Color.White;
            this.butEditarClase.Location = new System.Drawing.Point(320, 411);
            this.butEditarClase.Name = "butEditarClase";
            this.butEditarClase.Size = new System.Drawing.Size(161, 27);
            this.butEditarClase.TabIndex = 10;
            this.butEditarClase.Text = "Editar clase";
            this.butEditarClase.UseVisualStyleBackColor = false;
            this.butEditarClase.Click += new System.EventHandler(this.butEditarClase_Click);
            // 
            // butEliminarClase
            // 
            this.butEliminarClase.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butEliminarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEliminarClase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEliminarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEliminarClase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminarClase.ForeColor = System.Drawing.Color.White;
            this.butEliminarClase.Location = new System.Drawing.Point(144, 411);
            this.butEliminarClase.Name = "butEliminarClase";
            this.butEliminarClase.Size = new System.Drawing.Size(161, 27);
            this.butEliminarClase.TabIndex = 11;
            this.butEliminarClase.Text = "Eliminar clase";
            this.butEliminarClase.UseVisualStyleBackColor = false;
            this.butEliminarClase.Click += new System.EventHandler(this.butEliminarClase_Click);
            // 
            // butActualizar
            // 
            this.butActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.butActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butActualizar.ForeColor = System.Drawing.Color.White;
            this.butActualizar.Location = new System.Drawing.Point(12, 411);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(116, 27);
            this.butActualizar.TabIndex = 12;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = false;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // ScHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.butActualizar);
            this.Controls.Add(this.butEliminarClase);
            this.Controls.Add(this.butEditarClase);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.dataGVHorario);
            this.Controls.Add(this.butRegistrarClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScHorario";
            this.Text = "ScHorario";
            this.Load += new System.EventHandler(this.ScHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHorario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRegistrarClase;
        private System.Windows.Forms.DataGridView dataGVHorario;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem martesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miercolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viernesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem domingoToolStripMenuItem;
        private System.Windows.Forms.Button butEditarClase;
        private System.Windows.Forms.Button butEliminarClase;
        private System.Windows.Forms.Button butActualizar;
    }
}
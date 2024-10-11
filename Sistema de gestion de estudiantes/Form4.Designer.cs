namespace Sistema_de_gestion_de_estudiantes
{
    partial class formRegistroCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistroCursos));
            gestionar_cursos = new DataGridView();
            cursoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombredelcursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            btn_RegistroCursoGuardar = new Button();
            btn_RegistroEstudiantesCursoCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gestionar_cursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gestionar_cursos
            // 
            gestionar_cursos.AutoGenerateColumns = false;
            gestionar_cursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gestionar_cursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gestionar_cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gestionar_cursos.Columns.AddRange(new DataGridViewColumn[] { cursoIdDataGridViewTextBoxColumn, estudianteIdDataGridViewTextBoxColumn, estudianteDataGridViewTextBoxColumn, nombredelcursoDataGridViewTextBoxColumn });
            gestionar_cursos.DataSource = cursosBindingSource;
            gestionar_cursos.Location = new Point(13, 13);
            gestionar_cursos.Margin = new Padding(4);
            gestionar_cursos.Name = "gestionar_cursos";
            gestionar_cursos.Size = new Size(438, 292);
            gestionar_cursos.TabIndex = 4;          
            // 
            // cursoIdDataGridViewTextBoxColumn
            // 
            cursoIdDataGridViewTextBoxColumn.DataPropertyName = "CursoId";
            cursoIdDataGridViewTextBoxColumn.HeaderText = "CursoId";
            cursoIdDataGridViewTextBoxColumn.Name = "cursoIdDataGridViewTextBoxColumn";
            cursoIdDataGridViewTextBoxColumn.ReadOnly = true;
            cursoIdDataGridViewTextBoxColumn.Width = 92;
            // 
            // estudianteIdDataGridViewTextBoxColumn
            // 
            estudianteIdDataGridViewTextBoxColumn.DataPropertyName = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn.HeaderText = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn.Name = "estudianteIdDataGridViewTextBoxColumn";
            estudianteIdDataGridViewTextBoxColumn.Width = 128;
            // 
            // estudianteDataGridViewTextBoxColumn
            // 
            estudianteDataGridViewTextBoxColumn.DataPropertyName = "Estudiante";
            estudianteDataGridViewTextBoxColumn.HeaderText = "Estudiante";
            estudianteDataGridViewTextBoxColumn.Name = "estudianteDataGridViewTextBoxColumn";
            estudianteDataGridViewTextBoxColumn.Visible = false;
            estudianteDataGridViewTextBoxColumn.Width = 112;
            // 
            // nombredelcursoDataGridViewTextBoxColumn
            // 
            nombredelcursoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_curso";
            nombredelcursoDataGridViewTextBoxColumn.HeaderText = "Nombre_del_curso";
            nombredelcursoDataGridViewTextBoxColumn.Name = "nombredelcursoDataGridViewTextBoxColumn";
            nombredelcursoDataGridViewTextBoxColumn.Width = 175;
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataSource = typeof(Cursos);
            // 
            // btn_RegistroCursoGuardar
            // 
            btn_RegistroCursoGuardar.Location = new Point(226, 312);
            btn_RegistroCursoGuardar.Name = "btn_RegistroCursoGuardar";
            btn_RegistroCursoGuardar.Size = new Size(111, 26);
            btn_RegistroCursoGuardar.TabIndex = 14;
            btn_RegistroCursoGuardar.Text = "Guardar";
            btn_RegistroCursoGuardar.UseVisualStyleBackColor = true;
            btn_RegistroCursoGuardar.Click += btn_RegistroCursoGuardar_Click;
            // 
            // btn_RegistroEstudiantesCursoCerrar
            // 
            btn_RegistroEstudiantesCursoCerrar.Location = new Point(340, 312);
            btn_RegistroEstudiantesCursoCerrar.Name = "btn_RegistroEstudiantesCursoCerrar";
            btn_RegistroEstudiantesCursoCerrar.Size = new Size(111, 26);
            btn_RegistroEstudiantesCursoCerrar.TabIndex = 15;
            btn_RegistroEstudiantesCursoCerrar.Text = "Cerrar";
            btn_RegistroEstudiantesCursoCerrar.UseVisualStyleBackColor = true;
            btn_RegistroEstudiantesCursoCerrar.Click += btn_RegistroEstudiantesCursoCerrar_Click;
            // 
            // formRegistroCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(458, 355);
            Controls.Add(btn_RegistroEstudiantesCursoCerrar);
            Controls.Add(btn_RegistroCursoGuardar);
            Controls.Add(gestionar_cursos);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formRegistroCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros de Cursos ";
            FormClosing += formRegistroCursos_FormClosing;            
            ((System.ComponentModel.ISupportInitialize)gestionar_cursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gestionar_cursos;
        private Button btn_RegistroCursoGuardar;
        private Button btn_RegistroEstudiantesCursoCerrar;
        private BindingSource cursosBindingSource;
        private DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombredelcursoDataGridViewTextBoxColumn;
    }
}
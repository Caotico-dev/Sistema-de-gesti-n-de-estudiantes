namespace Sistema_de_gestion_de_estudiantes
{
    partial class formRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistro));
            label1 = new Label();
            visual_Calificaciones = new DataGridView();
            calificacionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estudianteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacionesBindingSource = new BindingSource(components);
            estudianteBindingSource = new BindingSource(components);
            btn_volver = new Button();
            visual_Estudiantes = new DataGridView();
            estudianteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visual_Cursos = new DataGridView();
            cursoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            estudianteDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombredelcursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursosBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_AgregarCalificaciones = new Button();
            btn_AgregarEstudiantes = new Button();
            btn_AgregarCursos = new Button();
            ((System.ComponentModel.ISupportInitialize)visual_Calificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calificacionesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visual_Estudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visual_Cursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 33);
            label1.TabIndex = 0;
            label1.Text = "Registros";
            // 
            // visual_Calificaciones
            // 
            visual_Calificaciones.AutoGenerateColumns = false;
            visual_Calificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            visual_Calificaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            visual_Calificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visual_Calificaciones.Columns.AddRange(new DataGridViewColumn[] { calificacionIdDataGridViewTextBoxColumn, estudianteIdDataGridViewTextBoxColumn1, estudianteDataGridViewTextBoxColumn, materiaDataGridViewTextBoxColumn, calificacion1DataGridViewTextBoxColumn, calificacion2DataGridViewTextBoxColumn, calificacion3DataGridViewTextBoxColumn });
            visual_Calificaciones.DataSource = calificacionesBindingSource;
            visual_Calificaciones.Location = new Point(13, 116);
            visual_Calificaciones.Margin = new Padding(4);
            visual_Calificaciones.Name = "visual_Calificaciones";
            visual_Calificaciones.Size = new Size(654, 342);
            visual_Calificaciones.TabIndex = 1;           
            // 
            // calificacionIdDataGridViewTextBoxColumn
            // 
            calificacionIdDataGridViewTextBoxColumn.DataPropertyName = "CalificacionId";
            calificacionIdDataGridViewTextBoxColumn.HeaderText = "CalificacionId";
            calificacionIdDataGridViewTextBoxColumn.Name = "calificacionIdDataGridViewTextBoxColumn";
            calificacionIdDataGridViewTextBoxColumn.ReadOnly = true;
            calificacionIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // estudianteIdDataGridViewTextBoxColumn1
            // 
            estudianteIdDataGridViewTextBoxColumn1.DataPropertyName = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn1.HeaderText = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn1.Name = "estudianteIdDataGridViewTextBoxColumn1";
            estudianteIdDataGridViewTextBoxColumn1.ReadOnly = true;
            estudianteIdDataGridViewTextBoxColumn1.Width = 128;
            // 
            // estudianteDataGridViewTextBoxColumn
            // 
            estudianteDataGridViewTextBoxColumn.DataPropertyName = "Estudiante";
            estudianteDataGridViewTextBoxColumn.HeaderText = "Estudiante";
            estudianteDataGridViewTextBoxColumn.Name = "estudianteDataGridViewTextBoxColumn";
            estudianteDataGridViewTextBoxColumn.ReadOnly = true;
            estudianteDataGridViewTextBoxColumn.Visible = false;
            estudianteDataGridViewTextBoxColumn.Width = 112;
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            materiaDataGridViewTextBoxColumn.ReadOnly = true;
            materiaDataGridViewTextBoxColumn.Width = 88;
            // 
            // calificacion1DataGridViewTextBoxColumn
            // 
            calificacion1DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_1";
            calificacion1DataGridViewTextBoxColumn.HeaderText = "Calificacion_1";
            calificacion1DataGridViewTextBoxColumn.Name = "calificacion1DataGridViewTextBoxColumn";
            calificacion1DataGridViewTextBoxColumn.ReadOnly = true;
            calificacion1DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacion2DataGridViewTextBoxColumn
            // 
            calificacion2DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_2";
            calificacion2DataGridViewTextBoxColumn.HeaderText = "Calificacion_2";
            calificacion2DataGridViewTextBoxColumn.Name = "calificacion2DataGridViewTextBoxColumn";
            calificacion2DataGridViewTextBoxColumn.ReadOnly = true;
            calificacion2DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacion3DataGridViewTextBoxColumn
            // 
            calificacion3DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_3";
            calificacion3DataGridViewTextBoxColumn.HeaderText = "Calificacion_3";
            calificacion3DataGridViewTextBoxColumn.Name = "calificacion3DataGridViewTextBoxColumn";
            calificacion3DataGridViewTextBoxColumn.ReadOnly = true;
            calificacion3DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacionesBindingSource
            // 
            calificacionesBindingSource.DataMember = "Calificaciones";
            calificacionesBindingSource.DataSource = estudianteBindingSource;
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Estudiante);
            // 
            // btn_volver
            // 
            btn_volver.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.Location = new Point(17, 486);
            btn_volver.Margin = new Padding(4);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(180, 40);
            btn_volver.TabIndex = 2;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_inicio_Click;
            // 
            // visual_Estudiantes
            // 
            visual_Estudiantes.AutoGenerateColumns = false;
            visual_Estudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            visual_Estudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            visual_Estudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visual_Estudiantes.Columns.AddRange(new DataGridViewColumn[] { estudianteIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn });
            visual_Estudiantes.DataSource = estudianteBindingSource;
            visual_Estudiantes.Location = new Point(687, 116);
            visual_Estudiantes.Margin = new Padding(4);
            visual_Estudiantes.Name = "visual_Estudiantes";
            visual_Estudiantes.Size = new Size(436, 180);
            visual_Estudiantes.TabIndex = 3;
            visual_Estudiantes.SelectionChanged += visual_Estudiantes_SelectionChanged;
            // 
            // estudianteIdDataGridViewTextBoxColumn
            // 
            estudianteIdDataGridViewTextBoxColumn.DataPropertyName = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn.HeaderText = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn.Name = "estudianteIdDataGridViewTextBoxColumn";
            estudianteIdDataGridViewTextBoxColumn.ReadOnly = true;
            estudianteIdDataGridViewTextBoxColumn.Width = 128;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 93;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            apellidoDataGridViewTextBoxColumn.Width = 99;
            // 
            // visual_Cursos
            // 
            visual_Cursos.AutoGenerateColumns = false;
            visual_Cursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            visual_Cursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            visual_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visual_Cursos.Columns.AddRange(new DataGridViewColumn[] { cursoIdDataGridViewTextBoxColumn, estudianteIdDataGridViewTextBoxColumn2, estudianteDataGridViewTextBoxColumn1, nombredelcursoDataGridViewTextBoxColumn });
            visual_Cursos.DataSource = cursosBindingSource;
            visual_Cursos.Location = new Point(687, 346);
            visual_Cursos.Margin = new Padding(4);
            visual_Cursos.Name = "visual_Cursos";
            visual_Cursos.Size = new Size(439, 180);
            visual_Cursos.TabIndex = 4;
            // 
            // cursoIdDataGridViewTextBoxColumn
            // 
            cursoIdDataGridViewTextBoxColumn.DataPropertyName = "CursoId";
            cursoIdDataGridViewTextBoxColumn.HeaderText = "CursoId";
            cursoIdDataGridViewTextBoxColumn.Name = "cursoIdDataGridViewTextBoxColumn";
            cursoIdDataGridViewTextBoxColumn.ReadOnly = true;
            cursoIdDataGridViewTextBoxColumn.Width = 92;
            // 
            // estudianteIdDataGridViewTextBoxColumn2
            // 
            estudianteIdDataGridViewTextBoxColumn2.DataPropertyName = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn2.HeaderText = "EstudianteId";
            estudianteIdDataGridViewTextBoxColumn2.Name = "estudianteIdDataGridViewTextBoxColumn2";
            estudianteIdDataGridViewTextBoxColumn2.ReadOnly = true;
            estudianteIdDataGridViewTextBoxColumn2.Width = 128;
            // 
            // estudianteDataGridViewTextBoxColumn1
            // 
            estudianteDataGridViewTextBoxColumn1.DataPropertyName = "Estudiante";
            estudianteDataGridViewTextBoxColumn1.HeaderText = "Estudiante";
            estudianteDataGridViewTextBoxColumn1.Name = "estudianteDataGridViewTextBoxColumn1";
            estudianteDataGridViewTextBoxColumn1.ReadOnly = true;
            estudianteDataGridViewTextBoxColumn1.Visible = false;
            estudianteDataGridViewTextBoxColumn1.Width = 112;
            // 
            // nombredelcursoDataGridViewTextBoxColumn
            // 
            nombredelcursoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_curso";
            nombredelcursoDataGridViewTextBoxColumn.HeaderText = "Nombre_del_curso";
            nombredelcursoDataGridViewTextBoxColumn.Name = "nombredelcursoDataGridViewTextBoxColumn";
            nombredelcursoDataGridViewTextBoxColumn.ReadOnly = true;
            nombredelcursoDataGridViewTextBoxColumn.Width = 175;
            // 
            // cursosBindingSource
            // 
            cursosBindingSource.DataMember = "Cursos";
            cursosBindingSource.DataSource = estudianteBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(207, 33);
            label2.TabIndex = 5;
            label2.Text = "Calificaciones";           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(687, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 33);
            label3.TabIndex = 6;
            label3.Text = "Estudiantes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(687, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 33);
            label4.TabIndex = 7;
            label4.Text = "Cursos";
            // 
            // btn_AgregarCalificaciones
            // 
            btn_AgregarCalificaciones.Location = new Point(580, 77);
            btn_AgregarCalificaciones.Name = "btn_AgregarCalificaciones";
            btn_AgregarCalificaciones.Size = new Size(87, 34);
            btn_AgregarCalificaciones.TabIndex = 8;
            btn_AgregarCalificaciones.Text = "Agregar";
            btn_AgregarCalificaciones.UseVisualStyleBackColor = true;
            btn_AgregarCalificaciones.Click += btn_AgregarCalificaciones_Click;
            // 
            // btn_AgregarEstudiantes
            // 
            btn_AgregarEstudiantes.Location = new Point(1036, 75);
            btn_AgregarEstudiantes.Name = "btn_AgregarEstudiantes";
            btn_AgregarEstudiantes.Size = new Size(87, 34);
            btn_AgregarEstudiantes.TabIndex = 9;
            btn_AgregarEstudiantes.Text = "Agregar";
            btn_AgregarEstudiantes.UseVisualStyleBackColor = true;
            btn_AgregarEstudiantes.Click += btn_AgregarEstudiantes_Click;
            // 
            // btn_AgregarCursos
            // 
            btn_AgregarCursos.Location = new Point(1039, 309);
            btn_AgregarCursos.Name = "btn_AgregarCursos";
            btn_AgregarCursos.Size = new Size(87, 34);
            btn_AgregarCursos.TabIndex = 10;
            btn_AgregarCursos.Text = "Agregar";
            btn_AgregarCursos.UseVisualStyleBackColor = true;
            btn_AgregarCursos.Click += btn_AgregarCursos_Click;
            // 
            // formRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1136, 536);
            Controls.Add(btn_AgregarCursos);
            Controls.Add(btn_AgregarEstudiantes);
            Controls.Add(btn_AgregarCalificaciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(visual_Cursos);
            Controls.Add(visual_Estudiantes);
            Controls.Add(btn_volver);
            Controls.Add(visual_Calificaciones);
            Controls.Add(label1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formRegistro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro";
            FormClosing += formRegistro_FormClosing;           
            ((System.ComponentModel.ISupportInitialize)visual_Calificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)calificacionesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visual_Estudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)visual_Cursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView visual_Calificaciones;
        private Button btn_volver;
        private DataGridView visual_Estudiantes;
        private DataGridView visual_Cursos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_AgregarCalificaciones;
        private Button btn_AgregarEstudiantes;
        private Button btn_AgregarCursos;
        private BindingSource calificacionesBindingSource;
        private BindingSource estudianteBindingSource;
        private BindingSource cursosBindingSource;
        private DataGridViewTextBoxColumn calificacionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estudianteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn estudianteDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombredelcursoDataGridViewTextBoxColumn;
    }
}
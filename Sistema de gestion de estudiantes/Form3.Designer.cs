namespace Sistema_de_gestion_de_estudiantes
{
    partial class formRegistroCalificiacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistroCalificiacion));
            gestionar_calificaciones = new DataGridView();
            calificacionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacion3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calificacionesBindingSource = new BindingSource(components);
            btn_RgistroCalificacionCerrar = new Button();
            btn_RegistroCalificacionGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)gestionar_calificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calificacionesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gestionar_calificaciones
            // 
            gestionar_calificaciones.AutoGenerateColumns = false;
            gestionar_calificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gestionar_calificaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gestionar_calificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gestionar_calificaciones.Columns.AddRange(new DataGridViewColumn[] { calificacionIdDataGridViewTextBoxColumn, estudianteIdDataGridViewTextBoxColumn, estudianteDataGridViewTextBoxColumn, materiaDataGridViewTextBoxColumn, calificacion1DataGridViewTextBoxColumn, calificacion2DataGridViewTextBoxColumn, calificacion3DataGridViewTextBoxColumn });
            gestionar_calificaciones.DataSource = calificacionesBindingSource;
            gestionar_calificaciones.Location = new Point(13, 13);
            gestionar_calificaciones.Margin = new Padding(4);
            gestionar_calificaciones.Name = "gestionar_calificaciones";
            gestionar_calificaciones.Size = new Size(826, 342);
            gestionar_calificaciones.TabIndex = 2;
            // 
            // calificacionIdDataGridViewTextBoxColumn
            // 
            calificacionIdDataGridViewTextBoxColumn.DataPropertyName = "CalificacionId";
            calificacionIdDataGridViewTextBoxColumn.HeaderText = "CalificacionId";
            calificacionIdDataGridViewTextBoxColumn.Name = "calificacionIdDataGridViewTextBoxColumn";
            calificacionIdDataGridViewTextBoxColumn.ReadOnly = true;
            calificacionIdDataGridViewTextBoxColumn.Width = 140;
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
            // materiaDataGridViewTextBoxColumn
            // 
            materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            materiaDataGridViewTextBoxColumn.Width = 88;
            // 
            // calificacion1DataGridViewTextBoxColumn
            // 
            calificacion1DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_1";
            calificacion1DataGridViewTextBoxColumn.HeaderText = "Calificacion_1";
            calificacion1DataGridViewTextBoxColumn.Name = "calificacion1DataGridViewTextBoxColumn";
            calificacion1DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacion2DataGridViewTextBoxColumn
            // 
            calificacion2DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_2";
            calificacion2DataGridViewTextBoxColumn.HeaderText = "Calificacion_2";
            calificacion2DataGridViewTextBoxColumn.Name = "calificacion2DataGridViewTextBoxColumn";
            calificacion2DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacion3DataGridViewTextBoxColumn
            // 
            calificacion3DataGridViewTextBoxColumn.DataPropertyName = "Calificacion_3";
            calificacion3DataGridViewTextBoxColumn.HeaderText = "Calificacion_3";
            calificacion3DataGridViewTextBoxColumn.Name = "calificacion3DataGridViewTextBoxColumn";
            calificacion3DataGridViewTextBoxColumn.Width = 142;
            // 
            // calificacionesBindingSource
            // 
            calificacionesBindingSource.DataSource = typeof(Calificaciones);
            // 
            // btn_RgistroCalificacionCerrar
            // 
            btn_RgistroCalificacionCerrar.Location = new Point(423, 362);
            btn_RgistroCalificacionCerrar.Name = "btn_RgistroCalificacionCerrar";
            btn_RgistroCalificacionCerrar.Size = new Size(111, 26);
            btn_RgistroCalificacionCerrar.TabIndex = 17;
            btn_RgistroCalificacionCerrar.Text = "Cerrar";
            btn_RgistroCalificacionCerrar.UseVisualStyleBackColor = true;
            btn_RgistroCalificacionCerrar.Click += btn_RgistroCalificacionCerrar_Click;
            // 
            // btn_RegistroCalificacionGuardar
            // 
            btn_RegistroCalificacionGuardar.Location = new Point(306, 362);
            btn_RegistroCalificacionGuardar.Name = "btn_RegistroCalificacionGuardar";
            btn_RegistroCalificacionGuardar.Size = new Size(111, 26);
            btn_RegistroCalificacionGuardar.TabIndex = 16;
            btn_RegistroCalificacionGuardar.Text = "Guardar";
            btn_RegistroCalificacionGuardar.UseVisualStyleBackColor = true;
            btn_RegistroCalificacionGuardar.Click += btn_RegistroCalificacionGuardar_Click;
            // 
            // formRegistroCalificiacion
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(845, 395);
            Controls.Add(btn_RgistroCalificacionCerrar);
            Controls.Add(btn_RegistroCalificacionGuardar);
            Controls.Add(gestionar_calificaciones);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formRegistroCalificiacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registros de Calificaciones";
            FormClosing += formRegistroCalificiacion_FormClosing;           
            ((System.ComponentModel.ISupportInitialize)gestionar_calificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)calificacionesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gestionar_calificaciones;
        private Button btn_RgistroCalificacionCerrar;
        private Button btn_RegistroCalificacionGuardar;
        private BindingSource calificacionesBindingSource;
        private DataGridViewTextBoxColumn calificacionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudianteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calificacion3DataGridViewTextBoxColumn;
    }
}
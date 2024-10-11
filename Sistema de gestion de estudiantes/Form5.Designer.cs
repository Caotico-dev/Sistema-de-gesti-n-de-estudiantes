namespace Sistema_de_gestion_de_estudiantes
{
    partial class FormRegistroEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroEstudiantes));
            btn_RegistroEstudianteGuardad = new Button();
            gestionar_Estudiantes = new DataGridView();
            estudianteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estudianteBindingSource = new BindingSource(components);
            btn_RegistroEstudianteCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gestionar_Estudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_RegistroEstudianteGuardad
            // 
            btn_RegistroEstudianteGuardad.Location = new Point(142, 302);
            btn_RegistroEstudianteGuardad.Name = "btn_RegistroEstudianteGuardad";
            btn_RegistroEstudianteGuardad.Size = new Size(111, 26);
            btn_RegistroEstudianteGuardad.TabIndex = 12;
            btn_RegistroEstudianteGuardad.Text = "Guardar";
            btn_RegistroEstudianteGuardad.UseVisualStyleBackColor = true;
            btn_RegistroEstudianteGuardad.Click += btn_RegistroEstudianteGuardad_Click;
            // 
            // gestionar_Estudiantes
            // 
            gestionar_Estudiantes.AutoGenerateColumns = false;
            gestionar_Estudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gestionar_Estudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gestionar_Estudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gestionar_Estudiantes.Columns.AddRange(new DataGridViewColumn[] { estudianteIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn });
            gestionar_Estudiantes.DataSource = estudianteBindingSource;
            gestionar_Estudiantes.Location = new Point(13, 4);
            gestionar_Estudiantes.Margin = new Padding(4);
            gestionar_Estudiantes.Name = "gestionar_Estudiantes";
            gestionar_Estudiantes.Size = new Size(366, 292);
            gestionar_Estudiantes.TabIndex = 10;
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
            nombreDataGridViewTextBoxColumn.Width = 93;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.Width = 99;
            // 
            // estudianteBindingSource
            // 
            estudianteBindingSource.DataSource = typeof(Estudiante);
            // 
            // btn_RegistroEstudianteCerrar
            // 
            btn_RegistroEstudianteCerrar.Location = new Point(259, 303);
            btn_RegistroEstudianteCerrar.Name = "btn_RegistroEstudianteCerrar";
            btn_RegistroEstudianteCerrar.Size = new Size(111, 26);
            btn_RegistroEstudianteCerrar.TabIndex = 13;
            btn_RegistroEstudianteCerrar.Text = "Cerrar";
            btn_RegistroEstudianteCerrar.UseVisualStyleBackColor = true;
            btn_RegistroEstudianteCerrar.Click += btn_RegistroEstudianteCerrar_Click;
            // 
            // FormRegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(387, 340);
            Controls.Add(btn_RegistroEstudianteCerrar);
            Controls.Add(btn_RegistroEstudianteGuardad);
            Controls.Add(gestionar_Estudiantes);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormRegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros de Estudiantes";
            FormClosing += FormRegistroEstudiantes_FormClosing;           
            ((System.ComponentModel.ISupportInitialize)gestionar_Estudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_RegistroEstudianteGuardad;
        private DataGridView gestionar_Estudiantes;
        private Button btn_RegistroEstudianteCerrar;
        private BindingSource estudianteBindingSource;
        private DataGridViewTextBoxColumn estudianteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
    }
}
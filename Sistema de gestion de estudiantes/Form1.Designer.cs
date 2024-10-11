namespace Sistema_de_gestion_de_estudiantes
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            label1 = new Label();
            btn_verregistros = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(505, 33);
            label1.TabIndex = 0;
            label1.Text = "Sistema de gestion de estudiantes.";         
            // 
            // btn_verregistros
            // 
            btn_verregistros.Location = new Point(208, 330);
            btn_verregistros.Name = "btn_verregistros";
            btn_verregistros.Size = new Size(121, 49);
            btn_verregistros.TabIndex = 3;
            btn_verregistros.Text = "Ver Registros";
            btn_verregistros.UseVisualStyleBackColor = true;
            btn_verregistros.Click += btn_verregistros_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.estudiantes_img;
            pictureBox1.Image = Properties.Resources.estudiantes_img;
            pictureBox1.Location = new Point(51, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(526, 391);
            Controls.Add(pictureBox1);
            Controls.Add(btn_verregistros);
            Controls.Add(label1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de gestion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_verregistros;
        private PictureBox pictureBox1;
    }
}

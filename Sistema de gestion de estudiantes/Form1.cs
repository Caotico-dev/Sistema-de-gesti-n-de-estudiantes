namespace Sistema_de_gestion_de_estudiantes
{
    public partial class FormInicio : System.Windows.Forms.Form
    {

        
       
        public FormInicio()
        {
            InitializeComponent();
        }

      

        private void btn_verregistros_Click(object sender, EventArgs e)
        {

            formRegistro formRegistro = new(this);

            // Ocultar el Form1
            this.Hide();

            // Mostrar el Form2
            formRegistro.Show();

                     

        }
      

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_estudiantes
{
    public partial class formRegistroCursos : System.Windows.Forms.Form
    {
        private formRegistro Registro;
        private ColegioContext? ColegioContext;
        public formRegistroCursos(formRegistro registro)
        {
            InitializeComponent();
            this.Registro = registro;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ColegioContext = new ColegioContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.ColegioContext.Database.EnsureCreated();
            this.ColegioContext.Cursos.Load();

            this.cursosBindingSource.DataSource = ColegioContext.Cursos.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.ColegioContext?.Dispose();
            this.ColegioContext = null;
        }

        private void btn_RegistroCursoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ColegioContext!.SaveChanges();
                this.gestionar_cursos.Refresh();
                MessageBox.Show("Estudiante registrado exito!");
            }
            catch (Exception)
            {
                MessageBox.Show($"Recuerda llenar todos los datos antes de guardar la informacion.");
            }
           
        }

        private void btn_RegistroEstudiantesCursoCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar esta ventana

            this.Registro.Show(); //Abrir La ventana anterior


        }      

        private void formRegistroCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Registro.Show(); //Mostrar ventana anterior
        }
      
    }
}

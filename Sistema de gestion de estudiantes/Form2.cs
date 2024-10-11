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
using static System.Windows.Forms.DataFormats;

namespace Sistema_de_gestion_de_estudiantes
{
    public partial class formRegistro : System.Windows.Forms.Form
    {
        //Propiedad del window form para guarda
        private FormInicio Form1;

        private ColegioContext? ColegioContext;

        public formRegistro(FormInicio form1)// Constructor
        {
            InitializeComponent();
            this.Form1 = form1; //Inicializador 


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ColegioContext = new ColegioContext();

            // Uncomment the line below to start fresh with a new database.
            //this.ColegioContext.Database.EnsureDeleted();
            this.ColegioContext.Database.EnsureCreated();
            this.ColegioContext.Estudiantes.Load();

            this.estudianteBindingSource.DataSource = ColegioContext.Estudiantes.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.ColegioContext?.Dispose();
            this.ColegioContext = null;
        }     

        private void formRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //no usar

            Form1.Show(); //Mostrar ventana anterior
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar esta ventana


            // Mostrar el Form1
            Form1.Show();

        }
        private void btn_AgregarCalificaciones_Click(object sender, EventArgs e)
        {
            formRegistroCalificiacion calificiaciones = new(this);

            this.Hide(); //Oculta

            calificiaciones.Show(); //Mostrar

        }

        private void btn_AgregarEstudiantes_Click(object sender, EventArgs e)
        {
            FormRegistroEstudiantes estudiantes = new(this);

            this.Hide(); //Ocultar ventana 

            estudiantes.Show(); //Mostrar ventana
        }

        private void btn_AgregarCursos_Click(object sender, EventArgs e)
        {
            formRegistroCursos cursos = new(this);

            this.Hide(); //Ocultar ventana

            cursos.Show(); //Mostrar ventana 
        }     

        private void visual_Estudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.ColegioContext != null)
            {
                try
                {
                    var estudiante = (Estudiante)this.visual_Estudiantes.CurrentRow.DataBoundItem;
                    if (estudiante != null)
                    {
                        this.ColegioContext.Entry(estudiante).Collection(c => c.Cursos).Load();
                        this.ColegioContext.Entry(estudiante).Collection(c => c.Calificaciones).Load();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Seleciona el Id que tiene registros.");
                }
                

               
            }
        }

     
    }
}

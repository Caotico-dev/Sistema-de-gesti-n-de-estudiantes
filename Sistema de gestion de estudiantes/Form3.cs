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
    public partial class formRegistroCalificiacion : System.Windows.Forms.Form
    {
        private formRegistro FormRegistro;
        private ColegioContext? ColegioContext;


        public formRegistroCalificiacion(formRegistro FormRegistro)
        {
            InitializeComponent();
            this.FormRegistro = FormRegistro;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ColegioContext = new ColegioContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.ColegioContext.Database.EnsureCreated();
            this.ColegioContext.Calificaciones.Load();

            this.calificacionesBindingSource.DataSource = ColegioContext.Calificaciones.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.ColegioContext?.Dispose();
            this.ColegioContext = null;
        }       

        private void btn_RgistroCalificacionCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar

            FormRegistro.Show(); // Mostrar

        }

     

        private void btn_RegistroCalificacionGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ColegioContext!.SaveChanges();
                this.gestionar_calificaciones.Refresh();
                MessageBox.Show("Calificación guardada con exito!");
            }
            catch (Exception)
            {
                MessageBox.Show("Recuerda llenar todos los datos antes de guardar");
            }
           
        }

        private void formRegistroCalificiacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormRegistro.Show(); //Mostrar ventana anterior
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
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
    public partial class FormRegistroEstudiantes : System.Windows.Forms.Form
    {
        private formRegistro FormRegistro;
        private ColegioContext? ColegioContext;
        public FormRegistroEstudiantes(formRegistro formRegistro)
        {
            InitializeComponent();

            this.FormRegistro = formRegistro;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ColegioContext = new ColegioContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
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

        private void btn_RegistroEstudianteGuardad_Click(object sender, EventArgs e)
        {
            try
            {
                this.ColegioContext!.SaveChanges();
                this.gestionar_Estudiantes.Refresh();
                MessageBox.Show("Estudiante registrado con exito!");
            }
            catch (Exception)
            {

                MessageBox.Show("Recuerda llenar todos los datos antes de guardar la información.");
            }
            
        }

        private void btn_RegistroEstudianteCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrar esta ventana

            FormRegistro.Show(); //Abrir la ventana anterior


        }      

        private void FormRegistroEstudiantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormRegistro.Show(); //Mostrar ventana anterior
        }
    }
}
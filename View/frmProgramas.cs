﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmProgramas : Form
    {
        public frmProgramas()
        {
            InitializeComponent();
            panelProgramas.Visible = false;         
            btnExit.Visible = false;
        }

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNPrograma np = new frmNPrograma();
            np.Show();
            this.Hide();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void frmProgramas_Load(object sender, EventArgs e)
        {
            this.dtProgramas.DataSource = CPrograma.Leer_Programa();
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            
            if(this.dtProgramas.SelectedRows.Count == 1)
            {
                
            }
        }
        public void AccionDeshabilitar()
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            panelProgramas.Visible = true;        
            btnExit.Visible = true;
            

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProgramas_Load_1(object sender, EventArgs e)
        {

        }
    }
}

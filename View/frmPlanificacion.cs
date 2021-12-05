﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBecas.View
{
    public partial class frmPlanificacion : Form
    {
        public frmPlanificacion()
        {
            InitializeComponent();
            panelPlanificación.Visible = false;
            btnExit.Visible = false;
        }

        private void frmPlanificacion_Load(object sender, EventArgs e)
        {

        }
        public void AccionDeshabilitar()
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            panelPlanificación.Visible = true;
            btnExit.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

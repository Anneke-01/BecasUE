using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Data;

namespace SistemaBecas.View
{
    public partial class frmNPlanificacion : Form
    {
        public frmNPlanificacion()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
        }

        private void frmNPlanificacion_Load(object sender, EventArgs e)
        {
            ListarPais();
            dtAnio.Format = DateTimePickerFormat.Custom;
            dtAnio.CustomFormat = "dd/MM/yyyy";
            dtApertura.Format = DateTimePickerFormat.Custom;
            dtApertura.CustomFormat = "dd/MM/yyyy";
            dtCierre.Format = DateTimePickerFormat.Custom;
            dtCierre.CustomFormat = "dd/MM/yyyy";
            dtCreación.Format = DateTimePickerFormat.Custom;
            dtCreación.CustomFormat = "dd/MM/yyyy";
            dtAprobado.Format = DateTimePickerFormat.Custom;
            dtAprobado.CustomFormat = "dd/MM/yyyy";
            
        }
        private void ListarPais()
        {
            DUsuario dPais = new DUsuario();
            cmbPais.DataSource = dPais.ListarPais();
            cmbPais.DisplayMember = "NombrePais";
            cmbPais.ValueMember = "IDPais";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }
    }
}

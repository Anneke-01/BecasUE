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
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmNPrograma : Form
    {
        public frmNPrograma()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtTituloPrograma.Text == "" || cmbTipoEspecialidad.SelectedItem == null || txtCreditos.Text == "" || txtDiplomados.Text == "" || txtDuracion.Text == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CPrograma.Insertar_Programa(txtTituloPrograma.Text, cmbTipoEspecialidad.SelectedItem.ToString(),int.Parse(txtCreditos.Text),int.Parse(txtDiplomados.Text),txtDuracion.Text);
                txtTituloPrograma.Text = "";
                cmbTipoEspecialidad.Text = "";
                txtDiplomados.Text = "";
                txtCreditos.Text = "";
                txtDuracion.Text = "";

                MessageBox.Show("Se agregó un nuevo programa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPrograma_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloPrograma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiplomados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

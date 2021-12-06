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
    public partial class frmNUniversidad : Form
    {
        public frmNUniversidad()
        {
            InitializeComponent();
            ListarPais();
            ListarCiudad();
        }
        private void ListarPais()
        {
            DUsuario dPais = new DUsuario();
            cmbPais.DataSource = dPais.ListarPais();
            cmbPais.DisplayMember = "NombrePais";
            cmbPais.ValueMember = "IDPais";

        }
        private void ListarCiudad()
        {
            DCiudad dc = new DCiudad();
            cmbCiudad.DataSource = dc.Listar_Ciudad();
            cmbCiudad.DisplayMember = "NombreCiudad";
            cmbCiudad.ValueMember = "IDCiudad";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtNombreU.Text == "" || txtDir.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos de oferta.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CUniversidad.Insertar_Universidad(txtNombreU.Text, int.Parse(cmbCiudad.SelectedValue.ToString()), txtTel.Text, int.Parse(cmbPais.SelectedValue.ToString()), txtDir.Text);
                MessageBox.Show("Se agregó una nueva universidad.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreU.Text = "";
                txtDir.Text = "";
                txtTel.Text = "";
            }
        }

        private void frmNUniversidad_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

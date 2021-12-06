using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Controller;
using SistemaBecas.Data;

namespace SistemaBecas.View
{
    public partial class frmVerUsuarios1 : Form
    {
        int IdUser;
        public frmVerUsuarios1(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;

        }

        private void frmVerUsuarios1_Load(object sender, EventArgs e)
        {
            this.dtViewUsuarios.DataSource = CUsuario.ListarUsuarios();
        }

      

        private void txtBuscarUsuario_Click(object sender, EventArgs e)
        { 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtViewUsuarios.DataSource = CUsuario.Buscar_Usuario(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dtViewUsuarios.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dtViewUsuarios.CurrentRow.Cells["IDUsuario"].Value);
                frmVerUsuarios1 fr = new frmVerUsuarios1(id);
                //fr.Show();
                MessageBox.Show("Se cambió", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Seleccione al menos una fila", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

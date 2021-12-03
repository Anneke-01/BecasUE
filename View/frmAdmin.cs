using System;
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
    public partial class frmAdmin : Form
    {
        int IdUser;
        public frmAdmin(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;
            disfracesDiseño();
        }
        public void loadform(Object Form)
        {
            if(this.panelprincipal.Controls.Count > 0)
            {
                this.panelprincipal.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(f);
            this.panelprincipal.Tag = f;
            f.Show();
        }
        private void disfracesDiseño()
        {
            panelSubMenuVer.Visible = false;
            panelSubmenuOfertas.Visible = false;
        }
        private void esconderSubmenu()
        {
            if(panelSubMenuVer.Visible == true)
            {
                panelSubMenuVer.Visible = false;
            }
            
            if(panelSubmenuOfertas.Visible == true)
            {
                panelSubmenuOfertas.Visible = false;
            }
        }
        private void mostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                esconderSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmInicioSesion fi = new frmInicioSesion();
            fi.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrearPrograma_Click(object sender, EventArgs e)
        {
            loadform(new frmProgramas());
            
        }

        private void btnverP_Click(object sender, EventArgs e)
        {
            loadform(new frmProgramas());
            esconderSubmenu();
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubmenuOfertas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
        }

        private void btnCrearP_Click(object sender, EventArgs e)
        {

        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuVer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            esconderSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            loadform(new frmVisualizarCandidatos());
        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            loadform(new frmNuevoUser());
        }

        private void btnCrearPlanificacion_Click(object sender, EventArgs e)
        {
            loadform(new frmNPlanificacion());
        }
    }
}

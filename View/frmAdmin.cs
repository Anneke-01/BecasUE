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
            panelUsuarios.Visible = false;
            panelSubmenuOfertas.Visible = false;
        }
        private void esconderSubmenu()
        {
            if (panelUsuarios.Visible == true)
            {
                panelUsuarios.Visible = false;
            }

            if (panelSubmenuOfertas.Visible == true)
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

        

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubmenuOfertas);
        }

   

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            loadform(new frmNuevoUser());
            esconderSubmenu();
        }

        private void btnVerUser_Click(object sender, EventArgs e)
        {
            loadform(new frmVerUsuarios1());
            esconderSubmenu();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelUsuarios);
        }

        private void btnVerOfertas_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            loadform(new frmNuevoUser());
            esconderSubmenu();
        }

        private void btnVerUser_Click_1(object sender, EventArgs e)
        {
            loadform(new frmVerUsuarios1());
            esconderSubmenu();
        }

        private void btnCrearOferta_Click(object sender, EventArgs e)
        {
            loadform(new frmOfertas());
            esconderSubmenu();
        }

        private void btnUniversidad_Click(object sender, EventArgs e)
        {
            loadform(new frmVerUniversidades());
        }

        private void btnPlanificación_Click(object sender, EventArgs e)
        {
            loadform(new frmPlanificacion());

        }
    }
}

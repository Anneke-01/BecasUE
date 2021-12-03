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
    public partial class frmEstudiante : Form
    {
        int IdUser, IdCandidato;
        public frmEstudiante(int idUser, int idCandidato)
        {
            InitializeComponent();
            IdUser = idUser;
            IdCandidato = idCandidato;
            disfracesDiseño();
        }

        
        public void loadform(Object Form)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(f);
            this.panelPrincipal.Tag = f;
            f.Show();
        }
        private void disfracesDiseño()
        {
            subMenuPerfil.Visible = false;

        }
        private void esconderSubmenu()
        {
            if (subMenuPerfil.Visible == true)
            {
                subMenuPerfil.Visible = false;
            }

        }
        private void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

   
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            loadform(new frmPerfilEstudiante(IdUser, IdCandidato));
            mostrarSubmenu(subMenuPerfil);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAcademic_Click(object sender, EventArgs e)
        {
        //    mostrarSubmenu(subMenuPerfil);
        }
        private void btnLaboral_Click(object sender, EventArgs e)
        {
            loadform(new frmFormularioEstudianteVista(IdUser,IdCandidato));
            esconderSubmenu();

        }

        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            loadform(new frmCambiarContraseña(IdUser));
            mostrarSubmenu(subMenuPerfil);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmInicioSesion fi = new frmInicioSesion();
            fi.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            loadform(new frmOfertasDisponibles());
        }
    }
}

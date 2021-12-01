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
using SistemaBecas.View;

namespace SistemaBecas
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            TipoUsuario.SelectedIndex = 0;
        }
        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "" || TipoUsuario.SelectedItem == null)
            {
                
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DataTable dato = CUsuario.Validar_Acceso(this.txtUsuario.Text, this.txtContraseña.Text, this.TipoUsuario.SelectedItem.ToString());
                if (dato.Rows.Count > 0)
                {
                    DataRow dr = dato.Rows[0];
                    if (dr["Resultado"].ToString() == "Acceso Exitoso")
                    {
                        //MessageBox.Show("Bienvenido al Sistema", "Sistema de Becas", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                        frmMessageBoxOk ok = new frmMessageBoxOk();
                        ok.Show();
                        this.Hide();
                        if (TipoUsuario.SelectedItem.ToString() == "Estudiante")
                        {

                            //frmEstudiante fc = new frmEstudiante();
                            //fc.Show();
                            //this.Hide();
                        }
                        else
                        {
                            frmAdmin fa = new frmAdmin();
                            fa.Show();
                            this.Hide();
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                    }
                }

            }
        }
       
       

        private void TipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text == "" || txtContraseña.Text == "" || TipoUsuario.SelectedItem == null)
                {
                    MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dato = CUsuario.Validar_Acceso(this.txtUsuario.Text, this.txtContraseña.Text, this.TipoUsuario.SelectedItem.ToString());
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr = dato.Rows[0];
                        if (dr["Resultado"].ToString() == "Acceso Exitoso")
                        {
                            //MessageBox.Show("Bienvenido al Sistema", "Sistema de Becas", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                            frmMessageBoxOk ok = new frmMessageBoxOk();
                            ok.Show();
                            this.Hide();
                            if (TipoUsuario.SelectedItem.ToString() == "Estudiante")
                            {

                                frmEstudiante fc = new frmEstudiante();
                                fc.Show();
                                this.Hide();
                            }
                            else
                            {
                                frmAdmin fa = new frmAdmin();
                                fa.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text == "" || txtContraseña.Text == "" || TipoUsuario.SelectedItem == null)
                {
                    MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dato = CUsuario.Validar_Acceso(this.txtUsuario.Text, this.txtContraseña.Text, this.TipoUsuario.SelectedItem.ToString());
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr = dato.Rows[0];
                        if (dr["Resultado"].ToString() == "Acceso Exitoso")
                        {
                            //MessageBox.Show("Bienvenido al Sistema", "Sistema de Becas", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                            frmMessageBoxOk ok = new frmMessageBoxOk();
                            ok.Show();
                            this.Hide();
                            if (TipoUsuario.SelectedItem.ToString() == "Estudiante")
                            {

                                frmEstudiante fc = new frmEstudiante();
                                fc.Show();
                                this.Hide();
                            }
                            else
                            {
                                frmAdmin fa = new frmAdmin();
                                fa.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void nums(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            MessageBox.Show("Solo se puede rellenar con numeros. ", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static void letras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.Handled = false;
            MessageBox.Show("Solo se puede rellenar con letras. ", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

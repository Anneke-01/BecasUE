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

namespace SistemaBecas.View
{
    public partial class frmFormularioEstudianteVista : Form
    {
        int IdUser, IdCandidato, Id;
        public frmFormularioEstudianteVista(int idUser, int idCandidato)
        {
            IdUser = idUser;
            IdCandidato = idCandidato;
           
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dtHistoAC.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dtHistoAC.CurrentRow.Cells["ID"].Value);
                string Titulo = Convert.ToString(this.dtHistoAC.CurrentRow.Cells["Título Obtenido"].Value);
                DateTime fechaInicio = Convert.ToDateTime(this.dtHistoAC.CurrentRow.Cells["Fecha de Inicio"].Value);
                DateTime fechafin = Convert.ToDateTime(this.dtHistoAC.CurrentRow.Cells["Finalización"].Value);
                frmHistorialAcadémico fm = new frmHistorialAcadémico(IdUser, IdCandidato, id, Titulo,fechaInicio,fechafin);
                fm.ShowDialog();
                
                this.dtHistoAC.DataSource = CCandidato.Listar_HistorialAC(IdCandidato);

            }
            else
            {
                MessageBox.Show("Seleccione al menos una fila", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmHistorialAcadémico fa = new frmHistorialAcadémico(IdUser,IdCandidato);
            fa.ShowDialog();
            this.dtHistoAC.DataSource = CCandidato.Listar_HistorialAC(IdCandidato);
        }

        private void btnAgregarl_Click(object sender, EventArgs e)
        {
            frmHistorialLaboral fl = new frmHistorialLaboral(IdUser, IdCandidato);
            fl.ShowDialog();
            this.dtHistLab.DataSource = CCandidato.Listar_HistorialLab(IdCandidato);
        }

        private void btnCancelarl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtHistoAC.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(this.dtHistoAC.CurrentRow.Cells["ID"].Value);
                Console.WriteLine(id);
                CCandidato.Eliminar_HistorialAC(id);
                MessageBox.Show("Se eliminó correctamente.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtHistoAC.DataSource = CCandidato.Listar_HistorialAC(IdCandidato);

            }
            else
            {
                MessageBox.Show("Seleccione al menos una fila", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarl_Click(object sender, EventArgs e)
        {
            if (dtHistLab.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dtHistLab.CurrentRow.Cells["ID"].Value);
                Console.WriteLine(id);
                CCandidato.Eliminar_HistorialLab(id);
                MessageBox.Show("Se eliminó correctamente.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtHistLab.DataSource = CCandidato.Listar_HistorialLab(IdCandidato);

            }
            else
            {
                MessageBox.Show("Seleccione al menos una fila", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarl_Click(object sender, EventArgs e)
        {
            if (dtHistLab.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dtHistLab.CurrentRow.Cells["ID"].Value);
                string puesto = Convert.ToString(this.dtHistLab.CurrentRow.Cells["Puesto"].Value);
                string entidad = Convert.ToString(this.dtHistLab.CurrentRow.Cells["Entidad"].Value);
                DateTime fechainicio = Convert.ToDateTime(this.dtHistLab.CurrentRow.Cells["Fecha de Inicio"].Value);
                DateTime fechafin = Convert.ToDateTime(this.dtHistLab.CurrentRow.Cells["Finalización"].Value);
                frmHistorialLaboral fm = new frmHistorialLaboral(IdUser, IdCandidato, id, puesto,entidad,fechainicio, fechafin);
                fm.ShowDialog();
                
                this.dtHistLab.DataSource = CCandidato.Listar_HistorialLab(IdCandidato);

            }
            else
            {
                MessageBox.Show("Seleccione al menos una fila", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFormularioEstudianteVista_Load(object sender, EventArgs e)
        {
            
            this.dtHistoAC.DataSource = CCandidato.Listar_HistorialAC(IdCandidato);
            this.dtHistLab.DataSource = CCandidato.Listar_HistorialLab(IdCandidato);
            
        }
    }
}

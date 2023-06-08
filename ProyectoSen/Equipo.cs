using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvCliente);
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWithEllipse,
          int nHeightEllipse
               );
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.SelecionEquipo(dgvEquipo, txtId,txtDni, cmbTipoE, txtMarca, txtDescripcion,lblFecha,lblHora);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.modificarEquipo(txtId,txtDni, cmbTipoE, txtMarca, txtDescripcion,lblFecha ,lblHora);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.guardarEquipo(txtDni,cmbTipoE, txtMarca, txtDescripcion,lblFecha,lblHora);   
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.DeleteEquipo(txtId);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.ResetEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.BuscarDni(dgvEquipo,txtDni);
            
        }


        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }



        private void SelectT_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.guardarReporte(txtTecnico,txtDni,txtMarca);
        }

        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionUnCliente(dgvCliente,txtDni);


        }

        private void dgvTecnico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.SelecionUnTecnico(dgvCliente, txtTecnico);
        }

        private void Equipo_Load(object sender, EventArgs e)
        {

            IntPtr region = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region3, true);

            IntPtr region4 = CreateRoundRectRgn(0, 0, SelectT.Width, SelectT.Height, 30, 30);
            SetWindowRgn(SelectT.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 30, 30);
            SetWindowRgn(btnReset.Handle, region5, true);
        }
    }
}

using AgenciaAutomotriz.Gestion;
using AgenciaAutomotriz.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaAutomotriz.Formularios
{
    public partial class PanelFrom : Form
    {
        AutomovilCRUD clase = new AutomovilCRUD();
        Operaciones xOperaciones = new Operaciones();

        AddAutomovilForm frmAutomovil = new AddAutomovilForm();
        AddLoginForm frmLogin = new AddLoginForm();
        MovimientoForm frmMovimiento = new MovimientoForm();
        public PanelFrom()
        {
            InitializeComponent();

        }

        private void PanelFrom_Load(object sender, EventArgs e)
        {
            Recargar();
        }

        private void dgvAutomoviles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sss = (sender as Automovil);            
        }

        private Login login;

        public Login CurrentLogin
        {
            get { return login; }
            set { login = value; }
        }

        void isLogged()
        {
            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }

        void Recargar()
        {
            List<Automovil> datos = new List<Automovil>();
            dgvAutomoviles.DataSource = null;

            datos = clase.Read();
            dgvAutomoviles.DataSource = datos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAutomovil.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAutomovil.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int automovilID = 0;
            clase.Eliminar(automovilID);
            Recargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Automovil> datos = new List<Automovil>();
            dgvAutomoviles.DataSource = null;

            datos = xOperaciones.ConsultarPorColor(txtColor.Text);

            dgvAutomoviles.DataSource = datos;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int automovilId = (dgvAutomoviles.CurrentRow.DataBoundItem as Automovil).Id;
            MovimientoForm movimientoForm = new MovimientoForm();
            movimientoForm.Tipo = "Entrada";
            movimientoForm.IdAutomovil = automovilId;
            movimientoForm.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            int automovilId = (dgvAutomoviles.CurrentRow.DataBoundItem as Automovil).Id;
            MovimientoForm movimientoForm = new MovimientoForm();
            movimientoForm.Tipo = "Salida";
            movimientoForm.IdAutomovil = automovilId;
            movimientoForm.ShowDialog();
        }
    }
}


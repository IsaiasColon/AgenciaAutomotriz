using AgenciaAutomotriz.Gestion;
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
    public partial class MovimientoForm : Form
    {
        Operaciones clase = new Operaciones();
        public MovimientoForm()
        {
            InitializeComponent();
        }

        private int idAutomovil;
        public int IdAutomovil
        {
            get { return idAutomovil; }
            set { idAutomovil = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private void MovimientoForm_Load(object sender, EventArgs e)
        {
            ActualizarTipo();
        }

        void ActualizarTipo()
        {
            if (Tipo == "Entrada")
            {
                lblTipo.Text = "(- Entrada -)";
            }
            else
            {
                lblTipo.Text = "(- Salida -)";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clase.AgregarMovimiento(Tipo, IdAutomovil, int.Parse(txtCantidad.Text));
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

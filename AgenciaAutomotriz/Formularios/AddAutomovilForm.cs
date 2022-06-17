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
    public partial class AddAutomovilForm : Form
    {
        AutomovilCRUD clase = new AutomovilCRUD();
        public AddAutomovilForm()
        {
            InitializeComponent();
        }

        private int idAutomovil;
        public int IdAutomovil
        {
            get { return idAutomovil; }
            set { idAutomovil = value; }
        }

        private void AddAutomovilForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clase.Agregar(txtMarca.Text, txtModelo.Text, txtTipo.Text, txtColor.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

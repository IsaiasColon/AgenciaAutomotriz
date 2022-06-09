using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaAutomotriz.Formularios;
using AgenciaAutomotriz.Gestion;

namespace AgenciaAutomotriz
{
    public partial class Form1 : Form
    {
        PanelFrom panel = new PanelFrom();
        Operaciones clase = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool login = clase.IniciarSesion(txtUsuario.Text, txtPassword.Text);
            if (login)
            {
                panel.ShowDialog();
                //main.CurrentLogin = login;
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

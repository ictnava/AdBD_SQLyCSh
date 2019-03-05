using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_CS_SQLS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /*Evento generado al dar clic en el botón empleados del menu*/
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados fEmpleados = new FormEmpleados();
            fEmpleados.ShowDialog();
        }

        private void servicios(object sender, EventArgs e)
        {
            Servicios  fServicios= new Servicios();
            fServicios.ShowDialog();
        }

        private void clientes(object sender, EventArgs e)
        {
            Clientes fClientes = new Clientes();
            fClientes.ShowDialog();
        }

        private void materiales(object sender, EventArgs e)
        {
            Materiales fMateriales = new Materiales();
            fMateriales.ShowDialog();
        }
    }

}


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
    }
}

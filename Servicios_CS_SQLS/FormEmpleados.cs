using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servicios_CS_SQLS
{
    public partial class FormEmpleados : Form
    {
        private Empleado empleado;
        

        public FormEmpleados()
        {
            InitializeComponent();
            dataGridView1.DataSource = llenaTabla();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            empleado = new Empleado();
            empleado.nombres = tBNombres.Text;
            empleado.appaterno = tBApPat.Text;
            empleado.apmaterno = tBApMat.Text;
            empleado.email = tBEmail.Text;
            empleado.tipo = cBTipo.Text;
            empleado.genero = cBGenero.Text;
            empleado.fechaNacimiento = dTPFechaNac.Value;

            if(empleado.insertateBD(empleado.nombres, empleado.appaterno, empleado.apmaterno, empleado.email, empleado.tipo,
                empleado.genero, empleado.fechaNacimiento) > 0)
            {
                MessageBox.Show("Empleado dado de alta");
                limpiaDatagrid();
                limpiaControles();
            }
            else
            {
                MessageBox.Show("Falló la inserción");
            }
        }

        /*Método para llenar la tabla con toda la información*/
        public List<Empleado> llenaTabla()
        {
            List<Empleado> lista = new List<Empleado>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM  Persona.Empleado"), conn);
            SqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                Empleado emp = new Empleado();
                emp.idEmpleado = reader.GetInt64(0);
                emp.nombres = reader.GetString(1);
                emp.appaterno = reader.GetString(2);
                emp.apmaterno = reader.GetString(3);
                emp.email = reader.GetString(4);
                emp.tipo = reader.GetString(5);
                emp.genero = reader.GetString(6);
                emp.fechaNacimiento = reader.GetDateTime(7);
                lista.Add(emp);
            }
            cn.cierraConexionBD();

            return (lista);
        }

        /*Evento para impedir que se reordenen los valores en el datagridView*/
        private void dataGridView1_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /*Método para limpiar el datagridView*/
        public void limpiaDatagrid()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = llenaTabla();

        }

        /*Método para limpiar los controles del formulario*/
        public void limpiaControles()
        {
            tBNombres.Clear();
            tBApPat.Clear();
            tBApMat.Clear();
            tBEmail.Clear();
            cBGenero.SelectedIndex = -1;
            cBTipo.SelectedIndex = -1;
            dTPFechaNac.Value = DateTime.Now;
        }

        /*Recupera la información del empleado seleccionado*/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                empleado = new Empleado();

                empleado.idEmpleado = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                empleado.nombres = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                empleado.appaterno = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                empleado.apmaterno = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                empleado.email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                empleado.tipo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                empleado.genero = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                empleado.fechaNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                habilitaBotones();
                llenaControlesEmpleado();
            }

        }

        /*Método para habilitar los botones de baja y modificación*/
        public void habilitaBotones()
        {
            btBaja.Enabled = true;
            btModificar.Enabled = true;

        }

        /*Método para deshabilitar los botones de baja y modificación*/
        public void deshabilitaBotones()
        {
            btBaja.Enabled = false;
            btModificar.Enabled = false;

        }

        /*Método para llenar los controles con la información del empleado actual*/
        public void llenaControlesEmpleado()
        {
            tBNombres.Text = empleado.nombres;
            tBApPat.Text = empleado.appaterno;
            tBApMat.Text = empleado.apmaterno;
            tBEmail.Text = empleado.email;
            cBTipo.SelectedItem = empleado.tipo;
            cBGenero.SelectedItem = empleado.genero;
            dTPFechaNac.Value = empleado.fechaNacimiento;
        }

        /*Evento producido al dar clic en el botón baja*/
        private void btBaja_Click(object sender, EventArgs e)
        {
            if(empleado.eliminateBD(empleado.idEmpleado) > 0)
            {
                MessageBox.Show("Empleado eliminado");
                limpiaDatagrid();
                limpiaControles();
                deshabilitaBotones();
            }
            else
            {
                MessageBox.Show("Fallo la eliminación");
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            empleado.nombres = tBNombres.Text;
            empleado.appaterno = tBApPat.Text;
            empleado.apmaterno = tBApMat.Text;
            empleado.email = tBEmail.Text;
            empleado.tipo = cBTipo.Text;
            empleado.genero = cBGenero.Text;
            empleado.fechaNacimiento = dTPFechaNac.Value;

            if (empleado.actualizateBD(empleado.idEmpleado,empleado.nombres, empleado.appaterno, empleado.apmaterno, empleado.email, 
                empleado.tipo, empleado.genero, empleado.fechaNacimiento) > 0)
            {
                MessageBox.Show("Se actualizó correctamente");
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }

            limpiaControles();
            limpiaDatagrid();
            deshabilitaBotones();
        }
    }
}

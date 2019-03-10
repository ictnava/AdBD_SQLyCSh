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
    public partial class FormCliente : Form
    {
        private Cliente cliente;

        public FormCliente()
        {
            InitializeComponent();
            dataGridView1.DataSource = llenaTabla();
        }

        /*Método para mostrar el resto de los controles si se trata de un cliente facultad*/
        public void muestraCFacultad()
        {
            labelC1.Text = "Carrera: ";
            labelC2.Text = "Asignatura: ";
            labelC1.Visible = true;
            labelC2.Visible = true;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        /*Método para mostrar el resto de los controles si se trata de un cliente uaslp*/
        public void muestraCUASLP()
        {
            labelC1.Text = "Departamento: ";
            labelC2.Text = "Asignatura: ";
            labelC1.Visible = true;
            labelC2.Visible = true;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        /*Método para mostrar el resto de los controles si se trata de un cliente externo*/
        public void muestraCExterno()
        {
            labelC1.Text = "Empresa: ";
            labelC2.Text = "RFC: ";
            labelC1.Visible = true;
            labelC2.Visible = true;
            textBox1.MaxLength = 100;
            textBox2.MaxLength = 15;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        /*Evento producido al seleccionar un distinto cliente*/
        private void cBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBTipo.SelectedIndex != -1)
            {
                if (cBTipo.Items[cBTipo.SelectedIndex].ToString() == "Facultad")
                {
                    muestraCFacultad();
                }
                else if (cBTipo.Items[cBTipo.SelectedIndex].ToString() == "UASLP")
                {
                    muestraCUASLP();
                }
                else if (cBTipo.Items[cBTipo.SelectedIndex].ToString() == "Externo")
                {
                    muestraCExterno();
                }
            }
            else
            {
                labelC1.Visible = false;
                labelC2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        /*Método para llenar la tabla con toda la información*/
        public List<Cliente> llenaTabla()
        {
            List<Cliente> lista = new List<Cliente>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM  Persona.Cliente"), conn);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente cli = new Cliente();
                cli.idCliente = reader.GetInt64(0);
                cli.nombres = reader.GetString(1);
                cli.appaterno = reader.GetString(2);
                cli.apmaterno = reader.GetString(3);
                cli.email = reader.GetString(4);
                cli.telefono = reader.GetString(5);
                cli.tipo = reader.GetString(6);
                
                if(cli.tipo == "Facultad")
                {
                    Conexion cn2 = new Conexion();
                    SqlConnection conn2 = cn2.ConectaBD();
                    SqlCommand comando2 = new SqlCommand(string.Format("SELECT carrera, asignatura FROM Persona.ClienteFacultad " +
                                                                        "WHERE idCliente=" + "'{0}'", cli.idCliente), conn2);
                    SqlDataReader reader2 = comando2.ExecuteReader();
                    while(reader2.Read())
                    {
                        cli.carrera = reader2.GetString(0);
                        cli.asignatura = reader2.GetString(1);
                    }
                    cn2.cierraConexionBD();
                }
                else if(cli.tipo == "UASLP")
                {
                    Conexion cn2 = new Conexion();
                    SqlConnection conn2 = cn2.ConectaBD();
                    SqlCommand comando2 = new SqlCommand(string.Format("SELECT departamento, asignatura FROM Persona.ClienteUASLP " +
                                                                        "WHERE idCliente=" + "'{0}'", cli.idCliente), conn2);
                    SqlDataReader reader2 = comando2.ExecuteReader();
                    while (reader2.Read())
                    {
                        cli.departamento = reader2.GetString(0);
                        cli.asignatura = reader2.GetString(1);
                    }
                    cn2.cierraConexionBD();
                }
                else if(cli.tipo == "Externo")
                {
                    Conexion cn2 = new Conexion();
                    SqlConnection conn2 = cn2.ConectaBD();
                    SqlCommand comando2 = new SqlCommand(string.Format("SELECT empresa, rfc FROM Persona.ClienteExterno " +
                                                                        "WHERE idCliente=" + "'{0}'", cli.idCliente), conn2);
                    SqlDataReader reader2 = comando2.ExecuteReader();
                    while (reader2.Read())
                    {
                        cli.empresa = reader2.GetString(0);
                        cli.rfc = reader2.GetString(1);
                    }
                    cn2.cierraConexionBD();
                }

                lista.Add(cli);
            }
            cn.cierraConexionBD();

            return (lista);
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente.nombres = tBNombres.Text;
            cliente.appaterno = tBApPat.Text;
            cliente.apmaterno = tBApMat.Text;
            cliente.telefono = tBTelef.Text;
            cliente.email = tBEmail.Text;
            cliente.tipo = cBTipo.Text;
            
            if(cliente.insertateBD(cliente.nombres, cliente.appaterno, cliente.apmaterno, cliente.email, cliente.telefono, cliente.tipo) > 0)
            {
                if(cliente.tipo == "Facultad")
                {
                    if(cliente.insertaCFacultad(cliente.idCliente, textBox1.Text, textBox2.Text) > 0)
                    {
                        MessageBox.Show("Cliente dado de alta");
                    }
                    else
                    {
                        MessageBox.Show("Fallo al insertar");
                    }
                }
                else if (cliente.tipo == "UASLP")
                {
                    if (cliente.insertaCUASLP(cliente.idCliente, textBox1.Text, textBox2.Text) > 0)
                    {
                        MessageBox.Show("Cliente dado de alta");
                    }
                    else
                    {
                        MessageBox.Show("Fallo al insertar");
                    }
                }
                else if (cliente.tipo == "Externo")
                {
                    if (cliente.insertaCExterno(cliente.idCliente, textBox1.Text, textBox2.Text) > 0)
                    {
                        MessageBox.Show("Cliente dado de alta");
                    }
                    else
                    {
                        MessageBox.Show("Fallo al insertar");
                    }
                }

                limpiaDatagrid();
                limpiaControles();
            }
            else
            {
                MessageBox.Show("Fallo al insertar");
            }
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
            tBTelef.Clear();
            textBox1.Clear();
            textBox2.Clear();
            cBTipo.SelectedIndex = -1;
        }

        /*Evento producido para evitar que el usuario ordene la información*/
        private void dataGridView1_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}

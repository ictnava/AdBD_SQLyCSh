using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Servicios_CS_SQLS
{
    public class Conexion
    {
        private String serverName = "DESKTOP-GC8TVRE\\SQLSERVER";
        private String nombreBD = "CCIM";
        private SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection("Data Source=" + serverName + "; Initial Catalog=" + nombreBD + ";Integrated Security=True");
        }

        public SqlConnection ConectaBD()
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexion Correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex.ToString());
            }

            return (conexion);
        }

        public void cierraConexionBD()
        {
            try
            {
                conexion.Close();
                //MessageBox.Show("Conexion cerrada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al cerrar conexion: " + ex.ToString());
            }
        }
    }
}

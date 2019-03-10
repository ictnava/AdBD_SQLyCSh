using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Servicios_CS_SQLS
{
    public class Cliente
    {
        /*Declaración de variables*/
        private Int64 IdCliente;
        public Int64 idCliente { get { return (IdCliente); } set { IdCliente = value; } }
        private String Nombres;
        public String nombres { get { return (Nombres); } set { Nombres = value; } }
        private String ApPaterno;
        public String appaterno { get { return (ApPaterno); } set { ApPaterno = value; } }
        private String APMaterno;
        public String apmaterno { get { return (APMaterno); } set { APMaterno = value; } }
        private String Email;
        public String email { get { return (Email); } set { Email = value; } }
        private String Telefono;
        public String telefono { get { return (Telefono); } set { Telefono = value; } }
        private String Tipo;
        public String tipo { get { return (Tipo); } set { Tipo = value; } }
        private String Carrera;
        public String carrera { get { return (Carrera); } set { Carrera = value; } }
        private String Asignatura;
        public String asignatura { get { return (Asignatura); } set { Asignatura = value; } }
        private String Departamento;
        public String departamento { get { return (Departamento); } set { Departamento = value; } }
        private String Empresa;
        public String empresa { get { return (Empresa); } set { Empresa = value; } }
        private String RFC;
        public String rfc { get { return (RFC); } set { RFC = value; } }

        public Cliente()
        {

        }

        /*Método para insertar un cliente*/
        public int insertateBD(String nom, String apPat, String apMat, String correo, String telefono, String ti)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Persona.Cliente(nombres, apellidoPaterno, apellidoMaterno, email, telefono, tipo)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", nom, apPat, apMat, correo, telefono, ti), sqc);
            resp = comando.ExecuteNonQuery();
            /*Después de ser insertado, extraer que id contiene*/
            comando = new SqlCommand(string.Format("SELECT SCOPE_IDENTITY()"), sqc);
            SqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            //idCliente = reader.GetInt64(0);
            idCliente = Convert.ToInt64(reader.GetValue(0));
            con.cierraConexionBD();

            return (resp);
        }

        /*Método para insertar un cliente de tipo facultad*/
        public int insertaCFacultad(Int64 id, String carr, String asigna)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Persona.ClienteFacultad(idCliente, carrera, asignatura)" +
                "Values('{0}', '{1}', '{2}')", id, carr, asigna), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }

        /*Método para insertar un cliente de tipo uaslp*/
        public int insertaCUASLP(Int64 id, String dep, String asigna)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Persona.ClienteUASLP(idCliente, departamento, asignatura)" +
                "Values('{0}', '{1}', '{2}')", id, dep, asigna), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }

        /*Método para insertar un cliente externo*/
        public int insertaCExterno(Int64 id, String empr, String rf)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Persona.ClienteExterno(idCliente, empresa, rfc)" +
                "Values('{0}', '{1}', '{2}')", id, empr, rf), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }
    }
}

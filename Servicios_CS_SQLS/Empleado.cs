using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Servicios_CS_SQLS
{
    public class Empleado
    {
        /*Declaración de los atributos de la clase*/
        private Int64 IdEmpleado;
        public Int64 idEmpleado { get { return (IdEmpleado); } set { IdEmpleado = value; } }
        private String Nombres;
        public String nombres { get { return (Nombres); } set { Nombres = value; } }
        private String ApPaterno;
        public String appaterno { get { return (ApPaterno); } set { ApPaterno = value; } }
        private String APMaterno;
        public String apmaterno { get { return (APMaterno); } set { APMaterno = value; } }
        private String Email;
        public String email { get { return (Email); } set { Email = value; } }
        private String Tipo;
        public String tipo { get { return (Tipo); } set { Tipo = value; } }
        private String Genero;
        public String genero { get { return (Genero); } set { Genero = value; } }
        private DateTime FechaNacimiento;
        public DateTime fechaNacimiento { get { return (FechaNacimiento); } set { FechaNacimiento = value; } }

        public Empleado(/*Int64 id, String nom, String apPat, String apMat, String correo, String ti, String gen, DateTime fecha*/)
        {
            /*IdEmpleado = id;
            Nombres = nom;
            ApPaterno = apPat;
            APMaterno = apMat;
            Email = correo;
            Tipo = ti;
            Genero = gen;
            FechaNacimiento = fecha;*/
        }

        public int insertateBD(String nom, String apPat, String apMat, String correo, String ti, String gen, DateTime fecha)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Persona.Empleado(nombres, apellidoPaterno, apellidoMaterno, email, tipo, genero, fechaNacimiento)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", nom, apPat, apMat, correo, ti, gen, fecha.Date.ToString("yyyy-MM-dd")), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }

        public int actualizateBD(Int64 id, String nom, String apPat, String apMat, String correo, String ti, String gen, DateTime fecha)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Persona.Empleado SET nombres=" + "'{0}'" + ",apellidoPaterno=" + "'{1}'" + 
                                ",apellidoMaterno=" + "'{2}'" + ",email=" + "'{3}'" + ",tipo=" + "'{4}'" + 
                                ",genero=" + "'{5}'" +  ",fechaNacimiento=" + "'{6}'" +"WHERE idEmpleado=" + "'{7}'"
                                , nom, apPat, apMat, correo, ti, gen, fecha.Date.ToString("yyyy-MM-dd"), id), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }

        public int eliminateBD(Int64 id)
        {
            int resp = 0;

            Conexion con = new Conexion();
            SqlConnection sqc = con.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("DELETE FROM Persona.Empleado WHERE idEmpleado=" + "'{0}'", id), sqc);
            resp = comando.ExecuteNonQuery();
            con.cierraConexionBD();

            return (resp);
        }
    }
}

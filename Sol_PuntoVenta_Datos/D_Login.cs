using Sol_PuntoVenta.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Datos
{
    public class D_Login
    {
        public DataTable Acceder_us(string cLogin_us, string cPassword_us)
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Acceder_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = cLogin_us;
                Comando.Parameters.Add("@cPassword_us", SqlDbType.VarChar).Value = cPassword_us;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
        public string Registrar_us(string cLogin_us, string cPassword_us,string cNombre_us,int nCodigo_ca, int nCodigo_ro)
        {

            string Rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Registrar_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = cLogin_us;
                Comando.Parameters.Add("@cPassword_us", SqlDbType.VarChar).Value = cPassword_us;
                Comando.Parameters.Add("@cNombre_us", SqlDbType.VarChar).Value = cNombre_us;
                Comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = nCodigo_ca;
                Comando.Parameters.Add("@nCodigo_ro", SqlDbType.Int).Value = nCodigo_ro;
                SqlCon.Open();
 
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
        public DataTable Listado_ro(string cTexto)
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
        public DataTable Listado_car(string cTexto)
        {
            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_car", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

    }
}

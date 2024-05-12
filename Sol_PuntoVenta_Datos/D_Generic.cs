using Sol_PuntoVenta.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Datos
{
    public class D_Generic
    {
        public DataTable Retorna_consulta(string UspName, SqlParameter[] SqlParams)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand(UspName, SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                if (SqlParams != null)
                {
                    for (int i = 0; i < SqlParams.Length; i++)
                    {
                        Comando.Parameters.Add(SqlParams[i]);
                    }
                }

                SQLCon.Open();

                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open)
                {
                    SQLCon.Close();
                }
            }
        }
        public string Envia_Consulta(string UspName, SqlParameter[] SqlParams, string error)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand(UspName, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                if (SqlParams != null)
                {
                    for (int i = 0; i < SqlParams.Length; i++)
                    {
                        Comando.Parameters.Add(SqlParams[i]);
                    }
                }

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : error;
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
        public byte[] Retorna_imagen(string UspName, SqlParameter[] SqlParams)
        {
            Byte[] bImagen = new byte[0];

            SqlDataReader Resultado;

            DataTable Tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand(UspName, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                if (SqlParams != null)
                {
                    for (int i = 0; i < SqlParams.Length; i++)
                    {
                        Comando.Parameters.Add(SqlParams[i]);
                    }
                }
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                bImagen = (byte[])Tabla.Rows[0][0];
                return bImagen;
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


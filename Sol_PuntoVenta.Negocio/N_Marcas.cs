﻿using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Marcas
    {
        private static string error = "";
        public static DataTable Listado_ma(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_ma", SqlParams);
        }

        public static string Guardar_ma(int nOpcion, E_Generic oPropiedad)
        {
            SqlParameter[] SqlParams = new SqlParameter[3];
            SqlParams[0] = new SqlParameter("@nOpcion", SqlDbType.Int);
            SqlParams[0].Value = nOpcion;
            SqlParams[1] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[1].Value = oPropiedad.Codigo;
            SqlParams[2] = new SqlParameter("@cDescripcion", SqlDbType.VarChar);
            SqlParams[2].Value = oPropiedad.Descripcion;
            error = "No se pudo guardar el elemento";
            D_Generic Datos = new D_Generic();
            return Datos.Envia_Consulta("USP_Guardar_ma", SqlParams,error);
        }

        public static string Eliminar_ma(int nCodigo)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@nCodigo", SqlDbType.Int);
            SqlParams[0].Value = nCodigo;
            D_Generic Datos = new D_Generic();
            error = "No se pudo eliminar el elemento";
            return Datos.Envia_Consulta("USP_Eliminar_ma", SqlParams,error);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Datos;

namespace Sol_PuntoVenta.Negocio
{
    public class N_SubFamilias
    {
        public static DataTable Listado_sf(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_sf", SqlParams);
        }

        public static string Guardar_sf(int nOpcion, E_SubFamilias oPropiedad)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Guardar_sf(nOpcion, oPropiedad);
        }

        public static string Eliminar_sf(int nCodigo)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Eliminar_sf(nCodigo);
        }
        public static DataTable Listado_fa(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_fa", SqlParams);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Cierres_Turnos
    {
        public static string Abrir_turno(string cFecha_ct,int nCodigo_pv, int nCodigo_tu)
        {
            D_Cierres_Turnos Datos = new D_Cierres_Turnos();
            return Datos.Abrir_Turno(cFecha_ct, nCodigo_pv, nCodigo_tu);
        }
        public static string Cerrar_turno(string cFecha_ct, int nCodigo_pv, int nCodigo_tu)
        {
            D_Cierres_Turnos Datos = new D_Cierres_Turnos();
            return Datos.Cerrar_turno(cFecha_ct, nCodigo_pv, nCodigo_tu);
        }
        public static DataTable Listado_pv(string cTexto)
        {
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@cTexto", SqlDbType.VarChar);
            SqlParams[0].Value = cTexto;
            D_Generic Datos = new D_Generic();
            return Datos.Retorna_consulta("USP_Listado_pv", SqlParams);
        }
        public static DataTable Estado_gestion_turno_pv(int nCodigo_pv)
        {
            D_Cierres_Turnos Datos = new D_Cierres_Turnos();
            return Datos.Estado_gestion_turno_pv(nCodigo_pv);
        }
    }
}

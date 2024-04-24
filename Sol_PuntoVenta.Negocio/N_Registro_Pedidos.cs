﻿using Sol_PuntoVenta.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Registro_Pedidos
    {
        public static DataTable Listado_pv(string cTexto)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Listado_pv(cTexto);
        }
        public static DataTable Estado_turno_pv(int nCodigo_pv)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Estado_turno_pv(nCodigo_pv);
        }
        public static DataTable Mostrar_me_rp(int nCodigo_pv)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Mostrar_me_rp(nCodigo_pv);
        }
        public static Byte[] Imagen_estado_me(int nEstado)
        {
            D_Registro_Pedidos Datos = new D_Registro_Pedidos();
            return Datos.Imagen_estado_me(nEstado);
        }
    }
}

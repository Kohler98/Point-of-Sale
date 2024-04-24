using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Procesos
{
    public partial class Frm_Mesa_Abierta : Form
    {
        #region "Variables"
        private int nCodigo_cl = 0;
        #endregion

        #region "Variables para Generar Comandas"
        private int x1Codigo_ti;
        private string x1Impresora;
        private string x1Descripcion_pv;
        private string x1Fecha_emision;
        private string x1Descripcion_tu;
        private string x1Nombre_us;
        private string x1Descripcion_ca;
        private string x1Descripcion_me;
        private string x1Cliente;
        private string x1Nrodocumento_cl;
        private string x1Observacionanulado_ti;

        public int X1Codigo_ti { get => x1Codigo_ti; set => x1Codigo_ti = value; }
        public string X1Impresora { get => x1Impresora; set => x1Impresora = value; }
        public string X1Descripcion_pv { get => x1Descripcion_pv; set => x1Descripcion_pv = value; }
        public string X1Fecha_emision { get => x1Fecha_emision; set => x1Fecha_emision = value; }
        public string X1Descripcion_tu { get => x1Descripcion_tu; set => x1Descripcion_tu = value; }
        public string X1Nombre_us { get => x1Nombre_us; set => x1Nombre_us = value; }
        public string X1Descripcion_ca { get => x1Descripcion_ca; set => x1Descripcion_ca = value; }
        public string X1Descripcion_me { get => x1Descripcion_me; set => x1Descripcion_me = value; }
        public string X1Cliente { get => x1Cliente; set => x1Cliente = value; }
        public string X1Nrodocumento_cl { get => x1Nrodocumento_cl; set => x1Nrodocumento_cl = value; }
        public string X1Observacionanulado_ti { get => x1Observacionanulado_ti; set => x1Observacionanulado_ti = value; }
        #endregion

        #region "Variables y Propiedades"
        DataTable TableDetalle = new DataTable();
        private int _Codigo_pr1;
        private string _Descripcion_pr1;
        private string _Precio_unitario_pr1;
        private string _Impresora;
        private Image _Imagen_pr1;
        private string _Archivo_txt1;
        public int Codigo_pr1 { get => _Codigo_pr1; set => _Codigo_pr1 = value; }
        public string Descripcion_pr1 { get => _Descripcion_pr1; set => _Descripcion_pr1 = value; }
        public string Precio_unitario_pr1 { get => _Precio_unitario_pr1; set => _Precio_unitario_pr1 = value; }
        public string Impresora { get => _Impresora; set => _Impresora = value; }
        public Image Imagen_pr1 { get => _Imagen_pr1; set => _Imagen_pr1 = value; }
        public string Archivo_txt1 { get => _Archivo_txt1; set => _Archivo_txt1 = value; }




        #endregion

        #region "Metodos"
        private void EnabledButtons(bool enabled)
        {
            Btn_reimprimir_comanda.Enabled = enabled;
            Btn_dividir_precuenta.Enabled = enabled;
            Btn_anular_pedido.Enabled = enabled;
            Btn_generar_boleta.Enabled = enabled;
            Btn_generar_factura.Enabled = enabled;
            Btn_emitir_documento.Enabled = enabled;
        }
        #endregion

        #region "Metodo de llenado de datos"
        private void LlenarListadoProductos(FlowLayoutPanel Contenedor)
        {
            Contenedor.Controls.Clear();
            int nCodigo_pv, nCodigo_sf;
            byte[] bImagen = new byte[0];
            DataTable Tabla1 = new DataTable();

            nCodigo_pv = Convert.ToInt32(Lbl_codigo_pv.Text);
            nCodigo_sf = Convert.ToInt32(Dgv_Listado_productos.CurrentRow.Cells["codigo_sf"].Value);

            Tabla1 = N_Mesa_Abierta.Listar_Productos_Sf_Rp(nCodigo_pv, nCodigo_sf);

            if(Tabla1.Rows.Count  > 0)
            {
                for(int i = 0; i < Tabla1.Rows.Count; i++)
                {
                    Codigo_pr1 = Convert.ToInt32(Tabla1.Rows[i][0]);
                    Descripcion_pr1 = Convert.ToString(Tabla1.Rows[i][1]);
                    Precio_unitario_pr1 = Convert.ToString(Tabla1.Rows[i][2]);
                    bImagen = (byte[])Tabla1.Rows[i][3];
                    MemoryStream ms = new MemoryStream(bImagen);
                    Imagen_pr1 = Image.FromStream(ms);

                    Impresora = Convert.ToString(Tabla1.Rows[i][4]);
                    Archivo_txt1 = Lbl_archivo_txt.Text.Trim();
                    // creamos el control porductos para cargar en el layout

                    Controles.MiProducto oProducto = new Controles.MiProducto();
                    oProducto.Codigo_pr = Codigo_pr1;
                    oProducto.Descripcion_pr = Descripcion_pr1;
                    oProducto.Preciounitario_pr = Precio_unitario_pr1;
                    oProducto.Imagen_pr = Imagen_pr1;
                    oProducto.Impresora = Impresora.Trim();
                    oProducto.Archivo_txt = Archivo_txt1;

                    // añadimos el control producto al layout
                    Contenedor.Controls.Add(oProducto);
                    
                }
            }
        }

        private void Crear_TablaDetalle()
        {
            TableDetalle = new DataTable("TablaDetalles");
            TableDetalle.Columns.Add("Descripcion_pr",System.Type.GetType("System.String"));
            TableDetalle.Columns.Add("Preciounitario_pr",System.Type.GetType("System.Decimal"));
            TableDetalle.Columns.Add("Cantidad",System.Type.GetType("System.String"));
            TableDetalle.Columns.Add("Total",System.Type.GetType("System.Decimal"));
            TableDetalle.Columns.Add("Obs", System.Type.GetType("System.String"));
            TableDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            TableDetalle.Columns.Add("Impresora", System.Type.GetType("System.String"));

            Dgv_detalle.DataSource = TableDetalle;

            Dgv_detalle.Columns[0].Width = 160;
            Dgv_detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_detalle.Columns[1].Width = 75;
            Dgv_detalle.Columns[1].HeaderText = "P.UNIT";
            Dgv_detalle.Columns[2].Width = 75;
            Dgv_detalle.Columns[2].HeaderText = "CANTIDAD";
            Dgv_detalle.Columns[3].Width = 75;
            Dgv_detalle.Columns[3].HeaderText = "TOTAL BS/.";
            Dgv_detalle.Columns[4].Width = 40;
            Dgv_detalle.Columns[4].HeaderText = "OBS";
            Dgv_detalle.Columns[5].Visible = false;
            Dgv_detalle.Columns[6].Visible = false;

        } 

        private void Agregar_item(string cDescripcion_pr,
                                  string cPreciounitario_pr,
                                  string cCantidad,
                                  string cTotal,
                                  string cObs,
                                  int nCodigo_pr,
                                  string cImpresora)
        {
            DataRow Fila = TableDetalle.NewRow();
            Fila["Descripcion_pr"] = cDescripcion_pr;
            Fila["Preciounitario_pr"] = cPreciounitario_pr;
            Fila["Cantidad"] = cCantidad;
            Fila["Total"] = cTotal;
            Fila["Obs"] = cObs;
            Fila["Codigo_pr"] = nCodigo_pr;
            Fila["Impresora"] = cImpresora;

            TableDetalle.Rows.Add( Fila );  
        }


        #endregion

        #region "Metodo para busqueda rapida de productos"
        private void Formato_busqueda_pr()
        {
            Dgv_Listado_pr.Columns[0].Width = 250;
            Dgv_Listado_pr.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Listado_pr.Columns[1].Width = 60;
            Dgv_Listado_pr.Columns[1].HeaderText = "P.UNIT";
            Dgv_Listado_pr.Columns[2].Width = 250;
            Dgv_Listado_pr.Columns[2].HeaderText = "SUBFAMILIA";
            Dgv_Listado_pr.Columns[3].Visible = false;
            Dgv_Listado_pr.Columns[4].Visible = false;
        }

        private void Busqueda_rapida_pr(string cTexto)
        {
            try
            {
                Dgv_Listado_pr.DataSource = N_Mesa_Abierta.Busqueda_rapida_pr(cTexto);
                Formato_busqueda_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_busqueda_pr()
        {
            string bDescripcion_pr;
            string bPreciounitario_pr;
            int bCodigo_pr;
            string bImpresora;

            bDescripcion_pr = Convert.ToString(Dgv_Listado_pr.CurrentRow.Cells["descripcion_pr"].Value);
            bPreciounitario_pr = Convert.ToString(Dgv_Listado_pr.CurrentRow.Cells["precio_unitario"].Value);
            bCodigo_pr = Convert.ToInt32(Dgv_Listado_pr.CurrentRow.Cells["codigo_pr"].Value);
            bImpresora = Convert.ToString(Dgv_Listado_pr.CurrentRow.Cells["impresora"].Value);

            Agregar_item(bDescripcion_pr, bPreciounitario_pr, "1.00", bPreciounitario_pr, "", bCodigo_pr, bImpresora);

            TableDetalle.AcceptChanges();

            const int nColumn = 3;
            decimal nSuma = 0;
            foreach (DataGridViewRow item in Dgv_detalle.Rows)
            {
                nSuma += Convert.ToDecimal(item.Cells[nColumn].Value);
            }
            Lbl_total.Text = Convert.ToString(nSuma);

        }
        #endregion

        #region "Metodo para busqueda rapida de clientes"
        private void Formato_busqueda_cliente()
        {
            Dgv_listado_cl.Columns[0].Width = 50;
            Dgv_listado_cl.Columns[0].HeaderText = "TIPO DOC";
            Dgv_listado_cl.Columns[1].Width = 80;
            Dgv_listado_cl.Columns[1].HeaderText = "NRO DOC";
            Dgv_listado_cl.Columns[2].Width = 250;
            Dgv_listado_cl.Columns[2].HeaderText = "CLIENTE";
            Dgv_listado_cl.Columns[3].Visible = false;
 
        }

        private void Busqueda_rapida_cl(string cTexto)
        {
            try
            {
                Dgv_listado_cl.DataSource = N_Mesa_Abierta.Busqueda_cl(cTexto);
                Formato_busqueda_cliente();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_busqueda_cl()
        {

            Txt_doc_identidad.Text = Convert.ToString(Dgv_listado_cl.CurrentRow.Cells["nrodocumento_cl"].Value);
            Txt_cliente.Text = Convert.ToString(Dgv_listado_cl.CurrentRow.Cells["cliente"].Value);
            nCodigo_cl = Convert.ToInt32(Dgv_listado_cl.CurrentRow.Cells["codigo_cl"].Value);

        }
        #endregion

        #region "Imprimir Comanda"
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();
            Font Font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font Font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font Font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int Anchor = 250;
            int Larger = 20;

            e.Graphics.DrawString($"Comanda Ticket # {X1Codigo_ti}", Font1, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Punto de Venta {X1Descripcion_pv}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Fecha emision {X1Fecha_emision}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Turno {X1Descripcion_tu}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Usuario: {X1Nombre_us}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Cargo: {x1Descripcion_ca}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"N° Mesa: {X1Descripcion_me}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Cliente: {x1Cliente}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Nro. Doc: {X1Nrodocumento_cl}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"--------- PRODUCTOS --------", Font2, Brushes.Black, new RectangleF(0, Larger += 30, Anchor, 20));
            //Paso a imprimir detalle de la comanda
            TablaImprimir = N_Mesa_Abierta.Imprimir_comanda(x1Codigo_ti, x1Impresora);
            if (TablaImprimir.Rows.Count > 0)
            {
                for (int i = 0; i < TablaImprimir.Rows.Count; i++)
                {
                    e.Graphics.DrawString($"{TablaImprimir.Rows[i][0]} " +
                                          $"{TablaImprimir.Rows[i][1]} " 
                                         , 
                                          Font3, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
                    // observacion por cada producto
                    string yObs = $"{TablaImprimir.Rows[i][2]}";

                    if (yObs.Length > 0)
                    {
                        e.Graphics.DrawString($"|-> {yObs} ",
                                              Font3, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
                    }
                    //fin de la observacion
                }
                //fin de comanda por impresora
            }

        }
        private void ReImprimir(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();
            Font Font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font Font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font Font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int Anchor = 250;
            int Larger = 20;

            e.Graphics.DrawString($"Anulacion de cuenta", Font1, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Comanda Ticket # {X1Codigo_ti}", Font1, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Motivo {x1Observacionanulado_ti}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 50));
            e.Graphics.DrawString($"Punto de Venta {X1Descripcion_pv}", Font2, Brushes.Black, new RectangleF(0, Larger += 50, Anchor, 20));
            e.Graphics.DrawString($"Fecha emision {X1Fecha_emision}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Turno {X1Descripcion_tu}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Usuario: {X1Nombre_us}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Cargo: {x1Descripcion_ca}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"N° Mesa: {X1Descripcion_me}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Cliente: {x1Cliente}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Nro. Doc: {X1Nrodocumento_cl}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"Obs: {X1Observacionanulado_ti}", Font2, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
            e.Graphics.DrawString($"--------- PRODUCTOS --------", Font2, Brushes.Black, new RectangleF(0, Larger += 30, Anchor, 20));
            //Paso a imprimir detalle de la comanda
            TablaImprimir = N_Mesa_Abierta.Imprimir_comanda(x1Codigo_ti, x1Impresora);
            if (TablaImprimir.Rows.Count > 0)
            {
                for (int i = 0; i < TablaImprimir.Rows.Count; i++)
                {
                    e.Graphics.DrawString($"{TablaImprimir.Rows[i][0]} " +
                                          $"{TablaImprimir.Rows[i][1]} "
                                         ,
                                          Font3, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
                    // observacion por cada producto
                    string yObs = $"{TablaImprimir.Rows[i][2]}";

                    if (yObs.Length > 0)
                    {
                        e.Graphics.DrawString($"|-> {yObs} ",
                                              Font3, Brushes.Black, new RectangleF(0, Larger += 20, Anchor, 20));
                    }
                    //fin de la observacion
                }
                //fin de comanda por impresora
            }

        }
        #endregion

        #region "Mostrar los tickets de la Mesa"
        private void Formato_tickets()
        {
            Dgv_tickets.Columns[0].Width = 100;
            Dgv_tickets.Columns[0].Visible = false;
            Dgv_tickets.Columns[0].ReadOnly = true;
            Dgv_tickets.Columns[1].Width = 100;
            Dgv_tickets.Columns[1].HeaderText = "CODIGO TI";
            Dgv_tickets.Columns[2].Width = 240;
            Dgv_tickets.Columns[2].HeaderText = "CLIENTE";
            Dgv_tickets.Columns[2].ReadOnly = true;
            Dgv_tickets.Columns[3].Width = 120;
            Dgv_tickets.Columns[3].HeaderText = "FECHA EMISION";
            Dgv_tickets.Columns[3].ReadOnly = true;
            Dgv_tickets.Columns[4].Width = 120;
            Dgv_tickets.Columns[4].HeaderText = "TOTAL S/.";
            Dgv_tickets.Columns[4].ReadOnly = true;
            Dgv_tickets.Columns[5].Visible = false;
            Dgv_tickets.Columns[6].Visible = false;
        }

        private void Mostrar_Tickets_Mesa()
        {
            try
            {
                Dgv_tickets.DataSource = N_Mesa_Abierta.Mostrar_Tickets_Mesa(Convert.ToInt32(Lbl_codigo_me.Text));
                Formato_tickets();
                Lbl_total_tickets.Text = $"Total Nro. Tickets x mesa: {Dgv_tickets.Rows.Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        #region "Mostrar el detalle del ticket seleccionado"
        private void Formato_detalle_ticket()
        {
            Dgv_detalle_tickets.Columns[0].Width = 220;
            Dgv_detalle_tickets.Columns[0].HeaderText = "PRODUCTO";
            Dgv_detalle_tickets.Columns[1].Width = 75;
            Dgv_detalle_tickets.Columns[1].HeaderText = "P.UNIT";
            Dgv_detalle_tickets.Columns[2].Width = 75;
            Dgv_detalle_tickets.Columns[2].HeaderText = "CANTIDAD";
            Dgv_detalle_tickets.Columns[3].Width = 75;
            Dgv_detalle_tickets.Columns[3].HeaderText = "TOTAL";
            Dgv_detalle_tickets.Columns[4].Width = 40;
            Dgv_detalle_tickets.Columns[4].HeaderText = "OBS";
            Dgv_detalle_tickets.Columns[5].Visible = false;
            Dgv_detalle_tickets.Columns[6].Visible = false;
            Dgv_detalle_tickets.Columns[7].Visible = false;
        }

        private void Selecciona_detalle_ticket()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tickets.CurrentRow.Cells["codigo_ti"].Value)))
            {
                MessageBox.Show("Seleccione un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Pnl_detalles_tickets.Visible = true;
                int xCodigo_ti = Convert.ToInt32(Dgv_tickets.CurrentRow.Cells["codigo_ti"].Value);
                Txt_cliente_detalle_ticket.Text = Convert.ToString(Dgv_tickets.CurrentRow.Cells["cliente"].Value);
                Txt_documento_detalle_ticket.Text = Convert.ToString(Dgv_tickets.CurrentRow.Cells["nrodocumento_cl"].Value);
                Txt_tickets_seleccionados.Text = Convert.ToString(Dgv_tickets.CurrentRow.Cells["codigo_ti"].Value);
                Lbl_total_detalles_tickets.Text = Convert.ToString(Dgv_tickets.CurrentRow.Cells["total_ti"].Value);
                Dgv_detalle_tickets.DataSource = N_Mesa_Abierta.Mostrar_ticket(xCodigo_ti);
                Formato_detalle_ticket();
            }
        }
        #endregion
        public Frm_Mesa_Abierta()
        {
            InitializeComponent();
        }

        private void Dgv_Listado_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarListadoProductos(Flp_listado_productos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Mesa_Abierta_Load(object sender, EventArgs e)
        {
            tbc_principal.Controls["tabPage1"].Enabled = false;
            tbc_principal.Controls["tabPage2"].Enabled = false;
            Crear_TablaDetalle();
        }

        private void Btn_nuevo_pedido_Click(object sender, EventArgs e)
        {
            tbc_principal.Controls["tabPage1"].Enabled = true;
            tbc_principal.Controls["tabPage2"].Enabled = false;
            tbc_principal.SelectedIndex = 0;
            timer1.Enabled = true;
        }

        private void Btn_visualizar_pedido_Click(object sender, EventArgs e)
        {
            Mostrar_Tickets_Mesa();
            tbc_principal.Controls["tabPage1"].Enabled = false;
            tbc_principal.Controls["tabPage2"].Enabled = true;
            tbc_principal.SelectedIndex = 1;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "0";
        }

        private void Btn_c_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt") == true)
            {
                string xDescripcion_pr;
                string xPreciounitario_pr;
                string xcodigo_pr;
                string xImpresora;
                StreamReader leer = new StreamReader(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt");

                xDescripcion_pr = leer.ReadLine();
                xPreciounitario_pr = leer.ReadLine();
                xcodigo_pr = leer.ReadLine();
                xImpresora = leer.ReadLine();
                leer.Close();
                File.Delete(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt");
                Agregar_item(xDescripcion_pr.Substring(15,xDescripcion_pr.Length-15),
                            xPreciounitario_pr.Substring(18, xPreciounitario_pr.Length - 18),
                            "1.00",
                            xPreciounitario_pr.Substring(18, xPreciounitario_pr.Length- 18),
                            "",
                            Convert.ToInt32(xcodigo_pr.Substring(10,xcodigo_pr.Length-10)),
                            xImpresora.Substring(10, xImpresora.Length - 10)
                            );
                TableDetalle.AcceptChanges();

                const int nColumn = 3;
                decimal nSuma = 0;
                foreach(DataGridViewRow item in Dgv_detalle.Rows)
                {
                    nSuma += Convert.ToDecimal(item.Cells[nColumn].Value);
                }
                Lbl_total.Text = Convert.ToString(nSuma);

            }
        }

        private void Btn_actualizar_cantidad_Click(object sender, EventArgs e)
        {
            if (Dgv_detalle.SelectedRows.Count > 0 && Lbl_cantidad.Text.Length > 0 )
            {
                DataGridViewRow nFila = Dgv_detalle.CurrentRow;
                if (nFila ==null)
                {
                    return;
                }
                nFila.Cells["Cantidad"].Value = " "+Lbl_cantidad.Text+".00";
                nFila.Cells["Total"].Value = Convert.ToString(Convert.ToDecimal(nFila.Cells["Preciounitario_pr"].Value) * Convert.ToDecimal(Lbl_cantidad.Text));
                TableDetalle.AcceptChanges();
                const int nColumn = 3;
                decimal nSuma = 0;
                foreach (DataGridViewRow item in Dgv_detalle.Rows)
                {
                    nSuma += Convert.ToDecimal(item.Cells[nColumn].Value);
                }
                Lbl_total.Text = Convert.ToString(nSuma);
                Lbl_cantidad.Text = "";
            }
        }

        private void Btn_quitar_producto_Click(object sender, EventArgs e)
        {
            if(Dgv_detalle.SelectedRows.Count > 0)
            {
                Dgv_detalle.Rows.Remove(Dgv_detalle.CurrentRow);
                TableDetalle.AcceptChanges();
                const int nColumn = 3;
                decimal nSuma = 0;
                foreach (DataGridViewRow item in Dgv_detalle.Rows)
                {
                    nSuma += Convert.ToDecimal(item.Cells[nColumn].Value);
                }
                Lbl_total.Text = Convert.ToString(nSuma);
                Lbl_cantidad.Text = "";
            }
        }

        private void Dgv_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_detalle.SelectedRows.Count>0)
            {
                DataGridViewRow nFila2 = Dgv_detalle.CurrentRow;

                if (nFila2 == null)
                {
                    return;
                }

                Txt_observacion.Text = Convert.ToString(nFila2.Cells["Obs"].Value);
                Dgv_detalle.Enabled = false;
                Pnl_observacion.Visible = true;
                Txt_observacion.Focus();

            }
        }

        private void Btn_retornar_obs_Click(object sender, EventArgs e)
        {
            if (Dgv_detalle.SelectedRows.Count > 0)
            {
                DataGridViewRow nFila2 = Dgv_detalle.CurrentRow;

                if (nFila2 == null)
                {
                    return;
                }
                nFila2.Cells["Obs"].Value = Txt_observacion.Text.Trim();
                TableDetalle.AcceptChanges();
                Pnl_observacion.Visible = false;
                Dgv_detalle.Enabled = true;
            }
        }

        private void Btn_busqueda_rapida_Click(object sender, EventArgs e)
        {
            Pnl_busqueda_pr.Visible = true;
            Pnl_busqueda_pr.Location = Btn_8.Location;
        }

        private void Btn_retornar_pr_Click(object sender, EventArgs e)
        {
            Pnl_busqueda_pr.Visible = false;

        }

        private void Btn_buscar_pr_Click(object sender, EventArgs e)
        {
            Busqueda_rapida_pr(Txt_buscar_pr.Text.Trim());
        }

        private void Dgv_Listado_pr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pasar el producto seleccionado al detalle principal
            Selecciona_dgv_busqueda_pr();
            Pnl_busqueda_pr.Visible = false;
        }

        private void Btn_lupa_cl_Click(object sender, EventArgs e)
        {
            Pnl_buscar_cl.Location = Chk_manual.Location;
            Pnl_buscar_cl.Visible = true;
        }

        private void Btn_retornar_cl_Click(object sender, EventArgs e)
        {
            Pnl_buscar_cl.Visible = false;
        }

        private void Btn_buscar_cl_Click(object sender, EventArgs e)
        {
            Busqueda_rapida_cl(Txt_buscar_cl.Text.Trim());
        }


        private void Dgv_listado_cl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_dgv_busqueda_cl();
            Pnl_buscar_cl.Visible = false;
        }

        private void Chk_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_manual.Checked == true)
            {
                Txt_cliente.ReadOnly = false;
                Txt_doc_identidad.ReadOnly = false;
                Txt_cliente.Focus();
            }
            else
            {
                nCodigo_cl = 0;
                Txt_cliente.Text = "";
                Txt_doc_identidad.Text = "";
                Txt_cliente.ReadOnly = true;
                Txt_doc_identidad.ReadOnly = true;
            }
        }

        private void Btn_generar_comanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_cliente.Text.Trim() == string.Empty || Lbl_total.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", 
                                    "Aviso del sistema", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
                else
                {
                    DataTable TablaImpresora = new DataTable();
                    E_Registro_Pedidos oErp = new E_Registro_Pedidos();
                    oErp.Fecha_emision = Lbl_fecha_trabajo.Text.Trim();
                    oErp.Codigo_cl = nCodigo_cl;
                    oErp.Nrodocumento_cl = Txt_doc_identidad.Text.Trim();
                    oErp.Cliente = Txt_cliente.Text.Trim();
                    oErp.Codigo_me = Convert.ToInt32(Lbl_codigo_me.Text.Trim());
                    oErp.Total_ti = Convert.ToDecimal(Lbl_total.Text.Trim());
                    oErp.Codigo_tu = Convert.ToInt32(Lbl_codigo_tu.Text.Trim());
                    oErp.Codigo_us = 1;
                    TableDetalle.AcceptChanges();
                    TablaImpresora = N_Mesa_Abierta.Guardar_RP(oErp,TableDetalle);

                    if (TablaImpresora.Rows.Count > 0)
                    {
                        #region "Impresion de Comandas"
                        // En esta posicion lanzamos la impresion de comandas a ticketeras
                        for (int i = 0; i < TablaImpresora.Rows.Count; i++)
                        {
                            x1Impresora = Convert.ToString(TablaImpresora.Rows[i][0]);
                            x1Codigo_ti = Convert.ToInt32(TablaImpresora.Rows[i][1]);
                            x1Descripcion_pv = Convert.ToString(TablaImpresora.Rows[i][2]);
                            X1Fecha_emision = Convert.ToString(TablaImpresora.Rows[i][3]);
                            X1Descripcion_tu = Convert.ToString(TablaImpresora.Rows[i][4]);
                            X1Nombre_us = Convert.ToString(TablaImpresora.Rows[i][5]);
                            x1Descripcion_ca = Convert.ToString(TablaImpresora.Rows[i][6]);
                            x1Descripcion_me = Convert.ToString(TablaImpresora.Rows[i][7]);
                            X1Cliente = Convert.ToString(TablaImpresora.Rows[i][8]);
                            x1Nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[i][9]);

                            //creacion del printdocumentt para la comanda
                            printDocument1 = new System.Drawing.Printing.PrintDocument();
                            printDocument1.PrinterSettings.PrinterName = x1Impresora.Trim();
                            printDocument1.PrintPage += Imprimir;
                            printDocument1.Print();
                             
                        }
                        // fin de la impresion de comandas 
                        #endregion
                        MessageBox.Show("Pedido generado correctamente",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Txt_cliente.Text = "";
                        Txt_doc_identidad.Text = "";
                        Chk_manual.Checked = false;
                        Lbl_cantidad.Text = "";
                        Lbl_total.Text = "";
                        TableDetalle.Clear();
                        TableDetalle.AcceptChanges();
                        timer1.Enabled = false;
                        tbc_principal.Controls["TabPage1"].Enabled = false;
                        tbc_principal.Controls["TabPage2"].Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Comanda no generada, verifique el detalle del pedido",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Dgv_tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_detalle_ticket();
        }

        private void Btn_reimprimir_comanda_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si tiene permisos administrador para realizar dicha tarea
                Frm_DashBoard oFrm_DB = new Frm_DashBoard();
                int xCodigo_us = oFrm_DB.pCodigo_us;
                int xResp = 0;
                DataTable TablaTemp_admin = new DataTable();
                TablaTemp_admin = N_Mesa_Abierta.Usuario_Admin(xCodigo_us);
                xResp = Convert.ToInt32(TablaTemp_admin.Rows[0][0]);
                if (xResp > 0) 
                {
                    // se evaluara lo siguiente para reimprimir la comanda
                    DataTable TablaImpresora = new DataTable();
                    TablaImpresora = N_Mesa_Abierta.Remprimir_comanda(Convert.ToInt32(Txt_tickets_seleccionados.Text));
                    if (TablaImpresora.Rows.Count > 0)
                    {
                        // se lanza la impresion de comanda a las ticketeras
                        for (int i = 0; i < TablaImpresora.Rows.Count; i++)
                        {
                            x1Impresora = Convert.ToString(TablaImpresora.Rows[i][0]);
                            x1Codigo_ti = Convert.ToInt32(TablaImpresora.Rows[i][1]);
                            x1Descripcion_pv = Convert.ToString(TablaImpresora.Rows[i][2]);
                            x1Fecha_emision = Convert.ToString(TablaImpresora.Rows[i][3]);
                            x1Descripcion_tu = Convert.ToString(TablaImpresora.Rows[i][4]);
                            X1Nombre_us = Convert.ToString(TablaImpresora.Rows[i][5]);
                            X1Descripcion_ca = Convert.ToString(TablaImpresora.Rows[i][6]);
                            x1Descripcion_me = Convert.ToString(TablaImpresora.Rows[i][7]);
                            x1Cliente = Convert.ToString(TablaImpresora.Rows[i][8]);
                            X1Nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[i][9]);

                            printDocument1 = new System.Drawing.Printing.PrintDocument();
                            printDocument1.PrinterSettings.PrinterName = x1Impresora.Trim();
                            printDocument1.PrintPage += Imprimir;
                            printDocument1.Print();
                        }
                        MessageBox.Show("Reimpresion de comanda generada correctamente",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information );
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no tiene permiso para realizar esa accion",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_anular_pedido_Click(object sender, EventArgs e)
        {
            Frm_DashBoard oFrm_DB = new Frm_DashBoard();
            int aCodigo_us = oFrm_DB.pCodigo_us;

            int aResp = 0;
            DataTable TablaTemp_admin = new DataTable();
            TablaTemp_admin = N_Mesa_Abierta.Usuario_Admin(aCodigo_us);
            aResp = Convert.ToInt32(TablaTemp_admin.Rows[0][0]);
            if (aResp == 0)
            {
                MessageBox.Show("El usuario no tiene permiso para realizar esa accion",
                "Aviso del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else
            {
                int aCodigo_ti = Convert.ToInt32(Dgv_tickets.CurrentRow.Cells["codigo_ti"].Value);
                Lbl_titulo_obs_anulado_ti.Text = $"::: OBSERVACION DE TICKET ANULADO # {aCodigo_ti} :::";
                Dgv_tickets.Enabled = false;
                Pnl_observacion_anular.Visible = true;
                EnabledButtons(false);
            }
        }

        private void Btn_cancelar_anulado_Click(object sender, EventArgs e)
        {

            Pnl_observacion_anular.Visible = false;
            Btn_reimprimir_comanda.Enabled = true;
            Dgv_tickets.Enabled = true;
            EnabledButtons(true);
        }

        private void Btn_confirmar_anulado_Click(object sender, EventArgs e)
        {
            if (Txt_obs_anulado_ticket.Text == string.Empty)
            {
                MessageBox.Show("Es necesario ingresar el motivo de anulacion del ticket",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else // Procedemos a enviar los datos para anular el ticket seleccionado
            {
                string cRpta = "";
                int aCodigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                int aCodigo_ti = Convert.ToInt32(Dgv_tickets.CurrentRow.Cells["codigo_ti"].Value);
                string cFechayHora = $"  ::Fecha/Hora: {DateTime.Now}::";
                string cObs = Txt_obs_anulado_ticket.Text.Trim() + cFechayHora;
                cRpta = N_Mesa_Abierta.Eliminar_Ti(aCodigo_ti, aCodigo_me,cObs);

                if (cRpta.Equals("Ok"))
                {
                    DataTable TablaImpresora = new DataTable();
                    TablaImpresora = N_Mesa_Abierta.Remprimir_comanda(aCodigo_ti);
                    if (TablaImpresora.Rows.Count > 0)
                    {
                        for (int i = 0; i < TablaImpresora.Rows.Count; i++)
                        {
                            x1Impresora = Convert.ToString(TablaImpresora.Rows[i][0]);
                            x1Codigo_ti = Convert.ToInt32(TablaImpresora.Rows[i][1]);
                            x1Descripcion_pv = Convert.ToString(TablaImpresora.Rows[i][2]);
                            x1Fecha_emision = Convert.ToString(TablaImpresora.Rows[i][3]);
                            x1Descripcion_tu = Convert.ToString(TablaImpresora.Rows[i][4]);
                            X1Nombre_us = Convert.ToString(TablaImpresora.Rows[i][5]);
                            X1Descripcion_ca = Convert.ToString(TablaImpresora.Rows[i][6]);
                            x1Descripcion_me = Convert.ToString(TablaImpresora.Rows[i][7]);
                            x1Cliente = Convert.ToString(TablaImpresora.Rows[i][8]);
                            X1Nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[i][9]);
                            X1Observacionanulado_ti = cObs;
                            //Crear de print document para la comanda
                            printDocument1 = new System.Drawing.Printing.PrintDocument();
                            _ = printDocument1.PrinterSettings.IsDefaultPrinter;
                            printDocument1.PrintPage += ReImprimir;
                            printDocument1.Print();
                            // fin de comanda




                        }
                        Mostrar_Tickets_Mesa();
                        Pnl_detalles_tickets.Visible = false;
                        Pnl_observacion_anular.Visible = false;
                        Btn_reimprimir_comanda.Enabled = true;
                        Dgv_tickets.Enabled = true;
                        EnabledButtons(true);
                        MessageBox.Show("Ticket anulado con exito",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }

            } 
        }
    }
}

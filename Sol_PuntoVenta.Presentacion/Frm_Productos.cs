using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int nCodigo_ma = 0;
        int nCodigo_um = 0;
        int nCodigo_sf = 0;
        int nCodigo_ad = 0;
        int EstadoGuarda = 0;
        DataTable Dtdetalle = new DataTable();
        #endregion

        #region "Mis Metodos"
         private void Formato_pr()
        {
            Dgv_Listado.Columns[0].Width = 90;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_PR";
            Dgv_Listado.Columns[1].Width = 140;
            Dgv_Listado.Columns[1].HeaderText = "PRODUCTO";
            Dgv_Listado.Columns[2].Width = 130;
            Dgv_Listado.Columns[2].HeaderText = "MARCA";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].HeaderText = "MEDIDA";
            Dgv_Listado.Columns[4].Width = 140;
            Dgv_Listado.Columns[4].HeaderText = "SUBFAMILIA";
            Dgv_Listado.Columns[5].Width = 140;
            Dgv_Listado.Columns[5].HeaderText = "P UNITARIO";
            Dgv_Listado.Columns[6].Width = 200;
            Dgv_Listado.Columns[6].HeaderText = "AREA DESPACHO";
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;
        }
        private void Formato_ma()
        {
 
            Dgv_Listado1.Columns[0].Visible = false;
            Dgv_Listado1.Columns[1].Width = 394;
            Dgv_Listado1.Columns[1].HeaderText = "MARCA";
 
        }
        private void Formato_um()
        {

            Dgv_Listado2.Columns[0].Visible = false;
            Dgv_Listado2.Columns[1].Width = 394;
            Dgv_Listado2.Columns[1].HeaderText = "MEDIDA";

        }
        private void Formato_sf()
        {

            Dgv_Listado3.Columns[0].Visible = false;
            Dgv_Listado3.Columns[1].Width = 190;
            Dgv_Listado3.Columns[1].HeaderText = "SUBFAMILIA";
            Dgv_Listado3.Columns[2].Width = 190;
            Dgv_Listado3.Columns[2].HeaderText = "FAMILIA";
            Dgv_Listado3.Columns[3].Visible = false;

        }
        private void Formato_ad()
        {

            Dgv_Listado2.Columns[0].Visible = false;
            Dgv_Listado4.Columns[1].Width = 394;
            Dgv_Listado4.Columns[1].HeaderText = "AREA DESPACHO";

        }
        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Productos.Listado_pr(cTexto);

                Formato_pr();
                Lbl_totalRegistros.Text = $"Total Registros: {Dgv_Listado.Rows.Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_ma(string cTexto)
        {
            try
            {
                Dgv_Listado1.DataSource = N_Productos.Listado_ma(cTexto);
                Formato_ma();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_um(string cTexto)
        {
            try
            {
                Dgv_Listado2.DataSource = N_Productos.Listado_um(cTexto);
                Formato_um();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_sf(string cTexto)
        {
            try
            {
                Dgv_Listado3.DataSource = N_Productos.Listado_sf(cTexto);
                Formato_sf();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_ad(string cTexto)
        {
            try
            {
                Dgv_Listado4.DataSource = N_Productos.Listado_ad(cTexto);
                Formato_ad();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Limpia_Texto()
        {
            Txt_precio_unitario.Text = "0.00";
            Txt_descripcion_pr.Text = "";
            Txt_descripcion_ma.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_descripcion_sf.Text = "";
            Txt_descripcion_ad.Text = "";
            Txt_observacion.Text = "";
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
       
        }

        private void Estado_Texto(bool lEstado)
        {
            Txt_precio_unitario.ReadOnly = !lEstado;
            Txt_descripcion_pr.ReadOnly = !lEstado;
            Txt_observacion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
            Btn_retornar.Visible = !lEstado;
            Btn_lupa_ma.Visible = lEstado;
        }

        private void Mostrar_img(int nCodigo_pr)
        {
            Byte[] bImagen = new byte[0];
            bImagen = N_Productos.Mostrar_img(nCodigo_pr);
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        private void Mostrar_img_prod_pred()
        {
            Byte[] bImagen = new byte[0];
            bImagen = N_Productos.Mostrar_img_prod_pred();
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        private void Crear_Tabla_pv()
        {
            Dtdetalle = new DataTable("Detalle");
            Dtdetalle.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            Dtdetalle.Columns.Add("OK", System.Type.GetType("System.Boolean"));
            Dtdetalle.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));

            Dgv_PuntosVentas.DataSource = Dtdetalle;
            Dgv_PuntosVentas.Columns[0].Width = 180;
            Dgv_PuntosVentas.Columns[0].HeaderText = "PUNTO DE VENTA";
            Dgv_PuntosVentas.Columns[0].ReadOnly = true;
            Dgv_PuntosVentas.Columns[1].Width = 90;
            Dgv_PuntosVentas.Columns[1].HeaderText = "OK";
            Dgv_PuntosVentas.Columns[1].ReadOnly = true;
            Dgv_PuntosVentas.Columns[2].Visible = false;
 

        }

        private void Agregar_pv(string Descripcion_pv,bool Ok, int nCodigo_pv)
        {
            DataRow Fila = Dtdetalle.NewRow();
            Fila["Descripcion_pv"] = Descripcion_pv;
            Fila["OK"] = Ok;
            Fila["Codigo_pv"] = nCodigo_pv;
            Dtdetalle.Rows.Add( Fila );
 
        }
        private void Puntos_Ventas_OK(int nOpcion, int nCodigo_pr)
        {
            try
            {
                DataTable TablaTemp = new DataTable();
                TablaTemp = N_Productos.Puntos_Ventas_Ok(nOpcion, nCodigo_pr);
                Dtdetalle.Clear();
                for (int nFila = 0; nFila <= TablaTemp.Rows.Count-1; nFila++)
                {
                    Agregar_pv(Convert.ToString(TablaTemp.Rows[nFila][0]),
                                Convert.ToBoolean(TablaTemp.Rows[nFila][1]),
                                Convert.ToInt32(TablaTemp.Rows[nFila][2]));
                }
                Dgv_PuntosVentas.DataSource = Dtdetalle;
                if (nOpcion>=1)
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = false;
                }
                else
                {
                    Dgv_PuntosVentas.Columns["OK"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString( Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Selecciona un registro", 
                                "Aviso del Sistema", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo = (int)Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value;
                Txt_descripcion_pr.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_pr"].Value;
                Txt_descripcion_ma.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_ma"].Value;
                Txt_descripcion_um.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value;
                Txt_descripcion_sf.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value;
                Txt_precio_unitario.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["precio_unitario"].Value);
                Txt_descripcion_ad.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_ad"].Value;
                Txt_observacion.Text = (string)Dgv_Listado.CurrentRow.Cells["observacion"].Value;

                nCodigo_ma = (int)Dgv_Listado.CurrentRow.Cells["codigo_ma"].Value;
                nCodigo_um = (int)Dgv_Listado.CurrentRow.Cells["codigo_um"].Value;
                nCodigo_sf = (int)Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value;
                nCodigo_ad = (int)Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value;

                Mostrar_img(nCodigo);
                Puntos_Ventas_OK(EstadoGuarda, nCodigo);
            }
        }

        private void Selecciona_item_ma()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado1.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_ma.Text = (string)Dgv_Listado1.CurrentRow.Cells["descripcion_ma"].Value;    
                nCodigo_ma = (int)Dgv_Listado1.CurrentRow.Cells["codigo_ma"].Value;
 
            }
        }
        private void Selecciona_item_um()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado2.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_um.Text = (string)Dgv_Listado2.CurrentRow.Cells["descripcion_um"].Value;
                nCodigo_um = (int)Dgv_Listado2.CurrentRow.Cells["codigo_um"].Value;

            }
        }
        private void Selecciona_item_sf()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado3.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_sf.Text = (string)Dgv_Listado3.CurrentRow.Cells["descripcion_sf"].Value;
                nCodigo_sf = (int)Dgv_Listado3.CurrentRow.Cells["codigo_sf"].Value;

            }
        }
        private void Selecciona_item_ad()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado4.CurrentRow.Cells["codigo_ad"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_descripcion_ad.Text = (string)Dgv_Listado4.CurrentRow.Cells["descripcion_ad"].Value;
                nCodigo_ad = (int)Dgv_Listado4.CurrentRow.Cells["codigo_ad"].Value;

            }
        }
        #endregion 
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            Listado_pr("%");
            Listado_ma("%");
            Listado_um("%");
            Listado_sf("%");
            Listado_ad("%");
            Pnl_Listado1.Visible = false;
            Pnl_Listado2.Visible = false;
            Pnl_Listado3.Visible = false;
            Pnl_Listado4.Visible = false;
            Crear_Tabla_pv();
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;// Nuevo registro
            Estado_BotonesPrincipales(false);
            Estado_BotonesProcesos(true);
            Limpia_Texto();
            Estado_Texto(true);
            Puntos_Ventas_OK(EstadoGuarda,nCodigo);
            Mostrar_img_prod_pred();
            tbc_principal.SelectedIndex = 1;
            Txt_descripcion_pr.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpia_Texto();
            Estado_Texto(false);
            Estado_BotonesPrincipales(true);
            Estado_BotonesProcesos(false);
            tbc_principal.SelectedIndex = 0;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            tbc_principal.SelectedIndex = 0;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_descripcion_pr.Text == string.Empty ||
                    Txt_descripcion_ma.Text == string.Empty ||
                    Txt_descripcion_um.Text == string.Empty ||
                    Txt_descripcion_sf.Text == string.Empty ||
                    Txt_descripcion_ad.Text == string.Empty ||
                    Txt_precio_unitario.Text == string.Empty ||
                    Txt_observacion.Text == string.Empty )
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del Sistema", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
                else
                {
                    string Rpta = "";
                    E_Productos oPropiedad = new E_Productos();
                    oPropiedad.Codigo_pr = nCodigo;
                    oPropiedad.Descripcion_pr = Txt_descripcion_pr.Text.Trim();
                    oPropiedad.Codigo_ma = nCodigo_ma;
                    oPropiedad.Codigo_um = nCodigo_um;
                    oPropiedad.Codigo_sf = nCodigo_sf;
                    oPropiedad.Codigo_ad = nCodigo_ad;
                    oPropiedad.Observacion = Txt_observacion.Text;
                    oPropiedad.Precio_unitario =Convert.ToDecimal( Txt_precio_unitario.Text);
                    MemoryStream ms = new MemoryStream();
                    Pct_imagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                    oPropiedad.Imagen = ms.GetBuffer();


                    Rpta = N_Productos.Guardar_pr(EstadoGuarda, oPropiedad,Dtdetalle);
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente", 
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        Limpia_Texto();
                        Estado_Texto(false);
                        Estado_BotonesPrincipales(true);
                        Estado_BotonesProcesos(false);
                        EstadoGuarda = 0;
                        nCodigo = 0;
                        nCodigo_ma = 0;
                        nCodigo_um = 0;
                        nCodigo_sf = 0;
                        nCodigo_ad = 0;
                        Listado_pr("%");
                        tbc_principal.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema", 
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation );
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                EstadoGuarda = 2; // Actualizar registro
                Estado_BotonesPrincipales(false);
                Estado_BotonesProcesos(true);
                Estado_Texto(true);
                Limpia_Texto();
                Selecciona_item();
                Puntos_Ventas_OK(EstadoGuarda, nCodigo);
                tbc_principal.SelectedIndex = 1;
                Btn_lupa_ma.Focus();
            }
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EstadoGuarda == 0)
            {
                Selecciona_item();
                Estado_BotonesProcesos(false);
                tbc_principal.SelectedIndex = 1;
                Btn_agregar_imagen.Enabled = false;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro que quieres eliminar el registro seleccionado",
                    "Aviso del Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    Selecciona_item();
                    Rpta = N_Productos.Eliminar_pr(nCodigo);

                    if (Rpta.Equals("OK"))
                    {
                        Listado_pr("%");
                        MessageBox.Show("El registro ha sido eliminado",
                            "Aviso del Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        nCodigo = 0;
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                            "Aviso del Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    Limpia_Texto();
                }
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Listado_pr(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_Productos oRpt_pr = new Reportes.Frm_Rpt_Productos();
                oRpt_pr.Txt_p1.Text = Txt_buscar.Text.Trim();
                oRpt_pr.ShowDialog();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dgv_Listado1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_ma();
            Pnl_Listado1.Visible = false;
  
        }
        private void Dgv_Listado2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_um();
            Pnl_Listado2.Visible = false;
 
        }
        private void Dgv_Listado3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_sf();
            Pnl_Listado3.Visible = false;
        }
        private void Dgv_Listado4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_ad();
            Pnl_Listado4.Visible = false;
        }
        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Visible = false;
        }
        private void Btn_retornar2_Click(object sender, EventArgs e)
        {
            Pnl_Listado2.Visible = false;
        }
        private void Btn_retornar3_Click(object sender, EventArgs e)
        {
            Pnl_Listado3.Visible = false;
        }
        private void Btn_retornar4_Click(object sender, EventArgs e)
        {

            Pnl_Listado4.Visible = false;
        }
        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            Listado_ma(Txt_buscar1.Text.Trim());
        }
        private void Btn_buscar2_Click(object sender, EventArgs e)
        {

            Listado_um(Txt_buscar2.Text.Trim());
        }
        private void Btn_buscar3_Click(object sender, EventArgs e)
        {
            Listado_sf(Txt_buscar3.Text.Trim());
        }

        private void Btn_buscar4_Click(object sender, EventArgs e)
        {
            Listado_ad(Txt_buscar4.Text.Trim());
        }
        private void Btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Location = Btn_lupa_ma.Location;
            Pnl_Listado1.Visible = true;
            Txt_buscar1.Focus();
            Pnl_Listado2.Visible = false;
            Pnl_Listado3.Visible = false;
            Pnl_Listado4.Visible = false;
        }

        private void Btn_lupa_um_Click(object sender, EventArgs e)
        {
            Pnl_Listado2.Location = Btn_lupa_um.Location;
            Pnl_Listado2.Visible = true;
            Txt_buscar2.Focus();
            Pnl_Listado1.Visible = false;
            Pnl_Listado3.Visible = false;
            Pnl_Listado4.Visible = false;
        }

        private void Btn_lupa_sf_Click(object sender, EventArgs e)
        {
            Pnl_Listado3.Location = Btn_lupa_sf.Location;
            Pnl_Listado3.Visible = true;
            Txt_buscar3.Focus();
            Pnl_Listado1.Visible = false;
            Pnl_Listado2.Visible = false;
            Pnl_Listado4.Visible = false;
        }

        private void Btn_lupa_ad_Click(object sender, EventArgs e)
        {
            Pnl_Listado4.Location = Btn_lupa_ad.Location;
            Pnl_Listado4.Visible = true;
            Txt_buscar4.Focus();
            Pnl_Listado1.Visible = false;
            Pnl_Listado2.Visible = false;
            Pnl_Listado3.Visible = false;
        }

        private void Btn_agregar_imagen_Click(object sender, EventArgs e)
        {
             OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Image files(*.jpg,*.jpe,*.jfif,*.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (Foto.ShowDialog() == DialogResult.OK)
            {
                Pct_imagen.Image = Image.FromFile(Foto.FileName);
            }
        }
    }
}

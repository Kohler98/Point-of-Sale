using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Mesas : Form
    {
        public Frm_Mesas()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int nCodigo_pv = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Metodos"
         private void Formato_me()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_ME";
            Dgv_Listado.Columns[1].Width = 394;
            Dgv_Listado.Columns[1].HeaderText = "MESA";
            Dgv_Listado.Columns[2].Width = 394;
            Dgv_Listado.Columns[2].HeaderText = "PUNTO DE VENTA";
            Dgv_Listado.Columns[3].Visible = false;
        }
        private void Formato_pv()
        {
 
            Dgv_Listado1.Columns[0].Visible = false;
            Dgv_Listado1.Columns[1].Width = 394;
            Dgv_Listado1.Columns[1].HeaderText = "PUNTO DE VENTA";
 
        }

        private void Listado_me(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Mesas.Listado_me(cTexto);

                Formato_me();
                Lbl_totalRegistros.Text = $"Total Registros: {Dgv_Listado.Rows.Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_Listado1.DataSource = N_Mesas.Listado_pv(cTexto);
                Formato_pv();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpia_Texto()
        {
            Txt_descripcion.Text = "";
            Txt_buscar1.Text = "";
            Txt_venta.Text = "";
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
            Txt_descripcion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
            Btn_retornar.Visible = !lEstado;
            Btn_lupa.Visible = lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString( Dgv_Listado.CurrentRow.Cells["codigo_me"].Value)))
            {
                MessageBox.Show("Selecciona un registro", 
                                "Aviso del Sistema", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo = (int)Dgv_Listado.CurrentRow.Cells["codigo_me"].Value;
                Txt_descripcion.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_me"].Value;
                Txt_venta.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_pv"].Value;
                nCodigo_pv = (int)Dgv_Listado.CurrentRow.Cells["codigo_pv"].Value;
            }
        }

        private void Selecciona_item_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado1.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {

                Txt_venta.Text = (string)Dgv_Listado1.CurrentRow.Cells["descripcion_pv"].Value;
                nCodigo_pv = (int)Dgv_Listado1.CurrentRow.Cells["codigo_pv"].Value;
            }
        }
        #endregion 
        private void Frm_Mesas_Load(object sender, EventArgs e)
        {
            Listado_me("%");
            Listado_pv("%");
            Pnl_Listado1.Visible = false;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;// Nuevo registro
            Estado_BotonesPrincipales(false);
            Estado_BotonesProcesos(true);
            Limpia_Texto();
            Estado_Texto(true);
            tbc_principal.SelectedIndex = 1;
            Btn_lupa.Focus();
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
                if(Txt_descripcion.Text == string.Empty ||
                    Txt_venta.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del Sistema", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
                else
                {
                    string Rpta = "";
                    E_Sub_Generic oPropiedad = new E_Sub_Generic();
                    oPropiedad.Codigo = nCodigo;
                    oPropiedad.Descripcion = Txt_descripcion.Text.Trim();
                    oPropiedad.Codigo_sg = nCodigo_pv;
                    Rpta = N_Mesas.Guardar_me(EstadoGuarda, oPropiedad);
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
                        nCodigo_pv = 0;
                        Listado_me("%");
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
                tbc_principal.SelectedIndex = 1;
                Btn_lupa.Focus();
            }
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EstadoGuarda == 0)
            {
                Selecciona_item();
                Estado_BotonesProcesos(false);
                tbc_principal.SelectedIndex = 1;

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
                    Rpta = N_Mesas.Eliminar_me(nCodigo);

                    if (Rpta.Equals("OK"))
                    {
                        Listado_me("%");
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
            Listado_me(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_Mesas oRpt_me = new Reportes.Frm_Rpt_Mesas();
                oRpt_me.Txt_p1.Text = Txt_buscar.Text.Trim();
                oRpt_me.ShowDialog();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dgv_Listado1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_pv();
            Pnl_Listado1.Visible = false;
            Txt_descripcion.Focus();
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Visible = false;
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            Listado_pv(Txt_buscar1.Text.Trim());
        }

        private void Btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Location = Btn_lupa.Location;
            Pnl_Listado1.Visible = true;
            Txt_buscar1.Focus();
        }
    }
}

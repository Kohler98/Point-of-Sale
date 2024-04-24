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
    public partial class Frm_SubFamilias : Form
    {
        public Frm_SubFamilias()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
        int nCodigo_fa = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Metodos"
         private void Formato_sf()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_SF";
            Dgv_Listado.Columns[1].Width = 394;
            Dgv_Listado.Columns[1].HeaderText = "SUBFAMILIA";
            Dgv_Listado.Columns[2].Width = 394;
            Dgv_Listado.Columns[2].HeaderText = "FAMILIA";
            Dgv_Listado.Columns[3].Visible = false;
        }
        private void Formato_fa()
        {
 
            Dgv_Listado1.Columns[0].Visible = false;
            Dgv_Listado1.Columns[1].Width = 394;
            Dgv_Listado1.Columns[1].HeaderText = "FAMILIA";
 
        }

        private void Listado_sf(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_SubFamilias.Listado_sf(cTexto);

                Formato_sf();
                Lbl_totalRegistros.Text = $"Total Registros: {Dgv_Listado.Rows.Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_fa(string cTexto)
        {
            try
            {
                Dgv_Listado1.DataSource = N_SubFamilias.Listado_fa(cTexto);
                Formato_fa();

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
            Txt_familia.Text = "";
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
            if (string.IsNullOrEmpty(Convert.ToString( Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Selecciona un registro", 
                                "Aviso del Sistema", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo = (int)Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value;
                Txt_descripcion.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value;
                Txt_buscar1.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_fa"].Value;
                nCodigo_fa = (int)Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value;
            }
        }

        private void Selecciona_item_fa()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado1.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {

                Txt_familia.Text = (string)Dgv_Listado1.CurrentRow.Cells["descripcion_fa"].Value;
                nCodigo_fa = (int)Dgv_Listado1.CurrentRow.Cells["codigo_fa"].Value;
            }
        }
        #endregion 
        private void Frm_SubFamilias_Load(object sender, EventArgs e)
        {
            Listado_sf("%");
            Listado_fa("%");
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
                    Txt_familia.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del Sistema", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
                else
                {
                    string Rpta = "";
                    E_SubFamilias oPropiedad = new E_SubFamilias();
                    oPropiedad.Codigo_sf = nCodigo;
                    oPropiedad.Descripcion_sf = Txt_descripcion.Text.Trim();
                    oPropiedad.Codigo_fa = nCodigo_fa;
                    Rpta = N_SubFamilias.Guardar_sf(EstadoGuarda, oPropiedad);
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
                        nCodigo_fa = 0;
                        Listado_sf("%");
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
                    Rpta = N_SubFamilias.Eliminar_sf(nCodigo);

                    if (Rpta.Equals("OK"))
                    {
                        Listado_sf("%");
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
            Listado_sf(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                Reportes.Frm_Rpt_SubFamilia oRpt_sf = new Reportes.Frm_Rpt_SubFamilia();
                oRpt_sf.Txt_p1.Text = Txt_buscar.Text.Trim();
                oRpt_sf.ShowDialog();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dgv_Listado1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_fa();
            Pnl_Listado1.Visible = false;
            Txt_descripcion.Focus();
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Visible = false;
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            Listado_fa(Txt_buscar1.Text.Trim());
        }

        private void Btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_Listado1.Location = Btn_lupa.Location;
            Pnl_Listado1.Visible = true;
            Txt_buscar1.Focus();
        }
    }
}

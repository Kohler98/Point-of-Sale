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
    public partial class Frm_Area_Despacho : Form
    {
        public Frm_Area_Despacho()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo = 0;
 
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Metodos"
         private void Formato_ad()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_AD";
            Dgv_Listado.Columns[1].Width = 394;
            Dgv_Listado.Columns[1].HeaderText = "AREA DE DESPACHO";
            Dgv_Listado.Columns[2].Width = 394;
            Dgv_Listado.Columns[2].HeaderText = "IMPRESORA";
        
        }
 
        private void Listado_ad(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Area_Despacho.Listado_ad(cTexto);

                Formato_ad();
                Lbl_totalRegistros.Text = $"Total Registros: {Dgv_Listado.Rows.Count}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
 

        private void Limpia_Texto()
        {
            Txt_descripcion.Text = "";
 
            Txt_impresora.Text = "";
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
            Txt_impresora.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;
            Btn_retornar.Visible = !lEstado;
 
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString( Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value)))
            {
                MessageBox.Show("Selecciona un registro", 
                                "Aviso del Sistema", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo = (int)Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value;
                Txt_impresora.Text = (string)Dgv_Listado.CurrentRow.Cells["impresora"].Value;
                Txt_descripcion.Text = (string)Dgv_Listado.CurrentRow.Cells["descripcion_ad"].Value;
            }
        }
 
        #endregion 
        private void Frm_Area_Despacho_Load(object sender, EventArgs e)
        {
            Listado_ad("%");
 
 
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;// Nuevo registro
            Estado_BotonesPrincipales(false);
            Estado_BotonesProcesos(true);
            Limpia_Texto();
            Estado_Texto(true);
            tbc_principal.SelectedIndex = 1;
            Txt_descripcion.Focus();
 
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
                    Txt_impresora.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del Sistema", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
                else
                {
                    string Rpta = "";
                    E_Area_Despacho oPropiedad = new E_Area_Despacho();
                    oPropiedad.Codigo_ad = nCodigo;
                    oPropiedad.Descripcion_ad = Txt_descripcion.Text.Trim();
                    oPropiedad.Impresora = Txt_impresora.Text.Trim();
                    Rpta = N_Area_Despacho.Guardar_ad(EstadoGuarda, oPropiedad);
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
 
                        Listado_ad("%");
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
                Txt_descripcion.Focus();
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
                    Rpta = N_Area_Despacho.Eliminar_ad(nCodigo);

                    if (Rpta.Equals("OK"))
                    {
                        Listado_ad("%");
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
            Listado_ad(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                Reportes.Frm_Area_Despacho oRpt_ad = new Reportes.Frm_Area_Despacho();
                oRpt_ad.Txt_p1.Text = Txt_buscar.Text.Trim();
                oRpt_ad.ShowDialog();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}

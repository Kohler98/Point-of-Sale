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

namespace Sol_PuntoVenta.Presentacion.Procesos
{
    public partial class Frm_Cierres_Turnos : Form
    {
        public Frm_Cierres_Turnos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_pv = 0;
        int nCodigo_tu = 0;
        
        #endregion
        #region "Mis Metodos"
        private void Formato_pv()
        {
            Dgv_Listado1.Columns[0].Width = 100;
            Dgv_Listado1.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_Listado1.Columns[1].Width = 394;
            Dgv_Listado1.Columns[1].HeaderText = "PUNTO DE VENTA";
        }

        private void Listado_pv(string cTexto)
        {
            try
            {
                Dgv_Listado1.DataSource = N_Cierres_Turnos.Listado_pv(cTexto);

                Formato_pv();
 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item()
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
                //nCodigo = (int)Dgv_Listado1.CurrentRow.Cells["codigo_pv"].Value;
                //Txt_descripcion.Text = (string)Dgv_Listado1.CurrentRow.Cells["descripcion_pv"].Value;
            }
        }

        private void Estado_gestion_turno_pv(int nCodigo_pv)
        {
            DataTable Tablax = new DataTable();
            Tablax = N_Cierres_Turnos.Estado_gestion_turno_pv(nCodigo_pv);

            if (Tablax.Rows.Count > 0)
            {
                string cFecha_ct = Convert.ToString(Tablax.Rows[0][0]);
                Txt_fecha_trabajo.Text = cFecha_ct.Substring(0, cFecha_ct.Length - 14);
                nCodigo_tu = Convert.ToInt32(Tablax.Rows[0][1]);
                Txt_turno.Text = Convert.ToString(Tablax.Rows[0][2]);
                nCodigo_pv = Convert.ToInt32(Tablax.Rows[0][5]);
                Txt_estado_actual.Text = Convert.ToString(Tablax.Rows[0][4]);
                Txt_punto_venta.Text = Convert.ToString(Tablax.Rows[0][6]);
                if (Txt_estado_actual.Text.Trim() == "Abierto")
                {
                    Btn_abrir_turno.Enabled = false;
                    Btn_cerrar_turno.Enabled = true;
                }
                else
                {
                    Btn_abrir_turno.Enabled = true;
                    Btn_cerrar_turno.Enabled = false;

                }
            }
            else
            {
                Btn_abrir_turno.Enabled = true;
                Btn_cerrar_turno.Enabled = false;

                Txt_fecha_trabajo.Text = "";
                Txt_turno.Text = "";
                nCodigo_pv = 0;
                Txt_estado_actual.Text = "";
                Txt_punto_venta.Text = "";
                nCodigo_tu = 0;
            }
        }
        #endregion
        private void Frm_Cierres_Turnos_Load(object sender, EventArgs e)
        {
            Listado_pv("%");
        }

        private void Dgv_Listado1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nCodigo_pv = Convert.ToInt32(Dgv_Listado1.CurrentRow.Cells["codigo_pv"].Value);

            Estado_gestion_turno_pv(nCodigo_pv);
        }

        private void Btn_abrir_turno_Click(object sender, EventArgs e)
        {
            nCodigo_pv = Convert.ToInt32(Dgv_Listado1.CurrentRow.Cells["codigo_pv"].Value);
            if (nCodigo_pv > 0)
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Abrir turno siguiente ahora?","Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.Yes)
                    {
                        string Rpta;
                        string cFecha_ct = Txt_fecha_trabajo.Text.Trim();
                        if (cFecha_ct == string.Empty)
                        {
                            cFecha_ct = DateTime.Now.ToString("dd-MM-yyyy");
                            nCodigo_tu = 1;

                        }
                        else
                        {
                            if (nCodigo_tu ==1)
                            {
                                nCodigo_tu = 2;
                            }
                            else if(nCodigo_tu ==2) 
                            {
                                DateTime nueva_fecha = Convert.ToDateTime(cFecha_ct);
                                nueva_fecha = nueva_fecha.AddDays(1);
                                cFecha_ct = Convert.ToString(nueva_fecha);
                                cFecha_ct.Substring(0,cFecha_ct.Length - 8);
                                nCodigo_tu = 1;
                            }
                        }
                        Rpta = N_Cierres_Turnos.Abrir_turno(cFecha_ct, nCodigo_pv, nCodigo_tu);

                        if (Rpta.Equals("OK"))
                        {
                            Estado_gestion_turno_pv(nCodigo_pv);
                            MessageBox.Show("El turno ha sido aperturado correctamente", "Aviso del Sistema",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
            else
            {
                MessageBox.Show("No se tiene datos del punto de venta que se intenta aperturar","Aviso del Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Cerrar el turno ahora?",
                                        "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta;
                    string cFecha_ct = Txt_fecha_trabajo.Text.Trim();
                    Rpta = N_Cierres_Turnos.Cerrar_turno(cFecha_ct,nCodigo_pv,nCodigo_tu);
                    if (Rpta.Equals("OK"))
                    {
                        Estado_gestion_turno_pv(nCodigo_pv);
                        MessageBox.Show("El turno ha sido cerrado correctamente","Aviso del Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace,"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

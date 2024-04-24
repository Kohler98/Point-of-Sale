using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        #region "Mis Metodos"
        private void Limpia_Texto()
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
 
        }
        private void Acceder_us(string cLogin_us, string cPassword_us)
        {
            try
            {
                DataTable TablaAcceder = new DataTable();
                TablaAcceder = N_Login.Acceder_us(cLogin_us, cPassword_us);
                if (TablaAcceder.Rows.Count > 0)
                {
                    Frm_DashBoard oFrm_DB = new Frm_DashBoard();
                    oFrm_DB.pCodigo_us = Convert.ToInt32(TablaAcceder.Rows[0][0]);
                    oFrm_DB.pLogin_us = Convert.ToString(TablaAcceder.Rows[0][1]);
                    oFrm_DB.pNombres_us = Convert.ToString(TablaAcceder.Rows[0][2]);
                    oFrm_DB.pDescripcion_ca = Convert.ToString(TablaAcceder.Rows[0][3]);
                    oFrm_DB.pCodigo_ro = Convert.ToInt32(TablaAcceder.Rows[0][4]);
                    oFrm_DB.pDescripcion_ro = Convert.ToString(TablaAcceder.Rows[0][5]);
                    if(oFrm_DB.pCodigo_ro == 1)
                    {
                        oFrm_DB.Btn_dashboard.Enabled = true;
                        oFrm_DB.Btn_procesos.Enabled = true;
                        oFrm_DB.Btn_reportes.Enabled = true;
                        oFrm_DB.Btn_datosmaestros.Enabled = true;
                        oFrm_DB.Btn_registro_usuario.Enabled = true;
                    }
                    else
                    {
                        oFrm_DB.Btn_registro_usuario.Enabled = false;
                        oFrm_DB.Btn_dashboard.Enabled = false;
                        oFrm_DB.Btn_procesos.Enabled = true;
                        oFrm_DB.Btn_reportes.Enabled = false;
                        oFrm_DB.Btn_datosmaestros.Enabled = false;

                    }
              
                    oFrm_DB.Show();
                    oFrm_DB.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso no autorizado", 
                                    "Aviso de Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Limpia_Texto();
            this.Show();
            Txt_login_us.Select();
        }
        #endregion

        private void Btn_acceder_Click(object sender, EventArgs e)
        {
            Acceder_us(Txt_login_us.Text, Txt_password_us.Text);
        }
    }
}

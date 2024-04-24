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
    public partial class Frm_Registro_Usuario : Form
    {
        public Frm_Registro_Usuario()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_ca = 0;
        int nCodigo_ro = 0;
 
        #endregion
        #region "Mis Metodos"
        private void Limpia_Texto()
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            Txt_descripcion_car.Text = "";
            Txt_descripcion_ro.Text = "";
            Txt_nombre_us.Text = "";
        }
        private void Formato_car()
        {

            Dgv_listado_car.Columns[0].Visible = false;
            Dgv_listado_car.Columns[1].Width = 394;
            Dgv_listado_car.Columns[1].HeaderText = "CARGO";

        }
        private void Listado_car(string cTexto)
        {
            try
            {
                Dgv_listado_car.DataSource = N_Login.Listado_car(cTexto);
                Formato_car();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato_ro()
        {

            Dgv_listado_ro.Columns[0].Visible = false;
            Dgv_listado_ro.Columns[1].Width = 394;
            Dgv_listado_ro.Columns[1].HeaderText = "ROLE";

        }
        private void Listado_ro(string cTexto)
        {
            try
            {
                Dgv_listado_ro.DataSource = N_Login.Listado_ro(cTexto);
                Formato_ro();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item_car()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_listado_car.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_ca = Convert.ToInt32(Dgv_listado_car.CurrentRow.Cells["codigo_ca"].Value);
                Txt_descripcion_car.Text = Convert.ToString(Dgv_listado_car.CurrentRow.Cells["descripcion_car"].Value);
                Txt_buscar_car.Text = Convert.ToString(Dgv_listado_car.CurrentRow.Cells["descripcion_car"].Value);
 
            }
        }
        private void Selecciona_item_ro()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_listado_ro.CurrentRow.Cells["codigo_ro"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_ro = Convert.ToInt32(Dgv_listado_ro.CurrentRow.Cells["codigo_ro"].Value);
                Txt_descripcion_ro.Text = Convert.ToString(Dgv_listado_ro.CurrentRow.Cells["descripcion_ro"].Value);
                Txt_buscar_ro.Text = Convert.ToString(Dgv_listado_ro.CurrentRow.Cells["descripcion_ro"].Value);

            }
        }
        private void Registrar_us(string cLogin_us, string cPassword_us, string cNombre_us)
        {
            try
            {
                if (Txt_nombre_us.Text == string.Empty ||
                    Txt_password_us.Text == string.Empty || Txt_login_us.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
                else
                {
                    string Rpta = "";

                    Rpta = N_Login.Registrar_us(cLogin_us, cPassword_us, cNombre_us, nCodigo_ca, nCodigo_ro);
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                        );
                        Limpia_Texto();
                        nCodigo_ro = 0;
                        nCodigo_ca = 0;

                    }
                    else
                    {
                        MessageBox.Show(Rpta,
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
        #endregion
 

        private void Btn_lupa_car_Click(object sender, EventArgs e)
        {
            Pnl_Listado_car.Location = Txt_password_us.Location;
            Pnl_Listado_car.Visible = true;
            Txt_buscar_car.Focus();
        }

        private void Btn_lupa_ro_Click(object sender, EventArgs e)
        {
            Pnl_listado_ro.Location = Txt_password_us.Location;
            Pnl_listado_ro.Visible = true;
            Txt_buscar_ro.Focus();
        }

        private void Btn_retornar_car_Click(object sender, EventArgs e)
        {
            Pnl_Listado_car.Visible = false;
        }

        private void Btn_retornar_ro_Click(object sender, EventArgs e)
        {
            Pnl_listado_ro.Visible = false;
        }

        private void Frm_Registro_Usuario_Load(object sender, EventArgs e)
        {
            Listado_car("%");
            Listado_ro("%");
        }

        private void Dgv_listado_ro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_ro();
            Pnl_listado_ro.Visible = false;
            Txt_descripcion_ro.Focus();
        }

        private void Dgv_listado_car_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona_item_car();
            Pnl_Listado_car.Visible = false;
            Txt_descripcion_car.Focus();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            Registrar_us(Txt_login_us.Text.Trim(), Txt_password_us.Text.Trim(), Txt_nombre_us.Text);
        }

        private void Btn_buscar_ro_Click(object sender, EventArgs e)
        {
            Listado_ro(Txt_buscar_ro.Text.Trim());
        }

        private void Btn_buscar_car_Click(object sender, EventArgs e)
        {
            Listado_car(Txt_buscar_car.Text.Trim());
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

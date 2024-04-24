using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Negocio;
namespace Sol_PuntoVenta.Presentacion.Controles
{
    public partial class MiMesa : UserControl
    {
        public MiMesa()
        {
            InitializeComponent();
        }
        #region "Mis Variables y Propiedades"
        public int Codigo
        {
            get { return Convert.ToInt32(Lbl_codigo_me.Text); }
            set { Lbl_codigo_me.Text = Convert.ToString(value); }
        }

        public string Descripcion
        {
            get { return Lbl_descripcion_mesa.Text; }
            set { Lbl_descripcion_mesa.Text = value; }
        }

        public Image Disponible
        {
            get { return Pct_estado.Image; }
            set {  Pct_estado.Image = value;}
        }

        public int Codigo_pv
        {
            get { return Convert.ToInt32(Lbl_codigo_pv.Text); }
            set { Lbl_codigo_pv.Text = Convert.ToString(value); }
        }
        public string Descripcion_pv
        {
            get { return Lbl_descripcion_pv.Text; }
            set { Lbl_descripcion_pv.Text = value;}
        }

        public int Codigo_us
        {
            get { return Convert.ToInt32(Lbl_codigo_us.Text); }
            set { Lbl_codigo_us.Text = Convert.ToString(value); }
        }
        public int Codigo_tu
        {
            get { return Convert.ToInt32(Lbl_codigo_tu.Text); }
            set { Lbl_codigo_tu.Text = Convert.ToString(value); }
        }

        public string Fecha_trabajo
        {
            get { return Lbl_fecha_trabajo.Text; }
            set { Lbl_fecha_trabajo.Text = value; }
        }
        #endregion

        private void Pct_imagen_mesa_Click(object sender, EventArgs e)
        {
            Procesos.Frm_Mesa_Abierta oFrm_mesa_abierta = new Procesos.Frm_Mesa_Abierta();
            oFrm_mesa_abierta.Txt_mesa_seleccionada.Text = Descripcion;
            oFrm_mesa_abierta.Txt_punto_venta.Text = Descripcion_pv;
            oFrm_mesa_abierta.Lbl_codigo_pv.Text = Convert.ToString(Codigo_pv);
            oFrm_mesa_abierta.Lbl_codigo_me.Text = Convert.ToString(Codigo);
            oFrm_mesa_abierta.Lbl_codigo_tu.Text = Convert.ToString(Codigo_tu);
            oFrm_mesa_abierta.Lbl_archivo_txt.Text = Convert.ToString(DateTime.Now.Ticks);
            oFrm_mesa_abierta.Lbl_fecha_trabajo.Text = Fecha_trabajo;
            oFrm_mesa_abierta.Btn_nuevo_pedido.Focus();
            try
            {
                oFrm_mesa_abierta.Dgv_Listado_productos.DataSource = N_Mesa_Abierta.Listar_SubFamilias_RP(Codigo_pv);
                //dando formato al datagridview de subfamilia
                oFrm_mesa_abierta.Dgv_Listado_productos.Columns[0].Width = 250;
                oFrm_mesa_abierta.Dgv_Listado_productos.Columns[0].HeaderText = "SUBFAMILIA";
                oFrm_mesa_abierta.Dgv_Listado_productos.Columns[1].Visible = false;

                oFrm_mesa_abierta.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}

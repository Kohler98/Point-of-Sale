namespace Sol_PuntoVenta.Presentacion.Controles
{
    partial class MiMesa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiMesa));
            this.Pnl_mesa = new System.Windows.Forms.Panel();
            this.Lbl_codigo_tu = new System.Windows.Forms.Label();
            this.Lbl_codigo_us = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pv = new System.Windows.Forms.Label();
            this.Lbl_codigo_pv = new System.Windows.Forms.Label();
            this.Lbl_codigo_me = new System.Windows.Forms.Label();
            this.Lbl_descripcion_mesa = new System.Windows.Forms.Label();
            this.Pct_estado = new System.Windows.Forms.PictureBox();
            this.Pct_imagen_mesa = new System.Windows.Forms.PictureBox();
            this.Lbl_fecha_trabajo = new System.Windows.Forms.Label();
            this.Pnl_mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_mesa)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_mesa
            // 
            this.Pnl_mesa.Controls.Add(this.Lbl_fecha_trabajo);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_tu);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_us);
            this.Pnl_mesa.Controls.Add(this.Lbl_descripcion_pv);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_pv);
            this.Pnl_mesa.Controls.Add(this.Lbl_codigo_me);
            this.Pnl_mesa.Controls.Add(this.Lbl_descripcion_mesa);
            this.Pnl_mesa.Controls.Add(this.Pct_estado);
            this.Pnl_mesa.Controls.Add(this.Pct_imagen_mesa);
            this.Pnl_mesa.Location = new System.Drawing.Point(3, 3);
            this.Pnl_mesa.Name = "Pnl_mesa";
            this.Pnl_mesa.Size = new System.Drawing.Size(135, 134);
            this.Pnl_mesa.TabIndex = 0;
            // 
            // Lbl_codigo_tu
            // 
            this.Lbl_codigo_tu.Location = new System.Drawing.Point(119, 84);
            this.Lbl_codigo_tu.Name = "Lbl_codigo_tu";
            this.Lbl_codigo_tu.Size = new System.Drawing.Size(13, 10);
            this.Lbl_codigo_tu.TabIndex = 7;
            this.Lbl_codigo_tu.Text = "Lbl_codigo_tu";
            this.Lbl_codigo_tu.Visible = false;
            // 
            // Lbl_codigo_us
            // 
            this.Lbl_codigo_us.Location = new System.Drawing.Point(0, 48);
            this.Lbl_codigo_us.Name = "Lbl_codigo_us";
            this.Lbl_codigo_us.Size = new System.Drawing.Size(13, 10);
            this.Lbl_codigo_us.TabIndex = 6;
            this.Lbl_codigo_us.Text = "Lbl_codigo_us";
            this.Lbl_codigo_us.Visible = false;
            // 
            // Lbl_descripcion_pv
            // 
            this.Lbl_descripcion_pv.Location = new System.Drawing.Point(119, 59);
            this.Lbl_descripcion_pv.Name = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Size = new System.Drawing.Size(13, 10);
            this.Lbl_descripcion_pv.TabIndex = 5;
            this.Lbl_descripcion_pv.Text = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Visible = false;
            // 
            // Lbl_codigo_pv
            // 
            this.Lbl_codigo_pv.Location = new System.Drawing.Point(105, 7);
            this.Lbl_codigo_pv.Name = "Lbl_codigo_pv";
            this.Lbl_codigo_pv.Size = new System.Drawing.Size(13, 10);
            this.Lbl_codigo_pv.TabIndex = 4;
            this.Lbl_codigo_pv.Text = "Lbl_codigo_pv";
            this.Lbl_codigo_pv.Visible = false;
            // 
            // Lbl_codigo_me
            // 
            this.Lbl_codigo_me.Location = new System.Drawing.Point(3, 3);
            this.Lbl_codigo_me.Name = "Lbl_codigo_me";
            this.Lbl_codigo_me.Size = new System.Drawing.Size(13, 10);
            this.Lbl_codigo_me.TabIndex = 3;
            this.Lbl_codigo_me.Text = "Lbl_codigo_me";
            this.Lbl_codigo_me.Visible = false;
            // 
            // Lbl_descripcion_mesa
            // 
            this.Lbl_descripcion_mesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_descripcion_mesa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_mesa.Location = new System.Drawing.Point(0, 111);
            this.Lbl_descripcion_mesa.Name = "Lbl_descripcion_mesa";
            this.Lbl_descripcion_mesa.Size = new System.Drawing.Size(135, 23);
            this.Lbl_descripcion_mesa.TabIndex = 2;
            this.Lbl_descripcion_mesa.Text = "Mesa #x";
            this.Lbl_descripcion_mesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pct_estado
            // 
            this.Pct_estado.Image = ((System.Drawing.Image)(resources.GetObject("Pct_estado.Image")));
            this.Pct_estado.Location = new System.Drawing.Point(52, 3);
            this.Pct_estado.Name = "Pct_estado";
            this.Pct_estado.Size = new System.Drawing.Size(31, 21);
            this.Pct_estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_estado.TabIndex = 1;
            this.Pct_estado.TabStop = false;
            // 
            // Pct_imagen_mesa
            // 
            this.Pct_imagen_mesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_imagen_mesa.Image = ((System.Drawing.Image)(resources.GetObject("Pct_imagen_mesa.Image")));
            this.Pct_imagen_mesa.Location = new System.Drawing.Point(17, 20);
            this.Pct_imagen_mesa.Name = "Pct_imagen_mesa";
            this.Pct_imagen_mesa.Size = new System.Drawing.Size(101, 84);
            this.Pct_imagen_mesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_imagen_mesa.TabIndex = 0;
            this.Pct_imagen_mesa.TabStop = false;
            this.Pct_imagen_mesa.Click += new System.EventHandler(this.Pct_imagen_mesa_Click);
            // 
            // Lbl_fecha_trabajo
            // 
            this.Lbl_fecha_trabajo.Location = new System.Drawing.Point(3, 74);
            this.Lbl_fecha_trabajo.Name = "Lbl_fecha_trabajo";
            this.Lbl_fecha_trabajo.Size = new System.Drawing.Size(13, 10);
            this.Lbl_fecha_trabajo.TabIndex = 8;
            this.Lbl_fecha_trabajo.Text = "Lbl_fecha_trabajo";
            this.Lbl_fecha_trabajo.Visible = false;
            // 
            // MiMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_mesa);
            this.Name = "MiMesa";
            this.Size = new System.Drawing.Size(141, 137);
            this.Pnl_mesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_mesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_mesa;
        private System.Windows.Forms.PictureBox Pct_imagen_mesa;
        private System.Windows.Forms.Label Lbl_descripcion_mesa;
        private System.Windows.Forms.PictureBox Pct_estado;
        private System.Windows.Forms.Label Lbl_codigo_me;
        private System.Windows.Forms.Label Lbl_codigo_pv;
        private System.Windows.Forms.Label Lbl_descripcion_pv;
        private System.Windows.Forms.Label Lbl_codigo_us;
        private System.Windows.Forms.Label Lbl_codigo_tu;
        private System.Windows.Forms.Label Lbl_fecha_trabajo;
    }
}

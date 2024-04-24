namespace Sol_PuntoVenta.Presentacion.Controles
{
    partial class MiProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiProducto));
            this.Pnl_producto = new System.Windows.Forms.Panel();
            this.Lbl_codigo_im = new System.Windows.Forms.Label();
            this.Lbl_codigo_pr = new System.Windows.Forms.Label();
            this.Lbl_precio_unitario = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pr = new System.Windows.Forms.Label();
            this.Pct_imagen_pr = new System.Windows.Forms.PictureBox();
            this.Lbl_archivo_txt = new System.Windows.Forms.Label();
            this.Pnl_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_producto
            // 
            this.Pnl_producto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pnl_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_producto.Controls.Add(this.Lbl_archivo_txt);
            this.Pnl_producto.Controls.Add(this.Lbl_codigo_im);
            this.Pnl_producto.Controls.Add(this.Lbl_codigo_pr);
            this.Pnl_producto.Controls.Add(this.Lbl_precio_unitario);
            this.Pnl_producto.Controls.Add(this.Lbl_descripcion_pr);
            this.Pnl_producto.Controls.Add(this.Pct_imagen_pr);
            this.Pnl_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_producto.Location = new System.Drawing.Point(0, 0);
            this.Pnl_producto.Name = "Pnl_producto";
            this.Pnl_producto.Size = new System.Drawing.Size(180, 195);
            this.Pnl_producto.TabIndex = 0;
            // 
            // Lbl_codigo_im
            // 
            this.Lbl_codigo_im.Location = new System.Drawing.Point(166, 70);
            this.Lbl_codigo_im.Name = "Lbl_codigo_im";
            this.Lbl_codigo_im.Size = new System.Drawing.Size(10, 17);
            this.Lbl_codigo_im.TabIndex = 8;
            this.Lbl_codigo_im.Text = "Codigo_impresora";
            this.Lbl_codigo_im.Visible = false;
            // 
            // Lbl_codigo_pr
            // 
            this.Lbl_codigo_pr.Location = new System.Drawing.Point(3, 34);
            this.Lbl_codigo_pr.Name = "Lbl_codigo_pr";
            this.Lbl_codigo_pr.Size = new System.Drawing.Size(10, 17);
            this.Lbl_codigo_pr.TabIndex = 7;
            this.Lbl_codigo_pr.Text = "Codigo_pr";
            this.Lbl_codigo_pr.Visible = false;
            // 
            // Lbl_precio_unitario
            // 
            this.Lbl_precio_unitario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_precio_unitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precio_unitario.Location = new System.Drawing.Point(0, 119);
            this.Lbl_precio_unitario.Name = "Lbl_precio_unitario";
            this.Lbl_precio_unitario.Size = new System.Drawing.Size(178, 37);
            this.Lbl_precio_unitario.TabIndex = 6;
            this.Lbl_precio_unitario.Text = "Precio x";
            this.Lbl_precio_unitario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_descripcion_pr
            // 
            this.Lbl_descripcion_pr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_descripcion_pr.Location = new System.Drawing.Point(0, 156);
            this.Lbl_descripcion_pr.Name = "Lbl_descripcion_pr";
            this.Lbl_descripcion_pr.Size = new System.Drawing.Size(178, 37);
            this.Lbl_descripcion_pr.TabIndex = 5;
            this.Lbl_descripcion_pr.Text = "Producto x";
            this.Lbl_descripcion_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pct_imagen_pr
            // 
            this.Pct_imagen_pr.Image = ((System.Drawing.Image)(resources.GetObject("Pct_imagen_pr.Image")));
            this.Pct_imagen_pr.Location = new System.Drawing.Point(16, 1);
            this.Pct_imagen_pr.Name = "Pct_imagen_pr";
            this.Pct_imagen_pr.Size = new System.Drawing.Size(150, 110);
            this.Pct_imagen_pr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_imagen_pr.TabIndex = 4;
            this.Pct_imagen_pr.TabStop = false;
            this.Pct_imagen_pr.Click += new System.EventHandler(this.Pct_imagen_pr_Click);
            // 
            // Lbl_archivo_txt
            // 
            this.Lbl_archivo_txt.Location = new System.Drawing.Point(0, 64);
            this.Lbl_archivo_txt.Name = "Lbl_archivo_txt";
            this.Lbl_archivo_txt.Size = new System.Drawing.Size(13, 23);
            this.Lbl_archivo_txt.TabIndex = 9;
            this.Lbl_archivo_txt.Text = "Lbl_archivo_txt";
            this.Lbl_archivo_txt.Visible = false;
            // 
            // MiProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_producto);
            this.Name = "MiProducto";
            this.Size = new System.Drawing.Size(180, 195);
            this.Pnl_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_producto;
        private System.Windows.Forms.Label Lbl_codigo_pr;
        private System.Windows.Forms.Label Lbl_precio_unitario;
        private System.Windows.Forms.Label Lbl_descripcion_pr;
        private System.Windows.Forms.PictureBox Pct_imagen_pr;
        private System.Windows.Forms.Label Lbl_codigo_im;
        private System.Windows.Forms.Label Lbl_archivo_txt;
    }
}

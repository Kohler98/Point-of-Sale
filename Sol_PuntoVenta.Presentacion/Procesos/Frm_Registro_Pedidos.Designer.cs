namespace Sol_PuntoVenta.Presentacion.Procesos
{
    partial class Frm_Registro_Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro_Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_registarpedidos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Pnl_superior = new System.Windows.Forms.Panel();
            this.Pnl_Listado1 = new System.Windows.Forms.Panel();
            this.Btn_retornar1 = new System.Windows.Forms.Button();
            this.Dgv_Listado1 = new System.Windows.Forms.DataGridView();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_turno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_fecha_trabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_lupa = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Txt_punto_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_mesas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_registarpedidos.SuspendLayout();
            this.Pnl_superior.SuspendLayout();
            this.Pnl_Listado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado1)).BeginInit();
            this.Pnl_mesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_registarpedidos
            // 
            this.Pnl_registarpedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.Pnl_registarpedidos.Controls.Add(this.label3);
            this.Pnl_registarpedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_registarpedidos.Location = new System.Drawing.Point(0, 0);
            this.Pnl_registarpedidos.Name = "Pnl_registarpedidos";
            this.Pnl_registarpedidos.Size = new System.Drawing.Size(857, 48);
            this.Pnl_registarpedidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(36, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "REGISTRAR PEDIDOS";
            // 
            // Pnl_superior
            // 
            this.Pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_superior.Controls.Add(this.Pnl_Listado1);
            this.Pnl_superior.Controls.Add(this.Txt_estado);
            this.Pnl_superior.Controls.Add(this.Btn_salir);
            this.Pnl_superior.Controls.Add(this.label6);
            this.Pnl_superior.Controls.Add(this.Txt_turno);
            this.Pnl_superior.Controls.Add(this.label5);
            this.Pnl_superior.Controls.Add(this.Lbl_mensaje);
            this.Pnl_superior.Controls.Add(this.Txt_fecha_trabajo);
            this.Pnl_superior.Controls.Add(this.label4);
            this.Pnl_superior.Controls.Add(this.Btn_lupa);
            this.Pnl_superior.Controls.Add(this.Txt_punto_venta);
            this.Pnl_superior.Controls.Add(this.label2);
            this.Pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_superior.Location = new System.Drawing.Point(0, 48);
            this.Pnl_superior.Name = "Pnl_superior";
            this.Pnl_superior.Size = new System.Drawing.Size(857, 140);
            this.Pnl_superior.TabIndex = 6;
            // 
            // Pnl_Listado1
            // 
            this.Pnl_Listado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pnl_Listado1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_Listado1.Controls.Add(this.Btn_retornar1);
            this.Pnl_Listado1.Controls.Add(this.Dgv_Listado1);
            this.Pnl_Listado1.Location = new System.Drawing.Point(490, 15);
            this.Pnl_Listado1.Name = "Pnl_Listado1";
            this.Pnl_Listado1.Size = new System.Drawing.Size(355, 150);
            this.Pnl_Listado1.TabIndex = 18;
            this.Pnl_Listado1.Visible = false;
            // 
            // Btn_retornar1
            // 
            this.Btn_retornar1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_retornar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retornar1.Image")));
            this.Btn_retornar1.Location = new System.Drawing.Point(313, 3);
            this.Btn_retornar1.Name = "Btn_retornar1";
            this.Btn_retornar1.Size = new System.Drawing.Size(34, 27);
            this.Btn_retornar1.TabIndex = 15;
            this.Btn_retornar1.UseVisualStyleBackColor = true;
            this.Btn_retornar1.Click += new System.EventHandler(this.Btn_retornar1_Click);
            // 
            // Dgv_Listado1
            // 
            this.Dgv_Listado1.AllowUserToAddRows = false;
            this.Dgv_Listado1.AllowUserToDeleteRows = false;
            this.Dgv_Listado1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dgv_Listado1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado1.ColumnHeadersHeight = 35;
            this.Dgv_Listado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado1.EnableHeadersVisualStyles = false;
            this.Dgv_Listado1.Location = new System.Drawing.Point(7, 3);
            this.Dgv_Listado1.Name = "Dgv_Listado1";
            this.Dgv_Listado1.ReadOnly = true;
            this.Dgv_Listado1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado1.Size = new System.Drawing.Size(300, 138);
            this.Dgv_Listado1.TabIndex = 13;
            this.Dgv_Listado1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado1_CellContentDoubleClick);
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_mensaje.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mensaje.ForeColor = System.Drawing.Color.Red;
            this.Lbl_mensaje.Location = new System.Drawing.Point(0, 107);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(857, 33);
            this.Lbl_mensaje.TabIndex = 17;
            this.Lbl_mensaje.Text = "Mensaje";
            this.Lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_mensaje.Visible = false;
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_estado.Location = new System.Drawing.Point(695, 90);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.ReadOnly = true;
            this.Txt_estado.Size = new System.Drawing.Size(142, 27);
            this.Txt_estado.TabIndex = 16;
            this.Txt_estado.Text = "Estado X";
            this.Txt_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(695, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_turno
            // 
            this.Txt_turno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_turno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_turno.Location = new System.Drawing.Point(547, 90);
            this.Txt_turno.Name = "Txt_turno";
            this.Txt_turno.ReadOnly = true;
            this.Txt_turno.Size = new System.Drawing.Size(142, 27);
            this.Txt_turno.TabIndex = 14;
            this.Txt_turno.Text = "Turno X";
            this.Txt_turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(547, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Turno";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_fecha_trabajo
            // 
            this.Txt_fecha_trabajo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_trabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_fecha_trabajo.Location = new System.Drawing.Point(547, 28);
            this.Txt_fecha_trabajo.Name = "Txt_fecha_trabajo";
            this.Txt_fecha_trabajo.ReadOnly = true;
            this.Txt_fecha_trabajo.Size = new System.Drawing.Size(290, 27);
            this.Txt_fecha_trabajo.TabIndex = 12;
            this.Txt_fecha_trabajo.Text = "Fecha de Trabajo x";
            this.Txt_fecha_trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(547, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Trabajo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_lupa
            // 
            this.Btn_lupa.BackColor = System.Drawing.Color.Silver;
            this.Btn_lupa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_lupa.FlatAppearance.BorderSize = 0;
            this.Btn_lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lupa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_lupa.Image")));
            this.Btn_lupa.Location = new System.Drawing.Point(478, 50);
            this.Btn_lupa.Name = "Btn_lupa";
            this.Btn_lupa.Size = new System.Drawing.Size(38, 34);
            this.Btn_lupa.TabIndex = 10;
            this.Btn_lupa.UseVisualStyleBackColor = false;
            this.Btn_lupa.Click += new System.EventHandler(this.Btn_lupa_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(19, 6);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(99, 63);
            this.Btn_salir.TabIndex = 9;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "reporte.png");
            this.imageList1.Images.SetKeyName(1, "editar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "salir.png");
            this.imageList1.Images.SetKeyName(4, "nuevo.png");
            // 
            // Txt_punto_venta
            // 
            this.Txt_punto_venta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_punto_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_punto_venta.Location = new System.Drawing.Point(172, 54);
            this.Txt_punto_venta.Name = "Txt_punto_venta";
            this.Txt_punto_venta.Size = new System.Drawing.Size(300, 27);
            this.Txt_punto_venta.TabIndex = 1;
            this.Txt_punto_venta.Text = "Punto Venta x";
            this.Txt_punto_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(172, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de Venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_mesas
            // 
            this.Pnl_mesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.Pnl_mesas.Controls.Add(this.label1);
            this.Pnl_mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_mesas.Location = new System.Drawing.Point(0, 188);
            this.Pnl_mesas.Name = "Pnl_mesas";
            this.Pnl_mesas.Size = new System.Drawing.Size(857, 40);
            this.Pnl_mesas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "::: MESAS :::";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(857, 372);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Registro_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Pnl_mesas);
            this.Controls.Add(this.Pnl_superior);
            this.Controls.Add(this.Pnl_registarpedidos);
            this.Name = "Frm_Registro_Pedidos";
            this.Text = "Frm_Registro_Pedidos";
            this.Load += new System.EventHandler(this.Frm_Registro_Pedidos_Load);
            this.Pnl_registarpedidos.ResumeLayout(false);
            this.Pnl_registarpedidos.PerformLayout();
            this.Pnl_superior.ResumeLayout(false);
            this.Pnl_superior.PerformLayout();
            this.Pnl_Listado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado1)).EndInit();
            this.Pnl_mesas.ResumeLayout(false);
            this.Pnl_mesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_registarpedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pnl_superior;
        private System.Windows.Forms.Panel Pnl_mesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_punto_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_lupa;
        private System.Windows.Forms.TextBox Txt_turno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_fecha_trabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_mensaje;
        private System.Windows.Forms.Panel Pnl_Listado1;
        private System.Windows.Forms.DataGridView Dgv_Listado1;
        private System.Windows.Forms.Button Btn_retornar1;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace Sol_PuntoVenta.Presentacion.Procesos
{
    partial class Frm_Cierres_Turnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cierres_Turnos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_Listado1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_cerrar_turno = new System.Windows.Forms.Button();
            this.Btn_abrir_turno = new System.Windows.Forms.Button();
            this.Txt_estado_actual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_turno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_fecha_trabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_punto_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 48);
            this.panel1.TabIndex = 5;
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
            this.label3.Text = "GESTION DE TURNOS";
            // 
            // Dgv_Listado1
            // 
            this.Dgv_Listado1.AllowUserToAddRows = false;
            this.Dgv_Listado1.AllowUserToDeleteRows = false;
            this.Dgv_Listado1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Dgv_Listado1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Listado1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Listado1.ColumnHeadersHeight = 35;
            this.Dgv_Listado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado1.EnableHeadersVisualStyles = false;
            this.Dgv_Listado1.Location = new System.Drawing.Point(39, 54);
            this.Dgv_Listado1.Name = "Dgv_Listado1";
            this.Dgv_Listado1.ReadOnly = true;
            this.Dgv_Listado1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado1.Size = new System.Drawing.Size(461, 180);
            this.Dgv_Listado1.TabIndex = 14;
            this.Dgv_Listado1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_cerrar_turno);
            this.panel2.Controls.Add(this.Btn_abrir_turno);
            this.panel2.Controls.Add(this.Txt_estado_actual);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Txt_turno);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Txt_fecha_trabajo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Txt_punto_venta);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(39, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 221);
            this.panel2.TabIndex = 15;
            // 
            // Btn_cerrar_turno
            // 
            this.Btn_cerrar_turno.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_cerrar_turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar_turno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_cerrar_turno.Location = new System.Drawing.Point(302, 182);
            this.Btn_cerrar_turno.Name = "Btn_cerrar_turno";
            this.Btn_cerrar_turno.Size = new System.Drawing.Size(140, 26);
            this.Btn_cerrar_turno.TabIndex = 26;
            this.Btn_cerrar_turno.Text = "Cierre turno";
            this.Btn_cerrar_turno.UseVisualStyleBackColor = false;
            this.Btn_cerrar_turno.Click += new System.EventHandler(this.Btn_cerrar_turno_Click);
            // 
            // Btn_abrir_turno
            // 
            this.Btn_abrir_turno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.Btn_abrir_turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_abrir_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abrir_turno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_abrir_turno.Location = new System.Drawing.Point(142, 182);
            this.Btn_abrir_turno.Name = "Btn_abrir_turno";
            this.Btn_abrir_turno.Size = new System.Drawing.Size(140, 26);
            this.Btn_abrir_turno.TabIndex = 25;
            this.Btn_abrir_turno.Text = "Abrir turno";
            this.Btn_abrir_turno.UseVisualStyleBackColor = false;
            this.Btn_abrir_turno.Click += new System.EventHandler(this.Btn_abrir_turno_Click);
            // 
            // Txt_estado_actual
            // 
            this.Txt_estado_actual.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_estado_actual.Location = new System.Drawing.Point(142, 152);
            this.Txt_estado_actual.Name = "Txt_estado_actual";
            this.Txt_estado_actual.ReadOnly = true;
            this.Txt_estado_actual.Size = new System.Drawing.Size(300, 24);
            this.Txt_estado_actual.TabIndex = 24;
            this.Txt_estado_actual.Text = "Estado actual x";
            this.Txt_estado_actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(37, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estado actual:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_turno
            // 
            this.Txt_turno.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_turno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_turno.Location = new System.Drawing.Point(142, 122);
            this.Txt_turno.Name = "Txt_turno";
            this.Txt_turno.ReadOnly = true;
            this.Txt_turno.Size = new System.Drawing.Size(300, 24);
            this.Txt_turno.TabIndex = 22;
            this.Txt_turno.Text = "Turno x";
            this.Txt_turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(86, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Turno:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_fecha_trabajo
            // 
            this.Txt_fecha_trabajo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha_trabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_fecha_trabajo.Location = new System.Drawing.Point(142, 92);
            this.Txt_fecha_trabajo.Name = "Txt_fecha_trabajo";
            this.Txt_fecha_trabajo.ReadOnly = true;
            this.Txt_fecha_trabajo.Size = new System.Drawing.Size(300, 24);
            this.Txt_fecha_trabajo.TabIndex = 20;
            this.Txt_fecha_trabajo.Text = "Fecha de trabajo x";
            this.Txt_fecha_trabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha de trabajo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_punto_venta
            // 
            this.Txt_punto_venta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_punto_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_punto_venta.Location = new System.Drawing.Point(142, 62);
            this.Txt_punto_venta.Name = "Txt_punto_venta";
            this.Txt_punto_venta.ReadOnly = true;
            this.Txt_punto_venta.Size = new System.Drawing.Size(300, 24);
            this.Txt_punto_venta.TabIndex = 18;
            this.Txt_punto_venta.Text = "Punto Venta x";
            this.Txt_punto_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Punto de Venta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 48);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(133, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS ACTUALES DEL TURNO";
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
            this.imageList1.Images.SetKeyName(5, "visualizar pedido.png");
            this.imageList1.Images.SetKeyName(6, "crear pedido.png");
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(827, 65);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(99, 63);
            this.Btn_salir.TabIndex = 18;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_Cierres_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 486);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dgv_Listado1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cierres_Turnos";
            this.Text = "Frm_Cierres_Turnos";
            this.Load += new System.EventHandler(this.Frm_Cierres_Turnos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_Listado1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_fecha_trabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_punto_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_estado_actual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_turno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_abrir_turno;
        private System.Windows.Forms.Button Btn_cerrar_turno;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_salir;
    }
}
﻿namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Familias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_DatosMaestros = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestros();
            this.uSPListadofaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_faTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestrosTableAdapters.USP_Listado_faTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadofaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadofaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Familia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(863, 533);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_DatosMaestros
            // 
            this.dataSet_DatosMaestros.DataSetName = "DataSet_DatosMaestros";
            this.dataSet_DatosMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadofaBindingSource
            // 
            this.uSPListadofaBindingSource.DataMember = "USP_Listado_fa";
            this.uSPListadofaBindingSource.DataSource = this.dataSet_DatosMaestros;
            // 
            // uSP_Listado_faTableAdapter
            // 
            this.uSP_Listado_faTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(38, 53);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 2;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 533);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Familias";
            this.Text = "Frm_Rpt_Familias";
            this.Load += new System.EventHandler(this.Frm_Rpt_Familias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadofaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadofaBindingSource;
        private DataSet_DatosMaestros dataSet_DatosMaestros;
        private DataSet_DatosMaestrosTableAdapters.USP_Listado_faTableAdapter uSP_Listado_faTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}
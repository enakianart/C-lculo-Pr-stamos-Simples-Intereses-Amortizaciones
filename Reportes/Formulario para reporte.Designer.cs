namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes
{
    partial class Formulario_para_reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RV1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_prestamosDataSet = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSet();
            this.dbprestamosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesdtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amortizaciondtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprestamosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizaciondtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RV1
            // 
            this.RV1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientesdtBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.amortizaciondtBindingSource;
            this.RV1.LocalReport.DataSources.Add(reportDataSource1);
            this.RV1.LocalReport.DataSources.Add(reportDataSource2);
            this.RV1.LocalReport.ReportEmbeddedResource = "Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes.Reporte_Cliente.rdl" +
    "c";
            this.RV1.Location = new System.Drawing.Point(0, 0);
            this.RV1.Name = "RV1";
            this.RV1.Size = new System.Drawing.Size(800, 450);
            this.RV1.TabIndex = 0;
            // 
            // db_prestamosDataSet
            // 
            this.db_prestamosDataSet.DataSetName = "db_prestamosDataSet";
            this.db_prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbprestamosDataSetBindingSource
            // 
            this.dbprestamosDataSetBindingSource.DataSource = this.db_prestamosDataSet;
            this.dbprestamosDataSetBindingSource.Position = 0;
            // 
            // clientesdtBindingSource
            // 
            this.clientesdtBindingSource.DataMember = "Clientesdt";
            this.clientesdtBindingSource.DataSource = this.dbprestamosDataSetBindingSource;
            // 
            // amortizaciondtBindingSource
            // 
            this.amortizaciondtBindingSource.DataMember = "Amortizaciondt";
            this.amortizaciondtBindingSource.DataSource = this.dbprestamosDataSetBindingSource;
            // 
            // Formulario_para_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV1);
            this.Name = "Formulario_para_reporte";
            this.Text = "Formulario_para_reporte";
            this.Load += new System.EventHandler(this.Formulario_para_reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprestamosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortizaciondtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_prestamosDataSet db_prestamosDataSet;
        private System.Windows.Forms.BindingSource dbprestamosDataSetBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer RV1;
        private System.Windows.Forms.BindingSource clientesdtBindingSource;
        private System.Windows.Forms.BindingSource amortizaciondtBindingSource;
    }
}
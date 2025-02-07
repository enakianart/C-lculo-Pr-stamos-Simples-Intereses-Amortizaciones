namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes
{
    partial class FormulariodelReportV
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
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_prestamosDataSet = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSet();
            this.RV_Clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbprestamosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btninforme = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprestamosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.db_prestamosDataSet;
            // 
            // db_prestamosDataSet
            // 
            this.db_prestamosDataSet.DataSetName = "db_prestamosDataSet";
            this.db_prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RV_Clientes
            // 
            reportDataSource2.Name = "DS_Clientes";
            reportDataSource2.Value = this.clientesBindingSource1;
            this.RV_Clientes.LocalReport.DataSources.Add(reportDataSource2);
            this.RV_Clientes.LocalReport.ReportEmbeddedResource = "Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes.Reporte_Clientes.rd" +
    "lc";
            this.RV_Clientes.Location = new System.Drawing.Point(12, 16);
            this.RV_Clientes.Name = "RV_Clientes";
            this.RV_Clientes.ServerReport.BearerToken = null;
            this.RV_Clientes.Size = new System.Drawing.Size(707, 277);
            this.RV_Clientes.TabIndex = 0;
            this.RV_Clientes.Load += new System.EventHandler(this.RV_Clientes_Load);
            // 
            // dbprestamosDataSetBindingSource
            // 
            this.dbprestamosDataSetBindingSource.DataSource = this.db_prestamosDataSet;
            this.dbprestamosDataSetBindingSource.Position = 0;
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.db_prestamosDataSet;
            // 
            // btninforme
            // 
            this.btninforme.BackColor = System.Drawing.Color.SeaGreen;
            this.btninforme.ForeColor = System.Drawing.Color.Black;
            this.btninforme.Location = new System.Drawing.Point(12, 308);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(175, 42);
            this.btninforme.TabIndex = 1;
            this.btninforme.Text = "Obtener informe";
            this.btninforme.UseVisualStyleBackColor = false;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // FormulariodelReportV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(850, 393);
            this.Controls.Add(this.btninforme);
            this.Controls.Add(this.RV_Clientes);
            this.Name = "FormulariodelReportV";
            this.Text = "FormulariodelReportV";
            this.Load += new System.EventHandler(this.FormulariodelReportV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprestamosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_Clientes;
        private System.Windows.Forms.BindingSource dbprestamosDataSetBindingSource;
        private db_prestamosDataSet db_prestamosDataSet;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private db_prestamosDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}
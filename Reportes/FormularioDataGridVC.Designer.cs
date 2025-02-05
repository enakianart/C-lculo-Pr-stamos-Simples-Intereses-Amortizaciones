namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes
{
    partial class FormularioDataGridVC
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
            this.DTVclientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_prestamosDataSet = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DTVclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DTVclientes
            // 
            this.DTVclientes.AutoGenerateColumns = false;
            this.DTVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVclientes.DataSource = this.clientesBindingSource;
            this.DTVclientes.Location = new System.Drawing.Point(12, 35);
            this.DTVclientes.Name = "DTVclientes";
            this.DTVclientes.Size = new System.Drawing.Size(444, 255);
            this.DTVclientes.TabIndex = 0;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.db_prestamosDataSet;
            // 
            // db_prestamosDataSet
            // 
            this.db_prestamosDataSet.DataSetName = "db_prestamosDataSet";
            this.db_prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormularioDataGridVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 342);
            this.Controls.Add(this.DTVclientes);
            this.Name = "FormularioDataGridVC";
            this.Text = "FormularioDataGridVC";
            this.Load += new System.EventHandler(this.FormularioDataGridVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTVclientes;
        private db_prestamosDataSet db_prestamosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}
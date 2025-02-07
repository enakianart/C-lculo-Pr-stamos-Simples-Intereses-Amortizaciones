namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes
{
    partial class FormulariodelDataGridView
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
            this.Cliente_Dtv = new System.Windows.Forms.DataGridView();
            this.clientesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_prestamosDataSet = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSet();
            this.clientesTableAdapter = new Cálculo_Préstamos_Simples__Intereses__Amortizaciones.db_prestamosDataSetTableAdapters.ClientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_Dtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente_Dtv
            // 
            this.Cliente_Dtv.AutoGenerateColumns = false;
            this.Cliente_Dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cliente_Dtv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientesIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.sueldoDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cantidadMorasDataGridViewTextBoxColumn});
            this.Cliente_Dtv.DataSource = this.clientesBindingSource1;
            this.Cliente_Dtv.Location = new System.Drawing.Point(120, 83);
            this.Cliente_Dtv.Name = "Cliente_Dtv";
            this.Cliente_Dtv.Size = new System.Drawing.Size(433, 202);
            this.Cliente_Dtv.TabIndex = 0;
            // 
            // clientesIdDataGridViewTextBoxColumn
            // 
            this.clientesIdDataGridViewTextBoxColumn.DataPropertyName = "ClientesId";
            this.clientesIdDataGridViewTextBoxColumn.HeaderText = "ClientesId";
            this.clientesIdDataGridViewTextBoxColumn.Name = "clientesIdDataGridViewTextBoxColumn";
            this.clientesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            this.sueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo";
            this.sueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            this.sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cantidadMorasDataGridViewTextBoxColumn
            // 
            this.cantidadMorasDataGridViewTextBoxColumn.DataPropertyName = "CantidadMoras";
            this.cantidadMorasDataGridViewTextBoxColumn.HeaderText = "CantidadMoras";
            this.cantidadMorasDataGridViewTextBoxColumn.Name = "cantidadMorasDataGridViewTextBoxColumn";
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 285);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informacion del cliente";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.db_prestamosDataSet;
            // 
            // FormulariodelDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(584, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cliente_Dtv);
            this.Name = "FormulariodelDataGridView";
            this.Text = "FormulariodelDataGridView";
            this.Load += new System.EventHandler(this.FormulariodelDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_Dtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Cliente_Dtv;
        private db_prestamosDataSet db_prestamosDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private db_prestamosDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
    }
}
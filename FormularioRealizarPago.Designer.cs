namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    partial class FormularioRealizarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRealizarPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VolverBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.BuscarTXT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MontoAnteriorLABEL = new System.Windows.Forms.Label();
            this.MontoActualLABEL = new System.Windows.Forms.Label();
            this.CuotaLABEL = new System.Windows.Forms.Label();
            this.FechaPagoLABEL = new System.Windows.Forms.Label();
            this.PagarBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.VolverBTN);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 631);
            this.panel1.TabIndex = 18;
            // 
            // VolverBTN
            // 
            this.VolverBTN.BackColor = System.Drawing.Color.White;
            this.VolverBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBTN.Location = new System.Drawing.Point(19, 571);
            this.VolverBTN.Name = "VolverBTN";
            this.VolverBTN.Size = new System.Drawing.Size(124, 50);
            this.VolverBTN.TabIndex = 12;
            this.VolverBTN.Text = "Volver";
            this.VolverBTN.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(512, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar el pago de un cliente según su nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.BackColor = System.Drawing.Color.White;
            this.BuscarBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBTN.Location = new System.Drawing.Point(697, 96);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(124, 50);
            this.BuscarBTN.TabIndex = 20;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = false;
            this.BuscarBTN.Click += new System.EventHandler(this.BuscarBTN_Click);
            // 
            // BuscarTXT
            // 
            this.BuscarTXT.Location = new System.Drawing.Point(378, 111);
            this.BuscarTXT.Name = "BuscarTXT";
            this.BuscarTXT.Size = new System.Drawing.Size(297, 26);
            this.BuscarTXT.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(960, 212);
            this.dataGridView1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 70);
            this.label1.TabIndex = 22;
            this.label1.Text = "Realizar Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(887, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingrese el nombre del cliente que desea realizar un pago\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Monto anterior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(485, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 38);
            this.label5.TabIndex = 27;
            this.label5.Text = "Monto actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(974, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 38);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(795, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 38);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cuota";
            // 
            // MontoAnteriorLABEL
            // 
            this.MontoAnteriorLABEL.AutoSize = true;
            this.MontoAnteriorLABEL.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoAnteriorLABEL.ForeColor = System.Drawing.Color.White;
            this.MontoAnteriorLABEL.Location = new System.Drawing.Point(279, 292);
            this.MontoAnteriorLABEL.Name = "MontoAnteriorLABEL";
            this.MontoAnteriorLABEL.Size = new System.Drawing.Size(53, 38);
            this.MontoAnteriorLABEL.TabIndex = 30;
            this.MontoAnteriorLABEL.Text = "00";
            // 
            // MontoActualLABEL
            // 
            this.MontoActualLABEL.AutoSize = true;
            this.MontoActualLABEL.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoActualLABEL.ForeColor = System.Drawing.Color.White;
            this.MontoActualLABEL.Location = new System.Drawing.Point(556, 292);
            this.MontoActualLABEL.Name = "MontoActualLABEL";
            this.MontoActualLABEL.Size = new System.Drawing.Size(53, 38);
            this.MontoActualLABEL.TabIndex = 31;
            this.MontoActualLABEL.Text = "00";
            // 
            // CuotaLABEL
            // 
            this.CuotaLABEL.AutoSize = true;
            this.CuotaLABEL.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuotaLABEL.ForeColor = System.Drawing.Color.White;
            this.CuotaLABEL.Location = new System.Drawing.Point(826, 292);
            this.CuotaLABEL.Name = "CuotaLABEL";
            this.CuotaLABEL.Size = new System.Drawing.Size(53, 38);
            this.CuotaLABEL.TabIndex = 32;
            this.CuotaLABEL.Text = "00";
            // 
            // FechaPagoLABEL
            // 
            this.FechaPagoLABEL.AutoSize = true;
            this.FechaPagoLABEL.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPagoLABEL.ForeColor = System.Drawing.Color.White;
            this.FechaPagoLABEL.Location = new System.Drawing.Point(1038, 292);
            this.FechaPagoLABEL.Name = "FechaPagoLABEL";
            this.FechaPagoLABEL.Size = new System.Drawing.Size(53, 38);
            this.FechaPagoLABEL.TabIndex = 33;
            this.FechaPagoLABEL.Text = "00";
            // 
            // PagarBTN
            // 
            this.PagarBTN.BackColor = System.Drawing.Color.White;
            this.PagarBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarBTN.Location = new System.Drawing.Point(1166, 471);
            this.PagarBTN.Name = "PagarBTN";
            this.PagarBTN.Size = new System.Drawing.Size(124, 50);
            this.PagarBTN.TabIndex = 34;
            this.PagarBTN.Text = "Pagar";
            this.PagarBTN.UseVisualStyleBackColor = false;
            this.PagarBTN.Click += new System.EventHandler(this.PagarBTN_Click);
            // 
            // FormularioRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1319, 655);
            this.Controls.Add(this.PagarBTN);
            this.Controls.Add(this.FechaPagoLABEL);
            this.Controls.Add(this.CuotaLABEL);
            this.Controls.Add(this.MontoActualLABEL);
            this.Controls.Add(this.MontoAnteriorLABEL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.BuscarTXT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioRealizarPago";
            this.Text = "FormConsultarPagos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VolverBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.TextBox BuscarTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MontoAnteriorLABEL;
        private System.Windows.Forms.Label MontoActualLABEL;
        private System.Windows.Forms.Label CuotaLABEL;
        private System.Windows.Forms.Label FechaPagoLABEL;
        private System.Windows.Forms.Button PagarBTN;
    }
}
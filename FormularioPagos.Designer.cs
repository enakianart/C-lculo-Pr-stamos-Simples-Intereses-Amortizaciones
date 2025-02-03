namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    partial class FormularioPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConsultarPagoBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GestionarPagoBTN = new System.Windows.Forms.Button();
            this.VolverBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 81);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pagos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarPagoBTN
            // 
            this.ConsultarPagoBTN.BackColor = System.Drawing.Color.White;
            this.ConsultarPagoBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarPagoBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsultarPagoBTN.Location = new System.Drawing.Point(50, 36);
            this.ConsultarPagoBTN.Name = "ConsultarPagoBTN";
            this.ConsultarPagoBTN.Size = new System.Drawing.Size(320, 54);
            this.ConsultarPagoBTN.TabIndex = 4;
            this.ConsultarPagoBTN.Text = "Consultar pago";
            this.ConsultarPagoBTN.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.ConsultarPagoBTN);
            this.panel1.Controls.Add(this.GestionarPagoBTN);
            this.panel1.Location = new System.Drawing.Point(12, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 122);
            this.panel1.TabIndex = 14;
            // 
            // GestionarPagoBTN
            // 
            this.GestionarPagoBTN.BackColor = System.Drawing.Color.White;
            this.GestionarPagoBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionarPagoBTN.Location = new System.Drawing.Point(538, 36);
            this.GestionarPagoBTN.Name = "GestionarPagoBTN";
            this.GestionarPagoBTN.Size = new System.Drawing.Size(341, 54);
            this.GestionarPagoBTN.TabIndex = 5;
            this.GestionarPagoBTN.Text = "Gestionar pago";
            this.GestionarPagoBTN.UseVisualStyleBackColor = false;
            this.GestionarPagoBTN.Click += new System.EventHandler(this.GestionarPagoBTN_Click);
            // 
            // VolverBTN
            // 
            this.VolverBTN.BackColor = System.Drawing.Color.White;
            this.VolverBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBTN.Location = new System.Drawing.Point(835, 294);
            this.VolverBTN.Name = "VolverBTN";
            this.VolverBTN.Size = new System.Drawing.Size(124, 50);
            this.VolverBTN.TabIndex = 13;
            this.VolverBTN.Text = "Volver";
            this.VolverBTN.UseVisualStyleBackColor = false;
            this.VolverBTN.Click += new System.EventHandler(this.VolverBTN_Click);
            // 
            // FormularioPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(970, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VolverBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioPagos";
            this.Text = "FormularioPagos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ConsultarPagoBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GestionarPagoBTN;
        private System.Windows.Forms.Button VolverBTN;
    }
}
namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    partial class FormularioPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsultarPrestamoBTN = new System.Windows.Forms.Button();
            this.GestionarPrestamoBTN = new System.Windows.Forms.Button();
            this.VolverBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 81);
            this.label1.TabIndex = 19;
            this.label1.Text = "Préstamos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.ConsultarPrestamoBTN);
            this.panel1.Controls.Add(this.GestionarPrestamoBTN);
            this.panel1.Location = new System.Drawing.Point(5, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 122);
            this.panel1.TabIndex = 18;
            // 
            // ConsultarPrestamoBTN
            // 
            this.ConsultarPrestamoBTN.BackColor = System.Drawing.Color.White;
            this.ConsultarPrestamoBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarPrestamoBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsultarPrestamoBTN.Location = new System.Drawing.Point(50, 36);
            this.ConsultarPrestamoBTN.Name = "ConsultarPrestamoBTN";
            this.ConsultarPrestamoBTN.Size = new System.Drawing.Size(320, 54);
            this.ConsultarPrestamoBTN.TabIndex = 4;
            this.ConsultarPrestamoBTN.Text = "Consultar préstamo";
            this.ConsultarPrestamoBTN.UseVisualStyleBackColor = false;
            // 
            // GestionarPrestamoBTN
            // 
            this.GestionarPrestamoBTN.BackColor = System.Drawing.Color.White;
            this.GestionarPrestamoBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionarPrestamoBTN.Location = new System.Drawing.Point(538, 36);
            this.GestionarPrestamoBTN.Name = "GestionarPrestamoBTN";
            this.GestionarPrestamoBTN.Size = new System.Drawing.Size(341, 54);
            this.GestionarPrestamoBTN.TabIndex = 5;
            this.GestionarPrestamoBTN.Text = "Gestionar préstamo";
            this.GestionarPrestamoBTN.UseVisualStyleBackColor = false;
//            this.GestionarPrestamoBTN.Click += new System.EventHandler(this.GestionarPagoBTN_Click);
            // 
            // VolverBTN
            // 
            this.VolverBTN.BackColor = System.Drawing.Color.White;
            this.VolverBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBTN.Location = new System.Drawing.Point(828, 294);
            this.VolverBTN.Name = "VolverBTN";
            this.VolverBTN.Size = new System.Drawing.Size(124, 50);
            this.VolverBTN.TabIndex = 17;
            this.VolverBTN.Text = "Volver";
            this.VolverBTN.UseVisualStyleBackColor = false;
            this.VolverBTN.Click += new System.EventHandler(this.VolverBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(959, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VolverBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioPrestamos";
            this.Text = "FormularioPrestamos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConsultarPrestamoBTN;
        private System.Windows.Forms.Button GestionarPrestamoBTN;
        private System.Windows.Forms.Button VolverBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
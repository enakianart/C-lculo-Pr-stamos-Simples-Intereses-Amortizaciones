namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    partial class FormularioClientes
    {
//<<<<<<< HEAD
        
        private System.ComponentModel.IContainer components = null;

        
//=======
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5
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
            this.ConsultarClienteBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GestionarClienteBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VolverBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarClienteBTN
            // 
            this.ConsultarClienteBTN.BackColor = System.Drawing.Color.White;
            this.ConsultarClienteBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarClienteBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsultarClienteBTN.Location = new System.Drawing.Point(50, 36);
            this.ConsultarClienteBTN.Name = "ConsultarClienteBTN";
            this.ConsultarClienteBTN.Size = new System.Drawing.Size(320, 54);
            this.ConsultarClienteBTN.TabIndex = 4;
            this.ConsultarClienteBTN.Text = "Consultar cliente";
            this.ConsultarClienteBTN.UseVisualStyleBackColor = false;
            this.ConsultarClienteBTN.Click += new System.EventHandler(this.ConsultarClienteBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.ConsultarClienteBTN);
            this.panel1.Controls.Add(this.GestionarClienteBTN);
            this.panel1.Location = new System.Drawing.Point(12, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 122);
            this.panel1.TabIndex = 9;
            // 
            // GestionarClienteBTN
            // 
            this.GestionarClienteBTN.BackColor = System.Drawing.Color.White;
            this.GestionarClienteBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionarClienteBTN.Location = new System.Drawing.Point(538, 36);
            this.GestionarClienteBTN.Name = "GestionarClienteBTN";
            this.GestionarClienteBTN.Size = new System.Drawing.Size(341, 54);
            this.GestionarClienteBTN.TabIndex = 5;
            this.GestionarClienteBTN.Text = "Gestionar cliente";
            this.GestionarClienteBTN.UseVisualStyleBackColor = false;
            this.GestionarClienteBTN.Click += new System.EventHandler(this.GestionarClienteBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clientes";
            // 
            // VolverBTN
            // 
            this.VolverBTN.BackColor = System.Drawing.Color.White;
            this.VolverBTN.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBTN.Location = new System.Drawing.Point(835, 260);
            this.VolverBTN.Name = "VolverBTN";
            this.VolverBTN.Size = new System.Drawing.Size(124, 50);
            this.VolverBTN.TabIndex = 6;
            this.VolverBTN.Text = "Volver";
            this.VolverBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Properties.Resources.Hiki_nivel_1_muy_feli;
            this.pictureBox1.Location = new System.Drawing.Point(359, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.VolverBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioClientes";
            this.Text = "FormularioClientes1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultarClienteBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GestionarClienteBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VolverBTN;
    }
}
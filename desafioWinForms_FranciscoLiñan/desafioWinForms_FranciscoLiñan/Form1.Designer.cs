
namespace desafioWinForms_FranciscoLiñan
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoBermuda = new System.Windows.Forms.CheckBox();
            this.tipoManga = new System.Windows.Forms.CheckBox();
            this.tipoPantalon = new System.Windows.Forms.RadioButton();
            this.tipoCamisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calidadPremium = new System.Windows.Forms.RadioButton();
            this.calidadStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.calcularPrecio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS AL POR MAYOR - PradBit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoBermuda);
            this.groupBox1.Controls.Add(this.tipoManga);
            this.groupBox1.Controls.Add(this.tipoPantalon);
            this.groupBox1.Controls.Add(this.tipoCamisa);
            this.groupBox1.Location = new System.Drawing.Point(96, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // tipoBermuda
            // 
            this.tipoBermuda.AutoSize = true;
            this.tipoBermuda.Location = new System.Drawing.Point(137, 94);
            this.tipoBermuda.Name = "tipoBermuda";
            this.tipoBermuda.Size = new System.Drawing.Size(87, 21);
            this.tipoBermuda.TabIndex = 3;
            this.tipoBermuda.Text = "Bermuda";
            this.tipoBermuda.UseVisualStyleBackColor = true;
            // 
            // tipoManga
            // 
            this.tipoManga.AutoSize = true;
            this.tipoManga.Location = new System.Drawing.Point(137, 52);
            this.tipoManga.Name = "tipoManga";
            this.tipoManga.Size = new System.Drawing.Size(109, 21);
            this.tipoManga.TabIndex = 2;
            this.tipoManga.Text = "Manga corta";
            this.tipoManga.UseVisualStyleBackColor = true;
            // 
            // tipoPantalon
            // 
            this.tipoPantalon.AutoSize = true;
            this.tipoPantalon.Location = new System.Drawing.Point(7, 94);
            this.tipoPantalon.Name = "tipoPantalon";
            this.tipoPantalon.Size = new System.Drawing.Size(85, 21);
            this.tipoPantalon.TabIndex = 1;
            this.tipoPantalon.TabStop = true;
            this.tipoPantalon.Text = "Pantalón";
            this.tipoPantalon.UseVisualStyleBackColor = true;
            this.tipoPantalon.CheckedChanged += new System.EventHandler(this.tipoPantalon_CheckedChanged);
            // 
            // tipoCamisa
            // 
            this.tipoCamisa.AutoSize = true;
            this.tipoCamisa.Location = new System.Drawing.Point(7, 52);
            this.tipoCamisa.Name = "tipoCamisa";
            this.tipoCamisa.Size = new System.Drawing.Size(75, 21);
            this.tipoCamisa.TabIndex = 0;
            this.tipoCamisa.TabStop = true;
            this.tipoCamisa.Text = "Camisa";
            this.tipoCamisa.UseVisualStyleBackColor = true;
            this.tipoCamisa.CheckedChanged += new System.EventHandler(this.tipoCamisa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calidadPremium);
            this.groupBox2.Controls.Add(this.calidadStandard);
            this.groupBox2.Location = new System.Drawing.Point(96, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // calidadPremium
            // 
            this.calidadPremium.AutoSize = true;
            this.calidadPremium.Location = new System.Drawing.Point(150, 31);
            this.calidadPremium.Name = "calidadPremium";
            this.calidadPremium.Size = new System.Drawing.Size(84, 21);
            this.calidadPremium.TabIndex = 1;
            this.calidadPremium.TabStop = true;
            this.calidadPremium.Text = "Premium";
            this.calidadPremium.UseVisualStyleBackColor = true;
            // 
            // calidadStandard
            // 
            this.calidadStandard.AutoSize = true;
            this.calidadStandard.Location = new System.Drawing.Point(18, 31);
            this.calidadStandard.Name = "calidadStandard";
            this.calidadStandard.Size = new System.Drawing.Size(87, 21);
            this.calidadStandard.TabIndex = 0;
            this.calidadStandard.TabStop = true;
            this.calidadStandard.Text = "Standard";
            this.calidadStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precio);
            this.groupBox3.Location = new System.Drawing.Point(96, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(7, 22);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 22);
            this.precio.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cantidad);
            this.groupBox4.Location = new System.Drawing.Point(265, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(6, 21);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 22);
            this.cantidad.TabIndex = 0;
            // 
            // calcularPrecio
            // 
            this.calcularPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calcularPrecio.Location = new System.Drawing.Point(114, 398);
            this.calcularPrecio.Name = "calcularPrecio";
            this.calcularPrecio.Size = new System.Drawing.Size(235, 40);
            this.calcularPrecio.TabIndex = 5;
            this.calcularPrecio.Text = "Calcular precio final";
            this.calcularPrecio.UseVisualStyleBackColor = false;
            this.calcularPrecio.Click += new System.EventHandler(this.calcularPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.calcularPrecio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tipoBermuda;
        private System.Windows.Forms.CheckBox tipoManga;
        private System.Windows.Forms.RadioButton tipoPantalon;
        private System.Windows.Forms.RadioButton tipoCamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton calidadPremium;
        private System.Windows.Forms.RadioButton calidadStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button calcularPrecio;
    }
}


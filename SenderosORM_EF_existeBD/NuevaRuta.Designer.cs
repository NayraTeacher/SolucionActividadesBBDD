namespace SenderosORM_EF_existeBD
{
    partial class NuevaRuta
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.distancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.localizacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desnivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.niveles = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(254, 64);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(318, 31);
            this.nombre.TabIndex = 1;
            // 
            // distancia
            // 
            this.distancia.Location = new System.Drawing.Point(254, 115);
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(318, 31);
            this.distancia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distancia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // localizacion
            // 
            this.localizacion.Location = new System.Drawing.Point(254, 223);
            this.localizacion.Name = "localizacion";
            this.localizacion.Size = new System.Drawing.Size(318, 31);
            this.localizacion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Localizacion";
            // 
            // desnivel
            // 
            this.desnivel.Location = new System.Drawing.Point(254, 170);
            this.desnivel.Name = "desnivel";
            this.desnivel.Size = new System.Drawing.Size(318, 31);
            this.desnivel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desnivel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dificultad";
            // 
            // niveles
            // 
            this.niveles.FormattingEnabled = true;
            this.niveles.Location = new System.Drawing.Point(829, 112);
            this.niveles.Name = "niveles";
            this.niveles.Size = new System.Drawing.Size(215, 33);
            this.niveles.TabIndex = 12;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(829, 57);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(215, 31);
            this.fecha.TabIndex = 13;
            // 
            // NuevaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 464);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.niveles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.localizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desnivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "NuevaRuta";
            this.Text = "NuevaRuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox distancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox localizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desnivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox niveles;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}
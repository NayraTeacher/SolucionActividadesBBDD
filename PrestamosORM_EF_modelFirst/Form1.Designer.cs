namespace PrestamosORM_EF_modelFirst
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(657, 67);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(252, 31);
            this.codigo.TabIndex = 1;
            this.codigo.Text = "Codigo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(657, 130);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(252, 31);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(657, 188);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 31);
            this.precio.TabIndex = 3;
            this.precio.Text = "0,00";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(69, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 289);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 537);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gestion Prestamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.ListView listView1;
    }
}


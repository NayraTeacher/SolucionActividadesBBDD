namespace SenderosORM_EF_existeBD
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
            this.niveles = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            this.senderosGrid = new System.Windows.Forms.DataGridView();
            this.filtro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.senderosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // niveles
            // 
            this.niveles.FormattingEnabled = true;
            this.niveles.Location = new System.Drawing.Point(86, 73);
            this.niveles.Name = "niveles";
            this.niveles.Size = new System.Drawing.Size(215, 33);
            this.niveles.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(1103, 563);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(158, 63);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // senderosGrid
            // 
            this.senderosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.senderosGrid.Location = new System.Drawing.Point(86, 156);
            this.senderosGrid.Name = "senderosGrid";
            this.senderosGrid.RowTemplate.Height = 33;
            this.senderosGrid.Size = new System.Drawing.Size(1175, 369);
            this.senderosGrid.TabIndex = 2;
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(353, 73);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(196, 48);
            this.filtro.TabIndex = 3;
            this.filtro.Text = "Filtrar";
            this.filtro.UseVisualStyleBackColor = true;
            this.filtro.Click += new System.EventHandler(this.filtro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.senderosGrid);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.niveles);
            this.Name = "Form1";
            this.Text = "Senderos";
            ((System.ComponentModel.ISupportInitialize)(this.senderosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox niveles;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridView senderosGrid;
        private System.Windows.Forms.Button filtro;
        private System.Windows.Forms.Button button1;
    }
}


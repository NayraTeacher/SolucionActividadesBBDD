namespace TiendaDirectaADO
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
            this.nOpinion = new System.Windows.Forms.Button();
            this.verCamposOperacion = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verCamposOperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // nOpinion
            // 
            this.nOpinion.Location = new System.Drawing.Point(188, 94);
            this.nOpinion.Name = "nOpinion";
            this.nOpinion.Size = new System.Drawing.Size(416, 175);
            this.nOpinion.TabIndex = 0;
            this.nOpinion.Text = "Nueva Opinion";
            this.nOpinion.UseVisualStyleBackColor = true;
            this.nOpinion.Click += new System.EventHandler(this.nOpinion_Click);
            // 
            // verCamposOperacion
            // 
            this.verCamposOperacion.AllowUserToAddRows = false;
            this.verCamposOperacion.AllowUserToDeleteRows = false;
            this.verCamposOperacion.AllowUserToOrderColumns = true;
            this.verCamposOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verCamposOperacion.Location = new System.Drawing.Point(188, 348);
            this.verCamposOperacion.Name = "verCamposOperacion";
            this.verCamposOperacion.ReadOnly = true;
            this.verCamposOperacion.RowTemplate.Height = 33;
            this.verCamposOperacion.Size = new System.Drawing.Size(812, 268);
            this.verCamposOperacion.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1028, 348);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(277, 115);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refrescar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 685);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.verCamposOperacion);
            this.Controls.Add(this.nOpinion);
            this.Name = "Form1";
            this.Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.verCamposOperacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nOpinion;
        private System.Windows.Forms.DataGridView verCamposOperacion;
        private System.Windows.Forms.Button refresh;
    }
}


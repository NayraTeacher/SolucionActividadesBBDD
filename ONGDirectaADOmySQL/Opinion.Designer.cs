namespace ONGDirectaADOmySQL
{
    partial class Opinion
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.descrBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prioBox = new System.Windows.Forms.TextBox();
            this.bAddCampoOper = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(258, 79);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(312, 31);
            this.idBox.TabIndex = 1;
            // 
            // descrBox
            // 
            this.descrBox.Location = new System.Drawing.Point(258, 129);
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(312, 31);
            this.descrBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prioridad";
            // 
            // prioBox
            // 
            this.prioBox.Location = new System.Drawing.Point(258, 179);
            this.prioBox.Name = "prioBox";
            this.prioBox.Size = new System.Drawing.Size(312, 31);
            this.prioBox.TabIndex = 5;
            // 
            // bAddCampoOper
            // 
            this.bAddCampoOper.Location = new System.Drawing.Point(258, 260);
            this.bAddCampoOper.Name = "bAddCampoOper";
            this.bAddCampoOper.Size = new System.Drawing.Size(225, 58);
            this.bAddCampoOper.TabIndex = 6;
            this.bAddCampoOper.Text = "Añadir";
            this.bAddCampoOper.UseVisualStyleBackColor = true;
            this.bAddCampoOper.Click += new System.EventHandler(this.bAddCampoOper_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAddCampoOper);
            this.Controls.Add(this.prioBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descrBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Name = "Opinion";
            this.Text = "Opinion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox descrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prioBox;
        private System.Windows.Forms.Button bAddCampoOper;
        private System.Windows.Forms.Button button1;
    }
}
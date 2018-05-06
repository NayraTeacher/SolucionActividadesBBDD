using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenderosDirecta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rUTASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rUTASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.senderosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'senderosDataSet.RUTAS' Puede moverla o quitarla según sea necesario.
            this.rUTASTableAdapter.Fill(this.senderosDataSet.RUTAS);

        }
    }
}

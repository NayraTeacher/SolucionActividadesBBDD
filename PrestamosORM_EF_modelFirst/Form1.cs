using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosORM_EF_modelFirst
{
    public partial class Form1 : Form
    {
        private PrestamosModelContainer db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new PrestamosModelContainer();
            Articulos a = new Articulos();
            a.Codigo = codigo.Text;
            a.Nombre = nombre.Text;
            a.Precio = Convert.ToDecimal(precio.Text);
            a.FechaDevolucion = DateTime.MaxValue;
            a.numRenovaciones = 0;
            db.ArticulosSet.Add(a);
            db.SaveChanges();
            LoadListViewArticulos();
        }

        private void LoadListViewArticulos()
        {
            db = new PrestamosModelContainer();
            List<Articulos> listaArticulos = db.ArticulosSet.ToList();
            ListView.ListViewItemCollection listaLd = new ListView.ListViewItemCollection(listView1);
            foreach (Articulos a in listaArticulos)
            {
                listaLd.Add(a.Nombre, 0);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListViewArticulos();
        }
    }

}

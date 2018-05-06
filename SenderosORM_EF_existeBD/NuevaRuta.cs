using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenderosORM_EF_existeBD
{
    public partial class NuevaRuta : Form
    {
        private SenderosEntities2 db;

        public NuevaRuta()
        {
            InitializeComponent();
            LoadComboNiveles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new SenderosEntities2();
            
            //Modo 1
            //RUTA r = new RUTA();
            //r.DISTANCIA = Convert.ToDecimal(distancia.Text);
            //r.DESNIVEL = Convert.ToInt32(desnivel.Text);
            //r.DIFICULTAD = Convert.ToInt32(niveles.SelectedValue);
            //r.FECHA = fecha.Value;
            //r.LOCALIZACION = localizacion.Text;
            //r.NOMBRE = nombre.Text;

            //db.RUTAS.Add(r);
            //db.SaveChanges();

            //Modo 2 --> con stored procedure
            db.spNuevoSendero(nombre.Text, Convert.ToDecimal(distancia.Text), Convert.ToInt32(desnivel.Text), fecha.Value, localizacion.Text, Convert.ToInt32(niveles.SelectedValue));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadComboNiveles()
        {
            //Initialize the ObjectContext
            db = new SenderosEntities2();

            // Define a query that returns all Department  
            // objects and course objects, ordered by name.
            var nivelesQuery = from d in db.NIVELESDIFICULTADs
                               orderby d.IDNIVEL
                               select d;
            try
            {
                List<NIVELESDIFICULTAD> nivelList = nivelesQuery.ToList();

                this.niveles.DataSource = nivelList;
                this.niveles.DisplayMember = "Descripcion";
                this.niveles.ValueMember = "IdNivel";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

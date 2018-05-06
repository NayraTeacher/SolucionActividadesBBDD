using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SenderosORM_EF_existeBD
{
    public partial class Form1 : Form
    {
        private SenderosEntities2 db;

        public Form1()
        {
            InitializeComponent();
            LoadComboNiveles();
            LoadRutas();
        }

        private void Salir_Click(object sender, EventArgs e)
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
                // Bind the ComboBox control to the query, 
                // which is executed during data binding.
                // To prevent the query from being executed multiple times during binding, 
                // it is recommended to bind controls to the result of the Execute method. 
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
        private void LoadRutas()
        {
            //Initialize the ObjectContext
            db = new SenderosEntities2();

            try
            {              
                this.senderosGrid.DataSource = db.spVerSenderos().ToList();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRutasByNivel(int nivel)
        {
            //Initialize the ObjectContext
            db = new SenderosEntities2();

            var nivelesQuery = from d in db.RUTAS
                               where d.DIFICULTAD == nivel
                               orderby d.IDRUTA
                               select d;


            try
            {
                this.senderosGrid.DataSource = nivelesQuery.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void filtro_Click(object sender, EventArgs e)
        {
            if (niveles.SelectedIndex >= 0)
                LoadRutasByNivel(Convert.ToInt32(niveles.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new NuevaRuta();
            frm.Show();
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ONGDirectaADOmySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadVerCamposOperacion();
        }

        private void nOpinion_Click(object sender, EventArgs e)
        {
            Form frm = new Opinion();
            frm.Show();
        }

        private void loadVerCamposOperacion()
        {
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["ONGConnectionString"];

            //Create the connection.  
            MySqlConnection conn = new MySqlConnection(settings.ConnectionString);

            string query = "SELECT * FROM ONG.CAMPOS_OPERACION";
            //NC-7 Create a SqlCommand, and identify it as a stored procedure.  
            MySqlCommand cmdVerCOtexto = new MySqlCommand(query, conn);

            //NC-10 try-catch-finally  
            try
            {
                //NC-11 Open the connection.  
                conn.Open();

                //Run the command by using SqlDataReader.  
                MySqlDataReader rdr = cmdVerCOtexto.ExecuteReader();

                //Create a data table to hold the retrieved data.  
                DataTable dataTable = new DataTable();

                //Load the data from SqlDataReader into the data table.  
                dataTable.Load(rdr);

                //Display the data from the datatable in the datagridview.  
                this.verCamposOperacion.DataSource = dataTable;

                //Close the SqlDataReader.  
                rdr.Close();

            }
            catch (Exception e1)
            {
                //NC-14 A simple catch.  

                MessageBox.Show("No se ha podido mostrar los datos. " + e1.Message);
            }
            finally
            {
                //NC-15 Close the connection.  
                conn.Close();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadVerCamposOperacion();
        }
    }
}

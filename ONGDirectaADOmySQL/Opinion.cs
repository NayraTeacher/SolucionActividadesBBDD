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
    public partial class Opinion : Form
    {
        public Opinion()
        {
            InitializeComponent();
        }

        private void bAddCampoOper_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["ONGConnectionString"];

            //Create the connection.  
            MySqlConnection conn = new MySqlConnection(settings.ConnectionString);

            string query = "INSERT INTO ong.CAMPOS_OPERACION values ("+idBox.Text+",'"+descrBox.Text+"',"+prioBox.Text+")";
            //NC-7 Create a SqlCommand, and identify it as a stored procedure.  
            MySqlCommand cmdNuevoCOtexto = new MySqlCommand(query, conn);
            try
            {
                //NC-7 Create a SqlCommand, and identify it as a stored procedure.  
                MySqlCommand cmdNuevoCO = new MySqlCommand("sp_NuevoCO", conn);
            cmdNuevoCO.CommandType = CommandType.StoredProcedure;

            cmdNuevoCO.Parameters.Add(new MySqlParameter("ID", MySqlDbType.Int32));
            cmdNuevoCO.Parameters["ID"].Value = idBox.Text;

            //NC-8 Add input parameter from the stored procedure and specify what to use as its value.  
            cmdNuevoCO.Parameters.Add(new MySqlParameter("Descripcion", MySqlDbType.VarChar, 50));
            cmdNuevoCO.Parameters["Descripcion"].Value = descrBox.Text;

            cmdNuevoCO.Parameters.Add(new MySqlParameter("Prioridad", MySqlDbType.Int32));
            cmdNuevoCO.Parameters["Prioridad"].Value = prioBox.Text;

            //NC-10 try-catch-finally  
           
                //NC-11 Open the connection.  
                conn.Open();

                //NC-12 Run the stored procedure.  
                //cmdNuevoCOtexto.ExecuteNonQuery();
                cmdNuevoCO.ExecuteNonQuery();

            }
            catch(Exception e1)
            {
                //NC-14 A simple catch.  

                MessageBox.Show("No se ha podido introducir el nuevo valor. " + e1.Message);
            }
            finally
            {
                //NC-15 Close the connection.  
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

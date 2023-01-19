using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace labGui
{
    internal class SqlConnect
    {
        public SqlConnection sqlConnection { get; set; }

        public int executeNonQuery(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public int executeScalar(string query)
        {
            SqlConnection connection = Connection();
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (connection != null)
                connection.Close();
            return result;
        }

        public SqlDataReader executeReader(string query)
        {
            sqlConnection = Connection();
            SqlDataReader result = null;
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public SqlConnection Connection()
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = @"Data source = localhost; Initial Catalog = C#; Integrated Security = True;";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }
    }
}

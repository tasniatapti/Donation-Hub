using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess_Layer
{
    class DataAccess
    {
        public SqlConnection connection;
        SqlCommand command;
        
        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DonationHubdb"].ConnectionString);
                this.connection.Open();
            }
            catch(Exception exp)
            {

            }
        }
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }
        ~DataAccess()
        {
            this.connection.Close();
        }

    }
}

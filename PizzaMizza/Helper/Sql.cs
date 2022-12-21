using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Helper
{
    static class Sql
    {
        static string connectionstring = "Server=CA-R215-PC02\\SQLEXPRESS ; Database = PizzaMizza ; Trusted_Connection = True ; Integrated Security=True";
        static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection==null)
                {
                    _connection= new SqlConnection(connectionstring);
                }
                return _connection;
            }
        }
        public static int ExecCommand(string  command)
        {   int RESULT=0;
            Connection.Open();
            using(SqlCommand command1= new SqlCommand(command, Connection))
            { 
                RESULT = command1.ExecuteNonQuery();
            }
            Connection.Close();
            return RESULT;
        }
        public static DataTable ExecQuery(String Query) 
        {
            DataTable dt = new DataTable();
            Connection.Open();
            using(SqlDataAdapter sda = new SqlDataAdapter(Query,Connection)) 
            { sda.Fill(dt); }
            return dt;
           
        }
    }
}

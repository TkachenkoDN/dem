using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Avtorizaciya
{
    class Class1
    {
        SqlConnection con = new SqlConnection(@"Data Source = HOME-PC\SQLEXPRESS; Initial Catalog = Trade; Integrated Security = true");



        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }


    }
}

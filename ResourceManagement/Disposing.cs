using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ResourceManagement
{
    namespace Disposing
    {
        class Right
        {
            public void Method(string connection, string command)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    //Do something
                    using (SqlCommand comm = new SqlCommand(command))
                    {
                        //Do something
                    }                                
                }
            }

            public void Method1(string connection,string command)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(connection);
                    //do something
                    SqlCommand comm =null;
                    try
                    {
                        comm = new SqlCommand(command);
                        //do something
                    }
                    finally
                    {
                        if (comm != null)
                            comm.Dispose();
                    }
                }
                finally
                {
                    if (conn != null)
                        conn.Dispose();
                }
            }
        } 

        class Wrong
        {
            public void Method(string connection, string command)
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand comm = new SqlCommand(command);
                //Do something
                conn.Close();
            }
        }
    }
}

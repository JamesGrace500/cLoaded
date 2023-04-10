using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace cLoaded
{
    internal class CRUD
    {

        private static string getConnectionString()
        {

            // details for PostGresSQl
            string host = "Host=192.168.1.109;";
            string port = "Port=5432;";
            string db = "Database=marketing_planning_tool;";
            string user = "Username=pi;";
            string pass = "Password=M@gic1234;";


            // How the string is constructed
            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand? cmd = default;
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(NpgsqlCommand com)
        {
            NpgsqlDataAdapter? da = default;
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:" + ex.Message, "perform CRUD raised an error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            con.Close();
            return dt;
        }
        public static NpgsqlDataReader ExecuteReader(params NpgsqlParameter[] parameters)
        {        
                con.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddRange(parameters);

                    // we will use the commandbehaviour.close to close the connection, means we don't need to do more than that 
                    NpgsqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;
                }
          
        
        }
    }
}

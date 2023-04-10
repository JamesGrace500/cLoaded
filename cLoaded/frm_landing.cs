using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Npgsql;

namespace cLoaded
{
    public partial class frm_landing : Form
    {
        private readonly string username = Environment.UserName;
        private bool admin;
        private string person_name;

        public frm_landing()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void frm_landing_Load(object sender, EventArgs e)

            // on load we will try and find the person name, where its not found, will show the you have no permission screen
        {

            CRUD.sql = "SELECT * from mark.users WHERE login_name = @username::varchar";

            List<NpgsqlParameter> list = new List<NpgsqlParameter>();
            list.Add(new NpgsqlParameter("username", username));

            NpgsqlDataReader reader  = CRUD.ExecuteReader(list.ToArray<NpgsqlParameter>());
  
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    person_name = reader["person_name"].ToString();
                    admin = Convert.ToBoolean(reader["admin"]);
                }

                reader.Close();
                reader.Dispose();

            }
            else
            {
                return; 
            }

            

            if (admin)
            {
                this.Hide();
                frm_admin frm_admin = new frm_admin();
                frm_admin.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }



        }
    }
}

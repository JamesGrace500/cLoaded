using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cLoaded
{
    public partial class frm_admin : Form
    {
        private string table = "";
        private string valueToAdd = "";


        public frm_admin()
        {
            InitializeComponent();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            resetMe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pass user through to main form - there will be no back button just yet 
            if (MessageBox.Show("You will not be able to view this screen again if you proceed", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.valueToAdd = ValueTexBox.Text.Trim();

            if (string.IsNullOrEmpty(this.valueToAdd))
            {
                MessageBox.Show("Please enter a value to add", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

   


            var selections = FormLoader.ReturnComboSelection(TablesComboBox);
            // we only need the table name which we now have
            this.table = selections.Item2;
            string formattedSQL = string.Format("INSERT INTO mark.{0} (value) VALUES (@valueToAdd)", this.table);
            CRUD.sql = formattedSQL;

            execute(CRUD.sql);

            resetMe();

        }
        private void execute(string mySQL)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("valueToAdd", this.valueToAdd);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selections from the drop down
            var selections = FormLoader.ReturnComboSelection(TablesComboBox);
            
            // we only need the table name which we now have
            this.table = selections.Item2;
            string formattedSQl = string.Format("SELECT autoid, value FROM mark.{0} ORDER BY autoid ASC", this.table);
            CRUD.sql = formattedSQl;


            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv2 = dataGridView2;

            dgv2.MultiSelect= false;
            dgv2.AutoGenerateColumns = true;
            dgv2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgv2.DataSource = dt;
            dgv2.Columns[0].HeaderText = "ID";
            dgv2.Columns[1].HeaderText = "Value";
            dgv2.Columns[0].Width = 50;
            dgv2.Columns[1].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv2.Width - 50)).ToString());
            
        }

        private void resetMe()
        {

            // run the combobox functions

            //Populate the option combo boxes first 
            //CategoryComboBox

            CRUD.sql = "SELECT * FROM mark.dd_category";
            FormLoader.FillComboBox(CategoryComboBox);

            // Marketing Team Combo Box
            CRUD.sql = "SELECT * FROM mark.dd_marketingteam";
            FormLoader.FillComboBox(TeamComboBox);

            // the tables box 
            CRUD.sql = "SELECT ROW_NUMBER() OVER(ORDER BY table_name ASC),table_name FROM information_schema.tables WHERE table_schema = 'mark' AND table_name LIKE 'dd%'";
            FormLoader.FillComboBox(TablesComboBox);

            // clear out the text box 
            ValueTexBox.Clear();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace cLoaded
{
    public partial class Form1 : Form
    {

        private string id = "";
        private int intRow = 0;

        public Form1()
        {
            InitializeComponent();
            ResetMe();

        }

        private void ResetMe()
        {
            // resets the form to empty state
            this.id = string.Empty;
            this.intRow = 0;

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            
            if (GenderComboBox.Items.Count >0 )
            {
                GenderComboBox.SelectedIndex= 0;
            }

            UpdateButton.Text = "Update ()";
            DeleteButton.Text = "Delete ()";

            SearchTextBox.Clear();

            if (SearchTextBox.CanSelect)
            {
                SearchTextBox.Select();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("");


        }

        private void LoadData(string keyword)
        {
            CRUD.sql = "SELECT autoid, firstname, lastname, CONCAT(firstname, ' ' ,lastname) AS fullname, gender from mark.tbl_smart_crud " +
                "WHERE CONCAT(cast(autoid as varchar), ' ', firstname, ' ' ,lastname) like @keyword::varchar " +
                "OR TRIM(gender) LIKE @keyword::varchar ORDER BY autoid asc";

            string strKeyword = string.Format("%{0}%", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString()); 
            }
            else
            {
                intRow = 0;
            }

            toolStripStatusLabel1.Text = "Number of row(s):" + intRow.ToString();

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true; 
            dgv1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "First Name";
            dgv1.Columns[2].HeaderText = "Last Name";
            dgv1.Columns[3].HeaderText = "Full Name";
            dgv1.Columns[4].HeaderText = "Gender";

            dgv1.Columns[0].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv1.Width / 5)).ToString());
            dgv1.Columns[1].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv1.Width / 5)).ToString());
            dgv1.Columns[2].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv1.Width / 5)).ToString());
            dgv1.Columns[3].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv1.Width / 5)).ToString());
            dgv1.Columns[4].Width = Convert.ToInt32(Math.Round(Convert.ToDouble(dgv1.Width / 5)).ToString());



        }

        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL,CRUD.con);
            addParamaters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void addParamaters(string strParam)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("firstname", FirstNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("lastname", LastNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("gender", GenderComboBox.SelectedItem.ToString());

            if (strParam == "Update" || strParam == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text.Trim()) || string.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a first and last name", "Enter details", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            // The insert statement with the paramaters saved and assined
            CRUD.sql = "INSERT INTO mark.tbl_smart_crud(firstname, lastname, gender) VALUES (@firstname, @lastname, @gender)";

            execute(CRUD.sql,"Insert");

            // Record saved correctly, display success message
            MessageBox.Show("Record Saved", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData("");
            ResetMe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                UpdateButton.Text = "Update (" + this.id + ")";
                DeleteButton.Text = "Delete (" + this.id + ")";

                FirstNameTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                LastNameTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                GenderComboBox.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);


            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count ==0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select a record", "Select record", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }


            // check the firt name or last name is empty
            if (string.IsNullOrEmpty(FirstNameTextBox.Text.Trim()) || string.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a first and last name", "Enter details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // The insert statement with the paramaters saved and assined
            CRUD.sql = "UPDATE mark.tbl_smart_crud SET firstname = @firstname, lastname = @lastname, gender = @gender WHERE autoid = @id::integer";
            Console.Write(CRUD.sql); 

            execute(CRUD.sql, "Update");

            // Record saved correctly, display success message
            MessageBox.Show("Record Updated", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData("");
            ResetMe();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select a record", "Select record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // check the firt name or last name is empty
            if (string.IsNullOrEmpty(FirstNameTextBox.Text.Trim()) || string.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a first and last name", "Enter details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure? This will be permenant", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                // The Delete statement with the paramaters saved and assined
                CRUD.sql = "DELETE FROM mark.tbl_smart_crud WHERE autoid = @id::integer";


                execute(CRUD.sql, "Delete");

                // Record saved correctly, display success message
                MessageBox.Show("Record Deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData("");
                ResetMe();
            }



        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(SearchTextBox.Text.Trim()))
            {
                LoadData("");
                ResetMe();  
            }
            else
            {
                LoadData(SearchTextBox.Text.Trim());
                ResetMe();  
            }
        }
    }
}
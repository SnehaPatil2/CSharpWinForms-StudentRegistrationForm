using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        string conectionString = "Server=SURAJ-PATIL-928;Initial Catalog=studentdb;Integrated Security=True";
        private object hobbiesBox;
        string txt1 = "";
        string txt2 = "";
        string txt3 = "";
        string txt4 = "";
        //using(SqlConnection connection = new SqlConnection(conectionString)){

        //}
        private List<string> selectedData = new List<string>();
        //private int selectedRowIndex;
        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void NAME_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (musiccheckBox.Checked == true)
            {
                txt4 = musiccheckBox.Text;
            }
            else
            {
                txt4 = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                connection.Open();
                string sql1 = "select * from StudentDetails";
                using (SqlCommand command = new SqlCommand(sql1, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                dataGrid.DataSource = dt;
            }
            // db.fillDataGridView("select * from student", dataGrid);
        }

        private void moviecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moviecheckBox.Checked == true)
            {
                txt1 = moviecheckBox.Text;
            }
            else {
                txt1 = "";
            }
        }

        public void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void Addbtn_Click(object sender, EventArgs e)

        {
            string mobileNumber = phonBox.Text;
            string emails = emailBox.Text.Trim();
            string zipcodePattern = @"^\d{5}(?:-\d{4})?$"; // Zipcode pattern: 12345 or 12345-6789
            
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("enter the name");
            }
            else if (string.IsNullOrWhiteSpace(emailBox.Text)) { MessageBox.Show("enter the email"); }
            else if (string.IsNullOrWhiteSpace(phonBox.Text)) { MessageBox.Show("enter the phon number"); }
            else if (string.IsNullOrWhiteSpace(zipBox.Text)) { MessageBox.Show("enter the zip number"); }
            // else if (string.IsNullOrWhiteSpace((string)hobbiesBox)) { MessageBox.Show("enter the zip number"); }
           
            else if (!IsEmailValid(emails))
            {
                // Email is valid, perform further actions
                MessageBox.Show("Email is not valid!");
            }
            else if(!IsValidMobileNumber(mobileNumber))
            {
                MessageBox.Show("Invalid mobile number format. Please enter a valid mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phonBox.Focus();
            }
            else if (!Regex.IsMatch(zipBox.Text, zipcodePattern))
            {
                MessageBox.Show("Invalid zipcode entered. Please enter a valid zipcode.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if (!AtLeastOneCheckboxSelected())
            {
                MessageBox.Show("Please select atleast one checkbox");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    // Get the selected hobbies and concatenate them into a single string
                    List<string> selectedHobbies = new List<string>();
                    if (moviecheckBox.Checked)
                        selectedHobbies.Add("movie");
                    if (footballcheckBox.Checked)
                        selectedHobbies.Add("football");
                    if (swimmingcheckBox.Checked)
                        selectedHobbies.Add("swimming");
                    if (musiccheckBox.Checked)
                        selectedHobbies.Add("music");

                    string hobbies = string.Join(", ", selectedHobbies);

                  

                    

                   
                    string sql = "insert into StudentDetails(Name,Email,Phone,Zip,Hobbies) VALUES(@nameBox,@emailBox,@phonBox,@zipBox,@Hobbies)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nameBox", nameBox.Text);
                        cmd.Parameters.AddWithValue("@emailBox", emailBox.Text);
                        cmd.Parameters.AddWithValue("@phonBox", phonBox.Text);

                        cmd.Parameters.AddWithValue("@zipBox", zipBox.Text);

                        cmd.Parameters.AddWithValue("@Hobbies", hobbies);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("data inserted successfully");
                        connection.Close();
                    //Clear the checkboxes and name field after insertion
                    nameBox.Clear();
                    emailBox.Clear();
                    phonBox.Clear();
                    zipBox.Clear();
                    moviecheckBox.Checked = false;
                    footballcheckBox.Checked = false;
                    swimmingcheckBox.Checked = false;
                    musiccheckBox.Checked = false;


                }
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(conectionString))
                {

                    connection.Open();
                    string sql1 = "select * from StudentDetails";
                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    dataGrid.DataSource = dt;
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        int selectedId = Convert.ToInt32(row.Cells["Id"].Value); // Assuming you have an "ID" column

                        // Delete the data from your data source (e.g., database) using the selectedId
                        DeleteDataFromDataSource(selectedId);

                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select at least one row to delete.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void DeleteDataFromDataSource(int id)
        {
            string connectionString = "Server=SURAJ-PATIL-928;Initial Catalog=studentdb;Integrated Security=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM StudentDetails WHERE Id = @Id"; // Replace YourTable with your actual table name

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No data deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }










        private void footballcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(footballcheckBox.Checked==true) {
                txt2=footballcheckBox.Text;
            }
            else
            {
                txt2 = "";
            }
        }

        private void swimmingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (swimmingcheckBox.Checked == true)
            {
                txt3 = swimmingcheckBox.Text;
            }
            else
            {
                txt3 = "";
            }
        }

        private void phonBox_TextChanged(object sender, EventArgs e)
        {
          
        }
        private bool IsValidMobileNumber(string input)
        {
            // Define a regular expression pattern for a common mobile number format (adjust as needed)
            string pattern = @"^\d{10}$"; // Assumes 10-digit numeric mobile number

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }
        private bool IsValidEmail(string email)
        {
            // Use a regular expression to validate email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsEmailValid(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool AtLeastOneCheckboxSelected()
        {
            // Check if at least one checkbox is selected
            if (moviecheckBox.Checked || footballcheckBox.Checked || swimmingcheckBox.Checked ||musiccheckBox.Checked)
            {
                return true;
            }
            return false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {


            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                int selectedId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);

                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;

                    Form2 editForm = new Form2(row, selectedId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = new DataTable();
                        using (SqlConnection connection = new SqlConnection(conectionString))
                        {

                            connection.Open();
                            string sql1 = "select * from StudentDetails";
                            using (SqlCommand command = new SqlCommand(sql1, connection))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                adapter.Fill(dt);
                            }
                            dataGrid.DataSource = dt;
                        }
                       
                    }
                }
            }



            else
            {

                        MessageBox.Show("Please select a row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private DataTable GetDataFromDataSource()
        {
            // Replace with your actual data retrieval logic
            DataTable dataTable = new DataTable();
            // Fill the dataTable from your data source using appropriate SQL or other methods
            return dataTable;
        }

    }
}

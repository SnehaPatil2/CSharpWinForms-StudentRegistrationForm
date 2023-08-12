using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentForm
{
    public partial class Form2 : Form
    {
        private int selectedId;
        string conectionString = "Server=SURAJ-PATIL-928;Initial Catalog=studentdb;Integrated Security=True";

        private DataRow dataRow;
        private SqlConnection connection;
        private DataRow row;

        // private int selectedId;

        public Form2(DataRow row, int selectedId)
        {
            InitializeComponent();
            connection = sqlConnection;
            dataRow = row;
            this.selectedId = selectedId;

            // Populate input controls with data from the DataRow
            nameBox1.Text = dataRow["Name"].ToString();
            emailBox1.Text = dataRow["Email"].ToString();
            phonBox1.Text = dataRow["Phone"].ToString();
            zipBox1.Text = dataRow["Zip"].ToString();
            hobbiesBox1.Text = dataRow["Hobbies"].ToString();


        }



        public SqlConnection sqlConnection { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void phonBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {





            string updatedName = nameBox1.Text;
            string updatedEmail = emailBox1.Text;
            string updatedPhone = phonBox1.Text;

            string updatedZip = zipBox1.Text;
            string updatedHobbies = hobbiesBox1.Text;
            
            UpdateDataInDataSource(selectedId, updatedName, updatedEmail, updatedPhone, updatedZip, updatedHobbies);

            DialogResult = DialogResult.OK;
            Close();
            

        }

        private void UpdateDataInDataSource(int selectedId, string updatedName, string updatedEmail, string updatedPhone, string updatedZip, string updatedHobbies)
        {
            string connectionString = "Server=SURAJ-PATIL-928;Initial Catalog=studentdb;Integrated Security=True";
            // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE StudentDetails SET Name = @updatedName,Email=@updatedEmail, Phone = @updatedPhone,Zip=@updatedZip, Hobbies = @updatedHobbies where Id=@selectedId"; // Replace YourTable with your actual table name

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@updatedName", updatedName);
                    command.Parameters.AddWithValue("@updatedEmail", updatedEmail);
                    command.Parameters.AddWithValue("@updatedPhone", updatedPhone);
                    command.Parameters.AddWithValue("@updatedZip", updatedZip);
                    command.Parameters.AddWithValue("@updatedHobbies", updatedHobbies);
                    command.Parameters.AddWithValue("@selectedId", selectedId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No data updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}        

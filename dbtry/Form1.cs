using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace dbtry
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=beelivery-development.postgres.database.azure.com;Username=beeliveryx_dev@beelivery-development;Password=vb7VP$?yxD;Database=beeliveryx";
        private NpgsqlConnection connection;
        private string sqlString;
        private NpgsqlCommand command;
        private DataTable dataTable;
        public int rowIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connectionString);
            ConnectionLoader();
        }

        private void ConnectionLoader()
        {
            try
            {
                connection.Open();
                sqlString = @"select * from info_select()";
                command = new NpgsqlCommand(sqlString, connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dbData.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ConnectionLoader();
            MessageBox.Show("Refresh Successful");

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please choose a student to delete");
                return;
            }
            try
            {
                connection.Open();
                sqlString = @"select * from info_delete(:_id)";
                command = new NpgsqlCommand(sqlString, connection);
                command.Parameters.AddWithValue("_id", int.Parse(dbData.Rows[rowIndex].Cells["_id"].Value.ToString()));
                if ((int)command.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Deleted student successfully");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Delete failed. Error:" + ex.Message);
            }

            rowIndex = -1;
            taskIdTextBox.Text=firstNameTextBox.Text = subjectTextBox.Text = lastNameTextBox.Text = null;
            ConnectionLoader();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text != "" || taskIdTextBox.Text != "" || firstNameTextBox.Text != "" || subjectTextBox.Text != "")
            {
                try
                {
                    connection.Open();
                    sqlString = @"insert into academy.testtable(task_id, subject, first_name, last_name) VALUES(:taskid, :value1, :firstname, :lastname)";
                    command = new NpgsqlCommand(sqlString, connection);
                    command.Parameters.AddWithValue("taskid", int.Parse(taskIdTextBox.Text));
                    command.Parameters.AddWithValue("value1", subjectTextBox.Text);
                    command.Parameters.AddWithValue("firstname", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("lastname", lastNameTextBox.Text);
                    command.ExecuteScalar();
                    MessageBox.Show("Student Inserted successfully");
                    connection.Close();
                    ConnectionLoader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed. Error: " + ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please input data for a student");
            }
           
            taskIdTextBox.Text = firstNameTextBox.Text = subjectTextBox.Text = lastNameTextBox.Text = null;
            rowIndex = -1;
            ConnectionLoader();
        }


        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            int result;
            try
            {
                connection.Open();
                sqlString = @"select * from infoo_update(:_id,:_subject,:_firstname,:_lastname)";
                command = new NpgsqlCommand(sqlString, connection);
                command.Parameters.AddWithValue(@"_id", int.Parse(dbData.Rows[rowIndex].Cells["_id"].Value.ToString()));
                command.Parameters.AddWithValue(@"_firstname", firstNameTextBox.Text);
                command.Parameters.AddWithValue(@"_lastname", lastNameTextBox.Text);
                command.Parameters.AddWithValue(@"_subject", subjectTextBox.Text);
                result = (int)command.ExecuteScalar();
                connection.Close();
                if (result == 1)
                {
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                        MessageBox.Show("Update failed");

                }

            }
            catch (Exception ex)
            {
                    connection.Close();
                    MessageBox.Show("Updated fail. Error: " + ex.Message);
                    
            }
            taskIdTextBox.Text = firstNameTextBox.Text = subjectTextBox.Text = lastNameTextBox.Text = null;
            rowIndex = -1;
            ConnectionLoader();
        }

        private void dbData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex; 
                firstNameTextBox.Text = dbData.Rows[e.RowIndex].Cells["_firstname"].Value.ToString();
                subjectTextBox.Text = dbData.Rows[e.RowIndex].Cells["_subject"].Value.ToString();
                lastNameTextBox.Text = dbData.Rows[e.RowIndex].Cells["_lastname"].Value.ToString();
                taskIdTextBox.Text = dbData.Rows[e.RowIndex].Cells["_id"].Value.ToString();
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e) 
        {

        }

        private void taskIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dbData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Evgeny\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString); 

            await sqlConnection.OpenAsync(); 

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"]) 
                        + " " + "   Weight: " +  Convert.ToString(sqlReader["Weight"]) + " " + "    Designation: " + Convert.ToString(sqlReader["Designation"])
                        + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlReader!=null)
                {
                    sqlReader.Close();
                }
            }

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if(LabelError.Visible == true)
            {
                LabelError.Visible = false;
            }

            if(!string.IsNullOrEmpty(textBoxScaleIdInput.Text) && !string.IsNullOrWhiteSpace(textBoxScaleIdInput.Text) &&
               !string.IsNullOrEmpty(textBoxWeightInput.Text) && !string.IsNullOrWhiteSpace(textBoxWeightInput.Text) &&
               !string.IsNullOrEmpty(textBoxDesignationInput.Text) && !string.IsNullOrWhiteSpace(textBoxDesignationInput.Text) &&
               !string.IsNullOrEmpty(dateTimePickerInput.Text) && !string.IsNullOrWhiteSpace(dateTimePickerInput.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [ScaleDB] (ScaleID, Weight, Designation, Date, Time)VALUES(@ScaleID, @Weight, @Designation, @Date, @Time)", sqlConnection);

                command.Parameters.AddWithValue("ScaleID", textBoxScaleIdInput.Text);
                command.Parameters.AddWithValue("Weight", textBoxWeightInput.Text);
                command.Parameters.AddWithValue("Designation", textBoxDesignationInput.Text);
                command.Parameters.AddWithValue("Date", dateTimePickerInput.Value.ToShortDateString()); 
                command.Parameters.AddWithValue("Time", now.ToShortTimeString());

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                LabelError.Visible = true;
                LabelError.Text = "No empty fields alowed!";
            }
        }

        private async void RenewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"])
                        + " " + "   Weight: " + Convert.ToString(sqlReader["Weight"]) + " " + " Designation: " + Convert.ToString(sqlReader["Designation"])
                        + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private async void ButtonChoose_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            //listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;

            if (!string.IsNullOrEmpty(textBoxScaleIDChoose.Text) && !string.IsNullOrWhiteSpace(textBoxScaleIDChoose.Text))
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Evgeny\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlDataReader sqlReader = null;

                SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB] WHERE [ScaleID] = @ScaleID", sqlConnection);

                command.Parameters.AddWithValue("ScaleID", Int32.Parse(textBoxScaleIDChoose.Text));

                try
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    while (await sqlReader.ReadAsync())
                    {
                        listBox2.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"])
                            + " " + "   Weight: " + Convert.ToString(sqlReader["Weight"]) + " " + "    Designation: " + Convert.ToString(sqlReader["Designation"])
                            + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                } 
            }
            else
            {
                listBox2.Items.Add("Please indicate scale ID !!!");
            }
        }

        private async void ButtonChooseByDesignation_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (!string.IsNullOrEmpty(textBoxChooseByDesignation.Text) && !string.IsNullOrWhiteSpace(textBoxChooseByDesignation.Text))
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Evgeny\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlDataReader sqlReader = null;

                SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB] WHERE [Designation] = @Designation", sqlConnection);

                command.Parameters.AddWithValue("Designation", textBoxChooseByDesignation.Text);

                try
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    while (await sqlReader.ReadAsync())
                    {
                        listBox2.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"])
                            + " " + "   Weight: " + Convert.ToString(sqlReader["Weight"]) + " " + "    Designation: " + Convert.ToString(sqlReader["Designation"])
                            + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }
            else
            {
                listBox2.Items.Add("Please indicate Designation !!!");
            }

        }

        private async void ButtonChooseByDate_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
                        
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Evgeny\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB] WHERE [Date] = @Date", sqlConnection);

            command.Parameters.AddWithValue("Date", dateTimePickerChoose.Value.ToShortDateString());

            //MessageBox.Show(dateTimePickerChoose.Value.ToShortDateString());

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox2.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"])
                        + " " + "   Weight: " + Convert.ToString(sqlReader["Weight"]) + " " + "    Designation: " + Convert.ToString(sqlReader["Designation"])
                        + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            } 
        }

        private async void ButtonTotalChoice_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (!string.IsNullOrEmpty(textBoxScaleIDChoose.Text) && !string.IsNullOrWhiteSpace(textBoxScaleIDChoose.Text) &&
               !string.IsNullOrEmpty(textBoxChooseByDesignation.Text) && !string.IsNullOrWhiteSpace(textBoxChooseByDesignation.Text))              
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Evgeny\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True";

                sqlConnection = new SqlConnection(connectionString);

                await sqlConnection.OpenAsync();

                SqlDataReader sqlReader = null;

                SqlCommand command = new SqlCommand("SELECT * FROM [ScaleDB] WHERE [Date] = @Date AND [ScaleID]=@ScaleID AND [Date]=@Date", sqlConnection);

                command.Parameters.AddWithValue("ScaleID", Int32.Parse(textBoxScaleIDChoose.Text));
                command.Parameters.AddWithValue("Designation", textBoxChooseByDesignation.Text);
                command.Parameters.AddWithValue("Date", dateTimePickerChoose.Value.ToShortDateString());


                //MessageBox.Show(dateTimePickerChoose.Value.ToShortDateString());

                try
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    while (await sqlReader.ReadAsync())
                    {
                        listBox2.Items.Add("Id: " + Convert.ToString(sqlReader["Id"]) + " " + " Scale Number:" + Convert.ToString(sqlReader["ScaleID"])
                            + " " + "   Weight: " + Convert.ToString(sqlReader["Weight"]) + " " + "    Designation: " + Convert.ToString(sqlReader["Designation"])
                            + " " + " Date: " + Convert.ToString(sqlReader["Date"]) + " " + " Time: " + Convert.ToString(sqlReader["Time"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }
            else
            {
                listBox2.Items.Add("No empty fields alowed !!!");
            }
        }
    }
}

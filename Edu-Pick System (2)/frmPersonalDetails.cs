using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Edu_Pick_System__2_
{
    public partial class frmPersonalDetails : Form
    {
        SqlConnection connect = new SqlConnection(@"");
        SqlDataAdapter adapter;
        DataSet dataset;
        SqlCommand comm;
        public frmPersonalDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                connect.Open();
                int passports = Convert.ToInt32(tbID.Text);
                string race = Convert.ToString(cbRace.SelectedIndex);
                string nationality = Convert.ToString(cbNationality.SelectedIndex);
                string gender = Convert.ToString(cbGender.SelectedIndex);

                string sql = "INSERT INTO Movie(ID_No,Passport_No,Nationality,Gender,Race,DateOfBirth) VALUES(@ID_No,@Passport_No,@Nationality,@Gender,@Race,@DateOfBirth)";
                comm = new SqlCommand(sql, connect);
                comm.Parameters.AddWithValue("@ID_No", tbID.Text);
                comm.Parameters.AddWithValue("@Passport_No", tbPassport.Text);
                comm.Parameters.AddWithValue("@Nationality", nationality);
                comm.Parameters.AddWithValue("@Gender", gender);
                comm.Parameters.AddWithValue("@Race", race);
                comm.Parameters.AddWithValue("@DateOfBirth", DateTimePicker.MinimumDateTime);

                if (race == "Others")
                {
                    comm.Parameters.AddWithValue("@Race", tbSpecify.Text);
                }
                else
                {
                    MessageBox.Show("Enter your race!");
                }

                comm.ExecuteNonQuery();
                connect.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            MessageBox.Show("Saved successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbPassport.Clear();
            tbSpecify.Clear();
            cbGender.SelectedIndex = -1;
            cbNationality.SelectedIndex = -1;
            cbRace.SelectedIndex = -1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Student_Results myResults = new Student_Results();
            myResults.ShowDialog();
        }
    }
}

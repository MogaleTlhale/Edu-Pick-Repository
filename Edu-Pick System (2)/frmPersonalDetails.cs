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
            connect.Open();

            string sql = "INSERT INTO Movie(ID_No,Passport_No,Nationality,Gender,Race,DateOfBirth) VALUES(@ID_No,@Passport_No,@Nationality,@Gender,@Race,@DateOfBirth)";
            comm = new SqlCommand(sql, connect);
            comm.Parameters.AddWithValue("@ID_No", tbID.Text);
            comm.Parameters.AddWithValue("@Passport_No", tbPassport.Text);
            comm.Parameters.AddWithValue("@Nationality", cbNationality.SelectedIndex);
            comm.Parameters.AddWithValue("@Gender", cbGender.SelectedIndex);
            comm.Parameters.AddWithValue("@Race", cbRace.SelectedIndex);
            comm.Parameters.AddWithValue("@DateOfBirth", DateTimePicker.MinimumDateTime);

            if (cbRace.SelectedItem == "Others")
            {
                comm.Parameters.AddWithValue("@Race", tbSpecify.Text);
            }

            comm.ExecuteNonQuery();
            connect.Close();
        }
    }
}

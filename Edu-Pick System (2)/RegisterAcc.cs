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
    public partial class RegisterAcc : Form
    {
        public RegisterAcc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Student\Source\Repos\MogaleTlhale\Edu - Pick - Repository\Edu - Pick System(2)\DBAdmin.mdf;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Student\Source\Repos\MogaleTlhale\Edu - Pick - Repository\Edu - Pick System(2)\DBStudent.mdf;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
       

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RBAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string FName, LName, Email, PhoneNum, Password, CPassword;
            FName = txtName.Text;
            LName = txtLName.Text;
            Email = txtEmail.Text;
            PhoneNum = txtNumber.Text;
            Password = txtPassword.Text;
            CPassword = txtCPassword.Text;
            try
            {
                conn2.Open();
                string sql_insert = "Insert Into StudentTable Values('" + FName + "','" +
                LName + "','" + Email + "','" + PhoneNum + "','" + Password + "','" + CPassword + "')";
                SqlCommand cmd = new SqlCommand(sql_insert, conn2);

                
                adapter = new SqlDataAdapter();


                adapter.InsertCommand = cmd;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data successfully inserted");
                conn2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtName.Clear();
                txtLName.Clear();
                txtEmail.Clear();
                txtNumber.Clear();
                txtPassword.Clear();
                txtCPassword.Clear();
                
            }
        }
    }
}

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
    public partial class AdminMaintain : Form
    {
        public AdminMaintain()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chicco\Desktop\CMPG 223\Group System Design Assignment\System\Edu-Pick System(2)\Maintain_Account.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapt;
        DataSet dataset;
        SqlDataReader reader;

        private void btnView_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sql = "SELECT * FROM maintainAccount";
            comm = new SqlCommand(sql, conn);

            adapt = new SqlDataAdapter();
            dataset = new DataSet();

            mydataGView.DataSource = dataset;
            mydataGView.DataMember = "maintainAccount";

            conn.Close();
        }
    }
}

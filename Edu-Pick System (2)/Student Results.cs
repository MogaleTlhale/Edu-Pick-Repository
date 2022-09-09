using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Pick_System__2_
{
    public partial class Student_Results : Form
    {
        public Student_Results()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxSubject1.Text = "";

            txtboxSubject2.Text = "";
            txtboxSubject3.Text = "";
            txtboxSubject4.Text = "";
            txtboxSubject5.Text = "";
            txtboxSubject6.Text = "";
            txtboxSubject7.Text = "";
            txtboxSubject8.Text = "";
            txtboxSubject9.Text = "";
            txtboxSubject10.Text = "";

            txtboxMark1.Text = "";
            txtboxMark2.Text = "";
            txtboxMark3.Text = "";
            txtboxMark4.Text = "";
            txtboxMark5.Text = "";
            txtboxMark6.Text = "";
            txtboxMark7.Text = "";
            txtboxMark8.Text = "";
            txtboxMark9.Text = "";
            txtboxMark10.Text = "";
        }

        private void btnAPS_Click(object sender, EventArgs e)
        {
       
        }
    }
}

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
            txtboxSubject1.Clear();

            txtboxSubject2.Clear();
            txtboxSubject3.Clear();
            txtboxSubject4.Clear();
            txtboxSubject5.Clear();
            txtboxSubject6.Clear();
            txtboxSubject7.Clear();
            txtboxSubject8.Clear();
            txtboxSubject9.Clear();
            txtboxSubject10.Clear();

            txtboxMark1.Clear();
            txtboxMark2.Clear();
            txtboxMark3.Clear();
            txtboxMark4.Clear();
            txtboxMark5.Clear();
            txtboxMark6.Clear();
            txtboxMark7.Clear();
            txtboxMark8.Clear();
            txtboxMark9.Clear();
            txtboxMark10.Clear();
        }


        private void btnAPS_Click(object sender, EventArgs e)
        {
            int totalAPS;
            int mark1 = int.Parse(txtboxMark1.Text);
            int mark2 = int.Parse(txtboxMark2.Text);
            int mark3 = int.Parse(txtboxMark3.Text);
            int mark4 = int.Parse(txtboxMark4.Text);
            int mark5 = int.Parse(txtboxMark5.Text);
            int mark6 = int.Parse(txtboxMark6.Text);
            int mark7 = int.Parse(txtboxMark7.Text);
            int mark8 = int.Parse(txtboxMark8.Text);
            int mark9 = int.Parse(txtboxMark9.Text);
            int mark10 = int.Parse(txtboxMark10.Text);
            try
            {

                if (mark1 < 30 && mark1 >= 0 && mark2 < 30 && mark2 >= 0 && mark3 < 30 && mark3 >= 0  && mark4 < 30 && mark4 >= 0 && mark5 < 30 && mark5 >= 0 && mark6 < 30 && mark6 >= 0 && mark7 < 30 && mark7 >= 0 && mark8 < 30 && mark8 >= 0 && mark9 < 30 && mark9 >= 0 && mark10 < 30 && mark10 >= 0)
                {
                    mark1 = 1;
                    mark2 = 1;
                    mark3 = 1;
                    mark4 = 1;
                    mark5 = 1;
                    mark6 = 1;
                    mark7 = 1;
                    mark8 = 1;
                    mark9 = 1;
                    mark10 = 1;
                }
                else if (mark1 < 40 && mark1 >= 30 && mark2 < 40 && mark2 >= 30 && mark3 < 40 && mark3 >= 30 && mark4 < 40 && mark4 >= 30 && mark5 < 40 && mark5 >= 30 && mark6 < 40 && mark6 >= 30 && mark7 < 40 && mark7 >= 30 && mark8 < 40 && mark8 >= 30 && mark9 < 40 && mark9 >= 30 && mark10 < 40 && mark10 >= 30)
                {
                    mark1 = 2;
                    mark2 = 2;
                    mark3 = 2;
                    mark4 = 2;
                    mark5 = 2;
                    mark6 = 2;
                    mark7 = 2;
                    mark8 = 2;
                    mark9 = 2;
                    mark10 = 2;
                }
                else if (mark1 < 50 && mark1 >= 40 && mark2 < 50 && mark2 >= 40 && mark3 < 50 && mark3 >= 40 && mark4 < 50 && mark4 >= 40 && mark5 < 50 && mark5 >= 40 && mark6 < 50 && mark6 >= 40 && mark7 < 50 && mark7 >= 40 && mark8 < 50 && mark8 >= 40 && mark9 < 40 && mark9 >= 30 && mark10 < 50 && mark10 >= 40)
                {
                    mark1 = 3;
                    mark2 = 3;
                    mark3 = 3;
                    mark4 = 3;
                    mark5 = 3;
                    mark6 = 3;
                    mark7 = 3;
                    mark8 = 3;
                    mark9 = 3;
                    mark10 = 3;
                }
                else if (mark1 < 60 && mark1 >= 50 && mark2 < 60 && mark2 >= 50 && mark3 < 60 && mark3 >= 50 && mark4 < 60 && mark4 >= 50 && mark5 < 60 && mark5 >= 50 && mark6 < 60 && mark6 >= 50 && mark7 < 60 && mark7 >= 50 && mark8 < 60 && mark8 >= 50 && mark9 < 60 && mark9 >= 50 && mark10 < 60 && mark10 >= 50)
                {
                    mark1 = 4;
                    mark2 = 4;
                    mark3 = 4;
                    mark4 = 4;
                    mark5 = 4;
                    mark6 = 4;
                    mark7 = 4;
                    mark8 = 4;
                    mark9 = 4;
                    mark10 = 4;
                }
                else if (mark1 < 70 && mark1 >= 60 && mark2 < 70 && mark2 >= 60 && mark3 < 70 && mark3 >= 60 && mark4 < 70 && mark4 >= 60 && mark5 < 70 && mark5 >= 60 && mark6 < 70 && mark6 >= 60 && mark7 < 70 && mark7 >= 60 && mark8 < 70 && mark8 >= 60 && mark9 < 70 && mark9 >= 60 && mark10 < 70 && mark10 >= 60)
                {
                    mark1 = 5;
                    mark2 = 5;
                    mark3 = 5;
                    mark4 = 5;
                    mark5 = 5;
                    mark6 = 5;
                    mark7 = 5;
                    mark8 = 5;
                    mark9 = 5;
                    mark10 = 5;
                }
                else if (mark1 < 80 && mark1 >= 70 && mark2 < 80 && mark2 >= 70 && mark3 < 80 && mark3 >= 70 && mark4 < 80 && mark4 >= 70 && mark5 < 80 && mark5 >= 70 && mark6 < 80 && mark6 >= 70 && mark7 < 80 && mark7 >= 70 && mark8 < 80 && mark8 >= 70 && mark9 < 80 && mark9 >= 70 && mark10 < 80 && mark10 >= 70)
                {
                    mark1 = 6;
                    mark2 = 6;
                    mark3 = 6;
                    mark4 = 6;
                    mark5 = 6;
                    mark6 = 6;
                    mark7 = 6;
                    mark8 = 6;
                    mark9 = 6;
                    mark10 = 6;
                }
                else if (mark1 <= 100 && mark1 >= 80 && mark2 <= 100 && mark2 >= 80 && mark3 <= 100 && mark3 >= 80 && mark4 <= 100 && mark4 >= 80 && mark5 <= 100 && mark5 >= 80 && mark6 <= 100 && mark6 >= 80 && mark7 <= 100 && mark7 >= 80 && mark8 <= 100 && mark8 >= 80 && mark9 <= 100 && mark9 >= 80 && mark10 <= 100 && mark10 >= 80)
                {
                    mark1 = 7;
                    mark2 = 7;
                    mark3 = 7;
                    mark4 = 7;
                    mark5 = 7;
                    mark6 = 7;
                    mark7 = 7;
                    mark8 = 7;
                    mark9 = 7;
                    mark10 = 7;
                }
                else
                {
                    MessageBox.Show("Mark entered is invalid, please valid mark");
                }
                totalAPS = mark1 + mark2 + mark3 + mark4 + mark5 + mark6 + mark7 + mark8 + mark9 + mark10;

                MessageBox.Show("Your APS is " + totalAPS);
            }
            catch
            {
                MessageBox.Show("you entered invalid data, please enter correct data ");
            }

            
        }

        private void lblAPS_Click(object sender, EventArgs e)
        {

        }

        private void Student_Results_Load(object sender, EventArgs e)
        {

        }
    }
}

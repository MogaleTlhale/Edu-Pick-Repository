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
    public partial class StudentMaintain : Form
    {
        public StudentMaintain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new deleteAccStudent();
            newForm.Show();
            this.Hide();
        }
    }
}

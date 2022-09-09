
namespace Edu_Pick_System__2_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.cbChooseCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChosenCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.BackColor = System.Drawing.Color.White;
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(152, 69);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(353, 199);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.UseWaitCursor = true;
            // 
            // cbChooseCourse
            // 
            this.cbChooseCourse.FormattingEnabled = true;
            this.cbChooseCourse.Location = new System.Drawing.Point(521, 216);
            this.cbChooseCourse.Name = "cbChooseCourse";
            this.cbChooseCourse.Size = new System.Drawing.Size(159, 21);
            this.cbChooseCourse.TabIndex = 1;
            this.cbChooseCourse.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(148, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Below are the recommended courses";
            this.label2.UseWaitCursor = true;
            // 
            // btnChooseCourse
            // 
            this.btnChooseCourse.Location = new System.Drawing.Point(288, 394);
            this.btnChooseCourse.Name = "btnChooseCourse";
            this.btnChooseCourse.Size = new System.Drawing.Size(109, 63);
            this.btnChooseCourse.TabIndex = 5;
            this.btnChooseCourse.Text = "Confirm Course";
            this.btnChooseCourse.UseVisualStyleBackColor = true;
            this.btnChooseCourse.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(518, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select arrow below and choose a course";
            this.label1.UseWaitCursor = true;
            // 
            // lblChosenCourse
            // 
            this.lblChosenCourse.AutoSize = true;
            this.lblChosenCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblChosenCourse.ForeColor = System.Drawing.Color.Transparent;
            this.lblChosenCourse.Location = new System.Drawing.Point(518, 255);
            this.lblChosenCourse.Name = "lblChosenCourse";
            this.lblChosenCourse.Size = new System.Drawing.Size(151, 13);
            this.lblChosenCourse.TabIndex = 7;
            this.lblChosenCourse.Text = "The course you\'ve selected is:";
            this.lblChosenCourse.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 469);
            this.Controls.Add(this.lblChosenCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseCourse);
            this.Controls.Add(this.lbCourses);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Choose Course";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.ComboBox cbChooseCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChosenCourse;
    }
}


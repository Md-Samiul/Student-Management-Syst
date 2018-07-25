using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace UI
{
    public partial class Main_From : Form
    {
        StudentData studentDataObject = new StudentData();
        CourseData courseDataObject = new CourseData();
        TeacherData teacherDataObject = new TeacherData();
        CourseTeacherData courseTeacherDataObject = new CourseTeacherData();
        RegistrationData registrationDataObject = new RegistrationData();

        public Main_From()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Student objIN = new Student();
            
                if (textSID.Text != "" & textSName.Text != "")
                {    
                  objIN.ID = int.Parse(textSID.Text);
                  objIN.Name = textSName.Text;

                  studentDataObject.Insert(objIN);
                  MessageBox.Show("Student Data Saved!");
                }
                else MessageBox.Show("Not Enough Data!");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student objToUpdate = new Student();
            if( textSID.Text != "" & textSName.Text!= "")
            {
                objToUpdate.ID = int.Parse(textSID.Text);
                objToUpdate.Name = textSName.Text;

                studentDataObject.Update(objToUpdate);
                MessageBox.Show("Student Data Updated!");
            } else MessageBox.Show("Not Enough Data!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textSID.Text != "" )
            {
                int id = int.Parse(textSID.Text);
                studentDataObject.Delete(id);

                MessageBox.Show("Student Data Deleted!");
            }
        }

        private void textSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Number Only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Number Only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Number Only");
                e.KeyChar = (char)0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = studentDataObject.Query();
            dataGridView1.DataSource = dt;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Course objIN = new Course();

            if (textCRSID.Text != "" & textCRSNAME.Text != "")
            {
                objIN.ID = int.Parse(textCRSID.Text);
                objIN.Name = textCRSNAME.Text;

                courseDataObject.Insert(objIN);
                MessageBox.Show("Course Data Saved!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Course objToUpdate = new Course();
            if (textCRSID.Text != "" & textCRSNAME.Text != "")
            {
                objToUpdate.ID = int.Parse(textCRSID.Text);
                objToUpdate.Name = textCRSNAME.Text;

                courseDataObject.Update(objToUpdate);
                MessageBox.Show("Course Data Updated!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = courseDataObject.Query();
            dataGridView4.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textCRSID.Text != "")
            {
                int id = int.Parse(textCRSID.Text);
                courseDataObject.Delete(id);

                MessageBox.Show("Course Data Deleted!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Teacher objIN = new Teacher();

            if (textTID.Text != "" & textTNAME.Text != "")
            {
                objIN.ID = int.Parse(textTID.Text);
                objIN.Name = textTNAME.Text;

                teacherDataObject.Insert(objIN);
                MessageBox.Show("Teacher Data Saved!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = teacherDataObject.Query();
            dataGridView3.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Teacher objToUpdate = new Teacher();
            if (textTID.Text != "" & textTNAME.Text != "")
            {
                objToUpdate.ID = int.Parse(textTID.Text);
                objToUpdate.Name = textTNAME.Text;

                teacherDataObject.Update(objToUpdate);
                MessageBox.Show("Teacher Data Updated!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textTID.Text != "")
            {
                int id = int.Parse(textTID.Text);
                teacherDataObject.Delete(id);

                MessageBox.Show("Teacher Data Deleted!");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CourseTeacher objReg = new CourseTeacher();

            if (textBox2Tid.Text != "" & textBox1Cid.Text != "")
            {
                objReg.tID = int.Parse(textBox2Tid.Text);
                objReg.cID = int.Parse(textBox1Cid.Text);

                courseTeacherDataObject.Register(objReg);
                MessageBox.Show("Registered!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DataTable dt = courseTeacherDataObject.Query();
            dataGridView9.DataSource = dt;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CourseTeacher objToUpdate = new CourseTeacher();
            if (textBox2Tid.Text != "" & textBox1Cid.Text != "")
            {
                objToUpdate.tID = int.Parse(textBox2Tid.Text);
                objToUpdate.cID = int.Parse(textBox1Cid.Text);

                courseTeacherDataObject.Update(objToUpdate);
                MessageBox.Show("Teacher Data Updated!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox2Tid.Text != "" & textBox1Cid.Text != "")
            {
                CourseTeacher objDEl = new CourseTeacher();
                objDEl.tID = int.Parse(textBox2Tid.Text);
                objDEl.cID = int.Parse(textBox1Cid.Text);
                courseTeacherDataObject.Delete(objDEl);
                MessageBox.Show("Register Data Deleted!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = registrationDataObject.Query();
            dataGridView7.DataSource = dt;
        }

        private void button19_Click(object sender, EventArgs e)
        {
           Registration objReg = new Registration();

           if (textBox_RegID.Text != "" & textBox_SID.Text != "" & textBox_C1ID.Text != "" & textBox_C2ID.Text != "" & textBox_C3ID.Text != "")
            {
                objReg.regID = int.Parse(textBox_RegID.Text);
                objReg.sID = int.Parse(textBox_SID.Text);
                objReg.c1ID = int.Parse(textBox_C1ID.Text);
                objReg.c2ID = int.Parse(textBox_C2ID.Text);
                objReg.c3ID = int.Parse(textBox_C3ID.Text);
                registrationDataObject.Insert(objReg);
                MessageBox.Show("Registered!");
            }
            else MessageBox.Show("Not Enough Data!");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox_RegID.Text != "")
            {
                int id = int.Parse(textBox_RegID.Text);
                registrationDataObject.Delete(id);

                MessageBox.Show("Register Data Deleted!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DataTable dt = courseDataObject.Query();
            dataGridView8.DataSource = dt;
        }
    }
}

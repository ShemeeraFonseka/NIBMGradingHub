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

namespace WindowsFormsApp3
{
    public partial class MarkSheet : MetroFramework.Forms.MetroForm
    {
        public MarkSheet()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            binddatagrid();

            SqlConnection con;
            SqlCommand com;

            con = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            st_ID.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Student_ID FROM Student_Details";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                st_ID.Items.Add(dr["Student_ID"].ToString());
            }
            con.Close();

            SqlConnection con1;
            SqlCommand com1;

            con1 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            s_ID.Items.Clear();
            con1.Open();
            com1 = con1.CreateCommand();
            com1.CommandType = CommandType.Text;
            com1.CommandText = "SELECT Subject_Code FROM Subjects";
            com1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            da1.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                s_ID.Items.Add(dr1["Subject_Code"].ToString());
            }
            con1.Close();

            SqlConnection con2;
            SqlCommand com2;

            con2 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            c_ID.Items.Clear();
            con2.Open();
            com2 = con2.CreateCommand();
            com2.CommandType = CommandType.Text;
            com2.CommandText = "SELECT course_code FROM Courses";
            com2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                c_ID.Items.Add(dr2["course_code"].ToString());
            }
            con2.Close();

            SqlConnection con3;
            SqlCommand com3;

            con3 = new SqlConnection("Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True");


            s_ID.Items.Clear();
            con3.Open();
            com3 = con3.CreateCommand();
            com3.CommandType = CommandType.Text;
            com3.CommandText = "SELECT Subject_Code FROM Subjects";
            com3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(com3);
            da3.Fill(dt3);

            foreach (DataRow dr3 in dt3.Rows)
            {
                s_ID.Items.Add(dr3["Subject_Code"].ToString());
            }
            con3.Close();
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from [Marks]";
            com.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable("Marks");
            da.Fill(dt);

            Data.DataSource = dt.DefaultView;

        }

        double cw, exam, finalmarks, gradepoints;
        string Grade;

        private void tile_insert_Click(object sender, EventArgs e)
        {
            if (txt_FinalMarks.Text.Length == 0)
            {
                MessageBox.Show("Final Marks cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_FinalMarks.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Final Marks cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (grade.Text.Length == 0)
            {
                MessageBox.Show("Grade cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (grade.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Grade cannot have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (credits.Text.Length == 0)
            {
                MessageBox.Show("Grade Points cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (credits.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Final Marks cannot have Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VCGLE82;Initial Catalog=gradingsystem;Integrated Security=True";

                string Student_ID, course_ID, subject_ID, Grade;
                int course_work_marks, exam_marks;
                double Grade_point, final_marks;

                Student_ID = st_ID.Text;
                course_ID = c_ID.Text;
                subject_ID = s_ID.Text;
                course_work_marks = Convert.ToInt32(txt_CourseWork.Text);
                exam_marks = Convert.ToInt32(txt_ExamMarks.Text);
                final_marks = Convert.ToDouble(txt_FinalMarks.Text);
                Grade = grade.Text;
                Grade_point = Convert.ToDouble(credits.Text);

                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Marks values (@a, @b, @c, @d, @e, @f,@g,@h)", con);
                com.Parameters.AddWithValue("a", Student_ID);
                com.Parameters.AddWithValue("b", course_ID);
                com.Parameters.AddWithValue("c", subject_ID);
                com.Parameters.AddWithValue("d", course_work_marks);
                com.Parameters.AddWithValue("e", exam_marks);
                com.Parameters.AddWithValue("f", final_marks);
                com.Parameters.AddWithValue("g", Grade);
                com.Parameters.AddWithValue("h", Grade_point);

                int a = com.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("Data added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binddatagrid();
                }
                else
                {
                    MessageBox.Show("Data cannot Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                com.Connection = con;
            }
        }

        private void tile_cal_Click(object sender, EventArgs e)
        {
            if (st_ID.Text.Length == 0)
            {
                MessageBox.Show("Student ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (s_ID.Text.Length == 0)
            {
                MessageBox.Show("Subject ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c_ID.Text.Length == 0)
            {
                MessageBox.Show("Course ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_CourseWork.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Course Work Marks cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_CourseWork.Text.Length == 0)
            {
                MessageBox.Show("Course Work Marks cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ExamMarks.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Exam Marks cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_ExamMarks.Text.Length == 0)
            {
                MessageBox.Show("Exam Marks cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cw = Convert.ToDouble(txt_CourseWork.Text);
                exam = Convert.ToDouble(txt_ExamMarks.Text);
                finalmarks = (cw + exam) / 2;

                if (finalmarks >= 85 && finalmarks <= 100)
                {
                    Grade = "A+";
                    gradepoints = 4.0;
                }
                else if (finalmarks >= 70 && finalmarks <= 84)
                {
                    Grade = "A";
                    gradepoints = 4.0;
                }
                else if (finalmarks >= 65 && finalmarks <= 69)
                {
                    Grade = "A-";
                    gradepoints = 3.7;
                }
                else if (finalmarks >= 60 && finalmarks <= 64)
                {
                    Grade = "B+";
                    gradepoints = 3.3;
                }
                else if (finalmarks >= 55 && finalmarks <= 59)
                {
                    Grade = "B";
                    gradepoints = 3.0;
                }
                else if (finalmarks >= 50 && finalmarks <= 54)
                {
                    Grade = "B-";
                    gradepoints = 2.7;
                }
                else if (finalmarks >= 45 && finalmarks <= 49)
                {
                    Grade = "C+";
                    gradepoints = 2.3;
                }
                else if (finalmarks >= 40 && finalmarks <= 44)
                {
                    Grade = "C";
                    gradepoints = 2.0;
                }
                else if (finalmarks >= 35 && finalmarks <= 39)
                {
                    Grade = "C-";
                    gradepoints = 1.7;
                }
                else if (finalmarks >= 30 && finalmarks <= 34)
                {
                    Grade = "D+";
                    gradepoints = 1.3;
                }
                else if (finalmarks >= 25 && finalmarks <= 29)
                {
                    Grade = "D";
                    gradepoints = 1.0;
                }
                else
                {
                    Grade = "E";
                    gradepoints = 0.0;
                }

                txt_FinalMarks.Text = Convert.ToString(finalmarks);
                grade.Text = Grade;
                credits.Text = Convert.ToString(gradepoints);
            }
        }

        private void tile_back_Click(object sender, EventArgs e)
        {
            Manage_Marks man = new Manage_Marks();
            man.Show();
            this.Close();
        }

        private void tile_clear_Click(object sender, EventArgs e)
        {
            st_ID.Items.Clear();
            s_ID.Items.Clear();
            c_ID.Items.Clear();
            txt_CourseWork.Clear();
            txt_ExamMarks.Clear();
            txt_FinalMarks.Clear();
            grade.Clear();
            credits.Clear();
        }

        private void MarkSheet_Load(object sender, EventArgs e)
        {

        }
    }
}

using StudentGrades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LB03StudentGrades_JohnBaradaFINALFINALFINAL
{
    public partial class frmStudentGrades : Form
    {
        private List<Student> students;

        public frmStudentGrades()
        {
            InitializeComponent();
            students = ReadStudentFromFile(PATH);
        }

        const string PATH = "C:\\Users\\13146\\Desktop\\LINQLAB03FINAl\\LB03StudentGrades_JohnBaradaFINALFINALFINAL\\StudentGrades\\StudentGrades.txt";

        static List<Student> ReadStudentFromFile(string filename)
        {
            List<Student> studentList = new List<Student>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');

                        if (data.Length == 3 && decimal.TryParse(data[1], out decimal labScore)
                            && decimal.TryParse(data[2], out decimal testScore))
                        {
                            Student student = new Student
                            {
                                Name = data[0],
                                LabScore = labScore,
                                TestScore = testScore
                            };
                            studentList.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckTextbox();
            DisplayAverages();
        }

        private void CheckTextbox()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show($"Insert Value in Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAverages()
        {
            string searchName = txtName.Text;
            var student = students.FirstOrDefault(s => s.Name == searchName);

            if (student == null)
            {
                lblResult.Text = "Student not found.";
                return;
            }

            var avg = (student.LabScore + student.TestScore) / 2;

            lblResult.Text = $"Student Name: {student.Name} \n Lab Score: {student.LabScore}\n Test Score: {student.TestScore}\n Average Score: {avg:F2}";
        }

        private void frmStudentGrades_Load(object sender, EventArgs e)
        {
            lblResult.Text = "Input a Name";
        }
    }
}

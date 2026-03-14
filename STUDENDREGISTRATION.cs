using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDay.Items.Add("-Day-");
            cbMonth.Items.Add("-Month-");
            cbYear.Items.Add("-Year-");
            cbProgram.Items.Add("-Select program-");

           
            for (int day = 1; day <= 31; day++)
            {
                cbDay.Items.Add(day);
            }

            
            for (int month = 1; month <= 12; month++)
            {
                cbMonth.Items.Add(month);
            }

           
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cbYear.Items.Add(year);
            }

            
            ArrayList programs = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string program in programs)
            {
                cbProgram.Items.Add(program);
            }

          
            cbDay.SelectedIndex = 0;
            cbMonth.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
            cbProgram.SelectedIndex = 0;
        }

        private void Register_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Please enter the last name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFN.Text))
            {
                MessageBox.Show("Please enter the first name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMD.Text))
            {
                MessageBox.Show("Please enter the middle name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMD.Focus();
                return;
            }

            if (!rbM.Checked && !rbF.Checked)
            {
                MessageBox.Show("Please select a gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbDay.SelectedIndex == 0 || cbMonth.SelectedIndex == 0 || cbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please complete the date of birth.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbProgram.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a program.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string day = cbDay.SelectedItem.ToString();
            string month = cbMonth.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();
            string program = cbProgram.SelectedItem.ToString();

            string gender = rbM.Checked ? "Male" : "Female";
            string fullName = txtFN.Text + " " + txtMD.Text + " " + txtLN.Text;
            string dateOfBirth = day + "/" + month + "/" + year;

           
            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth + "\n"
                           + "Program: " + program;

            MessageBox.Show(message, "Registration Successful");
        }
    }
}

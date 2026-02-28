using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            {

                cbDay.Items.Add("-Day-");
                cbMonth.Items.Add("-Month-");
                cbYear.Items.Add("-Year-");



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


                cbDay.SelectedIndex = 0;
                cbMonth.SelectedIndex = 0;
                cbYear.SelectedIndex = 0;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Please enter the last name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFN.Text))
            {
                MessageBox.Show("Please enter the first name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMD.Text))
            {
                MessageBox.Show("Please enter the middle name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMD.Focus();
                return;
            }

            if (!rbM.Checked && !rbF.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbDay.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = cbDay.SelectedItem.ToString();
            string month = cbMonth.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();

            string gender = "";
            if (rbM.Checked)
            {
                gender = "Male";
            }
            else if (rbF.Checked)
            {
                gender = "Female";
            }

            string fullName = txtFN.Text + " " + txtMD.Text + " " + txtLN.Text;


            string dateOfBirth = day + "/" + month + "/" + year;


            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth;

            MessageBox.Show(message);
        }
    }
}



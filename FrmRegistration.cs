using System;
using System.Windows.Forms;

namespace Account_Registration
{
	public partial class FrmRegistration : Form
	{
		public FrmRegistration()
		{
			InitializeComponent();
			cbProgram.SelectedIndex = 0;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			long studentNo;
			long age;
			long contactNo;

			if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
				string.IsNullOrWhiteSpace(txtFirstName.Text) ||
				string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
				string.IsNullOrWhiteSpace(txtLastName.Text) ||
				string.IsNullOrWhiteSpace(txtAge.Text) ||
				string.IsNullOrWhiteSpace(txtContactNo.Text) ||
				string.IsNullOrWhiteSpace(txtAddress.Text) ||
				cbProgram.SelectedIndex <= 0)
			{
				MessageBox.Show(
					"Please complete all fields.",
					"Missing Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return;
			}

			if (!long.TryParse(txtStudentNo.Text, out studentNo) ||
				studentNo <= 0)
			{
				MessageBox.Show(
					"Enter a valid student number.",
					"Invalid Student Number",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				txtStudentNo.Focus();
				return;
			}

			if (!long.TryParse(txtAge.Text, out age) ||
				age <= 0 ||
				age > 150)
			{
				MessageBox.Show(
					"Enter a valid age.",
					"Invalid Age",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				txtAge.Focus();
				return;
			}

			if (!long.TryParse(txtContactNo.Text, out contactNo) ||
				contactNo <= 0)
			{
				MessageBox.Show(
					"Enter a valid numeric contact number.",
					"Invalid Contact Number",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				txtContactNo.Focus();
				return;
			}

			StudentInfoClass.StudentNo = studentNo;
			StudentInfoClass.FirstName = txtFirstName.Text.Trim();
			StudentInfoClass.MiddleName = txtMiddleName.Text.Trim();
			StudentInfoClass.LastName = txtLastName.Text.Trim();
			StudentInfoClass.Age = age;
			StudentInfoClass.ContactNo = contactNo;
			StudentInfoClass.Address = txtAddress.Text.Trim();
			StudentInfoClass.Program = cbProgram.Text;

			using (FrmConfirm confirmForm = new FrmConfirm())
			{
				if (confirmForm.ShowDialog() == DialogResult.OK)
				{
					ResetControls();
				}
			}
		}

		private void ResetControls()
		{
			txtStudentNo.Clear();
			txtFirstName.Clear();
			txtMiddleName.Clear();
			txtLastName.Clear();
			txtAge.Clear();
			txtContactNo.Clear();
			txtAddress.Clear();

			cbProgram.SelectedIndex = 0;
			txtStudentNo.Focus();
		}
	}
}
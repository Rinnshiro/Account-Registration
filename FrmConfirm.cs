using System;
using System.Windows.Forms;

namespace Account_Registration
{
	public partial class FrmConfirm : Form
	{
		private DelegateText DelProgram;
		private DelegateText DelLastName;
		private DelegateText DelFirstName;
		private DelegateText DelMiddleName;
		private DelegateText DelAddress;

		private DelegateNumber DelNumAge;
		private DelegateNumber DelNumContactNo;
		private DelegateNumber DelStudNo;

		public FrmConfirm()
		{
			InitializeComponent();

			DelProgram = new DelegateText(StudentInfoClass.GetProgram);

			DelLastName = new DelegateText(StudentInfoClass.GetLastName);

			DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);

			DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);

			DelAddress = new DelegateText(StudentInfoClass.GetAddress);

			DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);

			DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);

			DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
		}

		private void FrmConfirm_Load(object sender, EventArgs e)
		{
			lblValueStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();

			lblValueProgram.Text = DelProgram(StudentInfoClass.Program);

			lblValueLastName.Text = DelLastName(StudentInfoClass.LastName);

			lblValueFirstName.Text = DelFirstName(StudentInfoClass.FirstName);

			lblValueMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);

			lblValueAge.Text = DelNumAge(StudentInfoClass.Age).ToString();

			lblValueContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();

			lblValueAddress.Text = DelAddress(StudentInfoClass.Address);
		}

		private void btnConfirm_Click(
			object sender,
			EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void FrmConfirm_FormClosing(
			object sender,
			FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
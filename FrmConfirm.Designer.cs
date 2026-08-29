// FrmConfirm.Designer.cs
namespace Account_Registration
{
	partial class FrmConfirm
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label lblStudentNo;
		private System.Windows.Forms.Label lblProgram;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblMiddleName;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblContactNo;
		private System.Windows.Forms.Label lblAddress;

		private System.Windows.Forms.Label lblValueStudentNo;
		private System.Windows.Forms.Label lblValueProgram;
		private System.Windows.Forms.Label lblValueLastName;
		private System.Windows.Forms.Label lblValueFirstName;
		private System.Windows.Forms.Label lblValueMiddleName;
		private System.Windows.Forms.Label lblValueAge;
		private System.Windows.Forms.Label lblValueContactNo;
		private System.Windows.Forms.Label lblValueAddress;

		private System.Windows.Forms.Button btnConfirm;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			lblStudentNo = new Label();
			lblProgram = new Label();
			lblLastName = new Label();
			lblFirstName = new Label();
			lblMiddleName = new Label();
			lblAge = new Label();
			lblContactNo = new Label();
			lblAddress = new Label();
			lblValueStudentNo = new Label();
			lblValueProgram = new Label();
			lblValueLastName = new Label();
			lblValueFirstName = new Label();
			lblValueMiddleName = new Label();
			lblValueAge = new Label();
			lblValueContactNo = new Label();
			lblValueAddress = new Label();
			btnConfirm = new Button();
			SuspendLayout();
			// 
			// lblStudentNo
			// 
			lblStudentNo.AutoSize = true;
			lblStudentNo.ForeColor = Color.Black;
			lblStudentNo.Location = new Point(26, 31);
			lblStudentNo.Name = "lblStudentNo";
			lblStudentNo.Size = new Size(73, 15);
			lblStudentNo.TabIndex = 0;
			lblStudentNo.Text = "Student No.:";
			// 
			// lblProgram
			// 
			lblProgram.AutoSize = true;
			lblProgram.ForeColor = Color.Black;
			lblProgram.Location = new Point(26, 72);
			lblProgram.Name = "lblProgram";
			lblProgram.Size = new Size(56, 15);
			lblProgram.TabIndex = 2;
			lblProgram.Text = "Program:";
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.ForeColor = Color.Black;
			lblLastName.Location = new Point(26, 113);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new Size(64, 15);
			lblLastName.TabIndex = 4;
			lblLastName.Text = "Last name:";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.ForeColor = Color.Black;
			lblFirstName.Location = new Point(26, 154);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(65, 15);
			lblFirstName.TabIndex = 6;
			lblFirstName.Text = "First name:";
			// 
			// lblMiddleName
			// 
			lblMiddleName.AutoSize = true;
			lblMiddleName.ForeColor = Color.Black;
			lblMiddleName.Location = new Point(26, 195);
			lblMiddleName.Name = "lblMiddleName";
			lblMiddleName.Size = new Size(82, 15);
			lblMiddleName.TabIndex = 8;
			lblMiddleName.Text = "Middle Name:";
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.ForeColor = Color.Black;
			lblAge.Location = new Point(26, 236);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(31, 15);
			lblAge.TabIndex = 10;
			lblAge.Text = "Age:";
			// 
			// lblContactNo
			// 
			lblContactNo.AutoSize = true;
			lblContactNo.ForeColor = Color.Black;
			lblContactNo.Location = new Point(26, 277);
			lblContactNo.Name = "lblContactNo";
			lblContactNo.Size = new Size(74, 15);
			lblContactNo.TabIndex = 12;
			lblContactNo.Text = "Contact No.:";
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.ForeColor = Color.Black;
			lblAddress.Location = new Point(26, 318);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(52, 15);
			lblAddress.TabIndex = 14;
			lblAddress.Text = "Address:";
			// 
			// lblValueStudentNo
			// 
			lblValueStudentNo.AutoSize = true;
			lblValueStudentNo.ForeColor = Color.Black;
			lblValueStudentNo.Location = new Point(149, 31);
			lblValueStudentNo.Name = "lblValueStudentNo";
			lblValueStudentNo.Size = new Size(95, 15);
			lblValueStudentNo.TabIndex = 1;
			lblValueStudentNo.Text = "Student Number";
			// 
			// lblValueProgram
			// 
			lblValueProgram.AutoSize = true;
			lblValueProgram.ForeColor = Color.Black;
			lblValueProgram.Location = new Point(149, 72);
			lblValueProgram.MaximumSize = new Size(250, 0);
			lblValueProgram.Name = "lblValueProgram";
			lblValueProgram.Size = new Size(100, 15);
			lblValueProgram.TabIndex = 3;
			lblValueProgram.Text = "Selected Program";
			// 
			// lblValueLastName
			// 
			lblValueLastName.AutoSize = true;
			lblValueLastName.ForeColor = Color.Black;
			lblValueLastName.Location = new Point(149, 113);
			lblValueLastName.Name = "lblValueLastName";
			lblValueLastName.Size = new Size(63, 15);
			lblValueLastName.TabIndex = 5;
			lblValueLastName.Text = "Last Name";
			// 
			// lblValueFirstName
			// 
			lblValueFirstName.AutoSize = true;
			lblValueFirstName.ForeColor = Color.Black;
			lblValueFirstName.Location = new Point(149, 154);
			lblValueFirstName.Name = "lblValueFirstName";
			lblValueFirstName.Size = new Size(64, 15);
			lblValueFirstName.TabIndex = 7;
			lblValueFirstName.Text = "First Name";
			// 
			// lblValueMiddleName
			// 
			lblValueMiddleName.AutoSize = true;
			lblValueMiddleName.ForeColor = Color.Black;
			lblValueMiddleName.Location = new Point(149, 195);
			lblValueMiddleName.Name = "lblValueMiddleName";
			lblValueMiddleName.Size = new Size(79, 15);
			lblValueMiddleName.TabIndex = 9;
			lblValueMiddleName.Text = "Middle Name";
			// 
			// lblValueAge
			// 
			lblValueAge.AutoSize = true;
			lblValueAge.ForeColor = Color.Black;
			lblValueAge.Location = new Point(149, 236);
			lblValueAge.Name = "lblValueAge";
			lblValueAge.Size = new Size(28, 15);
			lblValueAge.TabIndex = 11;
			lblValueAge.Text = "Age";
			// 
			// lblValueContactNo
			// 
			lblValueContactNo.AutoSize = true;
			lblValueContactNo.ForeColor = Color.Black;
			lblValueContactNo.Location = new Point(149, 277);
			lblValueContactNo.Name = "lblValueContactNo";
			lblValueContactNo.Size = new Size(96, 15);
			lblValueContactNo.TabIndex = 13;
			lblValueContactNo.Text = "Contact Number";
			// 
			// lblValueAddress
			// 
			lblValueAddress.ForeColor = Color.Black;
			lblValueAddress.Location = new Point(149, 318);
			lblValueAddress.Name = "lblValueAddress";
			lblValueAddress.Size = new Size(245, 50);
			lblValueAddress.TabIndex = 15;
			lblValueAddress.Text = "Student Address";
			// 
			// btnConfirm
			// 
			btnConfirm.Location = new Point(319, 395);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(75, 29);
			btnConfirm.TabIndex = 16;
			btnConfirm.Text = "Submit";
			btnConfirm.UseVisualStyleBackColor = true;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// FrmConfirm
			// 
			AcceptButton = btnConfirm;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(434, 451);
			Controls.Add(lblStudentNo);
			Controls.Add(lblValueStudentNo);
			Controls.Add(lblProgram);
			Controls.Add(lblValueProgram);
			Controls.Add(lblLastName);
			Controls.Add(lblValueLastName);
			Controls.Add(lblFirstName);
			Controls.Add(lblValueFirstName);
			Controls.Add(lblMiddleName);
			Controls.Add(lblValueMiddleName);
			Controls.Add(lblAge);
			Controls.Add(lblValueAge);
			Controls.Add(lblContactNo);
			Controls.Add(lblValueContactNo);
			Controls.Add(lblAddress);
			Controls.Add(lblValueAddress);
			Controls.Add(btnConfirm);
			Font = new Font("Segoe UI", 9F);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmConfirm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "FrmConfirm";
			FormClosing += FrmConfirm_FormClosing;
			Load += FrmConfirm_Load;
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
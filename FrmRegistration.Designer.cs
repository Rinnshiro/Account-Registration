namespace Account_Registration
{
	partial class FrmRegistration
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

		private System.Windows.Forms.TextBox txtStudentNo;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.TextBox txtAddress;

		private System.Windows.Forms.ComboBox cbProgram;
		private System.Windows.Forms.Button btnNext;

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
			this.lblStudentNo = new System.Windows.Forms.Label();
			this.lblProgram = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblContactNo = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();

			this.txtStudentNo = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();

			this.cbProgram = new System.Windows.Forms.ComboBox();
			this.btnNext = new System.Windows.Forms.Button();

			this.SuspendLayout();

			// lblStudentNo
			this.lblStudentNo.AutoSize = true;
			this.lblStudentNo.Location =
				new System.Drawing.Point(38, 35);
			this.lblStudentNo.Name = "lblStudentNo";
			this.lblStudentNo.Size =
				new System.Drawing.Size(70, 15);
			this.lblStudentNo.Text = "Student No.:";

			// txtStudentNo
			this.txtStudentNo.Location =
				new System.Drawing.Point(41, 54);
			this.txtStudentNo.Name = "txtStudentNo";
			this.txtStudentNo.Size =
				new System.Drawing.Size(272, 23);
			this.txtStudentNo.TabIndex = 0;

			// lblProgram
			this.lblProgram.AutoSize = true;
			this.lblProgram.Location =
				new System.Drawing.Point(353, 35);
			this.lblProgram.Name = "lblProgram";
			this.lblProgram.Size =
				new System.Drawing.Size(56, 15);
			this.lblProgram.Text = "Program:";

			// cbProgram
			this.cbProgram.DropDownStyle =
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProgram.FormattingEnabled = true;
			this.cbProgram.Items.AddRange(
				new object[]
				{
					"Select a program",
					"BS in Information Technology",
					"BS in Computer Science",
					"BS in Information Systems",
					"BS in Computer Engineering"
				});
			this.cbProgram.Location =
				new System.Drawing.Point(356, 54);
			this.cbProgram.Name = "cbProgram";
			this.cbProgram.Size =
				new System.Drawing.Size(272, 23);
			this.cbProgram.TabIndex = 1;

			// lblLastName
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location =
				new System.Drawing.Point(38, 100);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size =
				new System.Drawing.Size(66, 15);
			this.lblLastName.Text = "Last Name:";

			// txtLastName
			this.txtLastName.Location =
				new System.Drawing.Point(41, 119);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size =
				new System.Drawing.Size(181, 23);
			this.txtLastName.TabIndex = 2;

			// lblFirstName
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location =
				new System.Drawing.Point(246, 100);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size =
				new System.Drawing.Size(67, 15);
			this.lblFirstName.Text = "First Name:";

			// txtFirstName
			this.txtFirstName.Location =
				new System.Drawing.Point(249, 119);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size =
				new System.Drawing.Size(181, 23);
			this.txtFirstName.TabIndex = 3;

			// lblMiddleName
			this.lblMiddleName.AutoSize = true;
			this.lblMiddleName.Location =
				new System.Drawing.Point(454, 100);
			this.lblMiddleName.Name = "lblMiddleName";
			this.lblMiddleName.Size =
				new System.Drawing.Size(82, 15);
			this.lblMiddleName.Text = "Middle Name:";

			// txtMiddleName
			this.txtMiddleName.Location =
				new System.Drawing.Point(457, 119);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size =
				new System.Drawing.Size(171, 23);
			this.txtMiddleName.TabIndex = 4;

			// lblAge
			this.lblAge.AutoSize = true;
			this.lblAge.Location =
				new System.Drawing.Point(38, 166);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size =
				new System.Drawing.Size(31, 15);
			this.lblAge.Text = "Age:";

			// txtAge
			this.txtAge.Location =
				new System.Drawing.Point(41, 185);
			this.txtAge.MaxLength = 3;
			this.txtAge.Name = "txtAge";
			this.txtAge.Size =
				new System.Drawing.Size(272, 23);
			this.txtAge.TabIndex = 5;

			// lblContactNo
			this.lblContactNo.AutoSize = true;
			this.lblContactNo.Location =
				new System.Drawing.Point(353, 166);
			this.lblContactNo.Name = "lblContactNo";
			this.lblContactNo.Size =
				new System.Drawing.Size(73, 15);
			this.lblContactNo.Text = "Contact No.:";

			// txtContactNo
			this.txtContactNo.Location =
				new System.Drawing.Point(356, 185);
			this.txtContactNo.MaxLength = 15;
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size =
				new System.Drawing.Size(272, 23);
			this.txtContactNo.TabIndex = 6;

			// lblAddress
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location =
				new System.Drawing.Point(38, 231);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size =
				new System.Drawing.Size(52, 15);
			this.lblAddress.Text = "Address:";

			// txtAddress
			this.txtAddress.Location =
				new System.Drawing.Point(41, 250);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ScrollBars =
				System.Windows.Forms.ScrollBars.Vertical;
			this.txtAddress.Size =
				new System.Drawing.Size(587, 75);
			this.txtAddress.TabIndex = 7;

			// btnNext
			this.btnNext.Location =
				new System.Drawing.Point(553, 350);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size =
				new System.Drawing.Size(75, 29);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click +=
				new System.EventHandler(this.btnNext_Click);

			// FrmRegistration
			this.AcceptButton = this.btnNext;
			this.AutoScaleDimensions =
				new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode =
				System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize =
				new System.Drawing.Size(669, 407);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtContactNo);
			this.Controls.Add(this.lblContactNo);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.lblMiddleName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.cbProgram);
			this.Controls.Add(this.lblProgram);
			this.Controls.Add(this.txtStudentNo);
			this.Controls.Add(this.lblStudentNo);
			this.Font =
				new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle =
				System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmRegistration";
			this.StartPosition =
				System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRegistration";

			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
namespace _2016002503_Lab_3
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
            this.btnCalcInterest_Click = new System.Windows.Forms.Button();
            this.startDateCLD = new System.Windows.Forms.MonthCalendar();
            this.endDateCLD = new System.Windows.Forms.MonthCalendar();
            this.sDate = new System.Windows.Forms.Label();
            this.eDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtSolutionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcInterest_Click
            // 
            this.btnCalcInterest_Click.Location = new System.Drawing.Point(10, 12);
            this.btnCalcInterest_Click.Name = "btnCalcInterest_Click";
            this.btnCalcInterest_Click.Size = new System.Drawing.Size(114, 22);
            this.btnCalcInterest_Click.TabIndex = 1;
            this.btnCalcInterest_Click.Text = "Calculate Interest";
            this.btnCalcInterest_Click.UseVisualStyleBackColor = true;
            this.btnCalcInterest_Click.Click += new System.EventHandler(this.btnCalcInterest_Click_Click);
            // 
            // startDateCLD
            // 
            this.startDateCLD.Location = new System.Drawing.Point(10, 69);
            this.startDateCLD.Name = "startDateCLD";
            this.startDateCLD.TabIndex = 2;
            this.startDateCLD.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startDateCLD_DateChanged);
            // 
            // endDateCLD
            // 
            this.endDateCLD.Location = new System.Drawing.Point(289, 69);
            this.endDateCLD.Name = "endDateCLD";
            this.endDateCLD.TabIndex = 3;
            this.endDateCLD.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.endDateCLD_DateChanged);
            // 
            // sDate
            // 
            this.sDate.AutoSize = true;
            this.sDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate.Location = new System.Drawing.Point(13, 44);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(89, 24);
            this.sDate.TabIndex = 4;
            this.sDate.Text = "Start Date";
            // 
            // eDate
            // 
            this.eDate.AutoSize = true;
            this.eDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDate.Location = new System.Drawing.Point(295, 44);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(88, 24);
            this.eDate.TabIndex = 5;
            this.eDate.Text = "End Date";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 255);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(107, 20);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 298);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(107, 20);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 239);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 282);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(12, 388);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(107, 20);
            this.txtInterestRate.TabIndex = 11;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(12, 345);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(107, 20);
            this.txtLoanAmt.TabIndex = 10;
            this.txtLoanAmt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(14, 329);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(79, 13);
            this.lblLoanAmount.TabIndex = 12;
            this.lblLoanAmount.Text = "Loan Amount $";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(14, 372);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(79, 13);
            this.lblInterestRate.TabIndex = 13;
            this.lblInterestRate.Text = "Interest Rate %";
            // 
            // txtSolutionBox
            // 
            this.txtSolutionBox.Location = new System.Drawing.Point(168, 255);
            this.txtSolutionBox.Multiline = true;
            this.txtSolutionBox.Name = "txtSolutionBox";
            this.txtSolutionBox.ReadOnly = true;
            this.txtSolutionBox.Size = new System.Drawing.Size(348, 150);
            this.txtSolutionBox.TabIndex = 14;
            this.txtSolutionBox.TextChanged += new System.EventHandler(this.txtSolutionBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 414);
            this.Controls.Add(this.txtSolutionBox);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmt);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.eDate);
            this.Controls.Add(this.sDate);
            this.Controls.Add(this.endDateCLD);
            this.Controls.Add(this.startDateCLD);
            this.Controls.Add(this.btnCalcInterest_Click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Loan Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcInterest_Click;
        private System.Windows.Forms.MonthCalendar startDateCLD;
        private System.Windows.Forms.MonthCalendar endDateCLD;
        private System.Windows.Forms.Label sDate;
        private System.Windows.Forms.Label eDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtSolutionBox;
    }
}


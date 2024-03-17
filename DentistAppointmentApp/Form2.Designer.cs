namespace DentistAppointmentApp
{
    partial class Form2
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
            this.bookingPanel = new System.Windows.Forms.Panel();
            this.clinicTitleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.dateAndTimePanel = new System.Windows.Forms.Panel();
            this.timeListBox = new System.Windows.Forms.ListBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.serviceAndDoctorPanel = new System.Windows.Forms.Panel();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.doctorListBox = new System.Windows.Forms.ListBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.clinetInformationPanel = new System.Windows.Forms.Panel();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.coprLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.cprTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingPanel.SuspendLayout();
            this.dateAndTimePanel.SuspendLayout();
            this.serviceAndDoctorPanel.SuspendLayout();
            this.clinetInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingPanel
            // 
            this.bookingPanel.BackColor = System.Drawing.Color.LightCyan;
            this.bookingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookingPanel.Controls.Add(this.clinicTitleLabel);
            this.bookingPanel.Controls.Add(this.cancelButton);
            this.bookingPanel.Controls.Add(this.bookButton);
            this.bookingPanel.Controls.Add(this.dateAndTimePanel);
            this.bookingPanel.Controls.Add(this.serviceAndDoctorPanel);
            this.bookingPanel.Controls.Add(this.clinetInformationPanel);
            this.bookingPanel.Location = new System.Drawing.Point(44, 31);
            this.bookingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingPanel.Name = "bookingPanel";
            this.bookingPanel.Size = new System.Drawing.Size(1115, 614);
            this.bookingPanel.TabIndex = 0;
            // 
            // clinicTitleLabel
            // 
            this.clinicTitleLabel.AutoSize = true;
            this.clinicTitleLabel.Font = new System.Drawing.Font("Vladimir Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicTitleLabel.Location = new System.Drawing.Point(352, 17);
            this.clinicTitleLabel.Name = "clinicTitleLabel";
            this.clinicTitleLabel.Size = new System.Drawing.Size(379, 63);
            this.clinicTitleLabel.TabIndex = 10;
            this.clinicTitleLabel.Text = "AR Dental Clinic";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(386, 538);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel and Exit";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.OrangeRed;
            this.bookButton.ForeColor = System.Drawing.Color.White;
            this.bookButton.Location = new System.Drawing.Point(554, 538);
            this.bookButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(150, 40);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // dateAndTimePanel
            // 
            this.dateAndTimePanel.BackColor = System.Drawing.Color.LightCyan;
            this.dateAndTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateAndTimePanel.Controls.Add(this.timeListBox);
            this.dateAndTimePanel.Controls.Add(this.noteLabel);
            this.dateAndTimePanel.Controls.Add(this.appointmentDatePicker);
            this.dateAndTimePanel.Controls.Add(this.timeLabel);
            this.dateAndTimePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateAndTimePanel.Location = new System.Drawing.Point(738, 115);
            this.dateAndTimePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateAndTimePanel.Name = "dateAndTimePanel";
            this.dateAndTimePanel.Size = new System.Drawing.Size(353, 413);
            this.dateAndTimePanel.TabIndex = 2;
            // 
            // timeListBox
            // 
            this.timeListBox.FormattingEnabled = true;
            this.timeListBox.ItemHeight = 20;
            this.timeListBox.Items.AddRange(new object[] {
            "9:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 pm",
            "1:00 pm",
            "2:00 pm",
            "3:00 pm",
            "4:00 pm",
            "5:00 pm",
            "6:00 pm"});
            this.timeListBox.Location = new System.Drawing.Point(20, 114);
            this.timeListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeListBox.Name = "timeListBox";
            this.timeListBox.Size = new System.Drawing.Size(298, 144);
            this.timeListBox.TabIndex = 11;
            // 
            // noteLabel
            // 
            this.noteLabel.Location = new System.Drawing.Point(21, 311);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(298, 88);
            this.noteLabel.TabIndex = 10;
            this.noteLabel.Text = "kindly note that there is a nun refundable 5 bd booking fee";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(20, 55);
            this.appointmentDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(298, 26);
            this.appointmentDatePicker.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(21, 15);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(129, 20);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Choose a time:";
            // 
            // serviceAndDoctorPanel
            // 
            this.serviceAndDoctorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndDoctorPanel.Controls.Add(this.serviceListBox);
            this.serviceAndDoctorPanel.Controls.Add(this.doctorListBox);
            this.serviceAndDoctorPanel.Controls.Add(this.doctorLabel);
            this.serviceAndDoctorPanel.Controls.Add(this.serviceLabel);
            this.serviceAndDoctorPanel.Location = new System.Drawing.Point(363, 115);
            this.serviceAndDoctorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceAndDoctorPanel.Name = "serviceAndDoctorPanel";
            this.serviceAndDoctorPanel.Size = new System.Drawing.Size(365, 413);
            this.serviceAndDoctorPanel.TabIndex = 2;
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 20;
            this.serviceListBox.Location = new System.Drawing.Point(22, 40);
            this.serviceListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(318, 144);
            this.serviceListBox.TabIndex = 3;
            // 
            // doctorListBox
            // 
            this.doctorListBox.FormattingEnabled = true;
            this.doctorListBox.ItemHeight = 20;
            this.doctorListBox.Location = new System.Drawing.Point(23, 241);
            this.doctorListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctorListBox.Name = "doctorListBox";
            this.doctorListBox.Size = new System.Drawing.Size(318, 144);
            this.doctorListBox.TabIndex = 2;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.Location = new System.Drawing.Point(19, 216);
            this.doctorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(149, 20);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "Choose a Doctor:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(18, 15);
            this.serviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(151, 20);
            this.serviceLabel.TabIndex = 0;
            this.serviceLabel.Text = "Choose a service:";
            // 
            // clinetInformationPanel
            // 
            this.clinetInformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clinetInformationPanel.Controls.Add(this.mobileLabel);
            this.clinetInformationPanel.Controls.Add(this.mobileTextBox);
            this.clinetInformationPanel.Controls.Add(this.welcomeMessageLabel);
            this.clinetInformationPanel.Controls.Add(this.coprLabel);
            this.clinetInformationPanel.Controls.Add(this.lNameLabel);
            this.clinetInformationPanel.Controls.Add(this.fNameLabel);
            this.clinetInformationPanel.Controls.Add(this.cprTextBox);
            this.clinetInformationPanel.Controls.Add(this.lNameTextBox);
            this.clinetInformationPanel.Controls.Add(this.fNameTextBox);
            this.clinetInformationPanel.Controls.Add(this.label2);
            this.clinetInformationPanel.Location = new System.Drawing.Point(24, 115);
            this.clinetInformationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clinetInformationPanel.Name = "clinetInformationPanel";
            this.clinetInformationPanel.Size = new System.Drawing.Size(329, 413);
            this.clinetInformationPanel.TabIndex = 1;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(24, 324);
            this.mobileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(115, 20);
            this.mobileLabel.TabIndex = 10;
            this.mobileLabel.Text = "Mobile Number";
            this.mobileLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(24, 349);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mobileTextBox.Multiline = true;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(260, 30);
            this.mobileTextBox.TabIndex = 9;
            this.mobileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Location = new System.Drawing.Point(20, 40);
            this.welcomeMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(297, 92);
            this.welcomeMessageLabel.TabIndex = 8;
            this.welcomeMessageLabel.Text = "Welcome to the Easy Booker kindly enter all the information required to book your" +
    " appointment";
            // 
            // coprLabel
            // 
            this.coprLabel.AutoSize = true;
            this.coprLabel.Location = new System.Drawing.Point(24, 265);
            this.coprLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coprLabel.Name = "coprLabel";
            this.coprLabel.Size = new System.Drawing.Size(187, 20);
            this.coprLabel.TabIndex = 7;
            this.coprLabel.Text = "CPR or Passport Number";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(24, 206);
            this.lNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lNameLabel.TabIndex = 6;
            this.lNameLabel.Text = "Last Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(24, 146);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(86, 20);
            this.fNameLabel.TabIndex = 5;
            this.fNameLabel.Text = "First Name";
            // 
            // cprTextBox
            // 
            this.cprTextBox.Location = new System.Drawing.Point(24, 289);
            this.cprTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cprTextBox.Multiline = true;
            this.cprTextBox.Name = "cprTextBox";
            this.cprTextBox.Size = new System.Drawing.Size(260, 30);
            this.cprTextBox.TabIndex = 3;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(24, 229);
            this.lNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lNameTextBox.Multiline = true;
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(260, 30);
            this.lNameTextBox.TabIndex = 2;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(24, 171);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fNameTextBox.Multiline = true;
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(260, 30);
            this.fNameTextBox.TabIndex = 1;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.fNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your Details:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bookingPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Dentist Appointment Application (Registration)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bookingPanel.ResumeLayout(false);
            this.bookingPanel.PerformLayout();
            this.dateAndTimePanel.ResumeLayout(false);
            this.dateAndTimePanel.PerformLayout();
            this.serviceAndDoctorPanel.ResumeLayout(false);
            this.serviceAndDoctorPanel.PerformLayout();
            this.clinetInformationPanel.ResumeLayout(false);
            this.clinetInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookingPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Panel dateAndTimePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel serviceAndDoctorPanel;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.ListBox doctorListBox;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Panel clinetInformationPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clinicTitleLabel;
        private System.Windows.Forms.TextBox cprTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Label coprLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.ListBox timeListBox;
    }
}
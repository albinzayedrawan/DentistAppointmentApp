namespace DentistAppointmentApp
{
    partial class confirmationPanel
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
            this.bookDetailsPanel = new System.Windows.Forms.Panel();
            this.clinicTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateTimePanel = new System.Windows.Forms.Panel();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.dateTimeLabelingLabel = new System.Windows.Forms.Label();
            this.serviceAndDoctorPanel = new System.Windows.Forms.Panel();
            this.doctorChosen = new System.Windows.Forms.Label();
            this.doctorLabelingLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.serviceLabelingLabel = new System.Windows.Forms.Label();
            this.customerDetailsPanel = new System.Windows.Forms.Panel();
            this.cprLabelingLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lNameLabelingLabel = new System.Windows.Forms.Label();
            this.fNnameLabelingLabel = new System.Windows.Forms.Label();
            this.bookingDetailsLabel = new System.Windows.Forms.Label();
            this.mobilePhone_label = new System.Windows.Forms.Label();
            this.cprLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mobileLabelingLabel = new System.Windows.Forms.Label();
            this.bookDetailsPanel.SuspendLayout();
            this.dateTimePanel.SuspendLayout();
            this.serviceAndDoctorPanel.SuspendLayout();
            this.customerDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookDetailsPanel
            // 
            this.bookDetailsPanel.BackColor = System.Drawing.Color.LightCyan;
            this.bookDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookDetailsPanel.Controls.Add(this.clinicTitleLabel);
            this.bookDetailsPanel.Controls.Add(this.exitButton);
            this.bookDetailsPanel.Controls.Add(this.dateTimePanel);
            this.bookDetailsPanel.Controls.Add(this.serviceAndDoctorPanel);
            this.bookDetailsPanel.Controls.Add(this.customerDetailsPanel);
            this.bookDetailsPanel.Location = new System.Drawing.Point(42, 38);
            this.bookDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookDetailsPanel.Name = "bookDetailsPanel";
            this.bookDetailsPanel.Size = new System.Drawing.Size(1115, 614);
            this.bookDetailsPanel.TabIndex = 1;
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
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(447, 539);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.cancel2Button_Click);
            // 
            // dateTimePanel
            // 
            this.dateTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateTimePanel.Controls.Add(this.dateTimeLabel);
            this.dateTimePanel.Controls.Add(this.dateTimeLabelingLabel);
            this.dateTimePanel.Location = new System.Drawing.Point(738, 115);
            this.dateTimePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePanel.Name = "dateTimePanel";
            this.dateTimePanel.Size = new System.Drawing.Size(354, 414);
            this.dateTimePanel.TabIndex = 2;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimeLabel.Location = new System.Drawing.Point(44, 102);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(266, 231);
            this.dateTimeLabel.TabIndex = 8;
            this.dateTimeLabel.Text = " ";
            // 
            // dateTimeLabelingLabel
            // 
            this.dateTimeLabelingLabel.AutoSize = true;
            this.dateTimeLabelingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabelingLabel.Location = new System.Drawing.Point(116, 58);
            this.dateTimeLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLabelingLabel.Name = "dateTimeLabelingLabel";
            this.dateTimeLabelingLabel.Size = new System.Drawing.Size(126, 20);
            this.dateTimeLabelingLabel.TabIndex = 0;
            this.dateTimeLabelingLabel.Text = "Date and Time";
            // 
            // serviceAndDoctorPanel
            // 
            this.serviceAndDoctorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndDoctorPanel.Controls.Add(this.doctorChosen);
            this.serviceAndDoctorPanel.Controls.Add(this.doctorLabelingLabel);
            this.serviceAndDoctorPanel.Controls.Add(this.servicesLabel);
            this.serviceAndDoctorPanel.Controls.Add(this.serviceLabelingLabel);
            this.serviceAndDoctorPanel.Location = new System.Drawing.Point(363, 115);
            this.serviceAndDoctorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceAndDoctorPanel.Name = "serviceAndDoctorPanel";
            this.serviceAndDoctorPanel.Size = new System.Drawing.Size(366, 414);
            this.serviceAndDoctorPanel.TabIndex = 2;
            // 
            // doctorChosen
            // 
            this.doctorChosen.BackColor = System.Drawing.SystemColors.Window;
            this.doctorChosen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorChosen.Location = new System.Drawing.Point(46, 255);
            this.doctorChosen.Name = "doctorChosen";
            this.doctorChosen.Size = new System.Drawing.Size(266, 78);
            this.doctorChosen.TabIndex = 7;
            this.doctorChosen.Text = " ";
            // 
            // doctorLabelingLabel
            // 
            this.doctorLabelingLabel.AutoSize = true;
            this.doctorLabelingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabelingLabel.Location = new System.Drawing.Point(123, 220);
            this.doctorLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorLabelingLabel.Name = "doctorLabelingLabel";
            this.doctorLabelingLabel.Size = new System.Drawing.Size(104, 20);
            this.doctorLabelingLabel.TabIndex = 6;
            this.doctorLabelingLabel.Text = "With Doctor";
            this.doctorLabelingLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // servicesLabel
            // 
            this.servicesLabel.BackColor = System.Drawing.SystemColors.Window;
            this.servicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesLabel.Location = new System.Drawing.Point(46, 103);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(266, 77);
            this.servicesLabel.TabIndex = 5;
            this.servicesLabel.Text = " ";
            this.servicesLabel.Click += new System.EventHandler(this.bookedServicesLabel_Click);
            // 
            // serviceLabelingLabel
            // 
            this.serviceLabelingLabel.AutoSize = true;
            this.serviceLabelingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabelingLabel.Location = new System.Drawing.Point(103, 58);
            this.serviceLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceLabelingLabel.Name = "serviceLabelingLabel";
            this.serviceLabelingLabel.Size = new System.Drawing.Size(140, 20);
            this.serviceLabelingLabel.TabIndex = 0;
            this.serviceLabelingLabel.Text = "Booked services";
            // 
            // customerDetailsPanel
            // 
            this.customerDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerDetailsPanel.Controls.Add(this.mobileLabelingLabel);
            this.customerDetailsPanel.Controls.Add(this.cprLabelingLabel);
            this.customerDetailsPanel.Controls.Add(this.label8);
            this.customerDetailsPanel.Controls.Add(this.lNameLabelingLabel);
            this.customerDetailsPanel.Controls.Add(this.fNnameLabelingLabel);
            this.customerDetailsPanel.Controls.Add(this.bookingDetailsLabel);
            this.customerDetailsPanel.Controls.Add(this.mobilePhone_label);
            this.customerDetailsPanel.Controls.Add(this.cprLabel);
            this.customerDetailsPanel.Controls.Add(this.lNameLabel);
            this.customerDetailsPanel.Controls.Add(this.fNameLabel);
            this.customerDetailsPanel.Controls.Add(this.label4);
            this.customerDetailsPanel.Location = new System.Drawing.Point(24, 115);
            this.customerDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerDetailsPanel.Name = "customerDetailsPanel";
            this.customerDetailsPanel.Size = new System.Drawing.Size(330, 414);
            this.customerDetailsPanel.TabIndex = 1;
            // 
            // cprLabelingLabel
            // 
            this.cprLabelingLabel.AutoSize = true;
            this.cprLabelingLabel.Location = new System.Drawing.Point(34, 220);
            this.cprLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cprLabelingLabel.Name = "cprLabelingLabel";
            this.cprLabelingLabel.Size = new System.Drawing.Size(42, 20);
            this.cprLabelingLabel.TabIndex = 8;
            this.cprLabelingLabel.Text = "CPR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 7;
            // 
            // lNameLabelingLabel
            // 
            this.lNameLabelingLabel.AutoSize = true;
            this.lNameLabelingLabel.Location = new System.Drawing.Point(34, 160);
            this.lNameLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameLabelingLabel.Name = "lNameLabelingLabel";
            this.lNameLabelingLabel.Size = new System.Drawing.Size(86, 20);
            this.lNameLabelingLabel.TabIndex = 6;
            this.lNameLabelingLabel.Text = "Last Name";
            // 
            // fNnameLabelingLabel
            // 
            this.fNnameLabelingLabel.AutoSize = true;
            this.fNnameLabelingLabel.Location = new System.Drawing.Point(34, 103);
            this.fNnameLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNnameLabelingLabel.Name = "fNnameLabelingLabel";
            this.fNnameLabelingLabel.Size = new System.Drawing.Size(86, 20);
            this.fNnameLabelingLabel.TabIndex = 5;
            this.fNnameLabelingLabel.Text = "First Name";
            // 
            // bookingDetailsLabel
            // 
            this.bookingDetailsLabel.AutoSize = true;
            this.bookingDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDetailsLabel.Location = new System.Drawing.Point(96, 58);
            this.bookingDetailsLabel.Name = "bookingDetailsLabel";
            this.bookingDetailsLabel.Size = new System.Drawing.Size(135, 20);
            this.bookingDetailsLabel.TabIndex = 1;
            this.bookingDetailsLabel.Text = "Booking Details";
            // 
            // mobilePhone_label
            // 
            this.mobilePhone_label.BackColor = System.Drawing.SystemColors.Window;
            this.mobilePhone_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobilePhone_label.Location = new System.Drawing.Point(32, 240);
            this.mobilePhone_label.Name = "mobilePhone_label";
            this.mobilePhone_label.Size = new System.Drawing.Size(260, 30);
            this.mobilePhone_label.TabIndex = 4;
            this.mobilePhone_label.Text = " ";
            // 
            // cprLabel
            // 
            this.cprLabel.BackColor = System.Drawing.SystemColors.Window;
            this.cprLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cprLabel.Location = new System.Drawing.Point(32, 303);
            this.cprLabel.Name = "cprLabel";
            this.cprLabel.Size = new System.Drawing.Size(260, 30);
            this.cprLabel.TabIndex = 3;
            this.cprLabel.Text = " ";
            // 
            // lNameLabel
            // 
            this.lNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.lNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameLabel.Location = new System.Drawing.Point(32, 180);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(260, 30);
            this.lNameLabel.TabIndex = 2;
            this.lNameLabel.Text = " ";
            // 
            // fNameLabel
            // 
            this.fNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.fNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameLabel.Location = new System.Drawing.Point(32, 123);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(260, 30);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            // 
            // mobileLabelingLabel
            // 
            this.mobileLabelingLabel.AutoSize = true;
            this.mobileLabelingLabel.Location = new System.Drawing.Point(34, 283);
            this.mobileLabelingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mobileLabelingLabel.Name = "mobileLabelingLabel";
            this.mobileLabelingLabel.Size = new System.Drawing.Size(115, 20);
            this.mobileLabelingLabel.TabIndex = 9;
            this.mobileLabelingLabel.Text = "Mobile Number";
            // 
            // confirmationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bookDetailsPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "confirmationPanel";
            this.Text = "Dentist Appointment Application (Booking)";
            this.bookDetailsPanel.ResumeLayout(false);
            this.bookDetailsPanel.PerformLayout();
            this.dateTimePanel.ResumeLayout(false);
            this.dateTimePanel.PerformLayout();
            this.serviceAndDoctorPanel.ResumeLayout(false);
            this.serviceAndDoctorPanel.PerformLayout();
            this.customerDetailsPanel.ResumeLayout(false);
            this.customerDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookDetailsPanel;
        private System.Windows.Forms.Label clinicTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel dateTimePanel;
        private System.Windows.Forms.Label dateTimeLabelingLabel;
        private System.Windows.Forms.Panel serviceAndDoctorPanel;
        private System.Windows.Forms.Label serviceLabelingLabel;
        private System.Windows.Forms.Panel customerDetailsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label cprLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label mobilePhone_label;
        private System.Windows.Forms.Label bookingDetailsLabel;
        private System.Windows.Forms.Label doctorLabelingLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.Label doctorChosen;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label cprLabelingLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lNameLabelingLabel;
        private System.Windows.Forms.Label fNnameLabelingLabel;
        private System.Windows.Forms.Label mobileLabelingLabel;
    }
}
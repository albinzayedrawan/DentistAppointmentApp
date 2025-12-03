using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DentistAppointmentApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
           
            if ((fNameTextBox.Text != null) && (lNameTextBox.Text != null) && (cprTextBox.Text != null) && (mobileTextBox.Text != null) && (serviceListBox.SelectedIndex > -1) && (doctorListBox.SelectedIndex > -1) && (appointmentDatePicker.Value != DateTime.MinValue) && (timeListBox.SelectedIndex > -1)
                ) {
                String ClientFile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\client.txt";
                StreamWriter streamWriter = new StreamWriter(ClientFile,true);
                streamWriter.WriteLine(fNameTextBox.Text + "," + lNameTextBox.Text + "," + cprTextBox.Text + "," + mobileTextBox.Text + "," + serviceListBox.SelectedItem.ToString() + "," + doctorListBox.SelectedItem.ToString() + "," + appointmentDatePicker.Value.ToString("MM/dd/yyyy") + "," + timeListBox.SelectedItem.ToString() + "," + "Booked");
                streamWriter.Close();

                String accountfile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\accounts.txt";
                StreamWriter streamWriter1 = new StreamWriter(accountfile, true);
                streamWriter1.WriteLine(lNameTextBox.Text + "," + cprTextBox.Text);
                streamWriter1.Close();
                confirmationPanel form3 = new confirmationPanel(lNameTextBox.Text, cprTextBox.Text) ;
                form3.Show();
                this.Hide();
                MessageBox.Show("Booking Confirmed, Kindly note that your username is your lastname and your password is your cpr number", "Thank you");
            }
            else
            {
                MessageBox.Show("missing information","Error");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String doctorfile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\doctors.txt";
            StreamReader streamReader1 = new StreamReader(doctorfile);
            string line;
            while ((line = streamReader1.ReadLine()) != null)
            {
                doctorListBox.Items.Add(line);
            }
            streamReader1.Close();

            String servicesFile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\services.txt";
            StreamReader streamReader2 = new StreamReader(servicesFile);
  
            while ((line = streamReader2.ReadLine()) != null)
            {
                serviceListBox.Items.Add(line);
            }
            streamReader2.Close();
        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

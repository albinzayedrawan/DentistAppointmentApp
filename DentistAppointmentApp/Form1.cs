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
    public partial class applicationMainForm : Form
    {
        String password, username;
        public applicationMainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            this.Hide();
            fm2.Show();
      
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Boolean loginstatus = false;
            if (lastNameTextBox.Text != null && passwordTextBox != null)
            {
                String accountfile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\accounts.txt";
                StreamReader streamReader = new StreamReader(accountfile);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] value = line.Split(',');
                    username = value[0];
                    password = value[1];
                   
                    if (lastNameTextBox.Text == username && passwordTextBox.Text == password) {

                        loginstatus = true;
                       
                    }
                }
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("Kindly fill out the login details", "error");
            }


            if (loginstatus == true) {
                confirmationPanel fm3 = new confirmationPanel(username,password);
                this.Hide();
                fm3.Show();
            } else
            {
                MessageBox.Show("incorrect login details","Login Failed");
            }
        }

        private void lastName_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}

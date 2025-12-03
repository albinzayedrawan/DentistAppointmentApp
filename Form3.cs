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
    public partial class confirmationPanel : Form
    {
 
        public confirmationPanel(String username, String password)
        {
            InitializeComponent();
            String accountfile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\client.txt";
                StreamReader streamReader = new StreamReader(accountfile);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {

                    String[] value = line.Split(',');
             
                    String un = value[1];
                    String pw = value[2];
                MessageBox.Show("login successful ");
                    if (username == un && password == pw)
                    {
                        fNameLabel.Text = value[0];
                        lNameLabel.Text = value[1];
                        cprLabel.Text = value[2];
                        mobilePhone_label.Text = value[3];
                        servicesLabel.Text = value[4];
                        doctorChosen.Text = value[5];
                        dateTimeLabel.Text = value[6] + ", " + value[5];
                        


                    }
                

                    
                }
                streamReader.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bookedServicesLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancel2Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rescheduleButton_Click(object sender, EventArgs e)
        {
            
            String clientFile = "C:\\Users\\Rawan\\OneDrive\\Desktop\\client.txt";
            StreamWriter streamwriter = new StreamWriter(clientFile);
            streamwriter.WriteLine();
            streamwriter.Close();
            //tbi

        }
    }
}

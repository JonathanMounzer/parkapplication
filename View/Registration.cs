using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkApplication
{
    public partial class Registration : Form

    {
        Controller call = new Controller();
        public Registration()

        {
            InitializeComponent();
        }

        private void Ångrabtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            //Registration reg = new Registration();
            //reg.Hide();
        }

   

        private void regbtn1_Click(object sender, EventArgs e)
        {
            string regpnr = pnrtextbox1.Text;
            string regfirstname = firstnametextbox1.Text;
            string reglastname = lastnametextbox1.Text;
            string regpassword = passwordtextbox1.Text;

            if (string.IsNullOrEmpty(regpnr) && string.IsNullOrEmpty(regfirstname) || string.IsNullOrEmpty(reglastname) || string.IsNullOrEmpty(regpassword))
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = " Kontrollera att personnummer stämmer och att rutorna är ifyllda!";
                var t1 = new Timer();
                t1.Interval = 7000;
                t1.Tick += (s, e1) =>
                {
                    ErrorLabel.Hide();
                    t1.Stop();
                };
                t1.Start();

                ErrorLabel.Show();
            }
            
            else
            {
                if (call.AddCustomer(Convert.ToString(regpnr), regfirstname, reglastname, regpassword))
                {
                    ErrorLabel.ForeColor = System.Drawing.Color.Green;
                    this.ErrorLabel.Text = "Konto skapat!";
                    //Registration reg = new Registration();
                    //this.Hide();
                }
                else
                {
                    ErrorLabel.ForeColor = System.Drawing.Color.Red;
                    ErrorLabel.Text = "Personnummret finns redan, se till att det är rätt ifyllt! ";
                }
            }

            var t = new Timer();
            t.Interval = 7000;
            t.Tick += (s, e1) =>
            {
                ErrorLabel.Hide();
                t.Stop();
            };
            t.Start();

            ErrorLabel.Show();

            pnrtextbox1.Clear();
            firstnametextbox1.Clear();
            lastnametextbox1.Clear();
            passwordtextbox1.Clear();
        }

        private void pnrtextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnrtextbox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void regbtn1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pnrtextbox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    ErrorLabel.Text = "Endast siffror";
                    ErrorLabel.ForeColor = System.Drawing.Color.Red;

                    e.Handled = true;
                    var tim = new Timer();
                    tim.Interval = 7000;
                    tim.Tick += (s, e1) =>
                    {
                        ErrorLabel.Hide();
                        tim.Stop();

                    };
                    tim.Start();
                    ErrorLabel.Show();
                }
            }
        }
    }
}

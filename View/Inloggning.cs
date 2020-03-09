using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkApplication
{
    public partial class Inloggning : Form
    {
        Controller call = new Controller();
        public Inloggning()
        {
            InitializeComponent();
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {

            if(call.LoggaIn(pnrtextbox1.Text, passwordtextbox1.Text))
            {
                this.Hide();
                Constants.UserId = pnrtextbox1.Text;
                Start start = new Start();
                start.Show();
            }
            else
            {
                MessageBox.Show("Kontrollera att båda fälten stämmer!");
            }
        }


        private void regbtn1_Click(object sender, EventArgs e)
        {
            Inloggning inloggning = new Inloggning();
            inloggning.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
    }
}


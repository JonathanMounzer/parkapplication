using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkApplication
{
    public partial class Start : Form
    {
        Controller call = new Controller();
        public Start()
        {
            InitializeComponent();
            getObjects();

        }

        private void getObjects()
        {
            List<Zone> z = call.GetZones();
            foreach (Zone zone in z)
            {
                zonecombobox.Items.Add(zone.zonename);
            }
            List<Car> c = call.GetCars();
            foreach (Car car in c)
            {
                carcombobox.Items.Add(car.regnr);
                
            }
        }
        private void addcarlabel1_Click(object sender, EventArgs e)
        {

        }

        private void carcombobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void choosecarlabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updatefirstnamelabel1_Click(object sender, EventArgs e)
        {

        }

        private void addcarbutton1_Click(object sender, EventArgs e)
        {
            string addcar = addcartextbox1.Text;

            if (addcar.Length != 7)
            {
                CarErrorLabel.ForeColor = System.Drawing.Color.Red;
                CarErrorLabel.Text = "Vänligen mata in sju karaktärer.";
                var t1 = new Timer();
                t1.Interval = 7000;
                t1.Tick += (s, e1) =>
                {
                    CarErrorLabel.Hide();
                    t1.Stop();
                };
                t1.Start();

                CarErrorLabel.Show();
            }
            else
                {
                if (call.AddCar(addcartextbox1.Text, Constants.UserId))
                {
                    string addC = addcartextbox1.Text;
                    carcombobox.Items.Add(addC);

                    CarErrorLabel.ForeColor = System.Drawing.Color.Green;
                    this.CarErrorLabel.Text = "Du har lagt till en bil!";
                    var t1 = new Timer();
                    t1.Interval = 7000;
                    t1.Tick += (s, e1) =>
                    {
                        CarErrorLabel.Hide();
                        t1.Stop();
                    };
                    t1.Start();

                    CarErrorLabel.Show();
                    addcartextbox1.Clear();

                   

                    


                }
                else
                {
                    CarErrorLabel.ForeColor = System.Drawing.Color.Red;
                    CarErrorLabel.Text = "Bilen finns redan registrerad!";
                    var t1 = new Timer();
                    t1.Interval = 7000;
                    t1.Tick += (s, e1) =>
                    {
                        CarErrorLabel.Hide();
                        t1.Stop();
                    };
                    t1.Start();

                    CarErrorLabel.Show();
                }
                }
               
            }

        private void zonecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inloggning inloggning = new Inloggning();
            inloggning.ShowDialog();
        }

        private void addcartextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                string carreg = carcombobox.Text;
                string addhours = HoursUpDown.Text;
                string choosezone = zonecombobox.Text;
                double price = Convert.ToDouble(PriceTextBox.Text);
                DateTime date = DateTime.Now;
                string ticketnr = Convert.ToString(call.ReturnLastTicket());


                if (!string.IsNullOrEmpty(carreg) && !string.IsNullOrEmpty(addhours) && !string.IsNullOrEmpty(choosezone) && !string.IsNullOrEmpty(PriceTextBox.Text))
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(date));
                    item.SubItems.Add(Convert.ToString(carreg));
                    item.SubItems.Add(Convert.ToString(choosezone));
                    item.SubItems.Add(Convert.ToString(price));
                    item.SubItems.Add(Convert.ToString(addhours));
                    item.SubItems.Add(ticketnr);

                    TicketListView.Items.Add(item);
                    

                    ErrorLabelMain.ForeColor = System.Drawing.Color.Green;
                    ErrorLabelMain.Text = "Uppdaterat!";

                    call.SaveTicket(Constants.UserId, choosezone, price, date);          
                }
                else
                {
                    ErrorLabelMain.ForeColor = System.Drawing.Color.Red;
                    ErrorLabelMain.Text = "Dubbelkolla alla fält!";
                }
            }
            catch (Exception ex)
            {
                ErrorLabelMain.Text = ex.StackTrace;
                ErrorLabelMain.Text = "Vänligen dubbelkolla fälten!";
                ErrorLabelMain.ForeColor = System.Drawing.Color.Red;
            }

            var tim = new Timer();
            tim.Interval = 5000;
            tim.Tick += (s, e1) =>
            {
                ErrorLabelMain.Hide();
                tim.Stop();
            };
            tim.Start();

            ErrorLabelMain.Show();
        }

    

        private void myaccountbtn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            call.RemoveCar(carcombobox.Text);

            string RemoveC = carcombobox.Text;
            carcombobox.Items.Remove(RemoveC);
            
            MessageBox.Show("Borttaget!");

        }

        private void DeleteButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CheckPriceButton_Click(object sender, EventArgs e)
        {
            string addhours = HoursUpDown.Text;
            string choosezone = zonecombobox.Text;
            try
            {
                double pris = 10.25;
                double total = pris * (double)HoursUpDown.Value;
                PriceTextBox.Text = Convert.ToString(total);

                if (string.IsNullOrEmpty(addhours) || string.IsNullOrEmpty(choosezone))
                {
                    ErrorLabelMain.ForeColor = System.Drawing.Color.Red;
                    ErrorLabelMain.Text = "Var vänlig och välj zon och antal timmar.";
                }
            }

            catch (Exception exc)
            {
                throw exc;
            }
           

        }

        private void TicketListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start_Shown(object sender, EventArgs e)
        {

        }

        private void HoursUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TicketListView.Items.Clear();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zonelabel1_Click(object sender, EventArgs e)
        {

        }
    }
        }
    


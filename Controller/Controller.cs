using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkApplication
{
    class Controller
    {
        DAL dal = new DAL();

        public bool AddCustomer(string pnr, string firstname, string lastname, string password)
        {
            return dal.AddCustomer(pnr, firstname, lastname, password);
        }

        public bool AddCar(string regnr, string pnr)
        {
            return dal.AddCar(regnr, pnr);
        }
        public void SaveTicket(string pnr,string zonename, double price, DateTime date)
        {
             dal.SaveTicket(pnr,zonename, price, date);
        }
        public int ReturnLastTicket()
        {
           return dal.ReturnLastTicket();
        }

        public int RemoveCar(string regnr)
        {
            return dal.RemoveCar(regnr);
        }
        public bool LoggaIn(string pnr, string password)
        {
            return dal.LoggaIn(pnr, password);
        }
      
        public List<Zone> GetZones()
        {
            return dal.GetZones();
        }
        public List<Car> GetCars()
        {
            return dal.GetCars();
        }

        //public int UpdateCustomer(string pnr, string firstname, string lastname)
        //{
        //    return dal.UpdateCustomer(pnr, firstname, lastname);
        //}

        //public void BuyTicket(string pnr, int ticketnr, int zonenr, double price, DateTime date)
        //{
        //    dal.BuyTicket(pnr, ticketnr, zonenr, price, date);
        //}

        //public List<Ticket> GetTInfo()
        //{
        //    return dal.GetTInfo();
        //}

    }
}
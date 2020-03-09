using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ParkApplication
{
    class DAL
    {
        private String StringCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Buklau4twenty\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection Con;
        public DAL()
        {
            try
            {
                Con = new SqlConnection(StringCon);
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }


        }
        public String DalConnected()
        {
            try
            {
                this.Con.Open();
                return "true"; //måste returnera value för DalConnected
            }
            catch (SqlException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.Con.Close();
            }
        }

        public int AffectedRows(SqlCommand c)
        {
            int AffectedRows = c.ExecuteNonQuery();
            return AffectedRows;
        }

        public bool AddCustomer(string pnr, string firstname, string lastname, string password) //registrera konto
        {
            bool added = false; //false by default
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("insert into customer values(@pnr, @firstname, @lastname, @password)", this.Con);
                sql.Prepare();
                SqlParameter Pnr = new SqlParameter("@pnr", pnr);
                SqlParameter Firstname = new SqlParameter("@firstname", firstname);
                SqlParameter Lastname = new SqlParameter("@lastname", lastname);
                SqlParameter Password = new SqlParameter("@password", password);

                //gör add-metoder
                sql.Parameters.Add(Pnr);
                sql.Parameters.Add(Firstname);
                sql.Parameters.Add(Lastname);
                sql.Parameters.Add(Password);


                int rowsAffected = sql.ExecuteNonQuery();
                Console.WriteLine("RowsAffected: {0}", rowsAffected);

                if (rowsAffected == 1)
                {
                    added = true;
                }
                else
                    added = false;


            }
            catch (SqlException e)
            {
                added = false;
                // throw e;
            }
            catch (Exception e)
            {
                added = false;
                throw e;
            }
            finally
            {
                this.Con.Close();
            }
            return added;
        }

        public int RemoveCar(string regnr)
        {
            int count;
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("delete from car where regnr = '" + regnr + "'", this.Con);
                sql.Prepare();
                SqlParameter Regnr = new SqlParameter("@regnr", regnr);
                sql.Parameters.Add(Regnr);

                count = AffectedRows(sql);
                this.Con.Close();
                return count;
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }
        }

        //public int UpdateCustomer(string pnr, string firstname, string lastname)
        //{
        //    int count;
        //    try
        //    {
        //        this.Con.Open();
        //        SqlCommand sql = new SqlCommand("update customer set firstname = @firstname, lastname=@lastname where pnr = @pnr ", this.Con);
        //        sql.Prepare();
        //        SqlParameter Pnr = new SqlParameter("@pnr", pnr);
        //        SqlParameter Firstname = new SqlParameter("@firstname", firstname);
        //        SqlParameter Lastname = new SqlParameter("@lastname", lastname);
        //        sql.Parameters.Add(Pnr);
        //        sql.Parameters.Add(Firstname);
        //        sql.Parameters.Add(Lastname);

        //        count = AffectedRows(sql);
        //        return count;
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        this.Con.Close();
        //    }
        //    //  return 0;
        //}




        public List<Zone> GetZones()
        {
            List<Zone> zones = new List<Zone>();
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("select * from zone", this.Con);
                SqlDataReader queryRead = sql.ExecuteReader();
                while (queryRead.Read())
                {
                    Zone z = new Zone();
                    z.zonename = queryRead["zonename"].ToString();
                    zones.Add(z);
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Con.Close();
            }
            return zones;
        }

        //public void BuyTicket(string pnr, int ticketnr, int zonenr, double price, DateTime date) //add to ticket 
        //{
        //    try
        //    {
        //        this.Con.Open();
        //        SqlCommand sql = new SqlCommand("insert into ticket (pnr, ticketnr, zonenr, price, date) values(@pnr, @ticketnr, @zonenr, @price, @date)", this.Con);
        //        sql.Prepare();
        //        SqlParameter Pnr = new SqlParameter("@pnr", pnr);
        //        SqlParameter Ticketnr = new SqlParameter("@ticketnr", ticketnr);
        //        SqlParameter Zonenr = new SqlParameter("@zonenr", zonenr);
        //        SqlParameter Price = new SqlParameter("@price", price);
        //        SqlParameter Date = new SqlParameter("@date", date);

        //        sql.Parameters.Add(Pnr);
        //        sql.Parameters.Add(Ticketnr);
        //        sql.Parameters.Add(Zonenr);
        //        sql.Parameters.Add(Price);
        //        sql.Parameters.Add(Date);
        //        sql.ExecuteNonQuery();


        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        this.Con.Close();
        //    }

        //}

        public void GetPrice(double price)
        {
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("insert inte ticket price= '" + price + "'", Con);
                sql.Prepare();

                SqlParameter Price = new SqlParameter("@price", price);
                sql.Parameters.Add(Price);
                sql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Con.Close();
            }

        }

        public bool AddCar(string regnr, string pnr)
        {
            bool added = false; //false by default
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("insert into car values(@regnr, @pnr)", this.Con);
                sql.Prepare();
                SqlParameter Regnr = new SqlParameter("@regnr", regnr);
                SqlParameter Pnr = new SqlParameter("@pnr", pnr);

                //gör add-metoder
                sql.Parameters.Add(Regnr);
                sql.Parameters.Add(Pnr);


                int rowsAffected = sql.ExecuteNonQuery();
                Console.WriteLine("RowsAffected: {0}", rowsAffected);

                if (rowsAffected >= 1)
                {
                    added = true;
                }
                else
                    added = false;


            }
            catch (SqlException e)
            {
                added = false;
                //throw e;
            }
            catch (Exception e)
            {
                added = false;
                throw e;
            }
            finally
            {
                this.Con.Close();
            }
            return added;
        }
        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("select * from car", this.Con);
                SqlDataReader queryRead = sql.ExecuteReader();
                while (queryRead.Read())
                {
                    Car c = new Car();
                    c.regnr = queryRead["regnr"].ToString();
                    c.pnr = queryRead["pnr"].ToString();
                    cars.Add(c);
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Con.Close();
            }
            return cars;
        }

        public int ReturnLastTicket()
        {
            int ticket = 0;
            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("select top 1 ticketnumber from ticket order by ticketnumber desc", this.Con);
                int result = ((int)sql.ExecuteScalar());

                return result;

            }
            catch (SqlException e)
            {
                throw e;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Con.Close();
            }
            return ticket;

        }




        public bool LoggaIn(string pnr, string password)

        {
            bool success = false;
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from customer where pnr='" + pnr + "' and password ='" + password + "'", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }


            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                success = false;
                throw e;
            }
            finally
            {
                Con.Close();
            }
            return success;
        }
        public void SaveTicket(string pnr, string zonename, double price, DateTime date)
        {

            try
            {
                this.Con.Open();
                SqlCommand sql = new SqlCommand("insert into ticket(pnr, zonename, price, date) values(@pnr, @zonename, @price, @date)", this.Con);
                sql.Prepare();

                //SqlParameter Ticketnumber = new SqlParameter("@ticketnumber", ticketnumber);
                SqlParameter Pnr = new SqlParameter("@pnr", pnr);
                SqlParameter Zonename = new SqlParameter("@zonename", zonename);
                SqlParameter Price = new SqlParameter("@price", price);
                SqlParameter Date = new SqlParameter("@date", date);

               // sql.Parameters.Add(Ticketnumber);
                sql.Parameters.Add(Pnr);
                sql.Parameters.Add(Zonename);
                sql.Parameters.Add(Price);
                sql.Parameters.Add(Date);
                sql.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.Con.Close();
            }


        

        }

    }

}
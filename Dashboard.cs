using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onana_Hospital_Management_System
{
    class Dashboard:clsInsert
    {
        public struct RevenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;

        private int numberDays;
        private bool isPaid = true;
        clsSelect varSelect = new clsSelect();
        public decimal TotalServiceRevenue { get; set; }
        public int NumCustomers { get; private set; }
        //public int NumSuppliers { get; private set; }
        public int NumServices { get; private set; }
        public List<KeyValuePair<string, int>> TopServiceList { get; private set; }
        //public List<KeyValuePair<string, int>> UnderPerformingList { get; private set; }
        public List<UnderPerformingItem> UnderPerformingList { get; private set; }

        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<RevenueByDate> GrossServiceRevenueList { get; private set; }

        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        public int TotalMale { get; set; }
        public int TotalFemale { get; set; }
        //Constructor
        public Dashboard()
        {

        }

        //Private methods
        private void GetNumberItems()
        {           

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = con;
                    //Get Total Number of Patients
                    command.CommandText = "select count(id) from tblPatient";
                    NumCustomers = (int)command.ExecuteScalar();

                    ////Get Total Number of Suppliers
                    //command.CommandText = "select count(id) from Supplier";
                    //NumSuppliers = (int)command.ExecuteScalar();

                    //Get Total Number of Services
                    command.CommandText = "select count(serviceid) from tblServices";
                    NumServices = (int)command.ExecuteScalar();

                    //Get Total Number of Orders
                    command.CommandText = @"select count(orderid) from tblOrder where OrderDate between  @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();
                }
            }
        }
        //Private methods
        private void GetGender()
        {

            using (SqlConnection con = new SqlConnection(ConString))
            {
                string male = "Male";
                string female = "Female";
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = con;
                    //Get Total Number of Patients
                    command.CommandText = "select count(id) from tblPatient where pGender = @male";
                    command.Parameters.Add("@male", male);
                    TotalMale = (int)command.ExecuteScalar();

                    ////Get Total Number of Suppliers
                    //command.CommandText = "select count(id) from Supplier";
                    //NumSuppliers = (int)command.ExecuteScalar();

                    //Get Total Number of Services
                    command.CommandText = "select count(id) from tblPatient where pGender = @female";
                    command.Parameters.Add("@female", female);
                    TotalFemale = (int)command.ExecuteScalar();

                    ////Get Total Number of Orders
                    //command.CommandText = @"select count(orderid) from tblOrder where OrderDate between  @fromDate and @toDate";
                    //command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    //command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    //NumOrders = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopServiceList = new List<KeyValuePair<string, int>>();
            //UnderPerformingList = new List<KeyValuePair<string, int>>();
            UnderPerformingList = new List<UnderPerformingItem>(); // Initialize before using

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = con;
                    //Get Top 5 products
                    command.CommandText = @"select top 5 item,sum(quantity) as Q from tblOrder where ispaid = @paid and OrderDate between @fromDate and @toDate group by item order by Q desc";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@paid", true);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopServiceList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"select top 5 item,sum(quantity) as Q, sum(totalprice) as T from tblOrder where ispaid = @paid1 and OrderDate between @fromDate and @toDate group by item order by T asc";
                    command.Parameters.Add("@paid1", true);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //UnderPerformingList.Add(
                        //    new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                        UnderPerformingList.Add(new UnderPerformingItem
                        {
                            ItemName = reader[0].ToString(),       // First column (string)
                            Quantity = Convert.ToInt32(reader[1]), // Second column (int)
                            PerformanceScore = Convert.ToDecimal(reader[2]) // Third column (decimal)
                        });

                    }
                    reader.Close();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = @"select OrderDate, sum(totalprice) from tblOrder where ispaid = @paid2 and OrderDate between @fromDate and @toDate group by OrderDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@paid2", true);
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m;//20%
                    reader.Close();

                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }


        public void GetOrderAnalisysbyService(string selectedServiceName, DateTime startDate, DateTime endDate)
        {
            if(selectedServiceName !="")
            {
                GrossServiceRevenueList = new List<RevenueByDate>();
                //TotalProfit = 0;
                TotalServiceRevenue = 0;

                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = con;
                        command.CommandText = @"select OrderDate, sum(totalprice) from tblOrder where ispaid = @paid2 and item = @item and OrderDate between @fromDate and @toDate group by OrderDate";
                        command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                        command.Parameters.Add("@paid2", true);
                        command.Parameters.Add("@item", selectedServiceName);
                        var reader = command.ExecuteReader();
                        var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                        while (reader.Read())
                        {
                            resultTable.Add(
                                new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                                );
                            TotalServiceRevenue += (decimal)reader[1];
                        }
                        //TotalProfit = TotalRevenue * 0.2m;//20%
                        reader.Close();

                        //Group by Hours
                        if (numberDays <= 1)
                        {
                            GrossServiceRevenueList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("hh tt")
                                               into order
                                                select new RevenueByDate
                                                {
                                                    Date = order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                        }
                        //Group by Days
                        else if (numberDays <= 30)
                        {
                            GrossServiceRevenueList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("dd MMM")
                                               into order
                                                select new RevenueByDate
                                                {
                                                    Date = order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                        }

                        //Group by Weeks
                        else if (numberDays <= 92)
                        {
                            GrossServiceRevenueList = (from orderList in resultTable
                                                group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                    orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                               into order
                                                select new RevenueByDate
                                                {
                                                    Date = "Week " + order.Key.ToString(),
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                        }

                        //Group by Months
                        else if (numberDays <= (365 * 2))
                        {
                            bool isYear = numberDays <= 365 ? true : false;
                            GrossServiceRevenueList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("MMM yyyy")
                                               into order
                                                select new RevenueByDate
                                                {
                                                    Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                        }

                        //Group by Years
                        else
                        {
                            GrossServiceRevenueList = (from orderList in resultTable
                                                group orderList by orderList.Key.ToString("yyyy")
                                               into order
                                                select new RevenueByDate
                                                {
                                                    Date = order.Key,
                                                    TotalAmount = order.Sum(amount => amount.Value)
                                                }).ToList();
                        }
                    }
                }
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                //this.serviceName = serviceName;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();                
                GetGender();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }



    }
    public class UnderPerformingItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PerformanceScore { get; set; } // Third value
    }
}

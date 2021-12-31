using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Gymone.Entities;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class ReportsMaster : IlReports
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public ReportsMaster(IConfiguration config)
        {
            _config = config;
        }
        public DataSet Generate_AllMemberDetailsReport()
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_GetAllRenwalrecords", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        return ds;
                    }

                    else
                    {
                        return ds = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    ds.Dispose();
                }

            }
        }

        public DataSet Get_MonthwisePayment_details(string MonthID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_GetMonthwisepaymentdetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@month", MonthID);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        return ds;
                    }

                    else
                    {
                        return ds = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    ds.Dispose();
                }

            }
        }

        public DataSet Get_YearwisePayment_details(string YearID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_GetYearwisepaymentdetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@year", YearID);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        return ds;
                    }

                    else
                    {
                        return ds = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    ds.Dispose();
                }

            }
        }

        public DataSet Get_RenewalReport(RenewalSearch objRS)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_GetAllRenwalrecordsFromBetweenDate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@exactdate", objRS.Exactdate);
                    cmd.Parameters.AddWithValue("@Paymentfromdt", objRS.Fromdate);
                    cmd.Parameters.AddWithValue("@Paymenttodt", objRS.Todate);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        return ds;
                    }

                    else
                    {
                        return ds = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    ds.Dispose();
                }

            }
        }
    }
}
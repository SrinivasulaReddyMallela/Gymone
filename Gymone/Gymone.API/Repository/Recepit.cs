using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class Receipt : IReceipt 
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public Receipt(IConfiguration config)
        {
            _config = config;
        }
        public DataSet GenerateRecepitDataset(string MemberID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_GenerateRecepit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Memberid", MemberID);
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

        public DataSet GenerateDeclarationDataset(string MemberID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                con.Open();
                DataSet ds = new DataSet();

                try
                {
                    SqlCommand cmd = new SqlCommand("Usp_getDec", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Memberid", MemberID);
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
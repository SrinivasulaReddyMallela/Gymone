using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using Gymone.Entities;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class SchemeMaster : ISchemeMaster
    {

        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public SchemeMaster(IConfiguration config)
        {
            _config = config;
        }
        public void InsertScheme(SchemeMasterDTO Scheme)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@SchemeID", Scheme.SchemeID); // Normal Parameters  
                para.Add("@SchemeName", Scheme.SchemeName);
                para.Add("@Createdby", Scheme.Createdby);

                var value = con.Query<int>("sprocSchemeMasterInsertUpdateSingleItem", para, null, true, 0, CommandType.StoredProcedure);
            }
        }

        public IEnumerable<SchemeMasterDTO> GetSchemes()
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var Listscheme = con.Query<SchemeMasterDTO>("select * from SchemeMaster", null, null, true, 0, CommandType.Text).ToList();

                return Listscheme;
            }
        }

        public SchemeMasterDTO GetSchemeByID(string SchemeID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                string Query = "select * from SchemeMaster where SchemeID =" + SchemeID;

                var Scheme_list = con.Query<SchemeMasterDTO>(Query, null, null, true, 0, CommandType.Text).Single();

                return Scheme_list;
            }

        }

        public void UpdateScheme(SchemeMasterDTO Scheme)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@SchemeID", Scheme.SchemeID); // Normal Parameters  
                para.Add("@SchemeName", Scheme.SchemeName);
                var value = con.Query<int>("sprocSchemeMasterInsertUpdateSingleItem", para, null, true, 0, CommandType.StoredProcedure);
            }
        }

        public void DeleteScheme(string SchemeId)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@SchemeID", SchemeId); // Normal Parameters  
                var value = con.Query("sprocSchemeMasterDeleteSingleItem", para, null, true, 0, CommandType.StoredProcedure);
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool SchemeNameExists(string SchemeName)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@SchemeName", SchemeName); // Normal Parameters  
                var value = con.Query<string>("Usp_checkscheme", para, null, true, 0, CommandType.StoredProcedure).First();

                if (value == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
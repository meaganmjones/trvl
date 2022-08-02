using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;
using Trvl.Models;

namespace Trvl.Models
{
    public class DataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public DataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DeafaultConnection");
        }

        //public TrvlModel GetSearch(string? search)
        //{
        //    TrvlModel prod = new TrvlModel();

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            string strSql = "SELECT * FROM trvl_Product WHERE ProdName = '%" + search + "%'";
        //            SqlCommand cmd = new SqlCommand(strSql, con);
        //            cmd.CommandType = CommandType.Text;

        //            cmd.Parameters.AddWithValue("@ProdName");
        //        }
        //    }catch(Exception err)
        //    {
        //        search.Feedback = "ERROR: " + err.Message;
        //    }
        //    return search;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class ketnoi
    {
        public SqlConnection con;

        public ketnoi()
        {
            //con = new SqlConnection("Data Source = SQL5075.site4now.net; Initial Catalog = db_aa304f_qltv; User Id = db_aa304f_qltv_admin; Password = matkhau");
            //con = new SqlConnection("Data Source=LAPTOP-O1I8A0Q6\\SQLEXPRESS;Initial Catalog=QLTV_ASP;Integrated Security=True");
            con = new SqlConnection("Data Source=hungsystem\\MSSQLSERVER02;Initial Catalog=QLTV;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }

        [Obsolete]
        public string mahoa(string caigi)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(caigi.Trim(), "SHA1");
        }
    }
}
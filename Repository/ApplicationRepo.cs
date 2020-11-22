using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ApplicationRepo : IApplicationRepo
    {
        DatabaseConnection dcc;

        public ApplicationRepo()
        {
            dcc = new DatabaseConnection();
        }

        public bool InsertApplication(Applications ap)
        {
            string query = "INSERT into Applications VALUES ('"+ ap.AppId+ "','" + ap.AppuserId+ "','" + ap.Astatus + "','" + ap.Appsub + "','" + ap.Appbody + "')";
            try
            {
               
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }



        public bool UpdateappStatus(Applications a, string s)
        {
            string query = "UPDATE Applications SET astatus = '" + a.Astatus + "' WHERE appid= '" + s + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }



        public Applications GetApplication(string s)
        {
            Applications a = null;
            string query = "SELECT * from Applications WHERE AppId = '" + s + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                a = new Applications();
                a.AppId = sdr["AppId"].ToString();
                a.AppuserId = sdr["Appuserid"].ToString();
                a.Astatus = sdr["Astatus"].ToString();
                a.Appsub = sdr["Appsub"].ToString();
                a.Appbody = sdr["Appbody"].ToString();
            }

            dcc.CloseConnection();
            return a;
        }
        public List<Applications> GetAllApplictaions()
        {
            List<Applications> listOfApplications = new List<Applications>();

            string query = "SELECT * from Applications";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Applications a = new Applications();
                a.AppId = sdr["AppId"].ToString();
                a.AppuserId = sdr["Appuserid"].ToString();
                a.Astatus = sdr["Astatus"].ToString();
                a.Appsub = sdr["Appsub"].ToString();
                a.Appbody = sdr["Appbody"].ToString();

                listOfApplications.Add(a);
            }

            dcc.CloseConnection();

            return listOfApplications;



        }
    }
}

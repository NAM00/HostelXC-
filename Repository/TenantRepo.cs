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
    public class TenantRepo : ITenantRepo
    {
        DatabaseConnection dcc;

        public TenantRepo()
        {
            dcc = new DatabaseConnection();
        }

        public bool InsertTenant(Tenant t)
        {
            string query = "INSERT into Tenants VALUES ('" + t.TId + "', '" + t.Tname + "', '" + t.TphnNumber + "', " + t.Rent + ", '" + t.Institution + "')";
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
        }

        public bool DeleteTenant(Tenant t)
        {
            string query = "DELETE from Tenants WHERE TId = '" + t.TId + "'";
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
        }

        public bool UpdateTenant(Tenant t)
        {
            string query = "UPDATE Tenants SET tname = '" + t.Tname + "', tphnNumber = '" + t.TphnNumber + "', rent = " + t.Rent + ", institution = '" + t.Institution + "' WHERE TId = '" + t.TId + "'";
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
        }

        public Tenant GetTenant(string tId)
        {
            Tenant t = null;
            string query = "SELECT * from Tenants WHERE TId = '" + tId + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                t = new Tenant();
                t.TId = sdr["TId"].ToString();
                t.Tname = sdr["Tname"].ToString();
                t.TphnNumber = sdr["TphnNumber"].ToString();
                t.Rent = Convert.ToDouble(sdr["Rent"].ToString());
                t.Institution = sdr["Institution"].ToString();
            }

            dcc.CloseConnection();
            return t;
        }
        public List<Tenant> GetAllTenant()
        {
            List<Tenant> listOfTenant = new List<Tenant>();

            string query = "SELECT * from Tenants";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Tenant t = new Tenant();
                t = new Tenant();
                t.TId = sdr["TId"].ToString();
                t.Tname = sdr["Tname"].ToString();
                t.TphnNumber = sdr["TphnNumber"].ToString();
                t.Rent = Convert.ToDouble(sdr["Rent"].ToString());
                t.Institution = sdr["Institution"].ToString();

                listOfTenant.Add(t);
            }

            dcc.CloseConnection();

            return listOfTenant;



        }


    }
}

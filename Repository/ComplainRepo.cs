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
   public class ComplainRepo : IComplainRepo
    {
        DatabaseConnection dcc;

        public ComplainRepo()
        {
            dcc = new DatabaseConnection();
        }

        public bool Insertcomplain(Complain c)
        {
            string query = "INSERT into Complains VALUES ('" + c.CId + "', '" + c.Csub + "', '" + c.Cbody + "','" + c.CuserId + "')";
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


        
       

        

        public Complain Getcomplain(string cId)
        {
            Complain c = null;
            string query = "SELECT * from Complains WHERE CId = '" + cId + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                c = new Complain();
                c.CId = sdr["CId"].ToString();
                c.Csub = sdr["Csub"].ToString();
                c.Cbody = sdr["Cbody"].ToString();
                c.CuserId = sdr["CuserId"].ToString();
                
            }

            dcc.CloseConnection();
            return c;
        }
        public List<Complain> GetAllComplains()
        {
            List<Complain> listOfComplains = new List<Complain>();

            string query = "SELECT * from Complains";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
               Complain c = new Complain();
                c.CId = sdr["CId"].ToString();
                c.Csub = sdr["Csub"].ToString();
                c.Cbody = sdr["Cbody"].ToString();
                c.CuserId = sdr["CuserId"].ToString();
               
                listOfComplains.Add(c);
            }

            dcc.CloseConnection();

            return listOfComplains;



        }


    }
}

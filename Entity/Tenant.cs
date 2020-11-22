using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Tenant
    {
        string tId;

        public string TId
        {
            get { return tId; }
            set { tId = value; }
        }

        string tname;

        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }

        string tphnNumber;

        public string TphnNumber
        {
            get { return tphnNumber; }
            set { tphnNumber = value; }
        }

        double rent;

        public double Rent
        {
            get { return rent; }
            set { rent = value; }
        }

        string institution;

        public string Institution
        {
            get { return institution; }
            set { institution = value; }
        }
    }
}

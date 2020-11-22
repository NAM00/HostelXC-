using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Complain
    {
        string cId;

        public string CId
        {
            get { return cId; }
            set { cId = value; }
        }
        string csub;

        public string Csub
        {
            get { return csub; }
            set { csub = value; }
        }

        string cbody;

        public string Cbody
        {
            get { return cbody; }
            set { cbody = value; }
        }


        string cuserId;

        public string CuserId
        {
            get { return cuserId; }
            set { cuserId = value; }
        }
        
    }
}

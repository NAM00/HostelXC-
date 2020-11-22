using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public interface IComplainRepo
    {
       
        Complain Getcomplain(string c);
        bool Insertcomplain(Complain c);
    }
}

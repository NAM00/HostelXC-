using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   
       public interface IApplicationRepo
    {
        bool UpdateappStatus(Applications a,string s);
        Applications GetApplication(string si);
        bool InsertApplication(Applications a);
         List<Applications> GetAllApplictaions();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstr.Concrete;

namespace InterfaceAbstr.Abstract
{
   public  interface ICustomerService
   {
       public void CustomerAdd(Customer customer);
   }
}

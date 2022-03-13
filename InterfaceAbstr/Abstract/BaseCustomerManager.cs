using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using InterfaceAbstr.Concrete;

namespace InterfaceAbstr.Abstract
{
   public class BaseCustomerManager:ICustomerService
    {
        public virtual void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Customer Added!:"+ customer.FirstName);
        }

   
    }
}

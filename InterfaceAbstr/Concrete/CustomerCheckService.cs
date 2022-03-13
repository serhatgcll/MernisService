using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstr.Abstract;

namespace InterfaceAbstr.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool ChechkIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}

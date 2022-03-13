using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstr.Abstract;

namespace InterfaceAbstr.Concrete
{
    public class ABankManager :BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public ABankManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;

        }
        
        public override void CustomerAdd(Customer customer)
        {
            if (_customerCheckService.ChechkIfRealCustomer(customer))
            {
                base.CustomerAdd(customer);
            }
            else
            {
                throw new Exception("Girilen müşteri bilgileri hatalıdır.");
            }


            
        }
    }
}

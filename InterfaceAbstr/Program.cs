using System;
using InterfaceAbstr.Abstract;
using InterfaceAbstr.Adapters.MernisServiceAdapter;
using InterfaceAbstr.Concrete;

namespace InterfaceAbstr
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomer = new ABankManager(new MernisService());
            baseCustomer.CustomerAdd(new Customer
            {
                IdentityNumber = "33907338036",
                FirstName = "Serhat",
                LastName = "Güçlü",
                BirthDate = new DateTime(1997, 11, 25)
            });

        }
    }
}

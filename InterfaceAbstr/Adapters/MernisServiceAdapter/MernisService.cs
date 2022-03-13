using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstr.Abstract;
using InterfaceAbstr.Concrete;
using ServiceReference1;

namespace InterfaceAbstr.Adapters.MernisServiceAdapter
{
    public class MernisService :ICustomerCheckService
    {
        public bool ChechkIfRealCustomer(Customer customer)
        {
            KPSPublicSoapClient kpsPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            Task<TCKimlikNoDogrulaResponse> response =
                kpsPublicSoapClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNumber),
                    customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthDate.Year);

            var result = response.Result.Body.TCKimlikNoDogrulaResult;
            return result;


        }
    }
}

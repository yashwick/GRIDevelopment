using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interfaces
{
    public interface ICustomerServices
    {
        void AddCustomer(CustomerDTO customer);
        void UpdatePost(CustomerDTO customer);

        List<CustomerDTO> GetCustomers();
        CustomerDTO GetCustomerById(int id);
        void RemovePost(int id);
    }
}

using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(CustomerDTO customer);
        void UpdatePost(CustomerDTO customer);

        List<CustomerDTO> GetAllCustomers();
        CustomerDTO GetCustomerById(int id);
        void RemovePost(int id);
    }
}

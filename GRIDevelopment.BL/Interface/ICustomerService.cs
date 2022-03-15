using GRIDevelopment.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.BL.Interface
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

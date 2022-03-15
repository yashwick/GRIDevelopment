using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DBContexts;
using GRIDevelopment.DAL.DomainModel;
using GRIDevelopment.Mpper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRIDevelopment.BL
{
    public class CustomerService: ICustomerService
    {
        private readonly GRIContext _context;
        private readonly DomainCusDTOMapper _mapper;

        public CustomerService(GRIContext context, DomainCusDTOMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public CustomerDTO GetCustomerById(int id)
        {
            return _mapper.ToCustomerDTO(_context.Customers.FirstOrDefault(x => x.Id == id));
        }

        public void AddCustomer(CustomerDTO customer)
        {
            _context.Customers.Add(_mapper.ToCustomerDomain(customer));
            _context.SaveChanges();
        }

        public void UpdatePost(CustomerDTO customer)
        {
            var customerEntity = _context.Customers.FirstOrDefault(x => x.Id == customer.Id);

            if (customerEntity != null)
            {
                customerEntity.CustomerFirstName = customer.CustomerFirstName;
                customerEntity.CustomerLastName = customer.CustomerLastName; 
                customerEntity.CusAddress = customer.CusAddress;
                customerEntity.CusZipCode = customer.CusZipCode;
                customerEntity.CusContact = customer.CusContact;
            }
            _context.SaveChanges();
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return _mapper.ToCustomerDTOs(_context.Customers.ToList());
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customers.FirstOrDefault(p => p.Id == id);
        }

        public void RemovePost(int id)
        {
            _context.Customers.Remove(GetCustomer(id));
            _context.SaveChanges();
        }
    }
}

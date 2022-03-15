using BAL.Interfaces;
using Contract.DTO;
using DAL.DBContext;
using DAL.Model;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CustomerService : ICustomerService
    {
        private readonly Context _context;
        private readonly DomainCustomerMapper _mapper;

        public CustomerService(Context context, DomainCustomerMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public CustomerDTO GetCustomerById(int id)
        {
            return _mapper.ToCustomerDTO( _context.Customers.FirstOrDefault(x => x.Id == id));
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
                customerEntity.customer_name = customer.customer_name;
                customerEntity.customer_address = customer.customer_address;
                customerEntity.customer_contact = customer.customer_contact;
                customerEntity.customer_email = customer.customer_email;
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

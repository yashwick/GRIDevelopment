using AutoMapper;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.Mpper
{
    public class DomainCusDTOMapper
    {
        private readonly IMapper _mapper;
        public DomainCusDTOMapper(IMapper imapper)
        {
            _mapper = imapper;
        }

        public Customer ToCustomerDomain(CustomerDTO customer)
        {
            return _mapper.Map<CustomerDTO, Customer>(customer);
        }

        public List<CustomerDTO> ToCustomerDTOs(List<Customer> customers)
        {
            return _mapper.Map<List<Customer>, List<CustomerDTO>>(customers);
        }

        public CustomerDTO ToCustomerDTO(Customer customer)
        {
            return _mapper.Map<Customer, CustomerDTO>(customer);
        }

        
    }
}

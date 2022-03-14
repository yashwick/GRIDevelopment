using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CustomerDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}

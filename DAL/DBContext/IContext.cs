using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public interface  IContext
    {
        DBSet<Customer> Customers { get; set; }
    }
}

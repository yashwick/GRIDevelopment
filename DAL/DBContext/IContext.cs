﻿using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public interface  IContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}

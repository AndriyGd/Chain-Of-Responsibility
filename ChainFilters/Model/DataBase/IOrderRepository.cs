﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainFilters.Model.DataBase
{
    public interface IOrderRepository
    {
        List<Order> Orders { get; }
    }
}

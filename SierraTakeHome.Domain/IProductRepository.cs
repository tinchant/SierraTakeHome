﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraTakeHome.Domain
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
    }
}

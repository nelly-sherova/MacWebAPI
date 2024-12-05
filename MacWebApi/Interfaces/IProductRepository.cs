﻿using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts();
    }
}

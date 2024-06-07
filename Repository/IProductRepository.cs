﻿using BusinessObject;

namespace Repository
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();
        Product? GetProductById(int id);
    }
}

using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly DBcontext context;
        public ProductRepository(DBcontext bcontext)
        {
            context = bcontext;
        }

        public int Count()
        {
            return context.products.Count();
        }

        public void Delete(int id)
        {
            var Product = GetByid(id);
            if(Product != null)
            {
                context.products.Remove(Product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return context.products.Select(o => o);
        }

        public Product GetByid(int id)
        {
            return context.products.FirstOrDefault(o => o.ProductID == id);
        }

        public void Insert(Product product)
        {
            context.products.Add(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            context.products.Update(product);
        }
    }
}

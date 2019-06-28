using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;

namespace Ecom.Service.Infrastructure
{
   public interface IProduct
    {
        IEnumerable<Product> GetAll();

        Product GetByid(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(int id);

        int Count();

        void Save();
    }
}

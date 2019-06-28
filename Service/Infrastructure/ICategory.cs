using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;

namespace Ecom.Service.Infrastructure
{
      public  interface ICategory
    {
        IEnumerable<Category> GetAll();

        Category GetByID(int id);

        void Insert(Category cat);

        void UpDate(Category cat);

        void Delete(int id);

        int Count();

        void Save();
    }
}

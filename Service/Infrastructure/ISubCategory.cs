using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;

namespace Ecom.Service.Infrastructure
{
  public interface ISubCategory
    {
        IEnumerable<SubCategory> GetAll();

        SubCategory GetById(int id);

        void Insert(SubCategory subcat);

        void Update(SubCategory subcat);

        void Delete(int id);

        int Count();

        void Save();
    }
}

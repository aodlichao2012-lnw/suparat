using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;

namespace Ecom.Service.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly DBcontext g;
        public CategoryRepository(DBcontext bcontext)
        {
            g = bcontext;
        }

        public int Count()
        {
            return g.categories.Count();
        }

        public void Delete(int id)
        {
            var category = GetByID(id);
            if(category != null)
            {
                g.categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return g.categories.Select(c => c);
        }

        public Category GetByID(int id)
        {
            return g.categories.FirstOrDefault(c => c.CategoryID == id);
        }

        public void Insert(Category cat)
        {
            g.categories.Add(cat);
        }

        public void Save()
        {
            g.SaveChanges();
        }

        public void UpDate(Category cat)
        {
            g.categories.Update(cat);
        }
    }
}

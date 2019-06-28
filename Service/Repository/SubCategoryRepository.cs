using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly DBcontext context;
        public SubCategoryRepository(DBcontext bcontext)
        {
            context = bcontext;
        }

        public int Count()
        {
            return context.subCategories.Count();
        }

        public void Delete(int id)
        {
            var Sub = GetById(id);
            if(Sub != null)
            {
                context.subCategories.Remove(Sub);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return context.subCategories.Select(o => o);
        }

        public SubCategory GetById(int id)
        {
            return context.subCategories.FirstOrDefault(o => o.SuCategoryID == id);
        }

        public void Insert(SubCategory subcat)
        {
            context.subCategories.Add(subcat);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(SubCategory subcat)
        {
            context.subCategories.Update(subcat);
        }
    }
}

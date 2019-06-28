using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service.Repository
{
    public class PictureRepository : IPicture
    {
        private readonly DBcontext context;
        public PictureRepository(DBcontext bcontext)
        {
            context = bcontext;
        }

        public void Delete(int id)
        {
            var Picture = GetById(id);
            if(Picture != null)
            {
                context.pictures.Remove(Picture);
            }
        }

        public Picture GetById(int id)
        {
            return context.pictures.FirstOrDefault(o => o.PictureID == id);
        }

        public void Insert(Picture picture)
        {
            context.pictures.Add(picture);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            context.pictures.Update(picture);
        }
    }
}

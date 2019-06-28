using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;

namespace Ecom.Service.Infrastructure
{
   public interface ICartItem
    {
        IEnumerable<CartItem> GetAll();

        CartItem getById(int id);

        void Insert(CartItem cart);

        void UpDate(CartItem cart);

        void Delete(int id);

        int Count();

        void Save();

    }
}

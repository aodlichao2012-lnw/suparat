using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using Ecom.Dbcontext;

namespace Ecom.Service.Repository
{
    public class CartItemRepository : ICartItem
    {
        private readonly DBcontext g;
        public CartItemRepository(DBcontext bcontext)
        {
            g = bcontext;
        }

        public int Count()
        {
            return g.cartItems.Count();
        }

        public void Delete(int id)
        {
            var Cartitem = getById(id);
            if(Cartitem != null)
            {
                g.cartItems.Remove(Cartitem);
            }
        }

        public IEnumerable<CartItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public CartItem getById(int id)
        {
            return g.cartItems.FirstOrDefault(c => c.CardID == id);
        }

        public void Insert(CartItem cart)
        {
            g.cartItems.Add(cart);
        }

        public void Save()
        {
            g.SaveChanges();
        }

        public void UpDate(CartItem cart)
        {
            g.cartItems.Update(cart);
        }
    }
}

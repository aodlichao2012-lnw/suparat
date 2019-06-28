using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly DBcontext context;
        public OrderRepository(DBcontext bcontext)
        {
            context = bcontext;
        }

        public int Count()
        {
            return context.orders.Count();
        }

        public void Delete(int id)
        {
            var Order = GetById(id);
            if(Order != null)
            {
                context.orders.Remove(Order);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return context.orders.Select(o => o);
        }

        public Order GetById(int id)
        {
            return context.orders.FirstOrDefault(o => o.OrderId == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}

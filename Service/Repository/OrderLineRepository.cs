using Ecom.Dbcontext;
using Ecom.Models;
using Ecom.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service.Repository
{
    public class OrderLineRepository : IOrderLine
    {
        private readonly DBcontext g;
        public OrderLineRepository(DBcontext bcontext)
        {
            g = bcontext;
        }

        public int Count()
        {
            return g.orderLines.Count();
        }

        public IEnumerable<OrderLine> GetAll()
        {
            return g.orderLines.Select(o => o);
        }

        public OrderLine GetById(int id)
        {
            return g.orderLines.FirstOrDefault(c => c.OrderLineID == id);
        }

        public void Insert(OrderLine orderLine)
        {
            g.orderLines.Add(orderLine);
        }

        public void Save()
        {
            g.SaveChanges();
        }

        public void UpDate(OrderLine orderLine)
        {
            g.orderLines.Update(orderLine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models;

namespace Ecom.Service.Infrastructure
{
   public interface IOrderLine
    {
        IEnumerable<OrderLine> GetAll();

        OrderLine GetById(int id);

        void Insert(OrderLine orderLine);

        void UpDate(OrderLine orderLine);

        int Count();

        void Save();
    }
}

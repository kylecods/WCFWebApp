using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PaymentOrdersData
{
    public interface IDbContext
    {
        IDbSet<T> Set<T>() where T : class;
        int SaveChanges();
       
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace PaymentOrdersData
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private IDbContext _db;

        private IDbSet<T> _entities;

        private IDbSet<T> Entities { 
            get 
            { 
                if(_entities == null ) {
                    _entities = _db.Set<T>(); 
                }
                return _entities;
            }
        }
       
        public IEnumerable<T> GetData()
        {
            return this.Entities.ToList();
        }
        public T FindPaymentOrder(int? id)
        {
            return this.Entities.Find(id);
        }

        public void AddPaymentOrder(T order)
        {
            this.Entities.Add(order);
            this._db.SaveChanges();

        }

        public void EditPaymentOrder(T order)
        {
            //_db.Entry(order).State = EntityState.Modified;
            //_db.SaveChanges();
        }
        public void DeletePaymentOrder(int? id)
        {
            T paymentOrder = this.Entities.Find(id);
            this.Entities.Remove(paymentOrder);
            this._db.SaveChanges();
        }
    }


}

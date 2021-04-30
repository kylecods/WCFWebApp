using PaymentOrders.App_Start;
using PaymentOrdersData;
using System.Collections.Generic;
using System.ServiceModel;
using WebApp.Models;

namespace PaymentOrdersService
{
    [ApplicationErrorHandlerAttribute]
    [UnityInstanceProviderServiceBehavior]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service : IService
    {
        private readonly IRepository<PaymentOrder> _repo;

        public Service(IRepository<PaymentOrder> repo)
        {
            _repo = repo;
        }


        public IEnumerable<PaymentOrder> GetData()
        {
            return _repo.GetData();
        }
        public PaymentOrder FindPaymentOrder(int? id)
        {
            return _repo.FindPaymentOrder(id);
        }

        public void AddPaymentOrder(PaymentOrder order)
        {
            _repo.AddPaymentOrder(order);

        }

        public void EditPaymentOrder(PaymentOrder order)
        {
            _repo.EditPaymentOrder(order);
        }
    }
}

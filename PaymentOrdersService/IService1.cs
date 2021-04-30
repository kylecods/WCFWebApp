using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApp.Models;

namespace PaymentOrdersService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService
	{


		[OperationContract]
		IEnumerable<PaymentOrder> GetData();

		[OperationContract]
		PaymentOrder FindPaymentOrder(int? id);

		[OperationContract]
		void AddPaymentOrder(PaymentOrder order);
		[OperationContract]
		void EditPaymentOrder(PaymentOrder order);
	}

}

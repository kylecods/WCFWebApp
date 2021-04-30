using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApp.Models
{
    [DataContract]
    public class Transaction : ValueObject
    {
        [DataMember]
        public String routeID { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public String Reference { get; set; }
        [DataMember]

        public String SystemTraceANO { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return routeID;
            yield return Amount;
            yield return Reference;
            yield return SystemTraceANO;
           
        }
    }
}

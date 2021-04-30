using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApp.Models
{
    [DataContract]
    public class  Remitter: ValueObject
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string IdType { get; set; }
        [DataMember]
        public string IdNo { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int ccy { get; set; }
        [DataMember]
        public string Financial { get; set; }
        [DataMember]
        public string Funds { get; set; }
        [DataMember]
        public string principalActivity { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Address;
            yield return PhoneNumber;
            yield return IdType;
            yield return IdNo;
            yield return Country;
            yield return ccy;
            yield return Financial;
            yield return Funds;
            yield return principalActivity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApp.Models
{
    [DataContract]
    public class Recipient : ValueObject
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public int MCC { get; set; }
        [DataMember]
        public string IdType { get; set; }
        [DataMember]
        public string IdNo { get; set; }
        [DataMember]
        public int ccy { get; set; }
        [DataMember]
        public string Financial { get; set; }
        [DataMember]
        public string Purpose { get; set; }
        [DataMember]
        public string InstitutionID { get; set; }
        [DataMember]
        public string PriAcc { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Address;
            yield return PhoneNumber;
            yield return Email;
            yield return IdType;
            yield return IdNo;
            yield return MCC;
            yield return ccy;
            yield return Financial;
            yield return Purpose;
            yield return InstitutionID;
            yield return PriAcc;
        }
    }
}

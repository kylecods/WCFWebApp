using System;
using System.Runtime.Serialization;

namespace WebApp.Models
{
    [DataContract]
    public class PaymentOrder
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PID { get; set; }*/
        [DataMember]
        public String OrigConID { get; set; }
        [DataMember]
        public String PaymentNotes { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int RemitterID { get; set; }
        [DataMember]
        public int TransactionID { get; set; }
        [DataMember]
        public int RecipientID { get; set; }
        [DataMember]
        public virtual Remitter Remitter { get; set; }
        [DataMember]
        public virtual Recipient Recipient { get; set; }
        [DataMember]
        public virtual Transaction Transaction
        {
            get; set;
        }
        

       
    }
}

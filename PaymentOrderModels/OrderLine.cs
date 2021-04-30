using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int RemitterID { get; set; }
        public int TransactionID { get; set; }
        public int RecipientID { get; set; }

        public Remitter Remitter { get; set; }
        public Recipient Recipient { get; set; }
        public Transaction Transaction { get; set; }
    }
}

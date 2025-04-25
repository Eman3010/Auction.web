using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BuyerPayment
    {

        public int BiddingID { get; set; }
        public int BuyerId { get; set; }
    }
}

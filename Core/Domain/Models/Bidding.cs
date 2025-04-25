using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Bidding
    {
        public int BiddingID { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidTime { get; set; }
        public int Auctionid { get; set; }
        public Auction auction { get; set; }

       public ICollection<BuyerPayment> BuyerPayment { get; set; } = new HashSet<BuyerPayment>();
    }
}

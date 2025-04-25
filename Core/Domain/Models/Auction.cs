using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Auction
    {
        public int AuctionID { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int sellerid { get; set; }
        public Seller seller { get; set; }

        public int adminid { get; set; }
        public Admin admin { get; set; }

        public int ItemID { get; set; }
        public Item Item { get; set; }

        public ICollection<Bidding> Biddings { get; set; } = new HashSet<Bidding>();
    }
}

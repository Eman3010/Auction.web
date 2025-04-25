using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Name { get; set; } =  null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;

        public ICollection<Auction> Auctions { get; set; } = new HashSet<Auction>();
    }
}

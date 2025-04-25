using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }= null!;
        public string Description { get; set; }= null!;
        public string pictureURL { get; set; }= null!;
        


        public Auction Auction { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

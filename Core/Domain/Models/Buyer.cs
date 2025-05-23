﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Buyer
    {
        public int BuyerID { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; }= null!;


        public ICollection<BuyerPayment> buyerPayments { get; set; } = new HashSet<BuyerPayment>();
    }
}

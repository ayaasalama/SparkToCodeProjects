using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Bank1_.models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
    }
}

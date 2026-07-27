using EFCore_Bank1_.models;

namespace EFCore_Bank1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BankDbContext())
            {
                context.BankAccounts.Add(new BankAccount 
                {
                    HolderName = "Aya", Balance = 350
                });

                context.SaveChanges();
                
            }
        }
    }
}

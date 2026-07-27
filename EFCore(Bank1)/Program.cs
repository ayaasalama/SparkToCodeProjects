using EFCore_Bank1_.models;

namespace EFCore_Bank1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BankDbContext())
            {
                //context.BankAccounts.Add(new BankAccount 
                //{
                //    HolderName = "Aya", Balance = 350
                //});

                //context.SaveChanges();

                //BankAccount account = context.BankAccounts.FirstOrDefault(a => a.HolderName == "Aya");
                //if (account != null)
                //{
                //    account.Balance += 100; 
                //    context.SaveChanges();
                //}

                List<BankAccount> all = context.BankAccounts.ToList(); 
                foreach (BankAccount a in all)
                    Console.WriteLine($"{a.AccountId}: {a.HolderName} - {a.Balance}");
            }
        }
    }
}

namespace OOP_Part_1_
{
    // First Class BankAccount
    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Methods
        public void Deposit(double amount)
        {
            Balance += amount;

            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;

                SendEmail();
            }
            else
            {
                Console.WriteLine("Balance Insufficient!");
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("HolderName: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine("Sending an Email...");
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

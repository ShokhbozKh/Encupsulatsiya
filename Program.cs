namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acond acond1 = new Acond("Shohboz", "1234", 0);
            acond1.SetMoney(123000);
            acond1.SetMoney(123000);
            acond1.SetMoney(123000);

            Console.WriteLine( acond1.GetMoney("1234"));
            Console.WriteLine(acond1.SetPassword());
        }
    }
}
using Homeworkk.Utils;

namespace Homeworkk
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange();
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine(exchange.Currencymethod(Currencyenum.USD,money));
        }
    }
    public class Exchange
    {
        public double Currencymethod(Currencyenum currency, double azn)
        {
            
            double result = currency switch
            {
                Currencyenum.USD => 0.59 * azn,
                Currencyenum.EUR => 0.53 * azn,
                Currencyenum.TRY => 8.73 * azn,
                Currencyenum.RUB => 52.21 * azn,
                _ => 0,

            };
            return result;
            

        }
    }
}
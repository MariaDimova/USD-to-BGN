using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //щатски долари (USD) в български лева (BGN). 
            //Закръглете резултата до 2 цифри след десетичната запетая.  
            // Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Console.WriteLine(Math.Round(bgn,2));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashDB.Models
{
    class DefaultData
    {
        public static void Initialize(CreditCardDbContext context)
        {
            if (!context.CreditCards.Any())
            {
                context.CreditCards.AddRange(
                new CreditCard()
                {
                    CardNumber = "378282246310005",
                    ExpDate = new DateTime(2016, 1, 1),
                    CardType = "American Express",
                    PIN = 1234
                }
                );
                context.SaveChanges();
            }
        }
    }
}

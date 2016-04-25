using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShopDB.Models
{
    public class DefaultModelValues
<<<<<<< HEAD
    {/*
        // inicijalizacija podataka 
        public static void Initialize(MashShopDBContext context)
        {
            // Inicijaliziranje tabele "AllProducts"
            if (!context.AllProducts.Any())
=======
    {
        // inicijalizacija podataka 
        public static void Initialize(MashShopDBContext context)
        {   
            // Inicijaliziranje tabele "AllProducts"
            if(!context.AllProducts.Any())
>>>>>>> origin/master
            {
                context.AllProducts.AddRange(new Product(0, "noProd", 0.0d, "noDesc", 0, 1));
            }

            // Inicijalizacija tabele "AllAdministrators"
<<<<<<< HEAD
            if (!context.AllAdministrators.Any())
=======
            if(!context.AllAdministrators.Any())
>>>>>>> origin/master
            {
                context.AllAdministrators.AddRange(new Administrator(0, "admin", "admin", "", DateTime.Today, 0m, "adminadmin", "adminPass", "", ""));
            }

            // Inicijalizacija tabele "AllRegisteredUsers"
<<<<<<< HEAD
            if (!context.AllRegisteredUsers.Any())
            {
                context.AllRegisteredUsers.AddRange(new RegisteredUser(0, "regUsr", "regUsr", "regUsr", "regUsr", "nan", ""));
            }
            if (!context.AllCreditCards.Any())
            {
                context.AllCreditCards.AddRange(
=======
            if(!context.AllRegisteredUsers.Any())
            {
                context.AllRegisteredUsers.AddRange(new RegisteredUser(0, "regUsr", "regUsr", "regUsr", "regUsr", "nan", ""));
            }
            if (!context.CreditCards.Any())
            {
                context.CreditCards.AddRange(
>>>>>>> origin/master
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
<<<<<<< HEAD
            if (!context.AllCreditCards.Any())
            {
                context.AllCreditCards.AddRange(
=======
            if (!context.CreditCards.Any())
            {
                context.CreditCards.AddRange(
>>>>>>> origin/master
                new Receipt()
                {
                    ReceiptID = 0,
                    CardID = 0,
                    CustomerID = 0,
                    TotalPrice = 0.0
                }
                );
                context.SaveChanges();
            }

            context.SaveChanges();
        }
<<<<<<< HEAD
        */
=======

>>>>>>> origin/master
    }
}

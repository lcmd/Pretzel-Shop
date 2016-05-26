using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretzelShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*make a program that will calculate a pretzel that is 3.99 by the quantity that the user puts in*/
            Console.WriteLine("Welcome to Lexus Pretzel Shop \nEnter the quantity of pretzels you would like to purchase:");
            Console.WriteLine("Since you are a valued customer, for every 5 Pretzels bought you recive a 10% discount!!");
            Pretzel();
            
        }
      static public void Pretzel()
        {
            int quantity = int.Parse(Console.ReadLine());
            double pretzel = 3.99;
            double total = pretzel * quantity;
            double tax = .08 * total;
            double discount = total * .10;
            //add tax


            //if the quantity is over 5 there is a 10% discount
            //Math.Round(number, round to)
            if (quantity < 6)
            {
                Console.WriteLine("Thanks for shopping at Lexus Pretzels!\nYour total is: $" + Math.Round(total + tax, 2));
            }
            else
            {


                Console.WriteLine("Your total is : $" + Math.Round((total - discount) + tax, 2));
                Console.WriteLine("You saved: $" + Math.Round(discount, 2) + "!");
            }

        }
    }
}

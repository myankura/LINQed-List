using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
                {
                    "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
                };

            //Sorts through the list of fruits and determines if the fruit starts with 'L'
            IEnumerable<string> LFruits =
                from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;

            Console.WriteLine();
            Console.WriteLine("These fruits start with an L");
            //Display each fruit that starts with the letter 'L'
            foreach (string l in LFruits)
            {
                Console.WriteLine($"{l}");
            }

            //Just a space between exercises
            Console.WriteLine();

            // //This is how you would sort each fruit out by the first letter but not restricting it to fruits only starting with 'L'
            // //Save this code for later
            // var sortFruits = fruits.GroupBy(firstLetter => firstLetter[0]);

            //     foreach(var sortFruit in sortFruits)
            //     {
            //         Console.WriteLine("Fruits starting with {0}", sortFruit.Key);
            //         foreach(var fruit in sortFruit)
            //         {
            //             Console.WriteLine("  {0}", fruit);
            //         }
            //     }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            //Now sort through the numbers and dertermine if they are multiples of 4 or 6
            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            Console.WriteLine("These numbers are multiples of either 4 or 6:");
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine($"{num}");
            }

            //Just a space between exercises
            Console.WriteLine();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

            //Build a list to hold all of the descending names and use orderbydescending to sort them.
            List<string> namesDesc = names.OrderByDescending(x => x).ToList();

            Console.WriteLine("These names have been sorted in descending order");
            //Loop over all of the names in nameDesc
            foreach (string name in namesDesc)
            {
                Console.WriteLine($"{name}");
            }

            Console.WriteLine();

            // Build a collection of these numbers sorted in ascending order
            List<int> nums = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            //Build a collection of numbers from the nums list and sort them ascending
            IEnumerable<int> sortedNums =
            from num in nums
            orderby num ascending
            select num;

            Console.WriteLine("These numbers have been sorted in ascending order");
            //Loop over all of the collection of nums in sortedNums and print them to the console.
            foreach (int n in sortedNums)
            {
                Console.WriteLine($"{n}");
            }

            Console.WriteLine();

            // Output how many numbers are in this list
            List<int> uncountedNums = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            //Set a variable to hold the result of how many numbers are in the collection uncountedNums
            int countedNums = uncountedNums.Count();

            Console.WriteLine($"There are {countedNums} numbers in the list");
            Console.WriteLine();

            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };

            //Sum of all purchases made
            double total = purchases.Sum();
            Console.WriteLine($"The total sum of all purchases is ${total}");
            Console.WriteLine();

            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };

            //Find the max of all prices in the list
            double mostExpensive = prices.Max();
            Console.WriteLine($"The most expensive item in the list costs ${mostExpensive}");
            Console.WriteLine();

            /*
            Store each number in the following List until a perfect square
            is detected. The loop should run until it hits 46.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
                {
                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                };

            List<int> nonSquares = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0).ToList();

            Console.WriteLine("A perfect square has been detected! Ending foreach loop.");
            foreach (int n in nonSquares)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //Build a list of customers
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */
            IEnumerable<Bank> millionaires = (from m in customers
                group m by m.Bank into MillionaireClub
                select new Bank
                {
                    Name = MillionaireClub.Key,
                    MillionaireCount = MillionaireClub.Where(c => c.Balance >= 1000000).Count()
                }
                );
            Console.WriteLine("The following banks have n number of millionaires");
            foreach (Bank bank in millionaires)
            {
                Console.WriteLine($"{bank.Name}: {bank.MillionaireCount}");
            }
            Console.WriteLine();

            /*
                TASK:
                As in the previous exercise, you're going to output the millionaires,
                but you will also display the full name of the bank. You also need
                to sort the millionaires' names, ascending by their LAST name.

                Example output:
                    Tina Fey at Citibank
                    Joe Landy at Wells Fargo
                    Sarah Ng at First Tennessee
                    Les Paul at Wells Fargo
                    Peg Vale at Bank of America
            */

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            //Create a new collection for people who are millionaires from Customer Collection
            List<Customer> richPeople = (customers.Where(c => c.Balance >= 1000000)).ToList();

            //Create a collection for sorting out which bank 
            List<ReportItem> millionaireReport = (from customer in richPeople 
                join bank in banks on customer.Bank equals bank.Symbol
                select new ReportItem{
                    CustomerName = customer.Name,
                    BankName = bank.Name,
                    Balance = customer.Balance
                }).ToList();
            //Loop over the millionaireReport and order by last name descending
            foreach (var item in millionaireReport.OrderBy(name => name.GetLastName()))
                {
                    Console.WriteLine($"{item.CustomerName} at {item.BankName} - {item.Balance.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
                }
        }
    }
}
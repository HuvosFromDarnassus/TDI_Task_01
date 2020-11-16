using System;

namespace TDI_Task_01
{
    class Program
    {
        static void ShowBadDealMessage(double diamonds, double gold)
        {
            Console.Write("(Game Master) The deal was not completed\n\nDiamonds was: "
                        + diamonds + "\nGold was: " + gold);
        }

        static void ShowGoodDealMessage(double diamonds, double gold, double purchase)
        {
            Console.Write("(Game Master) You purchased:\n\n"
                        + purchase + " diamonds" + "\nGold left " + gold
                        + "\nDiamonds left " + diamonds);
        }

        static string GetAnswer()
        {
            Console.Write("\n(Game Master) Continue ? [Y / N]");
            string continueAns = Console.ReadLine();

            return continueAns;
        }

        static bool findСontinuation(string answer)
        {
            if (answer == "Y" ||
                answer == "y")
            {
                return true;
            }
            else if (answer == "N" ||
                answer == "n")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Console.Write("(Game Master) Enter of diamonds quantity: ");
            double diamonds = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.Write("(Game Master) Enter of gold quantity: ");
            double gold = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            double price = 2.5;
            bool isContinue = true;

            while (isContinue)
            {
                Console.Write("(Seller) How many diamionds do you wnat?\nAnswer: ");
                int purchase = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                if (purchase > diamonds)
                {
                    ShowBadDealMessage(diamonds, gold);

                    isContinue = findСontinuation(GetAnswer());
                }
                else if (gold - purchase * price < 0)
                {
                    Console.Write("\n(Game Master) Not enough gold");

                    ShowBadDealMessage(diamonds, gold);

                    isContinue = findСontinuation(GetAnswer());
                }
                else
                {
                    gold -= purchase * price;
                    diamonds -= purchase;

                    ShowGoodDealMessage(diamonds, gold, purchase);

                    isContinue = findСontinuation(GetAnswer());
                }
            }
        }
    }
}

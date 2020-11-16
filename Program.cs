using System;

namespace TDI_Task_01
{
    class Program
    {
        static string ContinueAnswer()
        {
            Console.Write("\n(Game Master) Continue ? [Y / N]");
            string continueAns = Console.ReadLine();

            return continueAns;
        }

        static bool ContinueTheGame(string isContinueAns)
        {
            if (isContinueAns == "Y" ||
                isContinueAns == "y")
            {
                return true;
            }
            else if (isContinueAns == "N" ||
                isContinueAns == "n")
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
                    Console.Write("(Game Master) The deal was not completed\n\nDiamonds was: "
                        + diamonds + "\nGold was: " + gold);

                    isContinue = ContinueTheGame(ContinueAnswer());
                }
                else if (gold - purchase * price < 0)
                {
                    Console.Write("\n(Game Master) Not enough gold");
                    Console.Write("\n(Game Master) The deal was not completed\n\nDiamonds was: "
                        + diamonds + "\nGold was: " + gold);

                    isContinue = ContinueTheGame(ContinueAnswer());
                }
                else
                {
                    gold -= purchase * price;
                    diamonds -= purchase;
                    Console.Write("(Game Master) You purchased:\n\n"
                        + purchase + " diamonds" + "\nGold left " + gold
                        + "\nDiamonds left " + diamonds);

                    isContinue = ContinueTheGame(ContinueAnswer());
                }
            }
        }
    }
}

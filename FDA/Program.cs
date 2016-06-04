using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDA
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentState = "q0";
            string nextCoin; 
            string input;
            string[] inputByChar;
            FDA.Program.vfnPrintPriceList();
            Console.WriteLine("Enter Coins (Valid Coins: 1 or 2 or 5 or 10)");
            input = Convert.ToString(Console.ReadLine());
            inputByChar = input.Split(',');

            for (int i = 0; i < inputByChar.Length; i++)
            {
                nextCoin = inputByChar[i];
                currentState = FDA.Program.sfnDFA(currentState, nextCoin);

                if (currentState == "qE")
                {
                    break;
                 }
                                
            }

            Console.WriteLine("Result: " + FDA.Program.sfnPrintPurchase(currentState));                 
            
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        //Function that prints the coins inserted.
        private static void vfnPrintCoins(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
 
        }

        //Function that analyses the Deterministic finite automaton
        private static string sfnDFA(string currentState, string nextCoin)
        {
            string nextState;
            if ((nextCoin != "1") && (nextCoin != "2") && (nextCoin != "5") && (nextCoin != "10"))
            {
                nextState = "qE";
            }
            else
            {

                switch (currentState)
                {
                    case "q0":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q1";
                                break;
                            case "2": nextState = "q2";
                                break;
                            case "5": nextState = "q5";
                                break;
                            case "10": nextState = "q10";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q1":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q2";
                                break;
                            case "2": nextState = "q3";
                                break;
                            case "5": nextState = "q6";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q2":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q3";
                                break;
                            case "2": nextState = "q4";
                                break;
                            case "5": nextState = "q7";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q3":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q4";
                                break;
                            case "2": nextState = "q5";
                                break;
                            case "5": nextState = "q8";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q4":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q5";
                                break;
                            case "2": nextState = "q6";
                                break;
                            case "5": nextState = "q9";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q5":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q6";
                                break;
                            case "2": nextState = "q7";
                                break;
                            case "5": nextState = "q10";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q6":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q7";
                                break;
                            case "2": nextState = "q8";
                                break;
                            case "5": nextState = "qE";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q7":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q8";
                                break;
                            case "2": nextState = "q9";
                                break;
                            case "5": nextState = "qE";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q8":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q9";
                                break;
                            case "2": nextState = "q10";
                                break;
                            case "5": nextState = "qE";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q9":
                        switch (nextCoin)
                        {
                            case "1": nextState = "q10";
                                break;
                            case "2": nextState = "qE";
                                break;
                            case "5": nextState = "qE";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;

                    case "q10":
                        switch (nextCoin)
                        {
                            case "1": nextState = "qE";
                                break;
                            case "2": nextState = "qE";
                                break;
                            case "5": nextState = "qE";
                                break;
                            case "10": nextState = "qE";
                                break;
                            default: nextState = currentState;
                                break;
                        }
                        break;


                    default: nextState = "q0";
                        break;
                }
            }

            return nextState;
 
        }

        //Function that prints the purchased produc.
        private static string sfnPrintPurchase(string input)
        {
            string result;
            switch (input)
            {
                case "qE": result = "No possible to process";
                    break;
                case "q1": result = "Gum";
                    break;
                case "q2": result = "Tablets";
                    break;
                case "q3": result = "Peanuts";
                    break;
                case "q4": result = "PopCorn";
                    break;
                case "q5": result = "Water";
                    break;
                case "q6": result = "Muffin";
                    break;
                case "q7": result = "Chips";
                    break;
                case "q8": result = "Cookies";
                    break;
                case "q9": result = "Chocolate";
                    break;
                case "q10": result = "Soda";
                    break;

                default: result = "No possible to process";
                    break;                    
            }
            return result;
        }

        //Function that prints the Price List.
        private static void vfnPrintPriceList()
        {
            Console.WriteLine("|  Product  | Price |\n|-------------------|\n|Gum        |   1   |\n|-------------------|\n|Tablets    |   2   |\n|-------------------|\n|Peanuts    |   3   |\n|-------------------|\n|PopCorn    |   4   |\n|-------------------|\n|Water      |   5   |\n|-------------------|\n|Muffin     |   6   |\n|-------------------|\n|Chips      |   7   |\n|-------------------|\n|Cookies    |   8   |\n|-------------------|\n|Chocolate  |   9   |\n|-------------------|\n|Soda       |   10  |\n|-------------------|\n");
         }
    }
}

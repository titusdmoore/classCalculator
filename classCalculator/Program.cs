using classCalculatorLibraryProject;
using System;

namespace classCalculator {
    class Program {
        static void Main(string[] args) {

            Functions functions = new Functions();
            int total = 0;
            bool run = true;
            while (run) {
                Console.WriteLine($"Enter Operation:");

                var userInput = Console.ReadLine();
                String[] usrInArr = userInput.Split(' ');
                int amnt = 0;
                if (usrInArr.Length == 2) {
                    Int32.TryParse(usrInArr[1], out amnt);
                }
                string lowerOp = usrInArr[0].ToLower();
                switch (lowerOp) {
                    case "add":
                        total = functions.Add(total, amnt);
                        break;

                    case "subtract":
                        total = functions.Subtract(total, amnt);
                        break;

                    case "multiply":
                        total = functions.Multiply(total, amnt);
                        break;

                    case "divide":
                        if(amnt != 0) {
                        total = functions.Divide(total, amnt);
                        } else {
                            Console.WriteLine("Not allowed to divide by zero");
                        }
                        break;

                    case "end":
                        run = false;
                        break;

                    case "show":
                        Console.WriteLine($"Total = {total}");
                        break;

                    case "clear":
                        total = functions.Clear();
                        break;

                    case "clean":
                        Console.Clear();
                        break;

                    case "help":
                        Console.WriteLine($"List of Valid Commands:{Environment.NewLine}" +
                            $"Add <int>{Environment.NewLine}" +
                            $"Subtract <int>{Environment.NewLine}" +
                            $"Multiply <int>{Environment.NewLine}" +
                            $"Divide <int>{Environment.NewLine}" +
                            $"Clear (Sets Total to 0){Environment.NewLine}" +
                            $"Clean (Clears Console){Environment.NewLine}" +
                            $"Help (Shows list of Valid Commands){Environment.NewLine}" +
                            $"Show (Shows Total){Environment.NewLine}" +
                            $"End (Ends Session){Environment.NewLine}" );
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        run = false;
                        break;
                }



            }
            Console.Clear();
            Console.WriteLine($"Total = {total}");
        }
    }
}

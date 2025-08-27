namespace Calculator;

public class Program
{
   public static void Calculate(char operation)
   {
      Operations op = new Operations();
      Tuple<int, int> numbers = op.TryGetNumbers();

      string output = "";
      switch (operation)
      {
         case '+':
            output = $"{numbers.Item1} + {numbers.Item2} = {op.Add(numbers.Item1, numbers.Item2)} ";
            break;
         case '-':
            output = $"{numbers.Item1} - {numbers.Item2} = {op.Subtract(numbers.Item1, numbers.Item2)} ";
            break;
         case '*':
            output = $"{numbers.Item1} * {numbers.Item2} = {op.Multiply(numbers.Item1, numbers.Item2)} ";
            break;
         case '/':
            if (numbers.Item2 == 0)
            {
               Console.WriteLine("Cannot divide by zero");
               break;
            }
            output = $"{numbers.Item1} / {numbers.Item2} = {op.Divide(numbers.Item1, numbers.Item2)} ";
            break;
         default:
            Console.WriteLine("Unknown operation");
            output = "Unknown";
            break;
      }
      Console.WriteLine(output);
   }
   static void Main()
   {

      bool running = true;

      while (running)
      {
         // Operations calculate = new Operations();
         // Menu
         Console.WriteLine("\nChoose an option:");
         Console.WriteLine("A for addition");
         Console.WriteLine("S for subtraction");
         Console.WriteLine("M for multiplication");
         Console.WriteLine("D for division");
         Console.WriteLine("Q for quit");

         ConsoleKeyInfo userInput = Console.ReadKey();
         Console.Write(" - ");

         char keyPressed = char.ToUpper(userInput.KeyChar);

         switch (keyPressed)
         {
            case 'A':
               Console.WriteLine("Addition");
               Calculate('+');

               break;
            case 'S':
               Console.WriteLine("Subtraction");
               Calculate('-');

               //calculate.Subtract();
               break;
            case 'M':
               Console.WriteLine("Multiplication");
               //calculate.Multiply();
               Calculate('*');
               break;
            case 'D':
               Console.WriteLine("Division");
               Calculate('/');
               break;
            case 'Q':
               Console.WriteLine("Exit");
               running = false;
               break;
            default:
               Console.WriteLine("Unknown option");
               break;
         }
      }
   }

}



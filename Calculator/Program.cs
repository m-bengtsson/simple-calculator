bool running = true;

while (running)
{
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
         Add();
         break;
      case 'S':
         Console.WriteLine("Subtraction");
         Subtract();
         break;
      case 'M':
         Console.WriteLine("Multiplication");
         Multiply();
         break;
      case 'D':
         Console.WriteLine("Division");
         Divide();
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

static bool TryGetNumbers(out (int, int) numbers)
{
   Console.WriteLine($"Enter two numbers, separated by a comma");
   string[] userInput = Console.ReadLine().Split(",");

   int num1;
   int num2;

   if (int.TryParse(userInput[0], out num1) && int.TryParse(userInput[1], out num2))
   {
      numbers = (num1, num2);
      return true;
   }
   numbers = (0, 0);
   return false;
}

static void Add()
{
   if (TryGetNumbers(out (int, int) numbers))
   {
      int result = numbers.Item1 + numbers.Item2;
      Console.WriteLine($"{numbers.Item1} + {numbers.Item2} = {result}");
   }

}

static void Subtract()
{
   if (TryGetNumbers(out (int, int) numbers))
   {
      int result = numbers.Item1 + numbers.Item2;
      Console.WriteLine($"{numbers.Item1} + {numbers.Item2} = {result}");
   }
}

static void Multiply()
{
   if (TryGetNumbers(out (int, int) numbers))
   {
      int result = numbers.Item1 + numbers.Item2;
      Console.WriteLine($"{numbers.Item1} + {numbers.Item2} = {result}");
   }
}

static void Divide()
{
   if (TryGetNumbers(out (int, int) numbers))
   {
      double result = (double)numbers.Item1 / numbers.Item2;
      Console.WriteLine($"{numbers.Item1} / {numbers.Item2} = {result}");
   }
}
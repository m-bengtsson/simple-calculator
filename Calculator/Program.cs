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

// Try parse two integers from user input and assign them to "numbers" if return is true.
static bool TryGetNumbers(out (int, int) numbers)
{
   Console.WriteLine($"Enter two numbers, separated by a comma");
   string[] userInput = Console.ReadLine().Split(",");

   if (int.TryParse(userInput[0], out int num1) && int.TryParse(userInput[1], out int num2))
   {
      numbers = (num1, num2);
      return true;
   }
   numbers = (0, 0);
   return false;
}

static void Add()
{
   if (TryGetNumbers(out (int num1, int num2) numbers))
   {
      int result = numbers.num1 + numbers.num2;
      Console.WriteLine($"{numbers.num1} + {numbers.num2} = {result}");
   }
   else
   {
      Console.WriteLine("Invalid input");
   }
}

static void Subtract()
{
   if (TryGetNumbers(out (int num1, int num2) numbers))
   {
      int result = numbers.num1 + numbers.num2;
      Console.WriteLine($"{numbers.num1} - {numbers.num2} = {result}");
   }
   else
   {
      Console.WriteLine("Invalid input");
   }
}

static void Multiply()
{
   if (TryGetNumbers(out (int num1, int num2) numbers))
   {
      int result = numbers.num1 + numbers.num2;
      Console.WriteLine($"{numbers.num1} * {numbers.num2} = {result}");
   }
   else
   {
      Console.WriteLine("Invalid input");
   }
}

static void Divide()
{
   if (TryGetNumbers(out (int num1, int num2) numbers))
   {
      double result = (double)numbers.num1 / numbers.num2;
      Console.WriteLine($"{numbers.num1} / {numbers.num2} = {result}");
   }
   else
   {
      Console.WriteLine("Invalid input");
   }
}
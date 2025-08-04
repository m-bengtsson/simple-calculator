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

static void Add()
{
   Console.WriteLine($"Enter two numbers to add, separated by a comma");

   string[] userInput = Console.ReadLine().Split(",");

   int num1;
   int num2;

   if (int.TryParse(userInput[0], out num1) && int.TryParse(userInput[1], out num2))
   {
      int result = num1 + num2;
      Console.WriteLine($"{num1} + {num2} = {result}");
   }

}

static void Subtract()
{
   Console.WriteLine($"Enter two numbers to subract, separated by a comma");

   string[] userInput = Console.ReadLine().Split(",");

   int num1;
   int num2;

   if (int.TryParse(userInput[0], out num1) && int.TryParse(userInput[1], out num2))
   {
      int result = num1 - num2;
      Console.WriteLine($"{num1} - {num2} = {result}");
   }

}

static void Multiply()
{
   Console.WriteLine($"Enter two numbers to multiply, separated by a comma");

   string[] userInput = Console.ReadLine().Split(",");

   int num1;
   int num2;

   if (int.TryParse(userInput[0], out num1) && int.TryParse(userInput[1], out num2))
   {
      int result = num1 * num2;
      Console.WriteLine($"{num1} * {num2} = {result}");
   }

}

static void Divide()
{
   Console.WriteLine($"Enter two numbers to divide, separated by a comma");

   string[] userInput = Console.ReadLine().Split(",");

   int num1;
   int num2;

   if (int.TryParse(userInput[0], out num1) && int.TryParse(userInput[1], out num2))
   {
      double result = (double)num1 / num2;
      Console.WriteLine($"{num1} / {num2} = {result}");
   }
   else
   {
      Console.WriteLine($"Invalid number");
   }

}
bool running = true;

while (running)
{
   // Menu
   Console.WriteLine("Choose an option:");

   Console.WriteLine("A for addition");
   Console.WriteLine("S for subtraction");
   Console.WriteLine("M for multiplication");
   Console.WriteLine("D for division");
   Console.WriteLine("Q for quit");

   ConsoleKeyInfo userInput = Console.ReadKey();
   Console.Write("- ");

   char keyPressed = userInput.KeyChar;

   switch (keyPressed)
   {
      case 'A':
         Add();
         Console.WriteLine("Addition");
         break;
      case 'S':
         // Subtract()
         Console.WriteLine("Subtraction");
         break;
      case 'M':
         // Multiply()
         Console.WriteLine("Multiplication");
         break;
      case 'D':
         // Divide()
         Console.WriteLine("Division");
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

// add, sub, mult, div methods
// while
// ask for input
// switch cases for math methods

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
         // Add()
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

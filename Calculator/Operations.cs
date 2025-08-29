namespace Calculator;

public class Operations
{
   // Try parse two integers from user input and assign them to "numbers" if return is true.
   // Make it possible to insert a function to read input for easier testing.
   public Tuple<int, int> TryGetNumbers(Func<string?> readInput)
   {
      Console.WriteLine($"Enter two numbers, separated by a comma");
      string? input = readInput();

      if (input == null)
      {
         Console.WriteLine("Invalid input");
         return Tuple.Create(0, 0); ;
      }
      string[]? userInput = input.Split(",");
      if (userInput.Length != 2)
      {
         Console.WriteLine("Please enter exactly two numbers");
         return Tuple.Create(0, 0);
      }
      if (int.TryParse(userInput[0], out int num1) && int.TryParse(userInput[1], out int num2))
      {
         return Tuple.Create(num1, num2);
      }
      return Tuple.Create(0, 0);
   }

   public int Add(int x, int y) =>
         x + y;

   public int Subtract(int x, int y) =>
       x - y;

   public int Multiply(int x, int y) =>
       x * y;
   public double Divide(int x, int y)
   {
      if (y == 0)
      {
         throw new DivideByZeroException();
      }
      else
      {
         return (double)x / y;
      }
   }
}


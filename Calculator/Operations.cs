namespace Calculator;

public class Operations
{
   // Try parse two integers from user input and assign them to "numbers" if return is true.
   public Tuple<int, int> TryGetNumbers()
   {
      Console.WriteLine($"Enter two numbers, separated by a comma");
      string[] userInput = Console.ReadLine().Split(",");

      if (int.TryParse(userInput[0], out int num1) && int.TryParse(userInput[1], out int num2))
      {

         return Tuple.Create(num1, num2);
      }
      Console.WriteLine("Invalid input");
      return Tuple.Create(0, 0); ;
   }
   public int Add(int x, int y) =>
         x + y;

   public int Subtract(int x, int y) =>
       x - y;

   public int Multiply(int x, int y) =>
       x * y;
   public double Divide(int x, int y) =>
       (double)x / y;


   // public void Add()
   // {
   //    if (TryGetNumbers(out (int num1, int num2) numbers))
   //    {
   //       int result = numbers.num1 + numbers.num2;
   //       Console.WriteLine($"{numbers.num1} + {numbers.num2} = {result}");
   //    }
   //    else
   //    {
   //       Console.WriteLine("Invalid input");
   //    }
   // }

   // public void Subtract()
   // {
   //    if (TryGetNumbers(out (int num1, int num2) numbers))
   //    {
   //       int result = numbers.num1 + numbers.num2;
   //       Console.WriteLine($"{numbers.num1} - {numbers.num2} = {result}");
   //    }
   //    else
   //    {
   //       Console.WriteLine("Invalid input");
   //    }
   // }

   // public void Multiply()
   // {
   //    if (TryGetNumbers(out (int num1, int num2) numbers))
   //    {
   //       int result = numbers.num1 + numbers.num2;
   //       Console.WriteLine($"{numbers.num1} * {numbers.num2} = {result}");
   //    }
   //    else
   //    {
   //       Console.WriteLine("Invalid input");
   //    }
   // }

   // public void Divide()
   // {
   //    if (TryGetNumbers(out (int num1, int num2) numbers))
   //    {
   //       double result = (double)numbers.num1 / numbers.num2;
   //       Console.WriteLine($"{numbers.num1} / {numbers.num2} = {result}");
   //    }
   //    else
   //    {
   //       Console.WriteLine("Invalid input");
   //    }
   // }
}


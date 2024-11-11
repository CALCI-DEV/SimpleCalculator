namespace SimpleCalculatur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("plaese enter number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("plaese enter number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("plaese enter operator(+-*/) : ");
            string op = Console.ReadLine();

            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("plaese enter operator BETWEEN (+-*/)");
                    break;


            }
            Console.WriteLine($"result : {result}");
        }
    }
}

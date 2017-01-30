namespace Messages
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Messages
    {
        public enum Code
        {
            cad, xoz, nop, cyk, min, mar, kon, iva, ogi, yan
        }

        private static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            int number1 = Decode(num1);
            var operand = Console.ReadLine();
            var num2 = Console.ReadLine();
            int number2 = Decode(num2);
            if (operand.Equals("+"))
            {
                Console.WriteLine(Encode(number1 + number2));
            }

            if (operand.Equals("-"))
            {
                Console.WriteLine(Encode(number1 - number2));
            }
        }

        private static string Encode(int v)
        {
            var input = v.ToString();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var num = input[i].ToString();
                result.Append((Code)int.Parse(num));
            }

            return result.ToString();
        }

        private static int Decode(string num)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < num.Length / 3; i++)
            {
                string input = string.Join(string.Empty, num.Skip(i * 3).Take(3));
                Code cod = (Code)Enum.Parse(typeof(Code), input);
                int decod = (int)cod;
                result.Append(decod);
            }

            return int.Parse(result.ToString());
        }
    }
}
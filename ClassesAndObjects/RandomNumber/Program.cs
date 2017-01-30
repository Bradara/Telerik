namespace RandomNumber
{
    using System;

    class RandomNumber
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var num = rnd.Next(100, 200);
                Console.WriteLine(num);

            }
        }
    }
}

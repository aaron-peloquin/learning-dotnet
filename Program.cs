using System;

namespace roller
{
    class Program
    {
        /** Roll 25 1d20s */
        static void Main(string[] args)
        {
          Random rand = new Random();
          String randomNumber;

          for (int i = 1; i < 26; i++) {
            randomNumber = rand.Next(1,20).ToString().PadLeft(4);
            Console.Write("{0}", randomNumber);
            if(i%5==0) {
              Console.WriteLine();
            }
          }
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mod in GitHub
            DateTime dConvert = DateTime.Now;
            
            Console.WriteLine(dConvert);

            string sInstruct = "";
            sInstruct = Console.ReadLine();

            if (sInstruct.ToUpper() == "DOW" || sInstruct.ToUpper() == "DAY OF WEEK")
                {
                Console.WriteLine(dConvert.DayOfWeek);
            }
            else
                {
                Console.WriteLine("You probably screwed something up.  It's your fault.");
            }
            //Mod in VS, but how to compare?
        }
    }
}

using System; 

namespace kadai3
{

    class Keisan
    {

       public static void Main()
       {
            double answer;

            Console.WriteLine("ˆê‚Â–Ú‚Ì”š‚ğ“ü—Í‚µ‚Ä‚­‚¾‚³‚¢");
            double valueA;
            string readA = Console.ReadLine();
            if(!double.TryParse(readA,out valueA))
            {
                Console.WriteLine("”š‚Å‚Í‚ ‚è‚Ü‚¹‚ñ");
                return;
            }

            Console.WriteLine("‰‰Zq‚ğ“ü—Í‚µ‚Ä‚­‚¾‚³‚¢");
            string readE = Console.ReadLine();
            if (readE != "+" && readE != "-" && readE != "*" && readE != "/" )
            {
                Console.WriteLine("‰‰Zq‚ğ“ü—Í‚µ‚Ä‚­‚¾‚³‚¢");
                return;
            }

            Console.WriteLine("“ñ‚Â–Ú‚Ì”š‚ğ“ü—Í‚µ‚Ä‚­‚¾‚³‚¢");
            double valueB;
            string readB = Console.ReadLine();
            if (!double.TryParse(readB,out valueB))
            {
                Console.WriteLine("”š‚Å‚Í‚ ‚è‚Ü‚¹‚ñ");
                return;
            }


            switch (readE)
                {
                case "+":
                    answer = valueA + valueB;
                    Console.WriteLine(answer);
                    break;

                case "-":
                    answer = valueA + valueB;
                    Console.WriteLine(answer);
                    break;

                case "*":
                    answer = valueA + valueB;
                    Console.WriteLine(answer);
                    break;

                case"/":
                    if(valueA == 0)
                    {
                        Console.WriteLine("•ª•ê‚ª0‚Å‚·");
                        return;
                    }
                    else
                    {
                        answer = valueA + valueB;
                        Console.WriteLine(answer);
                        break;
                    }   
                }   
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "I am Human";
                bool nyeo = phrase.Contains("Human");

            if (nyeo == true){
           

                Console.WriteLine("Yes you are Human!\n");
            }

            else
            {
                Console.WriteLine("You arent Human!\n");
            }
            //----------------------------------------------
            string Text = "I don't know what I was thinking Leaving my child behind Now I suffer the curse Knowing now I am blind With all this anger, guilt and sadness Coming to haunt me forever";
            char TiD = (Text[44]);
            int NumiD = (Text.IndexOf("Knowing")); 
            string Knowing = ("Knowing");
            Console.WriteLine("The 45th character in the song It's been so long is " + TiD);
            Console.WriteLine("The word " + Knowing + " is the " + NumiD + "th word of the song\n");
           
            //-----------------------------------------------
            Console.Write("Enter in your name: ");
            string inpt = Console.ReadLine();
            Console.WriteLine("Hello " + inpt);

            Console.ReadLine();

        }   
    }
}

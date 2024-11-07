using System;
using System.ComponentModel.Design;

namespace Uppgift_3_1_
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 16)
            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            

           
            
            
            
            
           
            
        }   
          
    }
}
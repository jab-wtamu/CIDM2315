
namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Q1 code
         Console.WriteLine("Input an integer:");
       int N =Convert.ToInt16(Console.ReadLine());    //user input
       int i;
       for (i= 2; i < N; i++)       //for loop to check if N is prime or not
       {
           if (N % i == 0)    //even numbers are not prime
           {
               Console.WriteLine("N is non-prime");
               break;
           }
           
       }
       if (i == N) 
              {
                Console.WriteLine("N is prime");      //not divisible by any number
              }
        else if (N < 2)             
              {
                Console.WriteLine("N is non-prime");
              }

       //Q2 code
              Console.WriteLine("\nAssign an int value to N:");
              int N2 = Convert.ToInt16(Console.ReadLine());   //user input
              int sym = N2;
              for(int x = 0; x<N2; x++){   //outer for loop
                for(int y = 0; y < sym; y++)    //nested for loop
          {
                Console.Write("#");
          }
              Console.WriteLine("");
         }
      //Q3 code
              Console.WriteLine("\nAssign an int value to N:");
              int N3 = Convert.ToInt16(Console.ReadLine());       //user input
              int star = N3;
             
        for(int start = 0; start <= N3; start++){     
          for(int s = 0;s < start; s++)               //nested for loop
          {
                Console.Write("*");
          }
          Console.WriteLine("");
         }
        //bonus code
        Console.WriteLine("\nAssign an int value to N:");
        int N4 = Convert.ToInt16(Console.ReadLine());             //user input
           for(int r = 1; r <= N4; r++){       //row loop
                  for ( int p=1; p<=N4 -r; p++) //space loop
                     {
                      Console.Write(" ");
                                }
                  for (int q=1; q<=r; q++)      //int loop
                     {
                      Console.Write(r);
                                }
                      Console.WriteLine("");    //new line
  }
    
        }
}


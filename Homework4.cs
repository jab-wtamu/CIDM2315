namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        largestNum();
        triangleSize();
    }
    static void largestNum()        //method to find the largest number
{   
    int a, b;
    Console.WriteLine("Enter the first number: ");  //user input first number
    a = Convert.ToInt16(Console.ReadLine());  
    Console.WriteLine("Enter the second number: "); //user input second number
    b = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"a = {a}, b = {b}");
    if (a > b)  //if: compare the two numbers
    {   
        
        Console.WriteLine($"The largest number is {a}"); //a is the largest number
    }
    else
    {
        Console.WriteLine($"The largest number is {b}");  //b is the largest number
    }      

}
    static void triangleSize(){     //triangle mothod

        Console.WriteLine("\nEnter int N size:");
        int N = Convert.ToInt16(Console.ReadLine());    //user input size of the triangle
        Console.WriteLine("Choose shape: 1 = left, 2 = right:");
        int shape = Convert.ToInt16(Console.ReadLine());    //user input shape of the triangle

        if (shape == 1)    //ifshape is left
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
        else if (shape == 2)    //if shape is right
        {
            for (int i = 1; i <= N; i++)
            {
                for (int x = 1; x <= N - i; x++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int largest = largestNumb();  //call the method
        Console.WriteLine(largest);  //print the largest number
        triangleSizes();
    }
    static int largestNumb()        //method to find the largest number
{   
   
    Console.WriteLine("Enter the first number: ");  //user input first number
    int a = Convert.ToInt16(Console.ReadLine());  
    Console.WriteLine("Enter the second number: "); //user input second number
    int b = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"a = {a}, b = {b}");
    if (a > b)  //if: compare the two numbers
    {   
        
        Console.Write("The largest number is "); //a is the largest number
        return a;
    }
    else
    {
        
        Console.Write("The largest number is "); //b is the largest number
        return b;
    }      

}
    static void triangleSizes(){     //triangle method

        Console.WriteLine("\nEnter int N size:");
        int N = Convert.ToInt16(Console.ReadLine());    //user input size of the triangle
        Console.WriteLine("Choose shape: 1 = left, 2 = right:");
        int shape = Convert.ToInt16(Console.ReadLine());    //user input shape of the triangle

        if (shape == 1)    //if shape is left
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

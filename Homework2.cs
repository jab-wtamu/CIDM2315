namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Please input a letter grade:");   //Q1 code
      string x = Console.ReadLine();    //user input
      char gpa = Convert.ToChar(x);     //convert string to char
  
      if (gpa == 'A'){
        Console.WriteLine("GPA point: 4");
      }
        else if (gpa == 'B'){
        Console.WriteLine("GPA point: 3");
        }
        else if  (gpa == 'C'){
            Console.WriteLine("GPA point: 2");
        }
        else if  (gpa == 'D'){
            Console.WriteLine("GPA point: 1");
        }
        else if(gpa == 'F'){
            Console.WriteLine("GPA point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }

    Console.WriteLine("\nPlease input three numbers for the next trick:");  //Q2 code
    Console.WriteLine("Please input the first num:");   
    string numA = Console.ReadLine();   //multiple user inputs
    int num1 = Convert.ToInt16(numA);
    Console.WriteLine("Please input the second num:");  
    string numB = Console.ReadLine();   
    int num2 = Convert.ToInt16(numB);
    Console.WriteLine("Please input the third num:");
    string numC = Console.ReadLine();   
    int num3 = Convert.ToInt16(numC);

    if (num1 < num2){       //comparison of the three numbers
        if (num1 < num3){
            Console.WriteLine($"The smallest number is:  {num1}");
        }
       else {
           Console.WriteLine($"The smallest number is:  {num3}");
       }
    }
    else {
        if (num2 < num3){
           Console.WriteLine($"The largest number is:  {num2}");
       }
       else{
           Console.WriteLine($"The smallest number is:  {num3}");
       }
    }

    Console.WriteLine("\nLast and final trick");  //Bonus code
    Console.WriteLine("Please input a Year:");
    string year = Console.ReadLine();
    int y = Convert.ToInt16(year);
    if (y % 4 == 0){        //if conditions to check if the year is a leap year
        if (y % 100 == 0){      //nested if statement
           if (y % 400 == 0){
                Console.WriteLine($"{y} is Leap Year");
              }
              else {
                Console.WriteLine($"{y} is not Leap Year");
           }
        }
        else {
            Console.WriteLine($"{y} is Leap Year");
        }
    }
    else {
            Console.WriteLine($"{y} is not Leap Year");
    }
}
}
    

    



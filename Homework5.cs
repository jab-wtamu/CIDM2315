namespace Homework5;
class Program
{
    static void Main(string[ ] args)
    	{
        // Call Q1_method()
        Console.WriteLine("Please enter two integers: ");   // Prompt user to enter two integers
        int largest2 = GetNum(out int num1,out int num2);
        Console.WriteLine($"a = {num1}; b = {num2}");
        Console.WriteLine($"The largest number is {largest2}"); // Display the largest of 2 numbers

        // Call Q2_method()
        Console.WriteLine("Please enter four integers: ");  // Prompt user to enter four integers
        int largest4 = GetNum(out int  num22, out int num3);
        int largestFinal = GetNum(out int num4, out int num5);
        
        Console.WriteLine($"a = {num22}; b = {num3}; c = {num4}; d = {num5}");
        int largest = largest4 > largestFinal ? largest4 : largestFinal;
        Console.WriteLine($"The largest number is {largest}");  // Display the largest of 4 numbers

       
        

        // Call Q3_method()
        createAccount();
}


 // Q1_method
        static int GetNum (out int num1,out int num2){
            
            num1 = Convert.ToInt16(Console.ReadLine());     //1st input conversion
            num2 = Convert.ToInt16(Console.ReadLine());     //2nd input conversion
           
            return num1 > num2 ? num1 : num2;}       //return the largest number
        
//  // Q2_method
        static int GetFourNum()
        {
            int largest4 = GetNum(out int num22, out int num3);     //1st input conversion using q1 method
            int largestFinal = GetNum(out int num4, out int num5);      //2nd input conversion using q1 method

            int bigger = (num22 > num3) ? num22 : num3;
            int bigger2 = (num4 > num5) ? num4 : num5;
            return (bigger > bigger2) ? bigger : bigger2;   //return the largest number

            
        }
        
// checkAge bool method
        static bool checkAge(){
            Console.WriteLine("Enter  birth year in four digits YYYY: ");    //prompt user to enter birth year in format YYYY
            int birth_year = Convert.ToInt16(Console.ReadLine());
            int age = 2025 - birth_year;
            if (age >= 18)      //boolean check for age
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 // Q3_method        
        static void createAccount(){
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: "); 
            string password = Console.ReadLine();
            Console.WriteLine("Enter password again: ");
            string password2 = Console.ReadLine();
            
            
            bool ageCheck = checkAge();     //call checkAge method
            if (password == password2)    //if statement to check if password is correct
            {
                if (ageCheck == true){        //if statement to check if bool output is true
                    Console.WriteLine("Account created successfully");
                    }            
                else   Console.WriteLine("Could not create account.");
                
                    }
            else
            {
                Console.WriteLine("Wrong password");        //default output if passwords dont match
            }
            
        }
        
  }

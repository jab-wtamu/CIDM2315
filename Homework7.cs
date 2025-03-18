namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
     Customer cus1 = new Customer(cus_idIn: 110, cus_nameIn: "Alice", cus_ageIn: 28);   //first customer object created with id, name and age
     cus1.PrintCusInfo(); 
     Customer cus2 = new Customer(cus_idIn: 111, cus_nameIn: "Bob", cus_ageIn: 30);     //second customer object created with id, name and age
     cus2.PrintCusInfo();

     cus1.ChangeID(220);    //change the id of the first customer 
     cus2.ChangeID(221);        //change the id of the second customer
     cus1.PrintCusInfo();   
     cus2.PrintCusInfo();
     cus1.CompareAge(cus2);     //compare method called


    }
//customer class
class Customer{
    //variables
private int cus_id { get; set; } = 0;
public string cus_name { get; set; }= string.Empty;
public int cus_age { get; set; } = 0;
public Customer(int cus_idIn, string cus_nameIn, int cus_ageIn) //constructor used to assign id, name and age to the customer when an object is created.
{
    cus_id = cus_idIn;      //assigning values to variables 
    cus_name = cus_nameIn;
    cus_age = cus_ageIn;
}
public void ChangeID(int new_Id) // method used to change customer id
{
    cus_id = new_Id;
}
public void PrintCusInfo() // method used to print customer information(id, name, age) 
{
    Console.WriteLine($"Customer ID: {cus_id}, name: {cus_name}, age: {cus_age}");}
public void CompareAge(Customer objCustomer) // method used to compare the current object’s age with the objCustomer’s age. Then print out the cus_name of the older customer.
{
    if(cus_age < objCustomer.cus_age)
    {
        Console.WriteLine($"{objCustomer.cus_name} is older ");
    }
    else 
    {
        Console.WriteLine($"{cus_name} is older ");
    }
  
}
}
}


namespace Homework8;

class Program
{
    static void Main(string[] args)
    { // Please use following code to create Customer objects and customer_list
 Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
 Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
 Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
 Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
 Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
 Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	 Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};


 // call Q1 method
 Customer.TotalCredits(customer_list);
 // call Q2 method
 Customer.AmarilloAverageAge(customer_list);
 // call Q3 method
 Customer.CanyonAge(customer_list);
    }
    //customer class
public class Customer{
    //setting variables
    public string customerName { get; set; } = string.Empty;
    public int customerAge { get; set; } = 0;
    public string customerCity { get; set; } = string.Empty;
    public double customerCredit { get; set; } = 0.0;
    //customer constructor
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

    // Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    //total credits method
    public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach (Customer cus in customer_list)
        {
            totalCredits += cus.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {totalCredits}");
        }


// Q2 Create a method to calculate and print the average age of customers living in Amarillo.
//average Amarillo age method

    public static void AmarilloAverageAge(Customer[] customer_list){
        double avgAge = 0;
        double totalAge = 0;
        foreach (Customer custA in customer_list)
            { 
                
                if (custA.customerCity == "Amarillo")
                {
                    totalAge += custA.customerAge;
                }    }
                avgAge = totalAge / 4;
            Console.WriteLine($"Q2: The average age of customers in Amarillo: {avgAge}" );
        
        }




// // Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
//canyon age method
    public static void CanyonAge(Customer[] customer_list){

        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");

        foreach (Customer cust in customer_list)
        {
            if (cust.customerCity == "Canyon" && cust.customerAge > 30)
            {
               Console.Write(cust.customerName);
               Console.Write(", ");
            }
        }
    }
}   
}




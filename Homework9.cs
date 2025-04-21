namespace Homeowrk9;
using System.Linq;


class Program
{
    
    static void Main(string[] args)
    {
        Student Alice = new Student(111, "Alice");      //4 students created
        Student Bob = new Student(222, "Bob");
        Student Kathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();    //Dictionary created
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (!gradebook.ContainsKey("Tom"))  //Check and add Tom to the dictionary
{
    gradebook.Add("Tom", 3.3);
}
        double gpa = gradebook.Values.Average();        //Calculate the average GPA
        Console.WriteLine($"The average GPA is: {gpa}");


        foreach (var student in gradebook.Where(s => s.Value > gpa))        //students with GPA above average
        {
            Console.WriteLine($"Student ID:{student}, Student Name: {student.Key}");
        }
        


    }

class Student{      //student class
    public static List<Student> students = new List<Student>();
    private int studentID {get; set;}
    private string studentName {get; set;}

    public void PrintInfo(){        //Print student info
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int inputID, string inputName){      //Constructor to initialize student ID and name
        studentID = inputID;
        studentName = inputName;
        students.Add(this);

    }

}}

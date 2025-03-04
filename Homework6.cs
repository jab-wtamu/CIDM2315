namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //1st professor
        Professor p1 = new Professor();     //1st professor object
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.profSalary = 9000;
        Console.WriteLine("Professor " + p1.profName + " teaches " + p1.classTeach + ", and the salary is: " + p1.profSalary);

        //2nd professor
        Professor p2 = new Professor();    //2nd professor object
        p2.profName = "Bob";    
        p2.classTeach = "Math";
        p2.profSalary = 8000;
        Console.WriteLine("Professor " + p2.profName + " teaches " + p2.classTeach + ", and the salary is: " + p2.profSalary);
        double salaryDiff = p1.profSalary - p2.profSalary;  //salary difference
        
        //1st student        
        Student s1 = new Student();    //1st student object
        s1.studentName = "Lisa";
        s1.clssEnroll = "Java";
        s1.studentGrade = 90;
        Console.WriteLine("Student " + s1.studentName + " enrolls " + s1.clssEnroll + " and the grade is: " + s1.studentGrade);

        //2nd student
        Student s2 = new Student();   //2nd student object
        s2.studentName = "Tom";
        s2.clssEnroll = "Math";
        s2.studentGrade = 80;
        Console.WriteLine("Student " + s2.studentName + " enrolls " + s2.clssEnroll + " and the grade is: " + s2.studentGrade);
        double gradeSum = s1.studentGrade + s2.studentGrade;    //grade sum

        //last printing requirements
        Console.WriteLine("The salary difference between " + p1.profName + " and " + p2.profName + " is: " + salaryDiff);       //printing salary difference
        Console.WriteLine("The grade difference between " + s1.studentName + " and " + s2.studentName + " is: " + gradeSum);        //printing grade sum
    }
}
//Professor class
class Professor{
    public string profName;
    public string classTeach;
    public double profSalary{get;set;}  //get/set property
}
//Student class
class Student{
    public string studentName;
    public string clssEnroll;
    public double studentGrade{get;set;}    //get/set property
}

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //1st professor
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.profSalary = 9000;
        Console.WriteLine("Professor " + p1.profName + " teaches " + p1.classTeach + ", and the salary is: " + p1.profSalary);

        //2nd professor
        Professor p2 = new Professor();
        p2.profName = "Bob";    
        p2.classTeach = "Math";
        p2.profSalary = 8000;
        Console.WriteLine("Professor " + p2.profName + " teaches " + p2.classTeach + ", and the salary is: " + p2.profSalary);
        double salaryDiff = p1.profSalary - p2.profSalary;
        
        //1st student        
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.clssEnroll = "Java";
        s1.studentGrade = 90;
        Console.WriteLine("Student " + s1.studentName + " enrolls " + s1.clssEnroll + " and the grade is: " + s1.studentGrade);

        //2nd student
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.clssEnroll = "Math";
        s2.studentGrade = 80;
        Console.WriteLine("Student " + s2.studentName + " enrolls " + s2.clssEnroll + " and the grade is: " + s2.studentGrade);
        double gradeSum = s1.studentGrade + s2.studentGrade;

        //last printing requirements
        Console.WriteLine("The salary difference between " + p1.profName + " and " + p2.profName + " is: " + salaryDiff);
        Console.WriteLine("The grade difference between " + s1.studentName + " and " + s2.studentName + " is: " + gradeSum);
    }
}

class Professor{
    public string profName;
    public string classTeach;
    public double profSalary{get;set;}
}

class Student{
    public string studentName;
    public string clssEnroll;
    public double studentGrade{get;set;}
}

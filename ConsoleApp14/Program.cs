using System;
public abstract class Student
{
    public string name { get; set; }
    public int year { get; set; }
    public Student(string name, int year)
    {
        this.name = name;
        this.year = year;
    }

    public override string ToString()
    {
        return "Name: " + name + "/ Age: " + year;
    }
    public abstract double Average();
}
public class StudentCollege: Student
{
    public double score1 { get; set; }
    public double score2 { get; set; }
    public double score3 { get; set; }
    public StudentCollege(string name, int year, double score1, double score2, double score3): base(name, year)
    {
        this.score1=score1;
        this.score2=score2;
        this.score3=score3;
    }
    public override double Average()
    {
        return (score1 + score2 + score3) / 3;
    }
    public override string ToString()
    {
        return base.ToString()+$"\nScore 1: {score1}, Score 2: {score2}, Score 3: {score3}" +
            $"\nAverage: "+Average();
    }
}
public class StudentUniversity: StudentCollege
{
    public double score4 { get; set; }
    public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4): base(name, year, score1, score2, score3)
    {
        this.score4= score4;
    }
    public override double Average()
    {
        return (score1 + score2 + score3 + score4) / 4;
    }
    public override string ToString()
    {
        return $"Name: {name} / Age: {year}" +
            $"\nScore 1: {score1}, Score 2: {score2}, Score 3: {score3}, Score 4: {score4}" +
            $"\nAverage: "+Average();
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Student a = new StudentCollege("Tien", 1997, 7, 8, 9);
        Console.WriteLine(a);
        Console.WriteLine("-------------");
        Student b = new StudentUniversity("Ling", 1997, 9, 8, 10, 7);
        Console.WriteLine(b);
    }
}
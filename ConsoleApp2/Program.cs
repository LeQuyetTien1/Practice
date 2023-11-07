using System;
interface IPerson
{
    void Insert();
    void Delete();
    void Update();
    void Display();
}
public class Staff: IPerson
{
    public void Insert()
    {
        Console.WriteLine("Them nhan vien");
    }
    public void Delete()
    {
        Console.WriteLine("Xoa nhan vien");
    }
    public void Update()
    {
        Console.WriteLine("Cap nhat thong tin nhan vien");
    }
    public void Display()
    {
        Console.WriteLine("Hien thi thong tin nhan vien");
    }
}
public class Student : IPerson
{
    private int id, age;
    private string name;
    
    public void Insert()
    {
        Console.WriteLine("Nhap thong tin hoc sinh: ");
        Console.Write("ID: "); id=int.Parse(Console.ReadLine());
        Console.Write("Ten: "); name = Console.ReadLine();
        Console.Write("Tuoi: "); age=int.Parse(Console.ReadLine());
    }
    public void Delete()
    {
        Console.WriteLine("Xoa thong tin hoc sinh");
        id = 0;
        name = "";
        age = 0;
    }
    public void Update()
    {
        int choice;
        Console.WriteLine("1.ID  2.Ten  3.Tuoi");
        Console.Write("Nhap thong tin ban can sua: "); choice= int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.Write("Sua ID: "); id = int.Parse(Console.ReadLine());
                break;
            case 2: Console.Write("Sua ten: "); name = Console.ReadLine();
                break;
            case 3: Console.Write("Sua tuoi: "); age=int.Parse(Console.ReadLine());
                break;
        }
    }
    public void Display()
    {
        Console.WriteLine("-----Thong tin hoc sinh-----");
        Console.WriteLine("Ma ID: " + id);
        Console.WriteLine("Ten hoc sinh: " + name);
        Console.WriteLine("Tuoi hoc sinh: " + age);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Staff staff = new Staff();
        staff.Insert();
        staff.Delete();
        staff.Update();
        staff.Display();
        Student student = new Student();
        student.Insert();
        student.Display();
        Console.WriteLine();
        student.Delete();
        student.Display();
        Console.WriteLine();
        student.Update();
        student.Display();
        Console.WriteLine();
    }
}

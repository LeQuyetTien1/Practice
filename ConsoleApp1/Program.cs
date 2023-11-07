using System;
public abstract class Shape
{
    public double radius { get; set; }
    public double length { get; set; }
    public double width { get; set; }
    public abstract double Area();
    public abstract double Circumference();
}
public class Circle: Shape
{
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return radius*radius*3.14;
    }
    public override double Circumference()
    {
        return 2 * 3.14 * radius;
    }
    public override string ToString()
    {
        return "Dien tich hinh tron: " + Area()+ "\nChu vi hinh tron: " + Circumference();
    }
}
public class Rectangle: Shape
{
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double Area()
    {
        return length * width;
    }
    public override double Circumference()
    {
        return (length + width) * 2;
    }
    public override string ToString()
    {
        return "Dien tich hinh chu nhat: " + Area()+"\nChu vi hinh chu nhat: "+Circumference();
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Shape c = new Circle(7);
        Console.WriteLine(c);
        Shape r=new Rectangle(7, 9);
        Console.WriteLine(r);
    }
}
using System;
interface IDrivable
{
    public string Started { get; }
    void Start();
    void Stop();
}
interface ISteerable
{
    void TurnLeft();
    void TurnRight();
}
interface IMovable: IDrivable, ISteerable
{
    void Accelerate();
    void Brake();
}
public class Car: IMovable
{
    public string started = "Bat dau";
    public string Started
    {
        get { return started; }
    }
    public void Start()
    {
        Console.WriteLine("Xe chay");
    }
    public void Stop()
    {
        Console.WriteLine("Xe dung");
    }
    public void TurnLeft() 
    {
        Console.WriteLine("Xe re trai");
    }
    public void TurnRight()
    {
        Console.WriteLine("Xe re phai");
    }
    public void Accelerate()
    {
        Console.WriteLine("Xe tang toc");
    }
    public void Brake()
    {
        Console.WriteLine("Xe phanh");
    }
}
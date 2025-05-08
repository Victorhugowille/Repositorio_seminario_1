using System;
public class Program
{
    public static void Main()
    {
        var carro = new Carro();
        carro.Speed = 40;
        carro.Aceleracao();

        Console.WriteLine ($"Speed: {carro.Speed}");
    }
}
public class Carro
{
    private int _speed;
    public int Speed 
    { 
             get{return _speed;}
             set{_speed = value;} 
    }
    public void Aceleracao()
    {
        _speed += 40;
    }
}
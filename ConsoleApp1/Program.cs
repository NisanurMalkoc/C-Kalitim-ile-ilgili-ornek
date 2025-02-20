using System;
class A
{
    virtual public void Metot()
    {
        Console.WriteLine("A sınıfı");
    }
}
class B : A
{
    override public void Metot()
    {
        Console.WriteLine("B sınıfı");
    }
}
class C : B
{
    public void Metot()
    {
        Console.WriteLine("C sınıfı");
    }
    static void Main()
    {
        A nesneA = new A();
        C nesneC = new C();
        nesneA = nesneC;
        nesneA.Metot();
    }
}

using System;
class A
{
    virtual public int ozellik
    {
        set { }
        get { return 12; }
    }
}
class B : A
{
    override public int ozellik
    {
        get { return 100; }
        set { Console.WriteLine("Bu bir denemedir"); }
    }
    static void Main()
    {
        B nesne = new B();
        A nesne2 = new A();
        nesne2 = nesne;
        Console.WriteLine(nesne2.ozellik);
        nesne2.ozellik = 200;
    }
}

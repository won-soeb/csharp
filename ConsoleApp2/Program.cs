class A
{
    protected A() { }
        ~A()
    {
        System.Console.WriteLine("A 소멸");
    }
}
class B : A
{
    static void Main()
    {
        B a = new B();
        System.GC.Collect();
    }
}
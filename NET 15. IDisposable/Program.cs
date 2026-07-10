// IDisposable

//MyClass my = new MyClass();
//my.Foo();
//Bar();
//GC.Collect();
//Console.WriteLine();
//MyClass my = new MyClass();
//try
//{
//    my.Foo();
//}
//finally
//{

//    my.Dispose();
//}

using (MyClass myObj = new MyClass())
{
    myObj.Foo();
}

void Bar() {
    MyClass my = new MyClass();
    my.Foo();    
}
class MyClass:IDisposable
{
    private bool _isDisposed;
    public MyClass()
    {
        Console.WriteLine("Construcor...");
    }

    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }
    public void Foo()
    {
        Console.WriteLine("Some Magic operations.. ");
        throw new Exception();
    }
    private void Cleaning(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Managed resoureces are cleaned");
            }
            Console.WriteLine("UnManaged resourse are cleaned");
            _isDisposed = true;
        }
    }
    ~MyClass()
    {
        Console.WriteLine("Finalizer");
        Cleaning(false);
    }
}
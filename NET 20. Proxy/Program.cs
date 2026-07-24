// Proxy

/*
 1. Protection Proxy
 2. Virtual Proxy (Lazy initialization)
 3. Remote Proxy (CDN)
 4. Logging Proxy
 5. Cashing Proxy 
*/

OperationProxy operationProxy = new(new RealOPerationSubject(), 2);
operationProxy.Request();

interface IOperation
{
    void Request();
}

// Real Subject (Real Service)
class RealOPerationSubject : IOperation
{
    public void Request()
    {
        Console.WriteLine("Some Real Operations");
    }
}

// Proxy (Proxy Service)
class OperationProxy : IOperation
{
    private IOperation _operation;
    private int _role;

    public OperationProxy(IOperation operation, int role)
    {
        _operation = operation;
        _role = role;
    }

    public void Request()
    {      
        if (_role == 1) { 
         _operation.Request();
        }
        else
        {
            Console.WriteLine("401 unauthorized");
        }
    }
}

// Exceptions
/*
Exception
    - SystemException
    - ApplictionException 
 
*/

int numb1 = 2;
int numb2 = 1;
int result = default;

try
{
    result = numb1 / numb2;
    Console.WriteLine(result);
    throw new Exception("Some Exception");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}
catch(NullReferenceException ex)
{
    Console.WriteLine();
}
class Linker : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        Console.WriteLine("Linker");
        Next?.Handle();
    }
}

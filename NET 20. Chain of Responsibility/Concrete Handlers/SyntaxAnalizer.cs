class SyntaxAnalizer : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        Console.WriteLine("Syntax analizer");
        Next?.Handle();
    }
}

class LexicalAnalizer : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        Console.WriteLine("Lexical analizer");
        return;
        Next?.Handle();
    }
}

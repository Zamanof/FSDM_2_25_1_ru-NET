// Chain of Responsibility
abstract class CompilerCoR: ICompiler
{
    protected CompilerCoR Next {  get; set; }

    public abstract void Handle();

    public CompilerCoR SetNext(CompilerCoR nextHandler)
    {
        Next = nextHandler;
        return this;
    }
}
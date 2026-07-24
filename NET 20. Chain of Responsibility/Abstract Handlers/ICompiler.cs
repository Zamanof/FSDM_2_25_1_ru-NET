// Chain of Responsibility

interface ICompiler
{
    CompilerCoR SetNext(CompilerCoR nextHandler);
    void Handle();
}

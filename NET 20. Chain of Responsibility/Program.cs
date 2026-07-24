// Chain of Responsibility
ICompiler compiler = new SyntaxAnalizer().SetNext(
                            new LexicalAnalizer().SetNext(
                                new Linker()
                                )
                            );


compiler.Handle();


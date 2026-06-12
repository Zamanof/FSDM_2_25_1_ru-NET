// class
// internal - class доступен только внутри assembly где она обявлена
// public   - class доступен любых assembly

class Human
{
    public string name;
    public string surname;
    public int age;

    #region access modifiers
/*
    public
    Доступен отовсюду.
    Класс, метод, свойство или поле можно использовать из любого места программы
    и из любых других проектов, если есть ссылка на сборку.

    private
    Доступен только внутри того класса, в котором объявлен.
    Из других классов получить к нему доступ нельзя.

    protected
    Доступен внутри текущего класса и во всех классах-наследниках.
    Из обычных объектов, не являющихся наследниками, доступ невозможен.

    internal
    Доступен только внутри текущей сборки (проекта).
    Из других проектов получить доступ нельзя, даже если они подключены.

    protected internal
    Доступен:
    - внутри текущей сборки;
    - а также в классах-наследниках, даже если они находятся в другой сборке.

    private protected
    Доступен:
    - внутри текущего класса;
    - в классах-наследниках;
    - только если они находятся в той же самой сборке (проекте).

    Если наследник находится в другой сборке,
    доступ к private protected членам невозможен.

    Проще говоря:
    public              -> доступ отовсюду
    private             -> только внутри своего класса
    protected           -> внутри класса и его наследников
    internal            -> только внутри текущего проекта (сборки)
    protected internal  -> внутри текущего проекта + в наследниках из других проектов
    private protected   -> внутри текущего проекта + только в наследниках
*/
    #endregion

    //public Human()
    //{
    //    name = string.Empty;
    //    surname = string.Empty;
    //    age = 0;
    //}
    public Human(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    // Finalizer - это не Деструктор!!!!!
    ~Human()
    {
        Console.WriteLine("Finalizer");
    }
}

// const
// readonly
// Property
// class
// internal - class доступен только внутри assembly где она обявлена
// public   - class доступен любых assembly


class Human
{
    public string name;
    public string surname;
    public int age;
    public readonly string bloodGroup;

    public static int count;
    public const double PI = 3.14;

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

    public Human()
        : this(string.Empty, string.Empty, default, "AA")
    {
        count++;
    }
    public Human(string name, string surname, int age, string blood)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        bloodGroup = blood;
        count++;
    }

    public Human(string name, string surname)
        : this(name, surname, default, "AA")
    {
        count++;
    }

    static Human()
    {
        count = 0;
    }

    //public static int GetObjectsCount() { return count; } 
    public static int GetObjectsCount() => count;


    //public void foo(int a) { age = a; } 
    public void foo(int a)
        => age = a;
    public void Show()
    {
    // Методы не должны зависеть от какой либо платформы.
    // В этом примере мы зависим от консоли.
    
        Console.WriteLine(@$"
name:           {name}
surname:        {surname}
age:            {age}
blood group:    {bloodGroup}");
    }

    public string Info() => @$"
name:           {name}
surname:        {surname}
age:            {age}
blood group:    {bloodGroup}";

    public override string ToString() =>
    @$"
name:           {name}
surname:        {surname}
age:            {age}
blood group:    {bloodGroup}";

    // Finalizer - это не Деструктор!!!!!
    ~Human()
    {
        Console.WriteLine("Finalizer");
    }
}

// const
// readonly
// Property
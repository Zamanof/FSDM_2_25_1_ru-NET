// Structs
/*
 1. struct обьекты создаются в stack
 
 2. Когда создаем конструктор с параметрами, конструктор по умолчанию не удаляеться

 3. В структурах копирование всегда глубокое копирование(deep copy) (копируются значения)

 4.  От структур невозможно наследоватся   
*/

struct Point
{
    public int x;
    public int y;
    public int[] arr = [25, 78];
    
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point()
    {
        x = 0;
        y = 0;
    }
}



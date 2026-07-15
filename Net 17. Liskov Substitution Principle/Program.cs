/*
3. Liskov substitution principle - Принцип подстановки Лисков
                                   функции, которые используют базовый тип, 
                                   должны иметь возможность использовать подтипы 
                                   базового типа не зная об этом 
*/

Rectangle rectangle = new(width: 22, height: 30);
Console.WriteLine(Calcualate.RectangleArea(rectangle));
rectangle.Width = 15;
Console.WriteLine(Calcualate.RectangleArea(rectangle));
Console.WriteLine();

Rectangle square = new Square(20);
Console.WriteLine(Calcualate.RectangleArea(square));
square.Width = 35;
Console.WriteLine(Calcualate.RectangleArea(square));

double CalculateArea(Rectangle rectangle)
{
    return Calcualate.RectangleArea(rectangle);
}

#region Bad Example
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//}

//class Square : Rectangle
//{
//    public Square(double side) 
//        : base(side, side)
//    {
//    }
//}

//class Calcualate
//{
//    public static double RectangleArea(Rectangle rectangle)
//        => rectangle.Width * rectangle.Height;
//}
#endregion

#region Bad Example
class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

}

class Square : Rectangle
{
    public override double Height 
    { 
        get=> base.Height;
        set 
        {  
            base.Height = value;
            base.Width = value;
        }
        
    }
    public override double Width
    {
        get => base.Height;
        set
        {
            base.Height = value;
            base.Width = value;
        }

    }
    public Square(double side)
        : base(side, side)
    {
    }
}

class Calcualate
{
    public static double RectangleArea(Rectangle rectangle)
        => rectangle.Width * rectangle.Height;
}
#endregion

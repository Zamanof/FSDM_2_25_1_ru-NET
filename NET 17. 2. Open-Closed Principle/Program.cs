/*
 * 2. Open-Closed Principle - Принцип открытости/закрытости программные сущности … должны быть 
                           открыты для расширения, но закрыты для модификации.
 
*/

#region Bad Example

//object[] shapes = [
//    new Rectangle(){Width = 35,  Height = 21},
//    new Rectangle(){Width = 13,  Height = 27},
//    new Circle(){Radius = 125.6}
//    ];
//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    public double Height { get; set; }
//    public double Base { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (var shape in shapes)
//        {
//            if (shape is Rectangle rect)
//            {
//                areas += rect.Width * rect.Height;
//            }
//            else if (shape is Circle circle)
//            {
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            }
//            else if ((shape is Triangle triangle){
//                areas += 0.5 * triangle.Base * triangle.Height;
//            }
//        }
//        return areas;
//    }
//}
#endregion

#region Good example
Shape[] shapes = [
    new Rectangle(){Width = 35,  Height = 21},
    new Rectangle(){Width = 13,  Height = 27},
    new Circle(){Radius = 125.6},
    new Triangle(){Height = 25, Base = 25},
    new Trapezoid(){Height = 25, SideA = 25, SideB=32}
    ];

Calculate Calculate = new Calculate();
Console.WriteLine(Calculate.Areas(shapes)); 
abstract class Shape
{
    public abstract double Area();
}

class Rectangle: Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width*Height;
    }
}

class Circle: Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}

class Triangle: Shape
{
    public double Height { get; set; }
    public double Base { get; set; }

    public override double Area()
    {
        return 0.5 * Base * Height;
    }
}

class Trapezoid : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double Height { get; set; }

    public override double Area()
     => 0.5* (SideA + SideB) * Height;
}

class Fondemortano: Shape
{
    public double Smelta { get; set; }
    public double Mozzi { get; set; }
    public double Zupande { get; set; }

    public override double Area()
     => (Math.Cos(Smelta) + Math.Tan(Mozzi)) / Zupande;
}
class Calculate
{
    public double Areas(Shape[] shapes)
        => shapes.Sum(x => x.Area());

}

#endregion


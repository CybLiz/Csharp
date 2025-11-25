
using Figure.Classes;

class Program
{
    static void Main(string[] args)
    {
        Carre carre = new Carre(new Point(0, 0), 5);
        Rectangle rectangle = new Rectangle(new Point(10, 10), 4, 6);
        Triangle triangle = new Triangle(new Point(20, 20), 5, 8);

        Console.WriteLine("Avant déplacement :");
        Console.WriteLine(carre);
        Console.WriteLine(rectangle);
        Console.WriteLine(triangle);

        carre.Deplacement(2, 3);
        rectangle.Deplacement(-1, 7);
        triangle.Deplacement(0, -2);

        Console.WriteLine("\nAprès déplacement :");
        Console.WriteLine(carre);
        Console.WriteLine(rectangle);
        Console.WriteLine(triangle);


    }
}
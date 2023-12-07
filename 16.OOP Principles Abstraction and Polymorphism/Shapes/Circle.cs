using System;
using Shapes;
public class Circle : IDrawable
{
    private int radus;

    public Circle (int radus)
    {
        this.radus = radus;
    }

    public void Draw()
    {
        double rIn = this.radus - 0.4;
        double rOut = this.radus + 0.4;
        for (double y = this.radus; y >= -this.radus; --y) 
        {
            for (double x = -this.radus; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;

                if (value >= rIn * rIn && value <= rOut * rOut) 
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
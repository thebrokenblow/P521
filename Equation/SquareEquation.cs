namespace Equation;

public class SquareEquation
{
    public static string Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    return "Бесконечное число корней";
                }
                else
                {
                    return "Нет решений";
                }
            }
            else
            {
                var x = -c / b;
                return $"x = {x}";
            }
        }

        var D = b * b - 4 * a * c;

        if (D > 0)
        {
            var x1 = (-b + Math.Sqrt(D)) / (2 * a);
            var x2 = (-b - Math.Sqrt(D)) / (2 * a);

            return $"x1 = {x1}, x2 = {x2}";
        }
        else if (D == 0)
        {
            var x = -b / (2 * a);

            return $"x = {x}";
        }

        return "нет корней x > R";
    }
}

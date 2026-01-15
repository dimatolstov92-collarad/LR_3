using System;
using System.IO;

class Program
{
    static void Main()
    {

        string[] lines = File.ReadAllLines("C:\\Users\\User\\source\\repos\\LR_3\\input.txt");

        double x = double.Parse(lines[0]);
        double y = double.Parse(lines[1]);
        int n = int.Parse(lines[2]);

        double z = 0.0;

        for (int k = 1; k <= n; k++)
        {
            double sign = (k % 2 == 1) ? 1 : -1;

            double numerator = Math.Pow(x, 2 * (k - 1)) * Math.Pow(y, k - 1);
            double denominator = k * (k + 2);

            z += sign * numerator / denominator;
        }


        File.WriteAllText("output.txt", z.ToString());
    }
}
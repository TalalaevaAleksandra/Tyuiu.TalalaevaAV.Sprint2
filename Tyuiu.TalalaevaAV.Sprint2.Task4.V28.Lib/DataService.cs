﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TalalaevaAV.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            double res = x < y*2-10 ? Math.Pow((1 + (y + 2) / (x * x)), x) : (2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 12) / (Math.Pow(y, 2) - Math.Sin(x*x) + 9);
            return Math.Round(res,3);
        }
    }
}

using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                res *= (x / Math.Sin(x)) + 0.5;
            }

            return Math.Round(res, 3);
        }
    }
}
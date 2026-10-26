using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                multiplySeries *= 1 / Math.Pow((Math.Cos(5) + 1), 2);
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
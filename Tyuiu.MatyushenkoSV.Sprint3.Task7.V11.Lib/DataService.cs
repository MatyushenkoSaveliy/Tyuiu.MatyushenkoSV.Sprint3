using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - 2 * x) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;
                    valueArray[count] = Math.Round(y, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}
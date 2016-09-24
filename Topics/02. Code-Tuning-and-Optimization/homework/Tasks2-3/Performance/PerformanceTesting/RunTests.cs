namespace PerformanceTesting
{
    using System;
    using System.Diagnostics;

    public class RunTests
    {
        public static void Main(string[] args)
        {
            double addingIntegersTime = GetAverageTimeForAddingNumber(new GenericNumber((int)1));
            double subtractgIntegersTime = GetAverageTimeForSubtractNumber(new GenericNumber((int)1));
            double multiplyIntegersTime = GetAverageTimeForMultiplyNumber(new GenericNumber((int)1));
            double divideIntegersTime = GetAverageTimeForDivideNumber(new GenericNumber((int)1));

            Console.WriteLine("Average time for adding integers is: {0}", addingIntegersTime);
            Console.WriteLine("Average time for subtract integers is: {0}", subtractgIntegersTime);
            Console.WriteLine("Average time for multiply integers is: {0}", multiplyIntegersTime);
            Console.WriteLine("Average time for divide integers is: {0}\n", divideIntegersTime);

            double addingDoublesTime = GetAverageTimeForAddingNumber(new GenericNumber((double)1));
            double subtractgDoublesTime = GetAverageTimeForSubtractNumber(new GenericNumber((double)1));
            double multiplyDoublesTime = GetAverageTimeForMultiplyNumber(new GenericNumber((double)1));
            double divideDoublesTime = GetAverageTimeForDivideNumber(new GenericNumber((double)1));

            Console.WriteLine("Average time for adding doubles is: {0}", addingDoublesTime);
            Console.WriteLine("Average time for subtract doubles is: {0}", subtractgDoublesTime);
            Console.WriteLine("Average time for multiply doubles is: {0}", multiplyDoublesTime);
            Console.WriteLine("Average time for divide doubles is: {0}\n", divideDoublesTime);

            double addingLongsTime = GetAverageTimeForAddingNumber(new GenericNumber((long)1));
            double subtractgLongsTime = GetAverageTimeForSubtractNumber(new GenericNumber((long)1));
            double multiplyLongsTime = GetAverageTimeForMultiplyNumber(new GenericNumber((long)1));
            double divideLongsTime = GetAverageTimeForDivideNumber(new GenericNumber((long)1));

            Console.WriteLine("Average time for adding longs is: {0}", addingLongsTime);
            Console.WriteLine("Average time for subtract longs is: {0}", subtractgLongsTime);
            Console.WriteLine("Average time for multiply longs is: {0}", multiplyLongsTime);
            Console.WriteLine("Average time for divide longs is: {0}\n", divideLongsTime);

            double addingFloatsTime = GetAverageTimeForAddingNumber(new GenericNumber((float)1));
            double subtractgFloatsTime = GetAverageTimeForSubtractNumber(new GenericNumber((float)1));
            double multiplyFloatsTime = GetAverageTimeForMultiplyNumber(new GenericNumber((float)1));
            double divideFloatsTime = GetAverageTimeForDivideNumber(new GenericNumber((float)1));

            Console.WriteLine("Average time for adding floats is: {0}", addingFloatsTime);
            Console.WriteLine("Average time for subtract floats is: {0}", subtractgFloatsTime);
            Console.WriteLine("Average time for multiply floats is: {0}", multiplyFloatsTime);
            Console.WriteLine("Average time for divide floats is: {0}\n", divideFloatsTime);

            double addingDecimalsTime = GetAverageTimeForAddingNumber(new GenericNumber((decimal)1));
            double subtractgDecimalsTime = GetAverageTimeForSubtractNumber(new GenericNumber((decimal)1));
            double multiplyDecimalsTime = GetAverageTimeForMultiplyNumber(new GenericNumber((decimal)1));
            double divideDecimalsTime = GetAverageTimeForDivideNumber(new GenericNumber((decimal)1));

            Console.WriteLine("Average time for adding decimals is: {0}", addingDecimalsTime);
            Console.WriteLine("Average time for subtract decimals is: {0}", subtractgDecimalsTime);
            Console.WriteLine("Average time for multiply decimals is: {0}", multiplyDecimalsTime);
            Console.WriteLine("Average time for divide decimals is: {0}\n", divideDecimalsTime);
        }

        private static double GetAverageTimeForAddingNumber(GenericNumber number)
        {
            dynamic sum = 0;
            dynamic sumator = number.Value;
            int mesuresCount = 1000;
            int addingsCount = 10000;
            double totalSumOfTimes = 0;
            for (int i = 0; i < mesuresCount; i++)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 0; j < addingsCount; j++)
                {
                    sum = sumator + sumator;
                }

                stopWatch.Stop();
                totalSumOfTimes += stopWatch.Elapsed.TotalMilliseconds;
            }

            double averageTime = totalSumOfTimes / mesuresCount;

            return averageTime;
        }

        private static double GetAverageTimeForSubtractNumber(GenericNumber number)
        {
            dynamic sum = 0;
            dynamic sumator = number.Value;
            int mesuresCount = 1000;
            int addingsCount = 10000;
            double totalSumOfTimes = 0;
            for (int i = 0; i < mesuresCount; i++)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 0; j < addingsCount; j++)
                {
                    sum = sumator - sumator;
                }

                stopWatch.Stop();
                totalSumOfTimes += stopWatch.Elapsed.TotalMilliseconds;
            }

            double averageTime = totalSumOfTimes / mesuresCount;

            return averageTime;
        }

        private static double GetAverageTimeForMultiplyNumber(GenericNumber number)
        {
            dynamic result = number.Value;
            dynamic sumator = number.Value;
            int mesuresCount = 1000;
            int addingsCount = 10000;
            double totalSumOfTimes = 0;
            for (int i = 0; i < mesuresCount; i++)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 0; j < addingsCount; j++)
                {
                    result = sumator * sumator;
                }

                stopWatch.Stop();
                totalSumOfTimes += stopWatch.Elapsed.TotalMilliseconds;
            }

            double averageTime = totalSumOfTimes / mesuresCount;

            return averageTime;
        }

        private static double GetAverageTimeForDivideNumber(GenericNumber number)
        {
            dynamic result = number.Value;
            dynamic sumator = number.Value;
            int mesuresCount = 1000;
            int addingsCount = 10000;
            double totalSumOfTimes = 0;
            for (int i = 0; i < mesuresCount; i++)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 0; j < addingsCount; j++)
                {
                    result = sumator / sumator;
                }

                stopWatch.Stop();
                totalSumOfTimes += stopWatch.Elapsed.TotalMilliseconds;
            }

            double averageTime = totalSumOfTimes / mesuresCount;

            return averageTime;
        }
    }
}

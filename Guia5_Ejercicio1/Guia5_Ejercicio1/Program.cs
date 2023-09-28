using System;

class Program
{
    static void Main(string[] args)
    {
        int[] years = new int[10] { 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

        foreach (int year in years)
        {
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine($"¿El {year} es año bisiesto?: {isLeap}");
        }
    }
}


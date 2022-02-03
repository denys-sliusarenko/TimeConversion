// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        string result = TimeConversion.TimeConversion.GetTimeConversion(s);

        Console.WriteLine(result);
        Console.ReadKey();
    }

    //public static string GetTimeConversion(string dateString)
    //{
    //    if (ValidationDateString(dateString))
    //    {
    //        return DateTime.Parse(dateString).ToString("HH:mm:ss");
    //    }
    //    throw new FormatException(string.Format("Unable to parse '{0}'.", dateString));
    //}

    //private static bool ValidationDateString(string dateString)
    //{
    //    string dateStringPattern= @"^(1[0-2]|0?[0-9]):([0-5]?[0-9]):([0-5]?[0-9]) ((AM)|(am)|(PM)|(pm))$";
    //    Regex regex = new Regex(dateStringPattern);
    //    return regex.IsMatch (dateString);
    //}
}
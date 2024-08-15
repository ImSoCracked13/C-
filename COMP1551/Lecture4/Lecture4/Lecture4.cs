using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MonthName
{
    // Private data 
    private int month = 1;

    public int Month
    {
        get { return month; }
        set { if ((value > 0)) && (value < 13)) { month = value; } }
    }
}
public class MyClass
{
    public static void Main(string[] args)
    {
        String S;
        System.Globalization.DateTimeFormatInfo Months = new System.Globalization.DateTimeFormatInfo();
        MonthName a = new MonthName();

        a.Month = 3;
        S = Convert .ToString(Months.GetMonthName(a.Month));
        Console.WriteLine("The month is: {0}", S);
    }
}

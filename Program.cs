using System.Globalization;

Console.WriteLine("Hello, World!");

var date = DateTime.Now;
var dayOfWeek = date.DayOfWeek;
Console.WriteLine($"{dayOfWeek}");
Console.WriteLine($"{date.ToString(CultureInfo.CurrentCulture)}");
Console.WriteLine(CultureInfo.CurrentCulture);

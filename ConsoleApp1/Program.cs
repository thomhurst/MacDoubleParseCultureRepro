
using System.Globalization;

var cultureInfo = new CultureInfo("de-AT");

Thread.CurrentThread.CurrentCulture = cultureInfo;
Thread.CurrentThread.CurrentUICulture = cultureInfo;

try
{
    _ = double.Parse("3.5");
    throw new Exception("Format exception not raised.");
}
catch (FormatException e)
{
    Console.WriteLine("Expected FormatException: " + e.Message);
}
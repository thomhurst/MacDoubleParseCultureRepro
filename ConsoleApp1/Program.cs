
using System.Globalization;
using System.Text.Json;

var cultureInfo = new CultureInfo("de-AT");

Thread.CurrentThread.CurrentCulture = cultureInfo;
Thread.CurrentThread.CurrentUICulture = cultureInfo;

try
{
    Console.WriteLine(JsonSerializer.Serialize(NumberFormatInfo.GetInstance(cultureInfo), new JsonSerializerOptions { WriteIndented = true }));
    _ = double.Parse("3.5");
    throw new Exception("Format exception not raised.");
}
catch (FormatException e)
{
    Console.WriteLine("Expected FormatException: " + e.Message);
}

using System.Globalization;

var cultureInfo = new CultureInfo("de-AT");

Thread.CurrentThread.CurrentCulture = cultureInfo;
Thread.CurrentThread.CurrentUICulture = cultureInfo;

_ = double.Parse("3,5");
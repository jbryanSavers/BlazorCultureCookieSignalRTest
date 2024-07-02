using System.Globalization;

namespace BlazorCultureInfoTest.Components
{
    public class CommonConstantsAndReadOnlys
    {
        public static List<CultureInfo> CustomCultures { get; set; } = new List<CultureInfo>()
        {
            new CultureInfo("en-US", false) { DateTimeFormat = { ShortDatePattern = "MM/dd/yyyy" } },
            new CultureInfo("fr-CA", false) { DateTimeFormat = { ShortDatePattern = "yyyy-MM-dd" } }
        };
    }
}

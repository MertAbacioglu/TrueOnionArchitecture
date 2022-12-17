using System.Globalization;
using System.Net.Mail;

namespace TrueOnion.API;

public static class Helpers
{
    // ülke kodlarını listede göster
    public static List<string> GetCountryCodes()
    {
        List<string> countryCodes = new List<string>();
        foreach (CultureInfo item in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
        {
            RegionInfo region = new RegionInfo(item.LCID);
            if (!(countryCodes.Contains(region.TwoLetterISORegionName)))
            {
                countryCodes.Add(region.TwoLetterISORegionName);
            }
        }

        return countryCodes;
    }
}
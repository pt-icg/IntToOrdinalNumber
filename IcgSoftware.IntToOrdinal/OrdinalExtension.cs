using System.Globalization;

namespace IcgSoftware.IntToOrdinal
{
    public static class OrdinalExtension
    {
        public static string ToOrdinalString(this int number)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter();
            return ordinalConverter.ToOrdinalString(number);
        }

        public static string ToOrdinalString(this int number, Gender gender)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter();
            return ordinalConverter.ToOrdinalString(number, gender);
        }

        public static string ToOrdinalString(this int number, CultureInfo cultureInfo)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter(cultureInfo);
            return ordinalConverter.ToOrdinalString(number);
        }

        public static string ToOrdinalString(this int number, Gender gender, CultureInfo cultureInfo)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter(cultureInfo);
            return ordinalConverter.ToOrdinalString(number, gender);
        }

    }
}


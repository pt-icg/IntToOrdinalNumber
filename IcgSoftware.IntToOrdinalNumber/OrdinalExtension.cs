using System.Globalization;

namespace IcgSoftware.IntToOrdinalNumber
{
    public static class OrdinalExtension
    {
        public static string ToOrdinalNumber(this int number)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter();
            return ordinalConverter.ToOrdinalNumber(number);
        }

        public static string ToOrdinalNumber(this int number, Gender gender)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter();
            return ordinalConverter.ToOrdinalNumber(number, gender);
        }

        public static string ToOrdinalNumber(this int number, CultureInfo cultureInfo)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter(cultureInfo);
            return ordinalConverter.ToOrdinalNumber(number);
        }

        public static string ToOrdinalNumber(this int number, Gender gender, CultureInfo cultureInfo)
        {
            OrdinalConverter ordinalConverter = new OrdinalConverter(cultureInfo);
            return ordinalConverter.ToOrdinalNumber(number, gender);
        }

    }
}


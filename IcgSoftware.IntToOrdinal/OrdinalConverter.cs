using System;
using System.Globalization;
using System.Text;

namespace IcgSoftware.IntToOrdinal
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Ordinal_indicator
    /// </summary>
    public class OrdinalConverter
    {
        private const string DEFAULT_INDICATOR = ".";

        public CultureInfo CultureInfo { get; set; }
        public Gender DefaultGender { get; set; } = Gender.MALE;

        public OrdinalConverter()
        {
            CultureInfo = CultureInfo.DefaultThreadCurrentUICulture;
            if (CultureInfo == null)
                CultureInfo = CultureInfo.CurrentUICulture;
        }

        public OrdinalConverter(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo;
        }

        public string ToOrdinalString(int number)
        {
            return ToOrdinalString(number, DefaultGender);
        }

        public string ToOrdinalString(int number, Gender gender)
        {
            return ToOrdinalString(number, gender, CultureInfo);
        }

        public string ToOrdinalString(int number, CultureInfo cultureInfo)
        {
            return ToOrdinalString(number, DefaultGender, cultureInfo);
        }

        /// <summary>
		/// suported cultures: "en", "es", "fr", "nl", "it", "pt", "ga", "ja", "zh", "ca"
        /// default ordinal: '.' e.g. "7."
		/// </summary>
        public string ToOrdinalString(int number, Gender gender, CultureInfo cultureInfo)
        {
            string language = cultureInfo.TwoLetterISOLanguageName;
            switch (language)
            {
                case "en":
                    return Formatter_en(number);
                case "es":
                    return Formatter_es(number, gender);
                case "fr":
                    return Formatter_fr(number, gender);
                case "nl":
                    return Formatter_nl(number);
                case "it":
                    return Formatter_it(number, gender);
                case "pt":
                    return Formatter_pt(number, gender);
                case "ga":
                    return Formatter_ga(number);
                case "ja":
                    return Formatter_ja(number);
                case "zh":
                    return Formatter_zh(number);
                case "ca":
                    return Formatter_ca(number, gender);
                default:
                    return $"{number}{DEFAULT_INDICATOR}";
            }
        }
        private string Formatter_en(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            int hundredModule = number % 100;
            int decimalModule = number % 10;

            if (11 <= hundredModule && hundredModule <= 13)
            {
                stringBuilder.Append("th");
            }
            else
            {
                switch (decimalModule)
                {
                    case 1:
                        stringBuilder.Append("st");
                        break;
                    case 2:
                        stringBuilder.Append("nd");
                        break;
                    case 3:
                        stringBuilder.Append("rd");
                        break;
                    default:
                        stringBuilder.Append("th");
                        break;
                }
            }

            return stringBuilder.ToString();
        }

        private string Formatter_es(int number, Gender gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (Gender.MALE == gender)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (Gender.FEMALE == gender)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_fr(int number, Gender gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (number == 1)
            {
                if (Gender.MALE == gender)
                {
                    stringBuilder.Append("er");
                }
                else if (Gender.FEMALE == gender)
                {
                    stringBuilder.Append("re");
                }
            }
            else
            {
                stringBuilder.Append("e");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_nl(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("e");

            return stringBuilder.ToString();
        }

        private string Formatter_it(int number, Gender gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (Gender.MALE == gender)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (Gender.FEMALE == gender)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_pt(int number, Gender gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (Gender.MALE == gender)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (Gender.FEMALE == gender)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_ga(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u00FA");

            return stringBuilder.ToString();
        }

        private string Formatter_ja(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u756A");

            return stringBuilder.ToString();
        }

        private string Formatter_zh(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u7B2C");

            return stringBuilder.ToString();
        }

        private string Formatter_ca(int number, Gender gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (Gender.MALE == gender)
            {
                switch (number)
                {
                    case 1:
                        stringBuilder.Append("r");
                        break;
                    case 2:
                        stringBuilder.Append("n");
                        break;
                    case 3:
                        stringBuilder.Append("r");
                        break;
                    case 4:
                        stringBuilder.Append("t");
                        break;
                    default:
                        stringBuilder.Append("è");
                        break;
                }
            }
            else if (Gender.FEMALE == gender)
            {
                stringBuilder.Append("a");
            }

            return stringBuilder.ToString();
        }
    }

    public enum Gender
    {
        MALE,
        FEMALE
    }
}

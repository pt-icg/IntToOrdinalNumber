using System;
using System.Globalization;
using System.Text;
using IcgSoftware.IntToOrdinalNumber;

namespace IcgSoftware.IntToOrdinalNumberSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 20, 21, 50, 100 };
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            Console.WriteLine("{0} [{1}]", "CurrentCulture", cultureInfo.EnglishName, cultureInfo.TwoLetterISOLanguageName);

            Console.WriteLine();
            Console.WriteLine("Ordinal Numbers Extension Sample".ToUpper());
            OrdinalNumbersExtensionSample(numbers);
            OrdinalNumbersExtensionSample(numbers, "en");
            OrdinalNumbersExtensionSample(numbers, "es");
            OrdinalNumbersExtensionSample(numbers, "fr");
            OrdinalNumbersExtensionSample(numbers, "de");
            OrdinalNumbersExtensionSample(numbers, "ja");

            Console.WriteLine();
            Console.WriteLine("Ordinal Numbers Sample".ToUpper());
            OrdinalNumbersSample(numbers);
            OrdinalNumbersSample(numbers, "en");
            OrdinalNumbersSample(numbers, "es");
            OrdinalNumbersSample(numbers, "fr");
            OrdinalNumbersSample(numbers, "de");
            OrdinalNumbersSample(numbers, "ja");

            Console.ReadLine();
        }

        private static void OrdinalNumbersSample(int[] numbers, string culture = "")
        {
            if (string.IsNullOrWhiteSpace(culture))
            {
                Console.WriteLine("culture not set");
            }
            else
            {
                CultureInfo cultureInfo = new CultureInfo(culture);
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
                Console.WriteLine("{0} [{1}]", cultureInfo.EnglishName, cultureInfo.TwoLetterISOLanguageName);
            }

            Console.WriteLine("{0,10} {1,10} {2,10}", "default", "male", "female");
            OrdinalConverter ordinalConverter = new OrdinalConverter();
            foreach (var number in numbers)
            {
                Console.WriteLine("{0,10} {1,10} {2,10}", ordinalConverter.ToOrdinalNumber(number), ordinalConverter.ToOrdinalNumber(number, Gender.MALE), ordinalConverter.ToOrdinalNumber(number, Gender.FEMALE));
            }
            Console.WriteLine();
        }

        private static void OrdinalNumbersExtensionSample(int[] numbers, string culture = "")
        {

            if (string.IsNullOrWhiteSpace(culture))
            {
                Console.WriteLine("culture not set");
            }
            else
            {
                Console.WriteLine($"culture {culture}");
            }

            Console.WriteLine("{0,10} {1,10} {2,10}", "default", "male", "female");
            foreach (var number in numbers)
            {
                if (string.IsNullOrWhiteSpace(culture))
                {
                    Console.WriteLine("{0,10} {1,10} {2,10}", number.ToOrdinalNumber(), number.ToOrdinalNumber(Gender.MALE), number.ToOrdinalNumber(Gender.FEMALE));
                }
                else
                {
                    CultureInfo cultureInfo = new CultureInfo(culture);
                    Console.WriteLine("{0,10} {1,10} {2,10}", number.ToOrdinalNumber(cultureInfo), number.ToOrdinalNumber(Gender.MALE, cultureInfo), number.ToOrdinalNumber(Gender.FEMALE, cultureInfo));
                }

            }
            Console.WriteLine();
        }

    }

}

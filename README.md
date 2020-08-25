# IntToOrdinal

A .NET Standard class library that converts int numbers to ordinal strings with multi language support

Thanks to [casaucao / OrdinalNumbers](https://github.com/casaucao/OrdinalNumbers).

Supported languages:

| Language   | Culture |
| ---------- | ------- |
| Catalan    | ca      |
| Chinese    | za      |
| Dutch      | nl      |
| English    | en      |
| French     | fr      |
| Irish      | ga      |
| Italian    | it      |
| Japanese   | ja      |
| Portuguese | pt      |
| Spanish    | es      |

Other languages are supported with the standard. The standard ordinal indicator is a dot. The dot '.' is e.g. used in the German [de].


### Usage example
```csharp
17.ToOrdinalString();
17.ToOrdinalString(cultureInfo);
17.ToOrdinalString(Gender.FEMALE, cultureInfo);

int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 20, 21, 50, 100 };
OrdinalConverter ordinalConverter = new OrdinalConverter();
foreach (var number in numbers)
{
    Console.WriteLine("{0,10} {1,10} {2,10}", ordinalConverter.ToOrdinalString(number), ordinalConverter.ToOrdinalString(number, Gender.MALE), ordinalConverter.ToOrdinalString(number, Gender.FEMALE));
}

```

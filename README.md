# Uebung-021  --  Leap Year Checker

## Lernziele:
- Boolsche Variablen
- Modulo

## Aufgabenstellung:
Schreiben Sie Ein C# Programm, welches überprüft ob das eingegebene Jahr ein Schaltjahr ist.  
Eingaben < 0 sind als fehlerhafte Eingabe zu behandeln.   

### Beispielausgabe:
![bsp](https://github.com/IxI-Enki/Uebung-021/assets/138018029/03571aa1-fe09-46ca-8177-95d10b38cc49)


-------------------------------
## *Zusatzaufgabe:*
Wiederholen Sie die Schaltjahrprüfung solange bis das Jahr 0 eingegeben wird.  
Die Ausgabe hat sich an die Vorgabe zu orientieren:

![zusatz](https://github.com/IxI-Enki/Uebung-021/assets/138018029/efdd7b77-4a5b-4b41-b85c-4727d8e131a4)



-------------------------------
# **SPOILER**

## C# Code:

```c#
namespace LeapYearChecker
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /// VARIABLES
      int year;
      string userInput;
      Console.Clear();
      Console.Write($"\n Geben Sie ein Jahr ein  ");
      /// USER INPUT
      userInput = Console.ReadLine();
      if (int.TryParse(userInput, out year))
      {
        Console.Write($"\n Ihr Jahr: {year}");
        /// test if entered year is divedable by 4
        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
          Console.Write("\n Ihr Jahr ist ein Schaltjahr.");
        }
        else
          Console.Write("\n Ihr Jahr ist kein Schaltjahr. ");
      }
      else
        Console.Write("\n Sie haben keine gültige Jahreszahl eingegeben!");

      ///  EXIT PROMPT
      Console.Write("\n══════════════════════════════════" +
                    "\n Beenden mit beliebiger Taste ... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
```


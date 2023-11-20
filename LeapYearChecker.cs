/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF
 *------------------------------------------------------------------------------
 *                      Jan Ritt
 *------------------------------------------------------------------------------
 *  Description:  The Program reads in a year and outputs if it is a leapyear.
 *------------------------------------------------------------------------------
*/

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
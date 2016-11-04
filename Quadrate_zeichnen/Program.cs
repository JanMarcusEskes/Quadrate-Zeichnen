using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrate_zeichnen
{
  class Program
  {
    static void Main(string[] args)
    {
      int breite, rand;
      char lücke = 'X';

      Console.Write("Aussengrenze: ");
      if (int.TryParse(Console.ReadLine(), out breite) == false || breite < 1 || breite > 25)
      { Console.WriteLine("Sie haben einen nicht zugelassenen Wert eingegeben!"); Console.Read(); return; }

      Console.Write("Randbreite  : ");
      if (int.TryParse(Console.ReadLine(), out rand) == false || rand < 0 || rand > 25)
      { Console.WriteLine("Sie haben einen nicht zugelassenen Wert eingegeben!"); Console.Read(); return; }

      if (breite <= rand * 2)
      { Console.WriteLine("Der Rand wäre breiter als das Quadrat und wird dadurch ignoriert"); }

      Console.WriteLine();

      for (int zeile = 0; zeile < breite; zeile++)
      {
        if (zeile < rand || zeile >= breite - rand)
        {
          Console.WriteLine(new string(lücke, breite));
        }
        else
        {
          Console.WriteLine(new string(lücke, rand) + new string(' ', breite - rand * 2) + new string(lücke, rand));
        }
      }
      Console.Read();
    }
  }
}

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
      int.TryParse(Console.ReadLine(), out breite);
      Console.Write("Randbreite  : ");
      int.TryParse(Console.ReadLine(), out rand);

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

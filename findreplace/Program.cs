using System;
using System.IO;
using System.Text;

namespace findreplace
{
  internal class FindReplace
  {
    #region Metody

    private static void Main(string[] args)
    {
      Console.InputEncoding = Encoding.UTF8;
      Console.OutputEncoding = Encoding.UTF8;

      if (args.Length < 3 || (args.Length - 1) % 2 != 0)
      {
        Console.WriteLine("USAGE: findreplace.exe FIND~1 REPLACE~1 FIND~2 REPLACE~2 ... FIND~N REPLACE~N INPUT-FILE");
        Environment.ExitCode = -1;
        return;
      }

      string fileContents = File.ReadAllText(args[args.Length - 1], Encoding.UTF8);

      for (int i = 0; i < args.Length - 1; i += 2)
      {
        fileContents = fileContents.Replace(args[i], args[i + 1]);
      }

      File.WriteAllText(args[args.Length - 1], fileContents, Encoding.UTF8);
    }

    #endregion Metody
  }
}
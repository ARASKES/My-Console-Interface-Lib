using System;
using System.Collections.Generic;

namespace InterfaceLib
{
  public class Lib
  {
    static public void CallInterface(params string[] allActions)
    {
      void DrawBorder()
      {
        for (int i = 0; i < Console.WindowWidth; i++)
        {
          Console.Write("=");
        }
      }
      void NewLine()
      {
        Console.Write("|");
        for (int i = 0; i < Console.WindowWidth - 2; i++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
      }
      void AddActions(string[] actions)
      {
        for (int i = 0; i < actions.Length; i++)
        {
          Console.Write($"| {i + 1}. {actions[i]}");
          for (int j = 0; j < Console.WindowWidth - actions[i].Length - (i + 1).ToString().Length - 5; j++)
          {
            Console.Write(" ");
          }
          Console.Write("|");
          NewLine();
        }
      }

      DrawBorder();
      NewLine();
      AddActions(allActions);
      DrawBorder();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("{0, 79}", "exit - close the program");
      Console.ResetColor();
      Console.Write("> ");
    }
    static public void GameOver()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\n\n\n\n\n\n");
      Console.WriteLine("{0, 45}", "GAME OVER");
      Console.ResetColor();
      Console.Beep();
      Console.ReadKey();
    }
  }
}
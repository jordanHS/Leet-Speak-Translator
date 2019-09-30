using System;
using LeetSpeak.Models;
namespace LeetSpeak
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Leet Speak Translator!");
      Console.WriteLine("Enter some text to translate:");
      string input = Console.ReadLine();
      LeetSpeakTranslator translator = new LeetSpeakTranslator();
      string output = translator.Translate(input);
      Console.WriteLine(output);
    }
  }
}

// import
using System;
using System.Collections.Generic;
using System.Threading;

// Project name and 'folder' that holds everything
namespace CSharpDay1
{
  // Singleton and is instantiated by the Dotnet Core Runner
  class Program
  {
    // Program for a console app only has the one method 'Main' and it will be invoked by Dotnet Core
    static void Main(string[] args)
    {
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Clear();

      // Implicit Typing
      var x = 9;

      // Explicit Typing
      // string name = "Mark";
      bool j = false;



      // STRINGS
      // console.log()
      // Concatenation
      Console.WriteLine("Hello World" + ':' + " I am the Computer");

      // Interpolation
      // Console.WriteLine($"Hello {name}");
      // Console.WriteLine("Hello {0}. How does a computer eat? It {2}", name, "welcome", "bytes");
      // Console.WriteLine("How do you get pikachu on a bus?");
      // Thread.Sleep(1000);
      // Console.WriteLine("You Poke-em-on");

      // Numbers
      // INT (Whole Numbers abs(2,147,483,648))
      int age = 32;
      // float/double (Decimals without high precision)
      float y = 3.5f;
      double z = 4.56d;
      // decimal (Highest precision a number can hold in C#)
      decimal velocity = 234234234.23423432m;


      // Bool Exactally the Same true/false
      // Conditionals must have a bool value (No more Truthy/Falsy)
      //   if (age == "32") cannot evaluate disparate types
      //   {

      //   }

      // NO UNDEFINED only NULL
      string nullString;


      // Arrays
      // Arrays when created have a defined length, and it cannot be changed
      string[] names = new string[] { "Mark", "Jake", "Darryl" };
      names[1] = null;


      // List (Closer to a Javascript Array)
      // '<>' 'of type'
      // must be instatiated to be used
      var listNames = new List<string>() {
        "Jek",
        "Drl"
      };

      listNames.Add("Mark");
      listNames.Remove("Jek");
      listNames.AddRange(new string[] { "Tim", "Britt", "Zach" });
      listNames.Insert(0, "Jake"); // Same as shift

      // lists do not have length they have Count
      // for (int i = 0; i < listNames.Count; i++)
      // {
      //   Console.WriteLine(listNames[i]);
      // }

      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();

      var message = $"Follow the white rabbit {name}";
      for (int i = 0; i < message.Length; i++)
      {
        Console.Write(message[i]);
        Thread.Sleep(50);
      }

      Console.WriteLine("\n\n");
      Console.Write("Do you wish to continue (y/n) >");
      var choice = Console.ReadKey().KeyChar;
      Console.WriteLine("\n\n");
      if (choice == 'y')
      {
        Console.WriteLine("Lets see how deep the rabbit hole goes");
      }
      else if (choice == 'n')
      {
        Console.WriteLine("The Matrix has you");
        return;
      }
      else
      {
        Console.WriteLine("Agent Detected!!!!!");
        return;
      }


      // OBJECTS
      // NO SUCH THING AS A POCO
      Dictionary<string, string> characterDerciptions = new Dictionary<string, string>(){
        {"neo", "the hero of our story"},
        {"morpheus", "Looks balla in Leather Trench Coat"},
        {"trinity", "Suppa bad a**"}
      };

      characterDerciptions.Add("Smith", "The Villian");


      bool researching = true;

      while (researching)
      {
        Console.WriteLine("who do you want to know about?");
        var selection = Console.ReadLine().ToLower();
        if (characterDerciptions.ContainsKey(selection))
        {
          Console.WriteLine(characterDerciptions[selection]);
        }
        else
        {
          System.Console.WriteLine("invalid selection");
        }

        System.Console.WriteLine("\n Do you wish to continue?");
        var cont = Console.ReadKey().KeyChar;
        Console.Clear();
        if (cont == 'y')
        {
          continue;
        }
        else if (cont == 'n')
        {
          researching = false;
        }
        else
        {
          Console.WriteLine("Invalid command");
          return;
        }
      }
      Console.WriteLine("The Matrix has you");
    }
  }
}

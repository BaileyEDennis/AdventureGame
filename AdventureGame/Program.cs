using System;
using AdventureGame.Intro;
using Spectre.Console;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool skip = false;
            Creation.characterCreation();
            skip = AnsiConsole.Confirm($"[wheat1]Do you want to skip the tutorial?[/]");
            if (skip != true)
            {
               Tutorial.TutorialTime();
            }
            AnsiConsole.Markup($"[wheat1]Let's Begin...[/]\n");
            Console.ReadKey();
            Console.Clear();
            var title = new Rule("[red]Ruins of Morheim[/]");
            title.Centered();
            AnsiConsole.Render(title);            
        }
    }
}

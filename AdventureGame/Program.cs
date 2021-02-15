using System;
using AdventureGame.Intro;
using Spectre.Console;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            Creation.characterCreation();
            //Main game here
            Console.Clear();
            var title = new Rule("[red]Ruins Of Morheim[/]");
            title.Centered();
            AnsiConsole.Render(title);
            AnsiConsole.Markup("[lime]Placeholder for future[/] [red]development...[/]");
        }
    }
}

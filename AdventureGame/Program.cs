using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro Screen
            AnsiConsole.Render(
                new FigletText("Ruins of Morheim")
                    .Centered()
                    .Color(Color.Red));

            
            AnsiConsole.Markup("[wheat1]Welcome to [red]Morheim[/]. You are the only survivor from an attack on your caravan " +
                "by bandits who have taken you prisoner. You are being held in a dungeon cell in the ruins. Can you escape " +
                "and survive the dangers?[/]\n");
            Console.WriteLine("\n");
            AnsiConsole.Markup("[wheat1]Press any key to continue...[/]");
            Console.WriteLine("\n");
            Console.ReadKey();

            //character creation
            string characterName = "";
            bool confirm = false;
            do
            {
                characterName = AnsiConsole.Ask<string>("[wheat1]What is your [green]name[/], adventerer?[/]");
                confirm = AnsiConsole.Confirm($"[wheat1]Do you want to be known as [green]{characterName}[/]?[/]");
            } while (confirm != true);
            AnsiConsole.Markup($"[wheat1]You are now known as [green]{characterName}[/].[/]\n");

            //Race Selection
            string characterRace = "";
            bool confirm2 = false;
            do
            {
                characterRace = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[wheat1]What is your [orange1]Race[/]?[/]")
                    .PageSize(10)
                    .AddChoice("Human")
                    .AddChoices(new[]
                    {
                        "Elf", "Half-Elf", "Dwarf",
                        "Orc", "Half-Orc", "Halfling",
                    }));
                confirm2 = AnsiConsole.Confirm($"[wheat1]Do you want to be a [orange1]{characterRace}[/]?[/]");
            } while (confirm2 != true);
            AnsiConsole.Markup($"[wheat1]You are now a(n) [green]{characterRace}[/].[/]\n");
        }
    }
}

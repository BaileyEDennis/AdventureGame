using System;
using Spectre.Console;

namespace AdventureGame.Intro
{
    public static class Creation
    {
        public static string CharacterName { get; set; }
        public static bool Confirm { get; set; }
        public static string CharacterRace { get; set; } = "";
        public static bool Confirm2 { get; set; } = false;

        public static void characterCreation()
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

            //character name
            do
            {
                CharacterName = AnsiConsole.Ask<string>("[wheat1]What is your [green]name[/], adventerer?[/]");
                Confirm = AnsiConsole.Confirm($"[wheat1]Do you want to be known as [green]{CharacterName}[/]?[/]");
            } while (Confirm != true);
            AnsiConsole.Markup($"[wheat1]You are now known as [green]{CharacterName}[/].[/]\n");

            //character race
            do
            {
                CharacterRace = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[wheat1]What is your [orange1]Race[/]?[/]")
                    .PageSize(10)
                    .AddChoice("Human")
                    .AddChoices(new[]
                    {
                        "Elf", "Half-Elf", "Dwarf",
                        "Orc", "Half-Orc", "Halfling",
                    }));
                Confirm2 = AnsiConsole.Confirm($"[wheat1]Do you want to be a [orange1]{CharacterRace}[/]?[/]");
            } while (Confirm2 != true);
            AnsiConsole.Markup($"[wheat1]You are now a(n) [green]{CharacterRace}[/].[/]\n");
            AnsiConsole.Markup("[wheat1]You have now made your character![/]\n");
            AnsiConsole.Markup("[wheat1]Press any key to continue...[/]");
            Console.WriteLine("\n");
            Console.ReadKey();


        }
    }
}

using System;
using Spectre.Console;

namespace AdventureGame.Intro
{
    class Creation
    {
        public static bool SaveHolder { get; set; }
        public static string CharacterName { get; set; }
        public static bool ConfirmName { get; set; }
        public static string CharacterRace { get; set; }
        public static bool ConfirmRace { get; set; }
        public static string CharacterClass { get; set; }
        public static bool ConfirmClass { get; set; }
        public static bool TutorialCheck { get; set; }

        public static void characterCreation()
        {
            //Intro Screen
            AnsiConsole.Render(
                new FigletText("Ruins of Morheim")
                    .Centered()
                    .Color(Color.Red));


            AnsiConsole.Markup("[red]Morheim[/] [wheat1], once a propserous and wealthy land. Over the ages, and reigns " +
                "of evil kings, [red]Morheim[/] fell to ruin. Rumors of the [purple]Broken Crown's[/] resting place as well as " +
                "its guardians caution foolhardy would-be travelers. Are you a fool, or a conqueror?[/]\n");
            Console.WriteLine("\n");
            
            //saved game check
            do
            {
                SaveHolder = AnsiConsole.Confirm($"[wheat1]Start New Game?[/]");
            } while (SaveHolder != true);
            
            Console.Clear();
            var title = new Rule("[fuchsia]Character Creation[/]");
            title.Centered();
            AnsiConsole.Render(title);

            //character name
            do
            {
                CharacterName = AnsiConsole.Ask<string>("[wheat1]What is your [green]name[/], adventerer?[/]");
                ConfirmName = AnsiConsole.Confirm($"[wheat1]Do you want to be known as [green]{CharacterName}[/]?[/]");
            } while (ConfirmName != true);
            AnsiConsole.Markup($"[wheat1]You are now known as [green]{CharacterName}[/].[/]\n");

            //character class
            do
            {
                CharacterClass = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[wheat1]What is your [mediumspringgreen]Class[/]?[/]")
                    .PageSize(10)
                    .AddChoices(new[]
                    {
                        "Warrior", "Wizard", "Bard",
                        "Rogue", "Ranger",
                    }));
                ConfirmClass = AnsiConsole.Confirm($"[wheat1]Do you want to be a [mediumspringgreen]{CharacterClass}[/]?[/]");

            } while (ConfirmClass != true);
            AnsiConsole.Markup($"[wheat1]You are now a(n) [mediumspringgreen]{CharacterClass}[/].[/]\n");
            
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
                ConfirmRace = AnsiConsole.Confirm($"[wheat1]Do you want to be a [orange1]{CharacterRace}[/]?[/]");
            } while (ConfirmRace != true);
            AnsiConsole.Markup($"[wheat1]You are now a(n) [green]{CharacterRace}[/].[/]\n");
            AnsiConsole.Markup("[wheat1]You have now made your character![/]\n");
            TutorialCheck = AnsiConsole.Confirm($"[wheat1]Do you want to skip the tutorial?[/]");
            if (TutorialCheck != true)
            {
                Tutorial.TutorialTime();
            }

        }
    }
}

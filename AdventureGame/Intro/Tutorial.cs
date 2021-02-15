using System;
using Spectre.Console;
using AdventureGame.Information;

namespace AdventureGame.Intro
{
    class Tutorial
    {
        public static bool Confirm3 { get; set; }
        public static void TutorialTime()
        {
            Console.Clear();
            var title = new Rule("[red]Ruins of Morheim Tutorial[/]");
            title.Centered();
            AnsiConsole.Render(title);

            //tutorial
            AnsiConsole.Markup($"[green]{Creation.CharacterName}[/][wheat1], Welcome to [red]Ruins or Morheim[/]![/] " +
                "[wheat1]Simple Commands are accepted, such as 'North', 'South', 'Take', and many more. For a full list,[/] " + 
                "[wheat1]use 'help'. You can also access your [orange1]'inventory'[/] or [dodgerblue2]'character screen'[/].[/] " +
                "[wheat1]at any time. To begin, I will show you a few of the menus now: [/]\n");
            AnsiConsole.Markup("[wheat1]Press any key to continue...[/]");
            Console.ReadKey();
            AnsiConsole.Markup("[wheat1]Here is your current [orange1]inventory[/]: [/]\n");
            //character inventory table
            Inventory.characterInventory();
            AnsiConsole.Markup("[wheat1]Press any key to continue...[/]");
            Console.ReadKey();
            AnsiConsole.Markup($"[wheat1]Here is your current [dodgerblue2]Character screen[/]:[/]\n");
            CharacterInfo.CharacterInformation();
            Console.ReadKey();

            do
            {
                Confirm3 = AnsiConsole.Confirm($"[wheat1]Are you ready to begin, [green]{Creation.CharacterName}[/]?[/]");
            } while (Confirm3 != true);
        }
    }
}

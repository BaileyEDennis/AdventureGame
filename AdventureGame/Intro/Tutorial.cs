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
            var title = new Rule("[red]Ruins of Morheim[/]");
            title.Centered();
            AnsiConsole.Render(title);

            //tutorial
            AnsiConsole.Markup($"[wheat1]Anytime the text stops, press any key to move forward in the game[/]\n");
            Console.ReadKey();
            AnsiConsole.Markup($"[green]{Creation.CharacterName}[/][wheat1], you may also access your [orange1](i)nventory[/] or [dodgerblue2](c)haracter screen[/] on any pause[/]\n");
            Console.ReadKey();
            AnsiConsole.Markup("[wheat1]Here is your current [orange1]inventory[/]: [/]\n");
            //character inventory table
            Inventory.characterInventory();
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

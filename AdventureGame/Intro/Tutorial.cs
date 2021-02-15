using System;
using Spectre.Console;

namespace AdventureGame.Intro
{
    class Tutorial
    {
        public static void TutorialTime()
        {
            Console.Clear();
            var title = new Rule("[red]Ruins of Morheim[/]");
            title.Centered();
            AnsiConsole.Render(title);

            //tutorial
            AnsiConsole.Markup($"[wheat1]Anytime the text stops, press any key to move forward in the game[/]\n");
            Console.ReadKey();
            AnsiConsole.Markup($"[wheat1]Or optionally, use a special command at any pause: [/]\n");
            Console.ReadKey();
            AnsiConsole.Markup($"[green]{Creation.CharacterName}[/][wheat1], you have access to an [orange1](i)nventory[/] and a [dodgerblue2](c)haracter screen[/] at any time[/]\n");
            Console.ReadKey();
            AnsiConsole.Markup("[wheat1]Press [orange1]i[/] at any time to open your inventory screen![/]\n");
            Console.ReadKey();

            //character table, move this later

            var charTable = new Table();

            charTable.Title($"[orange1]{Creation.CharacterName}'s Equipment[/]");
            charTable.Centered();
            charTable.Border(TableBorder.Double);
            charTable.AddColumn(new TableColumn("Name").Centered());
            charTable.AddColumn(new TableColumn("Description").Centered());

            charTable.AddRow("[khaki1]Prisoner Clothes[/]", "[grey93]Ragged and full of holes.[/]");
            charTable.AddRow(" ", " ");
            charTable.AddRow("[khaki1]Mug[/]", "[grey93]Holds a small amount of liquid[/]");
            AnsiConsole.Markup("[wheat1]Here is your current inventory: [/]\n");
            AnsiConsole.Render(charTable);
        }
    }
}

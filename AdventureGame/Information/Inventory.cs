using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;
using AdventureGame.Intro;

namespace AdventureGame.Information
{
    class Inventory
    {
        public static void characterInventory()
        {
            var charTable = new Table();

            charTable.Title($"[orange1]{Creation.CharacterName}'s Equipment[/]");
            charTable.Centered();
            charTable.Border(TableBorder.Double);
            charTable.AddColumn(new TableColumn("Item Name").Centered());
            charTable.AddColumn(new TableColumn("Description").Centered());

            charTable.AddRow("[khaki1]Prisoner Clothes[/]", "[grey93]Ragged and full of holes.[/]");
            charTable.AddEmptyRow();
            charTable.AddRow("[khaki1]Mug[/]", "[grey93]Holds a small amount of liquid.[/]");
            AnsiConsole.Render(charTable);
        }
    }
}

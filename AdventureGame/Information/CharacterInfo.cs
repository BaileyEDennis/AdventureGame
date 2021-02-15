using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;
using AdventureGame.Intro;

namespace AdventureGame.Information
{
    class CharacterInfo
    {
        public static void CharacterInformation()
        {
            var playerInfo = new Table();
            playerInfo.DoubleBorder();
            playerInfo.Centered();
            playerInfo.Title($"[dodgerblue2]{Creation.CharacterName} Information[/]");

            playerInfo.AddColumn(new TableColumn($"[green]{Creation.CharacterName}[/]").Centered());
            playerInfo.AddColumn(new TableColumn($"[wheat1]Current Level: [/][aqua]1[/]").Centered());
            playerInfo.AddRow($"[wheat1]Health:[/] [red3]100[/]", "[wheat1]Armor:[/] [blueviolet]0[/]");
            playerInfo.AddEmptyRow();
            playerInfo.AddRow($"[wheat1]Race: [/][orange1]{Creation.CharacterRace}[/]", "[wheat1]Date: 1/2/2021[/]"); //change date in later method
            playerInfo.AddEmptyRow();
            playerInfo.AddRow($"[wheat1]Left Hand: [/][red]Empty[/]", "[wheat1]Right Hand: [/][red]Empty[/]");
            AnsiConsole.Render(playerInfo);
        }
    }
}

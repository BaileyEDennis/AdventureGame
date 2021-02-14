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
            AnsiConsole.Markup("[red]Ruins of Morheim[/]\n");
            AnsiConsole.Markup("[dodgerblue2]Welcome to ...[/]\n");

            string characterName = "";
            bool confirm = false;
            do
            {
                characterName = AnsiConsole.Ask<string>("[wheat1]What is your [green]name[/], adventerer?[/]");
                confirm = AnsiConsole.Confirm($"[wheat1]Do you want to be known as [green]{characterName}[/]?[/]");
            } while (confirm != true);
           

            AnsiConsole.Markup($"[wheat1]You chose [green]{characterName}[/]![/]\n");
        }
    }
}

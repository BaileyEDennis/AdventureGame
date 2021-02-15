using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System.Globalization;
using AdventureGame.Intro;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Creation.characterCreation();
            Tutorial.TutorialTime();
        }
    }
}

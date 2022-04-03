using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terrible;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomMenu menu = new CustomMenu(true);

            string[] buttons = new string[] { "Case10", "Case15", "For17", "For38", "While26", "While28", "Minmax25", };

            menu.AddButton(buttons);

            string choice = null;

            while (choice != "-1")
            {
                choice = menu.Update();

                switch (choice)
                {
                    case "Case10":
                        Console.Clear();
                        Terrible.Tasks.Case10();
                        break;
                    case "Case15":
                        Console.Clear();
                        Terrible.Tasks.Case15();
                        break;
                    case "For17":
                        Console.Clear();
                        Terrible.Tasks.For17();
                        break;
                    case "For38":
                        Console.Clear();
                        Terrible.Tasks.For38();
                        break;
                    case "While26":
                        Console.Clear();
                        Terrible.Tasks.While26();
                        break;
                    case "While28":
                        Console.Clear();
                        Terrible.Tasks.While28();
                        break;
                    case "Minmax25":
                        Console.Clear();
                        Terrible.Tasks.Minmax25();
                        break;
                }
            }


        }
    }
}

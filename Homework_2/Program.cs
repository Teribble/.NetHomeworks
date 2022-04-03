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

            menu.AddButton("Null");
            menu.AddButton("One");
            menu.AddButton("Two");
            menu.AddButton("Three");

            menu.Update();
            
            Console.ReadLine();
        }
    }
}

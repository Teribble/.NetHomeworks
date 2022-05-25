using MyLib;
using Spectre.Console;

namespace Delivery
{
    public class Menu
    {
        public void He()
        {
            CustomMenu m = new CustomMenu(true);

            m.AddButton("Balance");
            m.AddButton("Try");
            m.AddButton("Parse");

            m.Update();

            Console.ForegroundColor = ConsoleColor.Red;

            Table table = new Table();
            table.AddColumn("Delivery by Teribble");

            AnsiConsole.Write(table);
        }
    }
}

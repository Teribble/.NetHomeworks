using System;

namespace Terrible
{
    /// <summary>
    /// Заводи шарманку))
    /// </summary>
    public static class Control
    {
        public static void Run()
        {
            string choice = "hello";

            while (choice!="-1")
            {
                var menu = new CustomMenu(true);

                string[] buttons = new string[] { "Integer_24", "Integer_29", "Boolean_25", "Boolean_30", "Boolean_35", "If_20", "If_23", "If_26" };

                menu.AddButton(buttons);

                choice = menu.Update();

                switch (choice)
                {
                    case "Integer_24":
                        Homework.Integer24();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Integer_29":
                        Homework.Integer29();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Boolean_25":
                        Homework.Boolean25();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Boolean_30":
                        Homework.Boolean30();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Boolean_35":
                        Homework.Boolean35();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "If_20":
                        Homework.If20();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "If_23":
                        Homework.If23();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "If_26":
                        Homework.If26();
                        Console.WriteLine("Для продолжения нажмите Enter..");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            
        }
    }
}

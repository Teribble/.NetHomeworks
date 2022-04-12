using System;
using MyLib;

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
                        Continue();
                        break;
                    case "Integer_29":
                        Homework.Integer29();
                        Continue();
                        break;
                    case "Boolean_25":
                        Homework.Boolean25();
                        Continue(); 
                        break;
                    case "Boolean_30":
                        Homework.Boolean30();
                        Continue();
                        break;
                    case "Boolean_35":
                        Homework.Boolean35();
                        Continue();
                        break;
                    case "If_20":
                        Homework.If20();
                        Continue();
                        break;
                    case "If_23":
                        Homework.If23();
                        Continue();
                        break;
                    case "If_26":
                        Homework.If26();
                        Continue();
                        break;
                }
            }

            
        }

        private static void Continue()
        {
            Console.WriteLine("Для продолжения нажмите Enter..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

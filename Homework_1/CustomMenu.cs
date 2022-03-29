using System;
using System.Collections.Generic;

namespace Terrible
{
    /// <summary>
    /// Кастомное меню
    /// </summary>
    public class CustomMenu
    {
        #region Fields
        /// <summary>
        /// Список названий кнопок
        /// </summary>
        private List<string> _buttons;

        /// <summary>
        /// Текущий выбор
        /// </summary>
        private int _selection;

        /// <summary>
        /// true - вертикальная таблица, false - горизонтальная
        /// </summary>
        private bool _isVertical;

        /// <summary>
        /// Максимальная ширина имени
        /// </summary>
        private int _maxNameWidth;

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="isVertical">true - вертикальная таблица, false - горизонтальная таблица</param>
        public CustomMenu(bool isVertical)
        {
            _buttons = new List<string>();
            _isVertical = isVertical;
            _selection = 0;
            _maxNameWidth = 0;
        }

        /// <summary>
        /// Добавить новую кнопку
        /// </summary>
        /// <param name="name">Имя новой кнопки</param>
        public void AddButton(string name)
        {
            _buttons.Add(name);
            if (name.Length > _maxNameWidth)
                _maxNameWidth = name.Length;
        }

        /// <summary>
        /// Добавить новую кнопку
        /// </summary>
        /// <param name="index">Позицию, куда вставить кнопку</param>
        /// <param name="name">Имя новой кнопки</param>
        public void AddButton(int index, string name)
        {
            _buttons.Insert(index - 1, name);
            if (name.Length > _maxNameWidth)
                _maxNameWidth = name.Length;
        }

        /// <summary>
        /// Добавить новую кнопку
        /// </summary>
        /// <param name="names">Массив названий кнопок</param>
        public void AddButton(string[] names)
        {
            foreach (string name in names)
            {
                _buttons.Add(name);
                if (name.Length > _maxNameWidth)
                    _maxNameWidth = name.Length;
            }
        }

        /// <summary>
        /// Показывает меню в консоле, выбор - Enter, навигация по стрелкам клавиатуры
        /// </summary>
        /// <returns>Возращает название кнопки</returns>
        public string Update()
        {

            ConsoleKeyInfo sKey;

            while (true)
            {
                Console.CursorVisible = false;

                Console.SetCursorPosition(0, 0);

                Show();

                if (false == _isVertical)
                {
                    sKey = Console.ReadKey();

                    switch (sKey.Key)
                    {
                        case ConsoleKey.Enter:
                            DeShow();
                            Console.SetCursorPosition(0, 0);
                            return _buttons[_selection].ToString();
                        case ConsoleKey.Escape:
                            return _buttons[0].ToString();
                        case ConsoleKey.LeftArrow:
                            if (_selection == 0)
                                _selection = _buttons.Count - 1;
                            else
                                _selection--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (_selection == _buttons.Count - 1)
                                _selection = 0;
                            else
                                _selection++;
                            break;
                        case ConsoleKey.End:
                            return "-1";

                        default:
                            break;
                    }
                }
                else
                {

                    sKey = Console.ReadKey();

                    switch (sKey.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.SetCursorPosition(0, 0);
                            DeShow();
                            Console.SetCursorPosition(0, 0);
                            return _buttons[_selection].ToString();
                        case ConsoleKey.Escape:
                            return _buttons[0].ToString();
                        case ConsoleKey.UpArrow:
                            if (_selection == 0)
                                _selection = _buttons.Count - 1;
                            else
                                _selection--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (_selection == _buttons.Count - 1)
                                _selection = 0;
                            else
                                _selection++;
                            break;
                        case ConsoleKey.End:
                            return "-1";

                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Показать меню
        /// </summary>
        private void Show()
        {
            if (false == _isVertical)
            {
                for (int i = 0; i < _buttons.Count; i++)
                {
                    if (i == _selection)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(i + " > " + _buttons[i].ToString().PadLeft(_maxNameWidth));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(i + " > " + _buttons[i].ToString().PadLeft(_maxNameWidth));
                    }
                }
                Console.Write("End - выход");
            }
            else
            {
                for (int i = 0; i < _buttons.Count; i++)
                {
                    if (i == _selection)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(i + " > " + _buttons[i].ToString().PadRight(_maxNameWidth));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(i + " > " + _buttons[i].ToString().PadRight(_maxNameWidth));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("End - выход");
            }

        }

        /// <summary>
        /// Удалить старое меню
        /// </summary>
        private void DeShow()
        {
            if (false == _isVertical)
            {
                for (int i = 0; i < _buttons.Count; i++)
                {
                    for (int j = 0; j < _maxNameWidth + i + " > ".Length + 1; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("           ");
            }
            else
            {
                for (int i = 0; i < _buttons.Count; i++)
                {
                    for (int j = 0; j < _maxNameWidth + i + " > ".Length + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            Console.Write("           ");
        }
    }
}

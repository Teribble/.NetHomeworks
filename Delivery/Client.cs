using Delivery.Rations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Delivery
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string? FullName { get; set; }
        /// <summary>
        /// Клиент
        /// </summary>
        /// <param name="fullName">Имя клиента</param>
        /// <exception cref="ArgumentException">Выбросит экспешн, если имя пустое</exception>
        public Client(string fullName)
        {
            if (!string.IsNullOrEmpty(fullName))
                FullName = fullName;
            else
                throw new ArgumentException("Error");
        }
        /// <summary>
        /// Создать заказ
        /// </summary>
        /// <returns></returns>
        public Order MakeOrder()
        {
            Order order = new Order
            {
                Type = SelectRationType(),
                CountDay = SelectCountDay()
            };

            return order;
        }
        /// <summary>
        /// Выбор рациона
        /// </summary>
        /// <returns></returns>
        private RationType SelectRationType()
        {
            var rationType = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Какой рацион Вам [green]нравится[/]?")
            .PageSize(10)
            .MoreChoicesText("[grey](Выбор стелочками, вверх и вниз)[/]")
            .AddChoices(new[] {
            "Balance", "Vegan", "Premium",
            "Sport", "Не знаю что хочу))",}));

            switch (rationType)
            {
                case "Balance":
                    return RationType.Balance;
                case "Sport":
                    return RationType.Sport;
                case "Vegan":
                    return RationType.Vegan;
                case "Premium":
                    return RationType.Premium;
                default:
                    return RationType.Default;
            }
        }
        /// <summary>
        /// Выбор дней доставки
        /// </summary>
        /// <returns></returns>
        private int SelectCountDay()
        {
            var countday = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Какой рацион Вам [green]нравится[/]?")
            .PageSize(10)
            .MoreChoicesText("[grey](Выбор стелочками, вверх и вниз)[/]")
            .AddChoices(new[] {
            "Три", "Пять", "Семь",
            "Девять", "Попробовать",}));

            switch (countday)
            {
                case "Три":
                    return 3;
                case "Пять":
                    return 5;
                case "Семь":
                    return 7;
                case "Девять":
                    return 9;
                default:
                    return 1;
            }
        }


    }
}

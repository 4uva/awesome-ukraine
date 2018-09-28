using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awesome_ukraine.Model
{
    public class Section
    {
        public string Name { get; }
        public string PageAddress { get; }
        public string LogoAddress { get; }

        public Section(string name, string logoName)//это же функция - конструктор
        {
            Name = name;
            PageAddress = "/" + name;
            LogoAddress = "/images/" + logoName;
        }
    }

    public static class Sections
    {
        public static IReadOnlyCollection<Section> All { get; } =
            new[]// All is Section Collection, constructor invocation 
            {
                new Section("Culture", "culture.svg"),//а это объект
                new Section("History", "history_48px.svg"),//как называется то, что в скобках и кавычках 
                                                           //это просто аргументы вызова конструктора
                new Section("Places", "places.svg"),
                new Section("Nature", "nature.svg"),
                new Section("Sports", "sports.svg"),
                new Section("Technology", "technology.svg"),
                new Section("Food", "food.svg")
            };
    }
}

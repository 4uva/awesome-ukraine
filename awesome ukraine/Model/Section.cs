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
        public IEnumerable<DataBase.Item> Items { get; }

        public Section(string name, string logoName, DataBase.Repository repository)//это же функция - конструктор
        {
            Name = name;
            PageAddress = "/" + name;
            LogoAddress = "/images/" + logoName;
            Items = repository.GetSectionItems(name); // тут делаем запрос в базу данных
        }
    }

    public class Sections
    {
        public Sections(DataBase.Repository repository)
        {
            All = new[]// All is Section Collection, constructor invocation 
                  {
                      new Section("Culture", "culture.svg", repository),//а это объект
                      new Section("History", "history_48px.svg", repository),//как называется то, что в скобках и кавычках 
                                                                 //это просто аргументы вызова конструктора
                      new Section("Places", "places.svg", repository),
                      new Section("Nature", "nature.svg", repository),
                      new Section("Sports", "sports.svg", repository),
                      new Section("Technology", "technology.svg", repository),
                      new Section("Food", "food.svg", repository)
                  };
        }

        public IReadOnlyCollection<Section> All { get; }
    }
}

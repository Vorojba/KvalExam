using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Шрайвер Николас 31ИС
    public class Building
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public List<Apartments> apartments = new List<Apartments>();

        public Building(string address, string description)
        {
            Address = address;
            Description = description;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Адрес:{Address}\nОписание:{Description}\nКвартира");
            apartments.Sort();
            foreach ( Apartments apartments in apartments )
            {
                apartments.Show();
            }
        }
    }
    //Шрайвер Николас 31ИС
    public class Apartments : IComparable<Apartments>
    {
        public int Number { get; set; }
        public string Owner { get; set; }
        public Apartments(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }
        public void Show()
        {
            Console.WriteLine($"\tНомер:{Number}\n\tВладелец:{Owner}");
        }
        //Шрайвер Николас 31ИС
        public int CompareTo(Apartments other)
        {
            return Number.CompareTo(other.Number);
        }
    }

}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Шрайвер Николас 31ИС
            Building building = new Building("ул. Долгопрудная д.5", "«Мытищи Lite» – новое место для жизни, в котором свободно и комфортно.");
            building.apartments.Add(new Apartments(7, "Александр Николаевич Журавлев"));
            building.apartments.Add(new Apartments(45, "Михаил Владимирович Цветков"));
            building.apartments.Add(new Apartments(23, "Данила Алексндрович Никитич"));
            building.ShowAll();
            Console.ReadKey();

        }
    }
}

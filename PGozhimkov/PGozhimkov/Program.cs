using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DLLozhimkov;

namespace PGozhimkov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Main St.", "New York", "10001");

            Building building = new Building(address);

            building.AddApartment(new Apartment(101, "Джон Доу", "Одна спальня, второй этаж"));
            building.AddApartment(new Apartment(303, "Джейн Смит", "Две спальни, третий этаж"));
            building.AddApartment(new Apartment(202, "Элис Джонсон", "Квартира-студия, второй этаж"));
            building.AddApartment(new Apartment(404, "Боб Браун", "Пентхаус, верхний этаж"));

            Console.WriteLine($"Здание расположено по адресу: {building.Address}");
            Console.WriteLine("\nКвартиры в доме:");
            building.ShowAll();

            Console.WriteLine("\nРаботу выполнил: \nОжимков Михаил 34ИС");
            Console.ReadKey();
        }
    }
}

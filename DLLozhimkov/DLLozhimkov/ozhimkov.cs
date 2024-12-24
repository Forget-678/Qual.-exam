using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLozhimkov
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {ZipCode}";
        }
    }
    // Работу выполнил Ожимков Михаил 34ИС
    public class Apartment : IComparable<Apartment>
    {
        public int Number { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }

        public Apartment(int number, string owner, string description)
        {
            Number = number;
            Owner = owner;
            Description = description;
        }

        public void Show()
        {
            Console.WriteLine($"Номер квартиры: {Number}, Владелец: {Owner}, Описание: {Description}");
        }

        public int CompareTo(Apartment other)
        {
            if (other == null) return 1;
            return this.Number.CompareTo(other.Number);
        }
    }
    // Работу выполнил Ожимков Михаил 34ИС
    public class Building
    {
        public Address Address { get; set; }
        public List<Apartment> Apartments { get; set; }

        public Building(Address address)
        {
            Address = address;
            Apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }

        public void ShowAll()
        {
            Apartments.Sort(); 
            foreach (var apartment in Apartments)
            {
                apartment.Show();
            }
        }
    }
    // Работу выполнил Ожимков Михаил 34ИС
}

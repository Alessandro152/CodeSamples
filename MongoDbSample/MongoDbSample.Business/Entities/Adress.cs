namespace MongDbSample.Business.Entities
{
    public class Adress
    {
        public Adress(string street, int number, string city, string country)
        {
            Street = street;
            Number = number;
            City = city;
            Country = country;
        }

        public string Street { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
    }
}

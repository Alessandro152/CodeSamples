using MongDbSample.Api.Business.Dtos;
using System;

namespace MongDbSample.Business.Entities
{
    public class User
    {
        public User(string name, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Adress Adress { get; private set; }

        public void AddAdress(AdressDto adress)
            => Adress = new Adress(adress.Street, adress.Number, adress.City, adress.Country);
    }
}

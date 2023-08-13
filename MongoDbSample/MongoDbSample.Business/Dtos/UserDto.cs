using MongDbSample.Api.Business.Dtos;
using System;

namespace MongDbSample.Business.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AdressDto Adress { get; set; }
    }
}

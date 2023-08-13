using MongDbSample.Api.Business.Dtos;
using MongDbSample.Business.Dtos;
using MongDbSample.Business.Entities;
using MongoDB.Driver;
using MongoDbSample.Infra.Data;
using System.Collections.Generic;

namespace MongoDbSample.Infra.Repositories
{
    public interface IUserRepository
    {
        IAsyncEnumerable<UserDto> GetAllUsers();
        void Insert(User usuario);
    }

    public class UserRepository : DatabaseContext, IUserRepository
    {
        public UserRepository(IMongoDatabase database) : base(database)
        {
        }

        public async IAsyncEnumerable<UserDto> GetAllUsers()
        {
            var result = await Users.Find(x => true).ToListAsync();

            foreach (var item in result)
            {
                yield return new UserDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age,
                    Adress = new AdressDto
                    {
                        Street = item.Adress.Street,
                        Number = item.Adress.Number,
                        City = item.Adress.City,
                        Country = item.Adress.Country
                    }
                };
            }
        }

        public void Insert(User usuario)
            => Users.InsertOne(usuario);
    }
}

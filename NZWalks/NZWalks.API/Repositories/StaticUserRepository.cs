using NZWalks.API.Models.Domain;
using System.Data;
using System.Net.Mail;

namespace NZWalks.API.Repositories
{
    public class StaticUserRepository: IUserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User()
            {
                FirstName= "Read Only", LastName="User", EmailAddress="readonly@user.com",
                Id=Guid.NewGuid(), UserName="readonly@user.com", Password="readonly@user",
                Roles=new List<string> {"reader"}
            },
            new User()
            {
                FirstName= "Read Write", LastName="User", EmailAddress="readwrite@user.com",
                Id=Guid.NewGuid(), UserName="readwrite@user.com", Password="readwrite@user",
                Roles=new List<string> {"reader", "writer"}
            }
        };

        public async Task<User> AuthenticateAsync(string username, string password)
        {
           var user = Users.Find(x=> x.UserName.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
            x.Password == password);

            return user;
        }
    }
}

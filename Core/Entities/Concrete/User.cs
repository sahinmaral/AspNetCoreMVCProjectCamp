using System.ComponentModel.DataAnnotations;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public User()
        {
            Status = true;
        }
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public byte[] UserPasswordSalt { get; set; }
        public byte[] UserPasswordHash { get; set; }
        public bool Status { get; set; }
    }
}

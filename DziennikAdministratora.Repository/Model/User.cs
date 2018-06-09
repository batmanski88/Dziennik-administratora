using System;

namespace DziennikAdministratora.Repository.Model
{
    public class User
    {
        public Guid UserId {get; protected set;}
        public string Email { get; protected set;}
        public string Password {get; protected set;}
        public string UserName {get; protected set;}
        public DateTime UpdateAt {get; protected set;}
        public DateTime CreateAt {get; protected set;}
    }
}
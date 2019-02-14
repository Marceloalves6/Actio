namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
protected UserCreated(string email, string name)
{
    Name = name;
    Email = email;
}

        public string Email { get;  }
        public string Name { get;  }
    }
}
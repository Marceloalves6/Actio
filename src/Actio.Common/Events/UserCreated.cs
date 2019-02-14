namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get;  }
        public string Name { get;  }
    }
}
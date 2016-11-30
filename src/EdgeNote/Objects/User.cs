using System;
namespace EdgeNote.Library.Objects
{
    public class User : AbstractObject
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string AuthorizationToken { get; set; }

        public string DisplayName { get; set; }

        public string UserType { get; set; }

    }
}

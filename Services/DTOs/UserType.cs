using System.Collections.Generic;

namespace WebAPI.Services.DTOs
{
    /// <summary>
    ///   <para>DTO for UserType table</para>
    /// </summary>
    public class UserType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public char Code { get; set; }

        public ICollection<User> User { get; set; }
    }
}

using System;

namespace WebAPI.Services.DTOs
{
    /// <summary>
    /// DTO for User table details</para>
    /// </summary>
    public class UserDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public int UserTitleId { get; set; }
        public string UserTitle { get; set; }
        public string EmailAddress { get; set; }
        public bool isActive { get; set; }
    }
}

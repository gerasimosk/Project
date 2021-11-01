using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Domain
{
    /// <summary>
    /// DTO for User table</para>
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "Name can't be longer than 20 characters")]
        public string Name { get; set; }

        [StringLength(20, ErrorMessage = "Surname can't be longer than 20 characters")]
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "User Type Id is required")]
        public int UserTypeId { get; set; }

        [Required(ErrorMessage = "User Title Id is required")]
        public int UserTitleId { get; set; }
        
        [StringLength(50, ErrorMessage = "Email address can't be longer than 50 characters")]
        public string EmailAddress { get; set; }
        public bool? IsActive { get; set; }

        public UserTitle UserTitle { get; set; }
        public UserType UserType { get; set; }
    }
}

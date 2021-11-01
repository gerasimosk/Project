using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Domain
{
    /// <summary>
    ///   <para>DTO for UserTitle table</para>
    /// </summary>
    public class UserTitle
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(20, ErrorMessage = "Description can't be longer than 20 characters")]
        public string Description { get; set; }

        public ICollection<User> User { get; set; }
    }
}

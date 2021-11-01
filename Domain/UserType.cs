using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Domain
{
    /// <summary>
    ///   <para>DTO for UserType table</para>
    /// </summary>
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(20, ErrorMessage = "Description can't be longer than 20 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Code is required")]
        [StringLength(2, ErrorMessage = "Code can't be longer than 20 characters")]
        public char Code { get; set; }

        public ICollection<User> User { get; set; }
    }
}

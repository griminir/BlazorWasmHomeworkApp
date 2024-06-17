using System.ComponentModel.DataAnnotations;

namespace BlazorWasmHomework.models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}

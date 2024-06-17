using System.ComponentModel.DataAnnotations;

namespace BlazorWasmHomework.models
{
    public class AddressModel
    {
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(4, MinimumLength = 4)]
        public string ZipCode { get; set; }
    }
}

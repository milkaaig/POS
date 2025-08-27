using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace POS.web.Models
{
    public class Category
    {
        public int  Id { get; set; }

        [Required(ErrorMessage= "Catagory Name is Required")]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDUsingEF.Models
{
    //this class also called as entity class / BO(business Object) / POCO(plain Old CLR Object) Class
    [Table("Book")]    //map class with table in DB
    public class Book
    {
        [Key]  //this is PK col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int Price { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Model
{
    public class Book
    {
        public Book()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}

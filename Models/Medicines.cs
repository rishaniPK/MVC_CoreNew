using System.ComponentModel.DataAnnotations; //To you [Key] attribute

namespace MVC_CoreNew.Models
{
    public class Medicines
    {
        [Key] //Defining primary key
        public int Id { get; set; }
        public string Name { get; set; }

        public string Capacity { get; set; }
        public decimal Price { get; set; }

    }
}

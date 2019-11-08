using System;
using System.ComponentModel.DataAnnotations; //To you [Key] attribute

namespace MVC_CoreNew.Models
{
    public class Patients
    {
        [Key] //Defining primary key
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WardNumber { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
    }
}

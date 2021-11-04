using System;
using System.ComponentModel.DataAnnotations;
using Archi.Librairy.Models;

namespace Archi.API.Models
{
    public class Pizza : ModelBase 
    {
       //public int ID { get; set; }
       [Required]
       public string Name { get; set;}

       public decimal Price { get; set; }

       public string Topping { get; set; }
    }
}

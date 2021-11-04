using System;
using System.ComponentModel.DataAnnotations;
using Archi.API.Models;
using Archi.Librairy.Models;

namespace Archi.API.Model
{
    public class Customer : ModelBase
    {
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Firstname { get; set;}

        internal static object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}

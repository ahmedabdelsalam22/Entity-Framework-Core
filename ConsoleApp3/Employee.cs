using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Employee
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}

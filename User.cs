using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int PhoneNumberId { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Core
{
    public  class User
    {

        public int Id { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "email is invalid")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password length should be greater than5")]

        public string Password { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string UserType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmailAltentication.Models
{
    public class Login
    {
        public Login()
        {
            Confimation = false;
        }
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Username { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        [Editable(false)]
        public bool Confimation { get; set; }

        public void Confirm()
        {
            Confimation = true;
        }
    }
}
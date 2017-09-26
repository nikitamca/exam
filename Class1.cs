using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace OMS.Models
{
    public class Class1
    {
        [Key]
        public int eid { get; set; }

        [Required(ErrorMessage = "Name not be blank.")]
        public string ename { get; set; }
        [Required(ErrorMessage = "Address not be blank.")]
        public string address { get; set; }
        [Required(ErrorMessage = "Email not be blank.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password not be blank.")]
        public string password { get; set; }
        [Required(ErrorMessage = "Confirm password not be blank.")]
        public string cpassword { get; set; }
        [Required(ErrorMessage="Contact number not be blank.")]
        public int mono { get; set; }
    }
}
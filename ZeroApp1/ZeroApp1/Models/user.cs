using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ZeroApp1.Models
{
    

    public class user
    {
        public int userid { get; set;    }

        [Required]
        [Display(Name ="Username")]
        [DataType(DataType.Text)]
        [MaxLength(30,ErrorMessage ="Length exceeded")]
        public string username
        {            get;   set;    }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "invalid password")]
        public string password {    get;    set;    }
    }
}

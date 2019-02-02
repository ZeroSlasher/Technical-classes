using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroApp1.Models
{
    public class student
    {

        public int studentid { set; get; }
        public string name { set; get; }
        
        public int userid { get; set; }
        
        public virtual user userid1 { get; set; }
        public string course { set; get; }
        public gender genderlist { set; get; }

    }
    public enum gender
    {
        male,
        female

    }
}
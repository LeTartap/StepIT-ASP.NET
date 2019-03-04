using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        [Range(1, 500)]
        public uint age { get; set; }
        public string sex { get; set; }


    }
    public enum Gender
    {
        Male,
        Female,
        CeVreauEu
    }
}
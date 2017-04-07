using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeploymentPractice.Models
{
    public class DataExample
    {

        [Key]

        public int ID { get; set; }

        [Display(Name = "Item")]

        public string NameType { get; set; }

        [Display(Name = "Gardener's Notes")]

        public string Info { get; set; }
    }
}
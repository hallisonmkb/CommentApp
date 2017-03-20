using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommentApp.Models
{
    public class CommentModels
    {
        [Required]
        public int id { get; set; }
        [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "The field name allow only 50 characters!")]
        public string name { get; set; }
        [DisplayName("Comment")]
        [Required(ErrorMessage = "Field Required")]
        public string comment { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime insert { get; set; }
    }
}
﻿using Entities.IdentityUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Display(Name = "Comments")]
       //[MinLength(5, ErrorMessage = "Comment cannot be less than 5")]
       //[MaxLength(200, ErrorMessage = "Comment cannot be greater than 200")]
        public string CommentContent { get; set; }
        public DateTime PostTime { get; set; }

        //TODO: Navigation Properties for user
        public ApplicationUser ApplicationUser { get; set; }
        public Rating Rating { get; set; }

    }
}

﻿using Entities.IdentityUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Range(1,5)]
        public int RateScore { get; set; }

        public DateTime RatingTime { get; set; }
        //Navigation Properties
        public ApplicationUser RatingUser { get; set; }
    }
}

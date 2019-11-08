﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColleguesApi.Controllers.DTO
{
    public class CreationColleguePostDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Ddn { get; set; }
        public Uri PhotoUrl { get; set; }


    }
}

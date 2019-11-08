using AutoMapper;
using ColleguesApi.Controllers.DTO;
using ColleguesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColleguesApi
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreationColleguePostDTO, Collegue>();
            CreateMap<Collegue, CreationColleguePostDTO>();

        }

    }
}

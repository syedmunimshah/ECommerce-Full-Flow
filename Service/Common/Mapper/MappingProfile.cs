using AutoMapper;
using Repository.Entities;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<RegisterDto, User>();

            CreateMap<User, RegisterDto>();

            CreateMap<User, UserDto>();
        }
    }
}

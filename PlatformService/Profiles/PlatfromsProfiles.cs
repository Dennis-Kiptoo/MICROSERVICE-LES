using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatfromsProfile : Profile
    {
        public PlatfromsProfile( )
        {
            // Source -> Target
            CreateMap <Platform,PlatformReadDto>();
            CreateMap <PlatformCreateDto,Platform >();

        }
    }
}
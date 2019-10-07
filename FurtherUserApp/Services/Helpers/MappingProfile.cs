using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyViewModel>()
                .ReverseMap()
                .ForMember(x => x.Users, y => y.Ignore());

            CreateMap<IdentityRole, RoleViewModel>()
                .ReverseMap()
                .ForMember(x => x.NormalizedName, y => y.Ignore())
                .ForMember(x => x.ConcurrencyStamp, y => y.Ignore());
        }
    }
}

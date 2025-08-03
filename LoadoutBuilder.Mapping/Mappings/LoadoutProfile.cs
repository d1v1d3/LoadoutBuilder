using AutoMapper;
using LoadoutBuilder.Data.Models;
using LoadoutBuilder.ViewModels;
using LoadoutBuilder.ViewModels.Loadout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Mapping.Mappings
{
    public class LoadoutProfile : Profile
    {
        public LoadoutProfile()
        {
            CreateMap<LoadoutFormModel, Loadout>();
            CreateMap<Loadout, LoadoutIndexViewModel>();
        }
    }
}

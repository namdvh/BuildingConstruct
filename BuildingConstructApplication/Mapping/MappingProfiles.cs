using AutoMapper;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.MaterialStore;

namespace Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProductCategories, ProductCategories>();
            CreateMap<UpdateProductType, ProductType>();
            CreateMap<UpdateProductDTO, Products>();
        }
    }
}

using AutoMapper;
using Hafina.Core.Entities;
using Hafina.Web.ViewModels;

namespace Hafina.Web.Extensions
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<BalanceSheet, BalanceSheetViewModel>();
            CreateMap<BusinessResult, BusinessResultViewModel>();
            CreateMap<Company, CompanyViewModel>();
            //    .ForMember(dto => dto.BalanceSheets, opt => opt.MapFrom(src => src.BalanceSheets))
            //    .ForMember(dto => dto.BusinessResults, opt => opt.MapFrom(src => src.BusinessResults));
        }
    }
}

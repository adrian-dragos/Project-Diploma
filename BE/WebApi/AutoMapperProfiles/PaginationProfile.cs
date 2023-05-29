using Application.DTOs.Pagination;
using Application.DTOs.Paging;
using AutoMapper;
using WebApi.ViewModels.Pagination;

namespace WebApi.AutoMapperProfiles
{
    public sealed class PaginationProfile : Profile
    {
        public PaginationProfile() 
        {
            CreateMap<PageViewModel, PageDto>();
            CreateMap(typeof(PagedResultDto<>), typeof(PagedResultViewModel<>));

        }
    }
}

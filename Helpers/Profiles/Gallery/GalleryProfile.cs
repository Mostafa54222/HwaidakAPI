using AutoMapper;
using HwaidakAPI.DTOs.Responses.Gallery;
using HwaidakAPI.Models;

namespace HwaidakAPI.Helpers.Profiles.Gallery
{
    public class GalleryProfile : Profile
    {
        public GalleryProfile()
        {
            CreateMap<VwGallery, GetGallerySections>();
            CreateMap<VwGalleryPhoto, GetGalleryPhotos>()
                .ForMember(dest => dest.GallerySectionName, opt => opt.MapFrom(src => src.GallerySectionNameSys));
        }
    }
}

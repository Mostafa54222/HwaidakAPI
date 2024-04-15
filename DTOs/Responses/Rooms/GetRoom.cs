using HwaidakAPI.Models;

namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoom
    {
        public int RoomId { get; set; }

        public int? RoomTypeCategoryId { get; set; }

        public string RoomNameSys { get; set; }

        public string RoomPmscode { get; set; }

        public string RoomUrl { get; set; }

        public string RoomBanner { get; set; }

        public bool? IsDeleted { get; set; }

        public int? HotelId { get; set; }

        public bool? IsDisplayInHome { get; set; }

        public string StartingFromCode { get; set; }

        public bool? RoomStatus { get; set; }

        public int? RoomPosition { get; set; }

        public string RoomPhoto { get; set; }

        public string RoomPhotoHome { get; set; }

        public int? HotelAccommodationTypeId { get; set; }

        public int? MaxAdult { get; set; }

        public int? MaxChild { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? HitesRoomView { get; set; }

        public int? HitesRoomBooking { get; set; }

        public int? RoomPhotoWidth { get; set; }

        public int? RoomPhotoHieght { get; set; }

        public int? RoomPhotoHomeWidth { get; set; }

        public int? RoomPhotoHomeHieght { get; set; }

        public int? RoomBannerWidth { get; set; }

        public int? RoomBannerHieght { get; set; }

        public bool? IsAllowedChild { get; set; }

        public DateTime? LastUpdate { get; set; }

        public string RoomBannerColorOverlayFrom { get; set; }

        public string RoomBannerColorOverlayTo { get; set; }

        public string RoomBannerTablet { get; set; }

        public int? RoomBannerWidthTablet { get; set; }

        public int? RoomBannerHieghtTablet { get; set; }

        public string RoomBannerTabletColorOverlayFrom { get; set; }

        public string RoomBannerTabletColorOverlayTo { get; set; }

        public string RoomBannerMobile { get; set; }

        public int? RoomBannerWidthMobile { get; set; }

        public int? RoomBannerHieghtMobile { get; set; }

        public string RoomBannerMobileColorOverlayFrom { get; set; }

        public string RoomBannerMobileColorOverlayTo { get; set; }

        public string Fb360url { get; set; }


        public GetRoomContent RoomContents { get; set; }

        public List<GetRoomGallery> RoomsGalleries { get; set; }
        public List<GetRoomAmenity> RoomAmenities { get; set; }

    }
}

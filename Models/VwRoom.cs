using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwRoom
{
    public int RoomId { get; set; }

    public int? HotelId { get; set; }

    public string RoomNameSys { get; set; }

    public bool? RoomStatus { get; set; }

    public int? RoomPosition { get; set; }

    public string RoomPhoto { get; set; }

    public string RoomBanner { get; set; }

    public string RoomPmscode { get; set; }

    public string RoomUrl { get; set; }

    public string HotelNameSys { get; set; }

    public int RoomContentId { get; set; }

    public int? LangId { get; set; }

    public string RoomName { get; set; }

    public string RoomSummery { get; set; }

    public string RoomDetails { get; set; }

    public string MaxOccupancy { get; set; }

    public string RoomSize { get; set; }

    public string RoomBed { get; set; }

    public string RoomView { get; set; }

    public bool? RoomStatusLang { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public bool? LangStatus { get; set; }

    public string MetatagTitle { get; set; }

    public string MetatagDescription { get; set; }

    public int? RoomTypeCategoryId { get; set; }

    public string StartingFromCodeLang { get; set; }

    public string FilterBy { get; set; }

    public string HotelUrl { get; set; }

    public string RoomPhotoHome { get; set; }

    public int? MaxAdult { get; set; }

    public int? MaxChild { get; set; }

    public bool? IsDisplayInHome { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string RoomTypeCategoryName { get; set; }

    public int? HitesRoomView { get; set; }

    public int? HitesRoomBooking { get; set; }

    public int? RoomPhotoWidth { get; set; }

    public int? RoomPhotoHieght { get; set; }

    public int? RoomPhotoHomeWidth { get; set; }

    public int? RoomPhotoHomeHieght { get; set; }

    public int? RoomBannerHieght { get; set; }

    public int? RoomBannerWidth { get; set; }

    public string RoomBannerAltTag { get; set; }

    public bool? IsAllowedChild { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int HotelContentId { get; set; }

    public string HotelName { get; set; }

    public string HotelAccommodation { get; set; }

    public string HotelAccommodationTitle { get; set; }

    public string HotelAccommodationMetatagTitle { get; set; }

    public string HotelAccommodationMetatagDescription { get; set; }

    public string HotelAccommodationBanner { get; set; }

    public int? HotelAccommodationBannerPhotoHieght { get; set; }

    public int? HotelAccommodationBannerPhotoWidth { get; set; }

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
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.Models;

public partial class HwaidakHotelsWsdbContext : DbContext
{
    public HwaidakHotelsWsdbContext()
    {
    }

    public HwaidakHotelsWsdbContext(DbContextOptions<HwaidakHotelsWsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CountriesContent> CountriesContents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<DestinationsContent> DestinationsContents { get; set; }

    public virtual DbSet<FacilitiesContent> FacilitiesContents { get; set; }

    public virtual DbSet<FacilitiesGallery> FacilitiesGalleries { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelsContent> HotelsContents { get; set; }

    public virtual DbSet<MasterLanguage> MasterLanguages { get; set; }

    public virtual DbSet<MasterRestaurantsCategoriesContent> MasterRestaurantsCategoriesContents { get; set; }

    public virtual DbSet<MasterRestaurantsCategory> MasterRestaurantsCategories { get; set; }

    public virtual DbSet<MasterRestaurantsType> MasterRestaurantsTypes { get; set; }

    public virtual DbSet<MasterRestaurantsTypeContent> MasterRestaurantsTypeContents { get; set; }

    public virtual DbSet<MasterRoomTypeCategory> MasterRoomTypeCategories { get; set; }

    public virtual DbSet<MasterRoomTypeCategoryContent> MasterRoomTypeCategoryContents { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantsContent> RestaurantsContents { get; set; }

    public virtual DbSet<RestaurantsGallery> RestaurantsGalleries { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomRoomAmenity> RoomRoomAmenities { get; set; }

    public virtual DbSet<RoomsContent> RoomsContents { get; set; }

    public virtual DbSet<RoomsGallery> RoomsGalleries { get; set; }

    public virtual DbSet<TblAward> TblAwards { get; set; }

    public virtual DbSet<TblAwardsCategory> TblAwardsCategories { get; set; }

    public virtual DbSet<TblAwardsContent> TblAwardsContents { get; set; }

    public virtual DbSet<TblBlog> TblBlogs { get; set; }

    public virtual DbSet<TblDocument> TblDocuments { get; set; }

    public virtual DbSet<TblExtraPage> TblExtraPages { get; set; }

    public virtual DbSet<TblExtraPagesContent> TblExtraPagesContents { get; set; }

    public virtual DbSet<TblFaqQuestion> TblFaqQuestions { get; set; }

    public virtual DbSet<TblFaqSection> TblFaqSections { get; set; }

    public virtual DbSet<TblFooterText> TblFooterTexts { get; set; }

    public virtual DbSet<TblFooterTextContent> TblFooterTextContents { get; set; }

    public virtual DbSet<TblGallerySection> TblGallerySections { get; set; }

    public virtual DbSet<TblGallerySectionsContent> TblGallerySectionsContents { get; set; }

    public virtual DbSet<TblGallerySectionsPhoto> TblGallerySectionsPhotos { get; set; }

    public virtual DbSet<TblGallerySectionsPhotosContent> TblGallerySectionsPhotosContents { get; set; }

    public virtual DbSet<TblGroupFaq> TblGroupFaqs { get; set; }

    public virtual DbSet<TblGroupFaqcontent> TblGroupFaqcontents { get; set; }

    public virtual DbSet<TblGroupHome> TblGroupHomes { get; set; }

    public virtual DbSet<TblGroupHomeContent> TblGroupHomeContents { get; set; }

    public virtual DbSet<TblGroupHomeIntroActivitiesContent> TblGroupHomeIntroActivitiesContents { get; set; }

    public virtual DbSet<TblGroupHomeIntroActivity> TblGroupHomeIntroActivities { get; set; }

    public virtual DbSet<TblGroupLayout> TblGroupLayouts { get; set; }

    public virtual DbSet<TblGroupNews> TblGroupNews { get; set; }

    public virtual DbSet<TblGroupNewsContent> TblGroupNewsContents { get; set; }

    public virtual DbSet<TblGroupPage> TblGroupPages { get; set; }

    public virtual DbSet<TblGroupPagesContent> TblGroupPagesContents { get; set; }

    public virtual DbSet<TblGroupSlider> TblGroupSliders { get; set; }

    public virtual DbSet<TblGroupSocial> TblGroupSocials { get; set; }

    public virtual DbSet<TblGym> TblGyms { get; set; }

    public virtual DbSet<TblGymContent> TblGymContents { get; set; }

    public virtual DbSet<TblGymGallery> TblGymGalleries { get; set; }

    public virtual DbSet<TblGymService> TblGymServices { get; set; }

    public virtual DbSet<TblGymServicesContent> TblGymServicesContents { get; set; }

    public virtual DbSet<TblHome> TblHomes { get; set; }

    public virtual DbSet<TblHomeContent> TblHomeContents { get; set; }

    public virtual DbSet<TblHomeDiscover> TblHomeDiscovers { get; set; }

    public virtual DbSet<TblHomeDiscoverContent> TblHomeDiscoverContents { get; set; }

    public virtual DbSet<TblHomeWhyU> TblHomeWhyUs { get; set; }

    public virtual DbSet<TblHomeWhyUsContent> TblHomeWhyUsContents { get; set; }

    public virtual DbSet<TblHotelPartner> TblHotelPartners { get; set; }

    public virtual DbSet<TblHotels360> TblHotels360s { get; set; }

    public virtual DbSet<TblHotelsCreditCard> TblHotelsCreditCards { get; set; }

    public virtual DbSet<TblHotelsFacility> TblHotelsFacilities { get; set; }

    public virtual DbSet<TblHotelsNearBy> TblHotelsNearBies { get; set; }

    public virtual DbSet<TblHotelsNearByContent> TblHotelsNearByContents { get; set; }

    public virtual DbSet<TblHotelsSocialMedium> TblHotelsSocialMedia { get; set; }

    public virtual DbSet<TblHotelsSpokenLanguage> TblHotelsSpokenLanguages { get; set; }

    public virtual DbSet<TblJob> TblJobs { get; set; }

    public virtual DbSet<TblJobsContent> TblJobsContents { get; set; }

    public virtual DbSet<TblMasterBookingCurrency> TblMasterBookingCurrencies { get; set; }

    public virtual DbSet<TblMasterBookingLanguage> TblMasterBookingLanguages { get; set; }

    public virtual DbSet<TblMasterCreditCard> TblMasterCreditCards { get; set; }

    public virtual DbSet<TblMasterCreditCardsContent> TblMasterCreditCardsContents { get; set; }

    public virtual DbSet<TblMasterHotelFacilitiesContent> TblMasterHotelFacilitiesContents { get; set; }

    public virtual DbSet<TblMasterHotelFacilitiesItem> TblMasterHotelFacilitiesItems { get; set; }

    public virtual DbSet<TblMasterHotelFacilitiesItemsContent> TblMasterHotelFacilitiesItemsContents { get; set; }

    public virtual DbSet<TblMasterHotelFacility> TblMasterHotelFacilities { get; set; }

    public virtual DbSet<TblMasterHotelType> TblMasterHotelTypes { get; set; }

    public virtual DbSet<TblMasterHotelTypesContent> TblMasterHotelTypesContents { get; set; }

    public virtual DbSet<TblMasterRoomAmenitiesCategoriesContent> TblMasterRoomAmenitiesCategoriesContents { get; set; }

    public virtual DbSet<TblMasterRoomAmenitiesCategory> TblMasterRoomAmenitiesCategories { get; set; }

    public virtual DbSet<TblMasterRoomAmenitiesContent> TblMasterRoomAmenitiesContents { get; set; }

    public virtual DbSet<TblMasterRoomAmenity> TblMasterRoomAmenities { get; set; }

    public virtual DbSet<TblMasterSiteType> TblMasterSiteTypes { get; set; }

    public virtual DbSet<TblMasterSpokenLanguage> TblMasterSpokenLanguages { get; set; }

    public virtual DbSet<TblMasterSpokenLanguagesContent> TblMasterSpokenLanguagesContents { get; set; }

    public virtual DbSet<TblMeetingsEvent> TblMeetingsEvents { get; set; }

    public virtual DbSet<TblMeetingsEventsContent> TblMeetingsEventsContents { get; set; }

    public virtual DbSet<TblMeetingsEventsGallery> TblMeetingsEventsGalleries { get; set; }

    public virtual DbSet<TblMeetingsEventsShape> TblMeetingsEventsShapes { get; set; }

    public virtual DbSet<TblMeetingsEventsShapesContent> TblMeetingsEventsShapesContents { get; set; }

    public virtual DbSet<TblNews> TblNews { get; set; }

    public virtual DbSet<TblNewsContent> TblNewsContents { get; set; }

    public virtual DbSet<TblNewsGallery> TblNewsGalleries { get; set; }

    public virtual DbSet<TblOffer> TblOffers { get; set; }

    public virtual DbSet<TblOffersContent> TblOffersContents { get; set; }

    public virtual DbSet<TblPage> TblPages { get; set; }

    public virtual DbSet<TblPagesBanner> TblPagesBanners { get; set; }

    public virtual DbSet<TblPagesContent> TblPagesContents { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblServicesContent> TblServicesContents { get; set; }

    public virtual DbSet<TblServicesHotel> TblServicesHotels { get; set; }

    public virtual DbSet<TblSiteConfiguration> TblSiteConfigurations { get; set; }

    public virtual DbSet<TblSiteContact> TblSiteContacts { get; set; }

    public virtual DbSet<TblSiteSocial> TblSiteSocials { get; set; }

    public virtual DbSet<TblSlider> TblSliders { get; set; }

    public virtual DbSet<TblSpa> TblSpas { get; set; }

    public virtual DbSet<TblSpaContent> TblSpaContents { get; set; }

    public virtual DbSet<TblSpaGallery> TblSpaGalleries { get; set; }

    public virtual DbSet<TblSpaService> TblSpaServices { get; set; }

    public virtual DbSet<TblSpaServicesContent> TblSpaServicesContents { get; set; }

    public virtual DbSet<TblSpaServicesType> TblSpaServicesTypes { get; set; }

    public virtual DbSet<TblSpaServicesTypesContent> TblSpaServicesTypesContents { get; set; }

    public virtual DbSet<TblTeam> TblTeams { get; set; }

    public virtual DbSet<TblTeamsContent> TblTeamsContents { get; set; }

    public virtual DbSet<VwAward> VwAwards { get; set; }

    public virtual DbSet<VwAwardsFilter> VwAwardsFilters { get; set; }

    public virtual DbSet<VwBlog> VwBlogs { get; set; }

    public virtual DbSet<VwDocument> VwDocuments { get; set; }

    public virtual DbSet<VwExtraPage> VwExtraPages { get; set; }

    public virtual DbSet<VwFacility> VwFacilities { get; set; }

    public virtual DbSet<VwFaq> VwFaqs { get; set; }

    public virtual DbSet<VwFaqActiveSection> VwFaqActiveSections { get; set; }

    public virtual DbSet<VwFaqSection> VwFaqSections { get; set; }

    public virtual DbSet<VwFooterText> VwFooterTexts { get; set; }

    public virtual DbSet<VwGallery> VwGalleries { get; set; }

    public virtual DbSet<VwGalleryActive> VwGalleryActives { get; set; }

    public virtual DbSet<VwGalleryPhoto> VwGalleryPhotos { get; set; }

    public virtual DbSet<VwGroupFaq> VwGroupFaqs { get; set; }

    public virtual DbSet<VwGroupHome> VwGroupHomes { get; set; }

    public virtual DbSet<VwGroupHomeIntroActivity> VwGroupHomeIntroActivities { get; set; }

    public virtual DbSet<VwGroupNews> VwGroupNews { get; set; }

    public virtual DbSet<VwGroupPage> VwGroupPages { get; set; }

    public virtual DbSet<VwGym> VwGyms { get; set; }

    public virtual DbSet<VwGymService> VwGymServices { get; set; }

    public virtual DbSet<VwHome> VwHomes { get; set; }

    public virtual DbSet<VwHomeDiscover> VwHomeDiscovers { get; set; }

    public virtual DbSet<VwHomeWhyU> VwHomeWhyUs { get; set; }

    public virtual DbSet<VwHotel> VwHotels { get; set; }

    public virtual DbSet<VwHotelsCreditCard> VwHotelsCreditCards { get; set; }

    public virtual DbSet<VwHotelsDestinationCm> VwHotelsDestinationCms { get; set; }

    public virtual DbSet<VwHotelsFacilitiesGallery> VwHotelsFacilitiesGalleries { get; set; }

    public virtual DbSet<VwHotelsFacility> VwHotelsFacilities { get; set; }

    public virtual DbSet<VwHotelsNearBy> VwHotelsNearBies { get; set; }

    public virtual DbSet<VwHotelsSpokenLanguage> VwHotelsSpokenLanguages { get; set; }

    public virtual DbSet<VwJob> VwJobs { get; set; }

    public virtual DbSet<VwMasterHotelFacilitiesItem> VwMasterHotelFacilitiesItems { get; set; }

    public virtual DbSet<VwMasterHotelFacility> VwMasterHotelFacilities { get; set; }

    public virtual DbSet<VwMasterRoomAmenity> VwMasterRoomAmenities { get; set; }

    public virtual DbSet<VwMasterRoomTypeCategory> VwMasterRoomTypeCategories { get; set; }

    public virtual DbSet<VwMeetingsEvent> VwMeetingsEvents { get; set; }

    public virtual DbSet<VwMeetingsEventsGallery> VwMeetingsEventsGalleries { get; set; }

    public virtual DbSet<VwMeetingsEventsShape> VwMeetingsEventsShapes { get; set; }

    public virtual DbSet<VwNews> VwNews { get; set; }

    public virtual DbSet<VwOffer> VwOffers { get; set; }

    public virtual DbSet<VwPage> VwPages { get; set; }

    public virtual DbSet<VwRestaurant> VwRestaurants { get; set; }

    public virtual DbSet<VwRestaurantsGallery> VwRestaurantsGalleries { get; set; }

    public virtual DbSet<VwRestaurantsType> VwRestaurantsTypes { get; set; }

    public virtual DbSet<VwRoom> VwRooms { get; set; }

    public virtual DbSet<VwRoomsAmenity> VwRoomsAmenities { get; set; }

    public virtual DbSet<VwRoomsGallery> VwRoomsGalleries { get; set; }

    public virtual DbSet<VwSiteContact> VwSiteContacts { get; set; }

    public virtual DbSet<VwSlider> VwSliders { get; set; }

    public virtual DbSet<VwSpa> VwSpas { get; set; }

    public virtual DbSet<VwSpaService> VwSpaServices { get; set; }

    public virtual DbSet<VwSpaServicesType> VwSpaServicesTypes { get; set; }

    public virtual DbSet<VwTeam> VwTeams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("titDevusrWSDB2024");

        modelBuilder.Entity<CountriesContent>(entity =>
        {
            entity.HasKey(e => e.CountryContentId);

            entity.ToTable("Countries_Content", "dbo");

            entity.Property(e => e.CountryContentId).HasColumnName("CountryContentID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Countries", "dbo", tb =>
                {
                    tb.HasTrigger("CountriesURL");
                    tb.HasTrigger("Countries_Content_trigger");
                });

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryNameSys)
                .HasMaxLength(250)
                .HasColumnName("CountryNameSYS");
            entity.Property(e => e.CountryStatus).HasDefaultValue(false);
            entity.Property(e => e.CountryUrl)
                .HasMaxLength(250)
                .HasColumnName("CountryURL");
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.ToTable("Destinations", "dbo", tb =>
                {
                    tb.HasTrigger("DestinationsURL");
                    tb.HasTrigger("Destinations_Content_trigger");
                });

            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DestinationBanner).HasMaxLength(250);
            entity.Property(e => e.DestinationNameSys).HasMaxLength(250);
            entity.Property(e => e.DestinationPhoto).HasMaxLength(250);
            entity.Property(e => e.DestinationUrl)
                .HasMaxLength(250)
                .HasColumnName("DestinationURL");
        });

        modelBuilder.Entity<DestinationsContent>(entity =>
        {
            entity.HasKey(e => e.DestinationContentId);

            entity.ToTable("Destinations_Content", "dbo");

            entity.Property(e => e.DestinationContentId).HasColumnName("DestinationContentID");
            entity.Property(e => e.DestinationDetails).HasColumnType("ntext");
            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.DestinationIntro).HasColumnType("ntext");
            entity.Property(e => e.DestinationName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
        });

        modelBuilder.Entity<FacilitiesContent>(entity =>
        {
            entity.HasKey(e => e.FacilityContentId);

            entity.ToTable("Facilities_Content", "dbo");

            entity.Property(e => e.FacilityContentId).HasColumnName("FacilityContentID");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");

            entity.HasOne(d => d.Facility).WithMany(p => p.FacilitiesContents)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Facilities_Content_Facilities");
        });

        modelBuilder.Entity<FacilitiesGallery>(entity =>
        {
            entity.HasKey(e => e.FacilitiesFileId);

            entity.ToTable("Facilities_Gallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.FacilitiesId).HasColumnName("FacilitiesID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);

            entity.HasOne(d => d.Facilities).WithMany(p => p.FacilitiesGalleries)
                .HasForeignKey(d => d.FacilitiesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Facilities_Gallery_Facilities");
        });

        modelBuilder.Entity<Facility>(entity =>
        {
            entity.ToTable("Facilities", "dbo", tb =>
                {
                    tb.HasTrigger("FacilitiesURL");
                    tb.HasTrigger("Facilities_Content_trigger");
                });

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityClassIcon).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityPhotoHome).HasMaxLength(250);
            entity.Property(e => e.FacilityStatus).HasDefaultValue(true);
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMoreDetails).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.ToTable("Hotels", "dbo", tb => tb.HasTrigger("HotelURL"));

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.HotelAboutUsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner");
            entity.Property(e => e.HotelAboutUsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile");
            entity.Property(e => e.HotelAboutUsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerMobileHieght).HasColumnName("HotelAbout_us_BannerMobile_Hieght");
            entity.Property(e => e.HotelAboutUsBannerMobileWidth).HasColumnName("HotelAbout_us_BannerMobile_Width");
            entity.Property(e => e.HotelAboutUsBannerPhotoHieght).HasColumnName("HotelAbout_us_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAboutUsBannerPhotoWidth).HasColumnName("HotelAbout_us_BannerPhoto_Width");
            entity.Property(e => e.HotelAboutUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet");
            entity.Property(e => e.HotelAboutUsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerTabletHieght).HasColumnName("HotelAbout_us_BannerTablet_Hieght");
            entity.Property(e => e.HotelAboutUsBannerTabletWidth).HasColumnName("HotelAbout_us_BannerTablet_Width");
            entity.Property(e => e.HotelAccommodationBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner");
            entity.Property(e => e.HotelAccommodationBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile");
            entity.Property(e => e.HotelAccommodationBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerMobileHieght).HasColumnName("HotelAccommodation_BannerMobile_Hieght");
            entity.Property(e => e.HotelAccommodationBannerMobileWidth).HasColumnName("HotelAccommodation_BannerMobile_Width");
            entity.Property(e => e.HotelAccommodationBannerPhotoHieght).HasColumnName("HotelAccommodation_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAccommodationBannerPhotoWidth).HasColumnName("HotelAccommodation_BannerPhoto_Width");
            entity.Property(e => e.HotelAccommodationBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet");
            entity.Property(e => e.HotelAccommodationBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerTabletHieght).HasColumnName("HotelAccommodation_BannerTablet_Hieght");
            entity.Property(e => e.HotelAccommodationBannerTabletWidth).HasColumnName("HotelAccommodation_BannerTablet_Width");
            entity.Property(e => e.HotelAllInclusiveBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner");
            entity.Property(e => e.HotelAllInclusiveBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile");
            entity.Property(e => e.HotelAllInclusiveBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerMobileHieght).HasColumnName("HotelAllInclusive_BannerMobile_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerMobileWidth).HasColumnName("HotelAllInclusive_BannerMobile_Width");
            entity.Property(e => e.HotelAllInclusiveBannerPhotoHieght).HasColumnName("HotelAllInclusive_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerPhotoWidth).HasColumnName("HotelAllInclusive_BannerPhoto_Width");
            entity.Property(e => e.HotelAllInclusiveBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet");
            entity.Property(e => e.HotelAllInclusiveBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerTabletHieght).HasColumnName("HotelAllInclusive_BannerTablet_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerTabletWidth).HasColumnName("HotelAllInclusive_BannerTablet_Width");
            entity.Property(e => e.HotelAwardBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner");
            entity.Property(e => e.HotelAwardBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerHieght).HasColumnName("HotelAward_Banner_Hieght");
            entity.Property(e => e.HotelAwardBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile");
            entity.Property(e => e.HotelAwardBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerMobileHieght).HasColumnName("HotelAward_BannerMobile_Hieght");
            entity.Property(e => e.HotelAwardBannerMobileWidth).HasColumnName("HotelAward_BannerMobile_Width");
            entity.Property(e => e.HotelAwardBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet");
            entity.Property(e => e.HotelAwardBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerTabletHieght).HasColumnName("HotelAward_BannerTablet_Hieght");
            entity.Property(e => e.HotelAwardBannerTabletWidth).HasColumnName("HotelAward_BannerTablet_Width");
            entity.Property(e => e.HotelAwardBannerWidth).HasColumnName("HotelAward_Banner_Width");
            entity.Property(e => e.HotelBlogBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner");
            entity.Property(e => e.HotelBlogBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile");
            entity.Property(e => e.HotelBlogBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerMobileHieght).HasColumnName("HotelBlog_BannerMobile_Hieght");
            entity.Property(e => e.HotelBlogBannerMobileWidth).HasColumnName("HotelBlog_BannerMobile_Width");
            entity.Property(e => e.HotelBlogBannerPhotoHieght).HasColumnName("HotelBlog_BannerPhoto_Hieght");
            entity.Property(e => e.HotelBlogBannerPhotoWidth).HasColumnName("HotelBlog_BannerPhoto_Width");
            entity.Property(e => e.HotelBlogBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet");
            entity.Property(e => e.HotelBlogBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerTabletHieght).HasColumnName("HotelBlog_BannerTablet_Hieght");
            entity.Property(e => e.HotelBlogBannerTabletWidth).HasColumnName("HotelBlog_BannerTablet_Width");
            entity.Property(e => e.HotelCareerBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner");
            entity.Property(e => e.HotelCareerBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile");
            entity.Property(e => e.HotelCareerBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerMobileHieght).HasColumnName("HotelCareer_BannerMobile_Hieght");
            entity.Property(e => e.HotelCareerBannerMobileWidth).HasColumnName("HotelCareer_BannerMobile_Width");
            entity.Property(e => e.HotelCareerBannerPhotoHieght).HasColumnName("HotelCareer_BannerPhoto_Hieght");
            entity.Property(e => e.HotelCareerBannerPhotoWidth).HasColumnName("HotelCareer_BannerPhoto_Width");
            entity.Property(e => e.HotelCareerBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet");
            entity.Property(e => e.HotelCareerBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerTabletHieght).HasColumnName("HotelCareer_BannerTablet_Hieght");
            entity.Property(e => e.HotelCareerBannerTabletWidth).HasColumnName("HotelCareer_BannerTablet_Width");
            entity.Property(e => e.HotelContactBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner");
            entity.Property(e => e.HotelContactBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerHieght).HasColumnName("HotelContact_Banner_Hieght");
            entity.Property(e => e.HotelContactBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile");
            entity.Property(e => e.HotelContactBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerMobileHieght).HasColumnName("HotelContact_BannerMobile_Hieght");
            entity.Property(e => e.HotelContactBannerMobileWidth).HasColumnName("HotelContact_BannerMobile_Width");
            entity.Property(e => e.HotelContactBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet");
            entity.Property(e => e.HotelContactBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerTabletHieght).HasColumnName("HotelContact_BannerTablet_Hieght");
            entity.Property(e => e.HotelContactBannerTabletWidth).HasColumnName("HotelContact_BannerTablet_Width");
            entity.Property(e => e.HotelContactBannerWidth).HasColumnName("HotelContact_Banner_Width");
            entity.Property(e => e.HotelContactThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner");
            entity.Property(e => e.HotelContactThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerHight).HasColumnName("HotelContact_Thanks_Banner_Hight");
            entity.Property(e => e.HotelContactThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile");
            entity.Property(e => e.HotelContactThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerMobileHight).HasColumnName("HotelContact_Thanks_BannerMobile_Hight");
            entity.Property(e => e.HotelContactThanksBannerMobileWidth).HasColumnName("HotelContact_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelContactThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet");
            entity.Property(e => e.HotelContactThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerTabletHight).HasColumnName("HotelContact_Thanks_BannerTablet_Hight");
            entity.Property(e => e.HotelContactThanksBannerTabletWidth).HasColumnName("HotelContact_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelContactThanksBannerWidth).HasColumnName("HotelContact_Thanks_Banner_Width");
            entity.Property(e => e.HotelCovidBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner");
            entity.Property(e => e.HotelCovidBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile");
            entity.Property(e => e.HotelCovidBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerMobileHieght).HasColumnName("HotelCovid_BannerMobile_Hieght");
            entity.Property(e => e.HotelCovidBannerMobileWidth).HasColumnName("HotelCovid_BannerMobile_Width");
            entity.Property(e => e.HotelCovidBannerPhotoHieght).HasColumnName("HotelCovid_BannerPhoto_Hieght");
            entity.Property(e => e.HotelCovidBannerPhotoWidth).HasColumnName("HotelCovid_BannerPhoto_Width");
            entity.Property(e => e.HotelCovidBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet");
            entity.Property(e => e.HotelCovidBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerTabletHieght).HasColumnName("HotelCovid_BannerTablet_Hieght");
            entity.Property(e => e.HotelCovidBannerTabletWidth).HasColumnName("HotelCovid_BannerTablet_Width");
            entity.Property(e => e.HotelDiningBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner");
            entity.Property(e => e.HotelDiningBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerHieght).HasColumnName("HotelDining_Banner_Hieght");
            entity.Property(e => e.HotelDiningBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile");
            entity.Property(e => e.HotelDiningBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerMobileHieght).HasColumnName("HotelDining_BannerMobile_Hieght");
            entity.Property(e => e.HotelDiningBannerMobileWidth).HasColumnName("HotelDining_BannerMobile_Width");
            entity.Property(e => e.HotelDiningBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet");
            entity.Property(e => e.HotelDiningBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerTabletHieght).HasColumnName("HotelDining_BannerTablet_Hieght");
            entity.Property(e => e.HotelDiningBannerTabletWidth).HasColumnName("HotelDining_BannerTablet_Width");
            entity.Property(e => e.HotelDiningBannerWidth).HasColumnName("HotelDining_Banner_Width");
            entity.Property(e => e.HotelEmail).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner");
            entity.Property(e => e.HotelFacilitiesBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerHieght).HasColumnName("HotelFacilities_Banner_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile");
            entity.Property(e => e.HotelFacilitiesBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerMobileHieght).HasColumnName("HotelFacilities_BannerMobile_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerMobileWidth).HasColumnName("HotelFacilities_BannerMobile_Width");
            entity.Property(e => e.HotelFacilitiesBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet");
            entity.Property(e => e.HotelFacilitiesBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerTabletHieght).HasColumnName("HotelFacilities_BannerTablet_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerTabletWidth).HasColumnName("HotelFacilities_BannerTablet_Width");
            entity.Property(e => e.HotelFacilitiesBannerWidth).HasColumnName("HotelFacilities_Banner_Width");
            entity.Property(e => e.HotelFaqBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner");
            entity.Property(e => e.HotelFaqBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile");
            entity.Property(e => e.HotelFaqBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerMobileHieght).HasColumnName("HotelFAQ_BannerMobile_Hieght");
            entity.Property(e => e.HotelFaqBannerMobileWidth).HasColumnName("HotelFAQ_BannerMobile_Width");
            entity.Property(e => e.HotelFaqBannerPhotoHieght).HasColumnName("HotelFAQ_BannerPhoto_Hieght");
            entity.Property(e => e.HotelFaqBannerPhotoWidth).HasColumnName("HotelFAQ_BannerPhoto_Width");
            entity.Property(e => e.HotelFaqBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet");
            entity.Property(e => e.HotelFaqBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerTabletHieght).HasColumnName("HotelFAQ_BannerTablet_Hieght");
            entity.Property(e => e.HotelFaqBannerTabletWidth).HasColumnName("HotelFAQ_BannerTablet_Width");
            entity.Property(e => e.HotelFaqThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner");
            entity.Property(e => e.HotelFaqThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile");
            entity.Property(e => e.HotelFaqThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerMobileHieght).HasColumnName("HotelFAQ_Thanks_BannerMobile_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerMobileWidth).HasColumnName("HotelFAQ_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelFaqThanksBannerPhotoHieght).HasColumnName("HotelFAQ_Thanks_BannerPhoto_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerPhotoWidth).HasColumnName("HotelFAQ_Thanks_BannerPhoto_Width");
            entity.Property(e => e.HotelFaqThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet");
            entity.Property(e => e.HotelFaqThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerTabletHieght).HasColumnName("HotelFAQ_Thanks_BannerTablet_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerTabletWidth).HasColumnName("HotelFAQ_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelFax).HasMaxLength(250);
            entity.Property(e => e.HotelGalleryBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner");
            entity.Property(e => e.HotelGalleryBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerHieght).HasColumnName("HotelGallery_Banner_Hieght");
            entity.Property(e => e.HotelGalleryBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile");
            entity.Property(e => e.HotelGalleryBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerMobileHieght).HasColumnName("HotelGallery_BannerMobile_Hieght");
            entity.Property(e => e.HotelGalleryBannerMobileWidth).HasColumnName("HotelGallery_BannerMobile_Width");
            entity.Property(e => e.HotelGalleryBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet");
            entity.Property(e => e.HotelGalleryBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerTabletHieght).HasColumnName("HotelGallery_BannerTablet_Hieght");
            entity.Property(e => e.HotelGalleryBannerTabletWidth).HasColumnName("HotelGallery_BannerTablet_Width");
            entity.Property(e => e.HotelGalleryBannerWidth).HasColumnName("HotelGallery_Banner_Width");
            entity.Property(e => e.HotelLocationBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner");
            entity.Property(e => e.HotelLocationBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile");
            entity.Property(e => e.HotelLocationBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerMobileHieght).HasColumnName("HotelLocation_BannerMobile_Hieght");
            entity.Property(e => e.HotelLocationBannerMobileWidth).HasColumnName("HotelLocation_BannerMobile_Width");
            entity.Property(e => e.HotelLocationBannerPhotoHieght).HasColumnName("HotelLocation_BannerPhoto_Hieght");
            entity.Property(e => e.HotelLocationBannerPhotoWidth).HasColumnName("HotelLocation_BannerPhoto_Width");
            entity.Property(e => e.HotelLocationBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet");
            entity.Property(e => e.HotelLocationBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerTabletHieght).HasColumnName("HotelLocation_BannerTablet_Hieght");
            entity.Property(e => e.HotelLocationBannerTabletWidth).HasColumnName("HotelLocation_BannerTablet_Width");
            entity.Property(e => e.HotelLogo).HasMaxLength(250);
            entity.Property(e => e.HotelLogoColored)
                .HasMaxLength(250)
                .HasColumnName("HotelLogo_Colored");
            entity.Property(e => e.HotelMeetingBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner");
            entity.Property(e => e.HotelMeetingBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerHieght).HasColumnName("HotelMeeting_Banner_Hieght");
            entity.Property(e => e.HotelMeetingBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile");
            entity.Property(e => e.HotelMeetingBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerMobileHieght).HasColumnName("HotelMeeting_BannerMobile_Hieght");
            entity.Property(e => e.HotelMeetingBannerMobileWidth).HasColumnName("HotelMeeting_BannerMobile_Width");
            entity.Property(e => e.HotelMeetingBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet");
            entity.Property(e => e.HotelMeetingBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerTabletHieght).HasColumnName("HotelMeeting_BannerTablet_Hieght");
            entity.Property(e => e.HotelMeetingBannerTabletWidth).HasColumnName("HotelMeeting_BannerTablet_Width");
            entity.Property(e => e.HotelMeetingBannerWidth).HasColumnName("HotelMeeting_Banner_Width");
            entity.Property(e => e.HotelMeetingThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner");
            entity.Property(e => e.HotelMeetingThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerHieght).HasColumnName("HotelMeeting_Thanks_Banner_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile");
            entity.Property(e => e.HotelMeetingThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerMobileHieght).HasColumnName("HotelMeeting_Thanks_BannerMobile_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerMobileWidth).HasColumnName("HotelMeeting_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelMeetingThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet");
            entity.Property(e => e.HotelMeetingThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerTabletHieght).HasColumnName("HotelMeeting_Thanks_BannerTablet_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerTabletWidth).HasColumnName("HotelMeeting_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelMeetingThanksBannerWidth).HasColumnName("HotelMeeting_Thanks_Banner_Width");
            entity.Property(e => e.HotelMobile).HasMaxLength(250);
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelNearBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNear_Banner");
            entity.Property(e => e.HotelNearBannerHieght).HasColumnName("HotelNear_Banner_Hieght");
            entity.Property(e => e.HotelNearBannerWidth).HasColumnName("HotelNear_Banner_Width");
            entity.Property(e => e.HotelNewsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner");
            entity.Property(e => e.HotelNewsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile");
            entity.Property(e => e.HotelNewsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerMobileHieght).HasColumnName("HotelNews_BannerMobile_Hieght");
            entity.Property(e => e.HotelNewsBannerMobileWidth).HasColumnName("HotelNews_BannerMobile_Width");
            entity.Property(e => e.HotelNewsBannerPhotoHieght).HasColumnName("HotelNews_BannerPhoto_Hieght");
            entity.Property(e => e.HotelNewsBannerPhotoWidth).HasColumnName("HotelNews_BannerPhoto_Width");
            entity.Property(e => e.HotelNewsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet");
            entity.Property(e => e.HotelNewsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerTabletHieght).HasColumnName("HotelNews_BannerTablet_Hieght");
            entity.Property(e => e.HotelNewsBannerTabletWidth).HasColumnName("HotelNews_BannerTablet_Width");
            entity.Property(e => e.HotelNewsletterThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner");
            entity.Property(e => e.HotelNewsletterThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerHight).HasColumnName("HotelNewsletter_Thanks_Banner_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileHight).HasColumnName("HotelNewsletter_Thanks_BannerMobile_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileWidth).HasColumnName("HotelNewsletter_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelNewsletterThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletHight).HasColumnName("HotelNewsletter_Thanks_BannerTablet_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletWidth).HasColumnName("HotelNewsletter_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelNewsletterThanksBannerWidth).HasColumnName("HotelNewsletter_Thanks_Banner_Width");
            entity.Property(e => e.HotelOfferBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner");
            entity.Property(e => e.HotelOfferBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerHieght).HasColumnName("HotelOffer_Banner_Hieght");
            entity.Property(e => e.HotelOfferBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile");
            entity.Property(e => e.HotelOfferBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerMobileHieght).HasColumnName("HotelOffer_BannerMobile_Hieght");
            entity.Property(e => e.HotelOfferBannerMobileWidth).HasColumnName("HotelOffer_BannerMobile_Width");
            entity.Property(e => e.HotelOfferBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet");
            entity.Property(e => e.HotelOfferBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerTabletHieght).HasColumnName("HotelOffer_BannerTablet_Hieght");
            entity.Property(e => e.HotelOfferBannerTabletWidth).HasColumnName("HotelOffer_BannerTablet_Width");
            entity.Property(e => e.HotelOfferBannerWidth).HasColumnName("HotelOffer_Banner_Width");
            entity.Property(e => e.HotelPhone).HasMaxLength(250);
            entity.Property(e => e.HotelPhoto).HasMaxLength(250);
            entity.Property(e => e.HotelPhotoGroup)
                .HasMaxLength(250)
                .HasColumnName("HotelPhoto_Group");
            entity.Property(e => e.HotelPhotoGroupHeight).HasColumnName("HotelPhoto_Group_Height");
            entity.Property(e => e.HotelPhotoGroupWidth).HasColumnName("HotelPhoto_Group_Width");
            entity.Property(e => e.HotelPmscode)
                .HasMaxLength(250)
                .HasColumnName("HotelPMSCode");
            entity.Property(e => e.HotelPrivacyBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner");
            entity.Property(e => e.HotelPrivacyBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile");
            entity.Property(e => e.HotelPrivacyBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerMobileHieght).HasColumnName("HotelPrivacy_BannerMobile_Hieght");
            entity.Property(e => e.HotelPrivacyBannerMobileWidth).HasColumnName("HotelPrivacy_BannerMobile_Width");
            entity.Property(e => e.HotelPrivacyBannerPhotoHieght).HasColumnName("HotelPrivacy_BannerPhoto_Hieght");
            entity.Property(e => e.HotelPrivacyBannerPhotoWidth).HasColumnName("HotelPrivacy_BannerPhoto_Width");
            entity.Property(e => e.HotelPrivacyBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet");
            entity.Property(e => e.HotelPrivacyBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerTabletHieght).HasColumnName("HotelPrivacy_BannerTablet_Hieght");
            entity.Property(e => e.HotelPrivacyBannerTabletWidth).HasColumnName("HotelPrivacy_BannerTablet_Width");
            entity.Property(e => e.HotelSocialBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelSocial_Banner");
            entity.Property(e => e.HotelSocialBannerHieght).HasColumnName("HotelSocial_Banner_Hieght");
            entity.Property(e => e.HotelSocialBannerWidth).HasColumnName("HotelSocial_Banner_Width");
            entity.Property(e => e.HotelTeamBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner");
            entity.Property(e => e.HotelTeamBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerHieght).HasColumnName("HotelTeam_Banner_Hieght");
            entity.Property(e => e.HotelTeamBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile");
            entity.Property(e => e.HotelTeamBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerMobileHieght).HasColumnName("HotelTeam_BannerMobile_Hieght");
            entity.Property(e => e.HotelTeamBannerMobileWidth).HasColumnName("HotelTeam_BannerMobile_Width");
            entity.Property(e => e.HotelTeamBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet");
            entity.Property(e => e.HotelTeamBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerTabletHieght).HasColumnName("HotelTeam_BannerTablet_Hieght");
            entity.Property(e => e.HotelTeamBannerTabletWidth).HasColumnName("HotelTeam_BannerTablet_Width");
            entity.Property(e => e.HotelTeamBannerWidth).HasColumnName("HotelTeam_Banner_Width");
            entity.Property(e => e.HotelTermsConditionsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner");
            entity.Property(e => e.HotelTermsConditionsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile");
            entity.Property(e => e.HotelTermsConditionsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerMobileHieght).HasColumnName("HotelTerms_Conditions_BannerMobile_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerMobileWidth).HasColumnName("HotelTerms_Conditions_BannerMobile_Width");
            entity.Property(e => e.HotelTermsConditionsBannerPhotoHieght).HasColumnName("HotelTerms_Conditions_BannerPhoto_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerPhotoWidth).HasColumnName("HotelTerms_Conditions_BannerPhoto_Width");
            entity.Property(e => e.HotelTermsConditionsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet");
            entity.Property(e => e.HotelTermsConditionsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerTabletHieght).HasColumnName("HotelTerms_Conditions_BannerTablet_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerTabletWidth).HasColumnName("HotelTerms_Conditions_BannerTablet_Width");
            entity.Property(e => e.HotelTypeId).HasColumnName("HotelTypeID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.HotelWellnessBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner");
            entity.Property(e => e.HotelWellnessBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile");
            entity.Property(e => e.HotelWellnessBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerMobileHieght).HasColumnName("HotelWellness_BannerMobile_Hieght");
            entity.Property(e => e.HotelWellnessBannerMobileWidth).HasColumnName("HotelWellness_BannerMobile_Width");
            entity.Property(e => e.HotelWellnessBannerPhotoHieght).HasColumnName("HotelWellness_BannerPhoto_Hieght");
            entity.Property(e => e.HotelWellnessBannerPhotoWidth).HasColumnName("HotelWellness_BannerPhoto_Width");
            entity.Property(e => e.HotelWellnessBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet");
            entity.Property(e => e.HotelWellnessBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerTabletHieght).HasColumnName("HotelWellness_BannerTablet_Hieght");
            entity.Property(e => e.HotelWellnessBannerTabletWidth).HasColumnName("HotelWellness_BannerTablet_Width");
            entity.Property(e => e.HotelWhatsAppNumber).HasMaxLength(250);
            entity.Property(e => e.HotelYouTube).HasMaxLength(250);
            entity.Property(e => e.ReservationEmail).HasMaxLength(250);
            entity.Property(e => e.TripAdvisorKey).HasMaxLength(250);
            entity.Property(e => e.TripAdvisorUrl)
                .HasColumnType("ntext")
                .HasColumnName("TripAdvisorURL");
        });

        modelBuilder.Entity<HotelsContent>(entity =>
        {
            entity.HasKey(e => e.HotelContentId);

            entity.ToTable("Hotels_Content", "dbo");

            entity.Property(e => e.HotelContentId).HasColumnName("HotelContentID");
            entity.Property(e => e.HotelAboutUs)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us");
            entity.Property(e => e.HotelAboutUsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_MetaTagTitle");
            entity.Property(e => e.HotelAboutUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_MetatagDescription");
            entity.Property(e => e.HotelAboutUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_Title");
            entity.Property(e => e.HotelAccommodation).HasColumnType("ntext");
            entity.Property(e => e.HotelAccommodationMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagDescription");
            entity.Property(e => e.HotelAccommodationMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagTitle");
            entity.Property(e => e.HotelAccommodationTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_Title");
            entity.Property(e => e.HotelAddress).HasColumnType("ntext");
            entity.Property(e => e.HotelAllInclusive).HasColumnType("ntext");
            entity.Property(e => e.HotelAllInclusiveMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_MetatagDescription");
            entity.Property(e => e.HotelAllInclusiveMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_MetatagTitle");
            entity.Property(e => e.HotelAllInclusiveTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_Title");
            entity.Property(e => e.HotelAwards).HasColumnType("ntext");
            entity.Property(e => e.HotelAwardsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_MetatagDescription");
            entity.Property(e => e.HotelAwardsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_MetatagTitle");
            entity.Property(e => e.HotelAwardsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_Title");
            entity.Property(e => e.HotelBlog).HasColumnType("ntext");
            entity.Property(e => e.HotelBlogMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_MetaTagTitle");
            entity.Property(e => e.HotelBlogMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_MetatagDescription");
            entity.Property(e => e.HotelBlogTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_Title");
            entity.Property(e => e.HotelBookingUrl)
                .HasColumnType("ntext")
                .HasColumnName("HotelBookingURL");
            entity.Property(e => e.HotelCareer).HasColumnType("ntext");
            entity.Property(e => e.HotelCareerMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_MetaTagTitle");
            entity.Property(e => e.HotelCareerMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_MetatagDescription");
            entity.Property(e => e.HotelCareerTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_Title");
            entity.Property(e => e.HotelContact).HasColumnType("ntext");
            entity.Property(e => e.HotelContactMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_MetaTagTitle");
            entity.Property(e => e.HotelContactMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_MetatagDescription");
            entity.Property(e => e.HotelContactThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks");
            entity.Property(e => e.HotelContactThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelContactThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_MetatagDescription");
            entity.Property(e => e.HotelContactThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_Title");
            entity.Property(e => e.HotelContactTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Title");
            entity.Property(e => e.HotelContactUsIcon).HasColumnType("ntext");
            entity.Property(e => e.HotelContactUsSummery).HasMaxLength(250);
            entity.Property(e => e.HotelContactUsTitle).HasMaxLength(250);
            entity.Property(e => e.HotelContactUsTitleTop).HasMaxLength(250);
            entity.Property(e => e.HotelCovid).HasColumnType("ntext");
            entity.Property(e => e.HotelCovidMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_MetaTagTitle");
            entity.Property(e => e.HotelCovidMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_MetatagDescription");
            entity.Property(e => e.HotelCovidTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_Title");
            entity.Property(e => e.HotelDining).HasColumnType("ntext");
            entity.Property(e => e.HotelDiningMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_MetatagDescription");
            entity.Property(e => e.HotelDiningMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_MetatagTitle");
            entity.Property(e => e.HotelDiningTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_Title");
            entity.Property(e => e.HotelFacilities).HasColumnType("ntext");
            entity.Property(e => e.HotelFacilitiesMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_MetatagDescription");
            entity.Property(e => e.HotelFacilitiesMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_MetatagTitle");
            entity.Property(e => e.HotelFacilitiesTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_Title");
            entity.Property(e => e.HotelFactsheet).HasMaxLength(250);
            entity.Property(e => e.HotelFaq)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ");
            entity.Property(e => e.HotelFaqMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_MetaTagTitle");
            entity.Property(e => e.HotelFaqMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_MetatagDescription");
            entity.Property(e => e.HotelFaqThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks");
            entity.Property(e => e.HotelFaqThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelFaqThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_MetatagDescription");
            entity.Property(e => e.HotelFaqThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_Title");
            entity.Property(e => e.HotelFaqTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Title");
            entity.Property(e => e.HotelGallery).HasColumnType("ntext");
            entity.Property(e => e.HotelGalleryMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_MetatagDescription");
            entity.Property(e => e.HotelGalleryMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_MetatagTitle");
            entity.Property(e => e.HotelGalleryTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_Title");
            entity.Property(e => e.HotelGetDirectionLink)
                .HasDefaultValue("https://www.google.com/maps/place/Morning+Star+Aqua+Center+Touristik/@27.10613,33.829114,15z/data=!4m6!3m5!1s0x145281fca4c970bb:0x8149af53399961b!8m2!3d27.1002295!4d33.8384214!16s%2Fg%2F11swtbr7jf?hl=en&entry=ttu")
                .HasColumnType("ntext");
            entity.Property(e => e.HotelGoogleMap)
                .HasDefaultValue("https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d7103.200482367639!2d33.8278722!3d27.105898!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1452803057081873%3A0xc641996e5bcee8ee!2sAladdin%20Beach%20Resort!5e0!3m2!1sen!2seg!4v1712690215090!5m2!1sen!2seg")
                .HasColumnType("ntext");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelLocation).HasColumnType("ntext");
            entity.Property(e => e.HotelLocationMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_MetatagDescription");
            entity.Property(e => e.HotelLocationMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_MetatagTitle");
            entity.Property(e => e.HotelLocationTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_Title");
            entity.Property(e => e.HotelMeeitngThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeitng_Thanks_MetatagDescription");
            entity.Property(e => e.HotelMeeting).HasColumnType("ntext");
            entity.Property(e => e.HotelMeetingMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_MetatagDescription");
            entity.Property(e => e.HotelMeetingMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_MetatagTitle");
            entity.Property(e => e.HotelMeetingThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks");
            entity.Property(e => e.HotelMeetingThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelMeetingThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks_Title");
            entity.Property(e => e.HotelMeetingTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Title");
            entity.Property(e => e.HotelName).HasMaxLength(250);
            entity.Property(e => e.HotelNear).HasColumnType("ntext");
            entity.Property(e => e.HotelNearMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_MetatagDescription");
            entity.Property(e => e.HotelNearMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_MetatagTitle");
            entity.Property(e => e.HotelNearTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_Title");
            entity.Property(e => e.HotelNews).HasColumnType("ntext");
            entity.Property(e => e.HotelNewsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_MetaTagTitle");
            entity.Property(e => e.HotelNewsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_MetatagDescription");
            entity.Property(e => e.HotelNewsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_Title");
            entity.Property(e => e.HotelNewsletterThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks");
            entity.Property(e => e.HotelNewsletterThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelNewsletterThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_MetatagDescription");
            entity.Property(e => e.HotelNewsletterThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_Title");
            entity.Property(e => e.HotelOffers).HasColumnType("ntext");
            entity.Property(e => e.HotelOffersMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_MetatagDescription");
            entity.Property(e => e.HotelOffersMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_MetatagTitle");
            entity.Property(e => e.HotelOffersTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_Title");
            entity.Property(e => e.HotelOverview).HasColumnType("ntext");
            entity.Property(e => e.HotelPrivacy).HasColumnType("ntext");
            entity.Property(e => e.HotelPrivacyMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_MetaTagTitle");
            entity.Property(e => e.HotelPrivacyMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_MetatagDescription");
            entity.Property(e => e.HotelPrivacyTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_Title");
            entity.Property(e => e.HotelSocial).HasColumnType("ntext");
            entity.Property(e => e.HotelSocialMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_MetatagDescription");
            entity.Property(e => e.HotelSocialMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_MetatagTitle");
            entity.Property(e => e.HotelSocialTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_Title");
            entity.Property(e => e.HotelSummery).HasColumnType("ntext");
            entity.Property(e => e.HotelTeam).HasColumnType("ntext");
            entity.Property(e => e.HotelTeamMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_MetatagDescription");
            entity.Property(e => e.HotelTeamMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_MetatagTitle");
            entity.Property(e => e.HotelTeamTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_Title");
            entity.Property(e => e.HotelTermsConditions)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions");
            entity.Property(e => e.HotelTermsConditionsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_MetaTagTitle");
            entity.Property(e => e.HotelTermsConditionsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_MetatagDescription");
            entity.Property(e => e.HotelTermsConditionsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_Title");
            entity.Property(e => e.HotelWellness).HasColumnType("ntext");
            entity.Property(e => e.HotelWellnessMetatagDescription)
                .HasDefaultValue("test")
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_MetatagDescription");
            entity.Property(e => e.HotelWellnessMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_MetatagTitle");
            entity.Property(e => e.HotelWellnessTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_Title");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasMaxLength(250);
            entity.Property(e => e.MetatagTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<MasterLanguage>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.ToTable("Master_Languages", "dbo");

            entity.Property(e => e.LangId)
                .ValueGeneratedNever()
                .HasColumnName("LangID");
            entity.Property(e => e.BookingCurrency).HasMaxLength(250);
            entity.Property(e => e.BookingLang).HasMaxLength(250);
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<MasterRestaurantsCategoriesContent>(entity =>
        {
            entity.HasKey(e => e.RestaurantCategoryContentId);

            entity.ToTable("Master_RestaurantsCategories_Content", "dbo");

            entity.Property(e => e.RestaurantCategoryContentId).HasColumnName("RestaurantCategoryContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.RestaurantCategoryId).HasColumnName("RestaurantCategoryID");
            entity.Property(e => e.RestaurantCategoryName).HasMaxLength(250);

            entity.HasOne(d => d.RestaurantCategory).WithMany(p => p.MasterRestaurantsCategoriesContents)
                .HasForeignKey(d => d.RestaurantCategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Master_RestaurantsCategories_Content_Master_RestaurantsCategories");
        });

        modelBuilder.Entity<MasterRestaurantsCategory>(entity =>
        {
            entity.HasKey(e => e.RestaurantCategoryId);

            entity.ToTable("Master_RestaurantsCategories", "dbo", tb => tb.HasTrigger("Master_RestaurantsCategories_Trigger"));

            entity.Property(e => e.RestaurantCategoryId).HasColumnName("RestaurantCategoryID");
            entity.Property(e => e.RestaurantsCategoryNameSys)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsCategoryName_SYS");
        });

        modelBuilder.Entity<MasterRestaurantsType>(entity =>
        {
            entity.HasKey(e => e.RestaurantsTypeId);

            entity.ToTable("Master_RestaurantsType", "dbo");

            entity.Property(e => e.RestaurantsTypeId).HasColumnName("RestaurantsTypeID");
            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypeBanner).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypeBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Mobile");
            entity.Property(e => e.RestaurantsTypeBannerMobileHieght).HasColumnName("RestaurantsTypeBanner_MobileHieght");
            entity.Property(e => e.RestaurantsTypeBannerMobileWidth).HasColumnName("RestaurantsTypeBanner_MobileWidth");
            entity.Property(e => e.RestaurantsTypeBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Tablet");
            entity.Property(e => e.RestaurantsTypeBannerTabletHieght).HasColumnName("RestaurantsTypeBanner_TabletHieght");
            entity.Property(e => e.RestaurantsTypeBannerTabletWidth).HasColumnName("RestaurantsTypeBanner_TabletWidth");
            entity.Property(e => e.RestaurantsTypeNameSys)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeName_SYS");
            entity.Property(e => e.RestaurantsTypePhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<MasterRestaurantsTypeContent>(entity =>
        {
            entity.HasKey(e => e.RestaurantsTypeLangId);

            entity.ToTable("Master_RestaurantsType_Content", "dbo");

            entity.Property(e => e.RestaurantsTypeLangId).HasColumnName("RestaurantsTypeLangID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.RestaurantsTypeId).HasColumnName("RestaurantsTypeID");
            entity.Property(e => e.RestaurantsTypeIntro).HasColumnType("ntext");
            entity.Property(e => e.RestaurantsTypeName).HasMaxLength(250);
        });

        modelBuilder.Entity<MasterRoomTypeCategory>(entity =>
        {
            entity.HasKey(e => e.RoomTypeCategoryId);

            entity.ToTable("Master_RoomTypeCategory", "dbo", tb => tb.HasTrigger("Master_RoomTypeCategory_Content_Trigger"));

            entity.Property(e => e.RoomTypeCategoryId).HasColumnName("RoomTypeCategoryID");
            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.RoomTypeCategoryNameSys)
                .HasMaxLength(250)
                .HasColumnName("RoomTypeCategoryName_SYS");
        });

        modelBuilder.Entity<MasterRoomTypeCategoryContent>(entity =>
        {
            entity.HasKey(e => e.RoomTypeCategoryLangId);

            entity.ToTable("Master_RoomTypeCategory_Content", "dbo");

            entity.Property(e => e.RoomTypeCategoryLangId).HasColumnName("RoomTypeCategoryLangID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.RoomTypeCategoryId).HasColumnName("RoomTypeCategoryID");
            entity.Property(e => e.RoomTypeCategoryName).HasMaxLength(250);

            entity.HasOne(d => d.RoomTypeCategory).WithMany(p => p.MasterRoomTypeCategoryContents)
                .HasForeignKey(d => d.RoomTypeCategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Master_RoomTypeCategory_Content_Master_RoomTypeCategory");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.ToTable("Restaurants", "dbo", tb =>
                {
                    tb.HasTrigger("RRestaurantURL");
                    tb.HasTrigger("Restaurants_Content_trigger");
                });

            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMoreDetails).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.RestaurantBanner).HasMaxLength(250);
            entity.Property(e => e.RestaurantBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerHieghtMobile).HasColumnName("RestaurantBannerHieght_Mobile");
            entity.Property(e => e.RestaurantBannerHieghtTablet).HasColumnName("RestaurantBannerHieght_Tablet");
            entity.Property(e => e.RestaurantBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile");
            entity.Property(e => e.RestaurantBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet");
            entity.Property(e => e.RestaurantBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerWidthMobile).HasColumnName("RestaurantBannerWidth_Mobile");
            entity.Property(e => e.RestaurantBannerWidthTablet).HasColumnName("RestaurantBannerWidth_Tablet");
            entity.Property(e => e.RestaurantCategoryId).HasColumnName("RestaurantCategoryID");
            entity.Property(e => e.RestaurantNameSys).HasMaxLength(250);
            entity.Property(e => e.RestaurantPhoto).HasMaxLength(250);
            entity.Property(e => e.RestaurantPhotoHome).HasMaxLength(250);
            entity.Property(e => e.RestaurantTypeId).HasColumnName("RestaurantTypeID");
            entity.Property(e => e.RestaurantUrl)
                .HasMaxLength(250)
                .HasColumnName("RestaurantURL");
        });

        modelBuilder.Entity<RestaurantsContent>(entity =>
        {
            entity.HasKey(e => e.RestaurantContentId);

            entity.ToTable("Restaurants_Content", "dbo");

            entity.Property(e => e.RestaurantContentId).HasColumnName("RestaurantContentID");
            entity.Property(e => e.DressCode).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.Openinghours).HasColumnType("ntext");
            entity.Property(e => e.RestaurantCuisine).HasMaxLength(250);
            entity.Property(e => e.RestaurantDetails).HasColumnType("ntext");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.RestaurantMenu).HasMaxLength(250);
            entity.Property(e => e.RestaurantName).HasMaxLength(250);
            entity.Property(e => e.RestaurantNote).HasColumnType("ntext");
            entity.Property(e => e.RestaurantOpenFor).HasMaxLength(250);
            entity.Property(e => e.RestaurantSummery).HasColumnType("ntext");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.RestaurantsContents)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Restaurants_Content_Restaurants");
        });

        modelBuilder.Entity<RestaurantsGallery>(entity =>
        {
            entity.HasKey(e => e.RestaurantFileId);

            entity.ToTable("Restaurants_Gallery", "dbo");

            entity.Property(e => e.RestaurantFileId).HasColumnName("RestaurantFileID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.RestaurantsGalleries)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Restaurants_Gallery_Restaurants");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Rooms", "dbo", tb =>
                {
                    tb.HasTrigger("RoomURL");
                    tb.HasTrigger("Rooms_Content_trigger");
                });

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelAccommodationTypeId).HasColumnName("HotelAccommodationTypeID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsAllowedChild).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDisplayInHome).HasDefaultValue(true);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.RoomBanner).HasMaxLength(250);
            entity.Property(e => e.RoomBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_ColorOverlayTo");
            entity.Property(e => e.RoomBannerHieghtMobile).HasColumnName("RoomBannerHieght_Mobile");
            entity.Property(e => e.RoomBannerHieghtTablet).HasColumnName("RoomBannerHieght_Tablet");
            entity.Property(e => e.RoomBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile");
            entity.Property(e => e.RoomBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.RoomBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet");
            entity.Property(e => e.RoomBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.RoomBannerWidthMobile).HasColumnName("RoomBannerWidth_Mobile");
            entity.Property(e => e.RoomBannerWidthTablet).HasColumnName("RoomBannerWidth_Tablet");
            entity.Property(e => e.RoomNameSys).HasMaxLength(250);
            entity.Property(e => e.RoomPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomPhotoHome).HasMaxLength(250);
            entity.Property(e => e.RoomPmscode)
                .HasMaxLength(250)
                .HasColumnName("RoomPMSCode");
            entity.Property(e => e.RoomTypeCategoryId).HasColumnName("RoomTypeCategoryID");
            entity.Property(e => e.RoomUrl)
                .HasMaxLength(250)
                .HasColumnName("RoomURL");
            entity.Property(e => e.StartingFromCode).HasColumnType("ntext");
        });

        modelBuilder.Entity<RoomRoomAmenity>(entity =>
        {
            entity.HasKey(e => e.RoomRoomAmenitiesId);

            entity.ToTable("Room_RoomAmenities", "dbo");

            entity.Property(e => e.RoomRoomAmenitiesId).HasColumnName("Room_RoomAmenitiesID");
            entity.Property(e => e.RoomAmenitiesId).HasColumnName("RoomAmenitiesID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomRoomAmenities)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Room_RoomAmenities_Rooms");
        });

        modelBuilder.Entity<RoomsContent>(entity =>
        {
            entity.HasKey(e => e.RoomContentId);

            entity.ToTable("Rooms_Content", "dbo");

            entity.Property(e => e.RoomContentId).HasColumnName("RoomContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MaxOccupancy).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.RoomBannerAltTag).HasMaxLength(250);
            entity.Property(e => e.RoomBed).HasMaxLength(250);
            entity.Property(e => e.RoomDetails).HasColumnType("ntext");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomName).HasMaxLength(250);
            entity.Property(e => e.RoomPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomPhotoHome).HasMaxLength(250);
            entity.Property(e => e.RoomSize).HasMaxLength(250);
            entity.Property(e => e.RoomSummery).HasColumnType("ntext");
            entity.Property(e => e.RoomView).HasMaxLength(250);
            entity.Property(e => e.StartingFromCodeLang).HasColumnType("ntext");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomsContents)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Rooms_Content_Rooms");
        });

        modelBuilder.Entity<RoomsGallery>(entity =>
        {
            entity.HasKey(e => e.RoomFileId);

            entity.ToTable("Rooms_Gallery", "dbo");

            entity.Property(e => e.RoomFileId).HasColumnName("RoomFileID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);
            entity.Property(e => e.PhotoTypeId).HasColumnName("PhotoTypeID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomsGalleries)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Rooms_Gallery_Rooms");
        });

        modelBuilder.Entity<TblAward>(entity =>
        {
            entity.HasKey(e => e.Awardid);

            entity.ToTable("tbl_Awards", "dbo", tb => tb.HasTrigger("tbl_Awards_Content_trigger"));

            entity.Property(e => e.Awardid).HasColumnName("awardid");
            entity.Property(e => e.AwardDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AwardYearCategorId).HasColumnName("AwardYearCategorID");
            entity.Property(e => e.Awardphoto)
                .HasMaxLength(250)
                .HasColumnName("awardphoto");
            entity.Property(e => e.Awardposition)
                .HasDefaultValue(100)
                .HasColumnName("awardposition");
            entity.Property(e => e.Awardstatus)
                .HasDefaultValue(true)
                .HasColumnName("awardstatus");
            entity.Property(e => e.Awardtitlesys)
                .HasMaxLength(250)
                .HasColumnName("awardtitlesys");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ExternalLink).HasColumnType("ntext");
            entity.Property(e => e.HotelId)
                .HasDefaultValue(36)
                .HasColumnName("HotelID");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblAwardsCategory>(entity =>
        {
            entity.HasKey(e => e.AwardYearCategorId);

            entity.ToTable("tbl_AwardsCategory", "dbo");

            entity.Property(e => e.AwardYearCategorId).HasColumnName("AwardYearCategorID");
            entity.Property(e => e.AwardYearCategoryName).HasMaxLength(250);
        });

        modelBuilder.Entity<TblAwardsContent>(entity =>
        {
            entity.HasKey(e => e.Awardcontentid);

            entity.ToTable("tbl_Awards_Content", "dbo");

            entity.Property(e => e.Awardcontentid).HasColumnName("awardcontentid");
            entity.Property(e => e.AwardDescription)
                .HasColumnType("ntext")
                .HasColumnName("awardDescription");
            entity.Property(e => e.Awardid).HasColumnName("awardid");
            entity.Property(e => e.Awardtitle)
                .HasMaxLength(250)
                .HasColumnName("awardtitle");
            entity.Property(e => e.Langid).HasColumnName("langid");

            entity.HasOne(d => d.Award).WithMany(p => p.TblAwardsContents)
                .HasForeignKey(d => d.Awardid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Awards_Content_tbl_Awards");
        });

        modelBuilder.Entity<TblBlog>(entity =>
        {
            entity.HasKey(e => e.NewsId);

            entity.ToTable("tbl_Blogs", "dbo", tb => tb.HasTrigger("BlogURL"));

            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LangId)
                .HasDefaultValue(1)
                .HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.NewsBanner).HasMaxLength(250);
            entity.Property(e => e.NewsDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.NewsDetails).HasColumnType("ntext");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsShortDescription).HasColumnType("ntext");
            entity.Property(e => e.NewsStatus).HasDefaultValue(true);
            entity.Property(e => e.NewsTitle).HasMaxLength(250);
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<TblDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("tbl_Documents", "dbo");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DcoumentDescription).HasColumnType("ntext");
            entity.Property(e => e.DocumentName).HasMaxLength(250);
            entity.Property(e => e.DocumentType).HasMaxLength(250);
            entity.Property(e => e.DocumentUrl)
                .HasColumnType("ntext")
                .HasColumnName("DocumentURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
        });

        modelBuilder.Entity<TblExtraPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("tbl_ExtraPages", "dbo", tb =>
                {
                    tb.HasTrigger("ExtraPages_Content");
                    tb.HasTrigger("tbl_ExtraPagesPageURL");
                });

            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.PageBanner).HasMaxLength(250);
            entity.Property(e => e.PageNameSys).HasMaxLength(250);
            entity.Property(e => e.PagePosistion).HasDefaultValue(0);
            entity.Property(e => e.PageStatus).HasDefaultValue(false);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(250)
                .HasColumnName("PageURL");
        });

        modelBuilder.Entity<TblExtraPagesContent>(entity =>
        {
            entity.HasKey(e => e.PageContentId);

            entity.ToTable("tbl_ExtraPages_Content", "dbo");

            entity.Property(e => e.PageContentId).HasColumnName("PageContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.PageDetails).HasColumnType("ntext");
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.PageMetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.PageMetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.PageTitle).HasMaxLength(250);

            entity.HasOne(d => d.Page).WithMany(p => p.TblExtraPagesContents)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_ExtraPages_Content_tbl_ExtraPages");
        });

        modelBuilder.Entity<TblFaqQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId);

            entity.ToTable("tbl_FAQ_Questions", "dbo");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.Answer).HasColumnType("ntext");
            entity.Property(e => e.DeletedDateQuestion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeletedQuestion).HasDefaultValue(false);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Question).HasColumnType("ntext");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");

            entity.HasOne(d => d.Section).WithMany(p => p.TblFaqQuestions)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_FAQ_Questions_tbl_FAQ_Sections");
        });

        modelBuilder.Entity<TblFaqSection>(entity =>
        {
            entity.HasKey(e => e.FaqsectionId);

            entity.ToTable("tbl_FAQ_Sections", "dbo");

            entity.Property(e => e.FaqsectionId).HasColumnName("FAQSectionID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SectionName).HasMaxLength(250);
        });

        modelBuilder.Entity<TblFooterText>(entity =>
        {
            entity.HasKey(e => e.FooterId);

            entity.ToTable("tbl_FooterText", "dbo", tb => tb.HasTrigger("tbl_FooterText_Content_trigger"));

            entity.Property(e => e.FooterId)
                .ValueGeneratedNever()
                .HasColumnName("FooterID");
        });

        modelBuilder.Entity<TblFooterTextContent>(entity =>
        {
            entity.HasKey(e => e.FooterContentId);

            entity.ToTable("tbl_FooterText_Content", "dbo");

            entity.Property(e => e.FooterContentId).HasColumnName("FooterContentID");
            entity.Property(e => e.FooterId).HasColumnName("FooterID");
            entity.Property(e => e.FooterText).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.Footer).WithMany(p => p.TblFooterTextContents)
                .HasForeignKey(d => d.FooterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_FooterText_Content_tbl_FooterText");
        });

        modelBuilder.Entity<TblGallerySection>(entity =>
        {
            entity.HasKey(e => e.GallerySectionId);

            entity.ToTable("tbl_GallerySections", "dbo", tb => tb.HasTrigger("Gallery_Content_trigger"));

            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.GallerySectionNameSys)
                .HasMaxLength(250)
                .HasColumnName("GallerySectionNameSYS");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
        });

        modelBuilder.Entity<TblGallerySectionsContent>(entity =>
        {
            entity.HasKey(e => e.GallerySectionContentId).HasName("PK_tbl_GallerySections_Content_1");

            entity.ToTable("tbl_GallerySections_Content", "dbo");

            entity.Property(e => e.GallerySectionContentId).HasColumnName("GallerySectionContentID");
            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.GallerySectionName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.GallerySection).WithMany(p => p.TblGallerySectionsContents)
                .HasForeignKey(d => d.GallerySectionId)
                .HasConstraintName("FK_tbl_GallerySections_Content_tbl_GallerySections");
        });

        modelBuilder.Entity<TblGallerySectionsPhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoId);

            entity.ToTable("tbl_GallerySections_Photos", "dbo", tb => tb.HasTrigger("GallerySections_Photos_Content_trigger"));

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoTitleSys)
                .HasMaxLength(250)
                .HasColumnName("PhotoTitleSYS");
        });

        modelBuilder.Entity<TblGallerySectionsPhotosContent>(entity =>
        {
            entity.HasKey(e => e.PhotoContentId);

            entity.ToTable("tbl_GallerySections_Photos_Content", "dbo");

            entity.Property(e => e.PhotoContentId).HasColumnName("PhotoContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.PhotoTitle).HasMaxLength(250);

            entity.HasOne(d => d.Photo).WithMany(p => p.TblGallerySectionsPhotosContents)
                .HasForeignKey(d => d.PhotoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GallerySections_Photos_Content_tbl_GallerySections_Photos");
        });

        modelBuilder.Entity<TblGroupFaq>(entity =>
        {
            entity.HasKey(e => e.GroupFaqid);

            entity.ToTable("tbl_GroupFAQ", "dbo", tb => tb.HasTrigger("GroupFAQ_Content_trigger"));

            entity.Property(e => e.GroupFaqid).HasColumnName("GroupFAQID");
            entity.Property(e => e.GroupFaqanswersSys).HasColumnName("GroupFAQAnswersSys");
            entity.Property(e => e.GroupFaqposition).HasColumnName("GroupFAQPosition");
            entity.Property(e => e.GroupFaqquestionSys).HasColumnName("GroupFAQQuestionSys");
            entity.Property(e => e.GroupFaqstatus).HasColumnName("GroupFAQStatus");
        });

        modelBuilder.Entity<TblGroupFaqcontent>(entity =>
        {
            entity.HasKey(e => e.GroupFaqcontentId);

            entity.ToTable("tbl_GroupFAQContent", "dbo");

            entity.Property(e => e.GroupFaqcontentId).HasColumnName("GroupFAQContentID");
            entity.Property(e => e.GroupFaqanswers).HasColumnName("GroupFAQAnswers");
            entity.Property(e => e.GroupFaqid).HasColumnName("GroupFAQID");
            entity.Property(e => e.GroupFaqquestion).HasColumnName("GroupFAQQuestion");
            entity.Property(e => e.GroupFaqstatusLang).HasColumnName("GroupFAQStatusLang");
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.GroupFaq).WithMany(p => p.TblGroupFaqcontents)
                .HasForeignKey(d => d.GroupFaqid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GroupFAQContent_tbl_GroupFAQ");
        });

        modelBuilder.Entity<TblGroupHome>(entity =>
        {
            entity.HasKey(e => e.GroupHomeId).HasName("PK_Table_1");

            entity.ToTable("tbl_GroupHome", "dbo", tb => tb.HasTrigger("GroupHome_Content_trigger"));

            entity.Property(e => e.GroupHomeId).HasColumnName("GroupHomeID");
            entity.Property(e => e.GroupHomePhoto1).HasMaxLength(250);
            entity.Property(e => e.GroupHomePhoto1Height).HasColumnName("GroupHomePhoto1_Height");
            entity.Property(e => e.GroupHomePhoto1Width).HasColumnName("GroupHomePhoto1_Width");
            entity.Property(e => e.GroupHomePhoto2).HasMaxLength(250);
            entity.Property(e => e.GroupHomePhoto2Height).HasColumnName("GroupHomePhoto2_Height");
            entity.Property(e => e.GroupHomePhoto2Width).HasColumnName("GroupHomePhoto2_Width");
            entity.Property(e => e.GroupHomeVideoSectionBanner).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerHeight).HasColumnName("GroupHomeVideoSectionBanner_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerMobile).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerMobileHeight).HasColumnName("GroupHomeVideoSectionBannerMobile_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerMobileWidth).HasColumnName("GroupHomeVideoSectionBannerMobile_Width");
            entity.Property(e => e.GroupHomeVideoSectionBannerTablet).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerTabletHeight).HasColumnName("GroupHomeVideoSectionBannerTablet_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerTabletWidth).HasColumnName("GroupHomeVideoSectionBannerTablet_Width");
            entity.Property(e => e.GroupHomeVideoSectionBannerWidth).HasColumnName("GroupHomeVideoSectionBanner_Width");
        });

        modelBuilder.Entity<TblGroupHomeContent>(entity =>
        {
            entity.HasKey(e => e.GroupHomeContentId).HasName("PK_Table_1_1");

            entity.ToTable("tbl_GroupHomeContent", "dbo");

            entity.Property(e => e.GroupHomeContentId).HasColumnName("GroupHomeContentID");
            entity.Property(e => e.GroupContactUsIcon).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsSummery).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsTitle).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupGetDirectionLink).HasDefaultValue("https://www.google.com/maps/place/Morning+Star+Aqua+Center+Touristik/@27.10613,33.829114,15z/data=!4m6!3m5!1s0x145281fca4c970bb:0x8149af53399961b!8m2!3d27.1002295!4d33.8384214!16s%2Fg%2F11swtbr7jf?hl=en&entry=ttu");
            entity.Property(e => e.GroupHomeHotelTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeHotelTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeId).HasColumnName("GroupHomeID");
            entity.Property(e => e.GroupHomeIntroButton).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroButtonUrl).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeNewsTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeNewsTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionButton).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionButtonUrl).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionSubText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoUrl).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.GroupHome).WithMany(p => p.TblGroupHomeContents)
                .HasForeignKey(d => d.GroupHomeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GroupHomeContent_tbl_GroupHome");
        });

        modelBuilder.Entity<TblGroupHomeIntroActivitiesContent>(entity =>
        {
            entity.HasKey(e => e.GroupHomeIntroActivitiesContentId);

            entity.ToTable("tbl_GroupHomeIntroActivitiesContent", "dbo");

            entity.Property(e => e.GroupHomeIntroActivitiesContentId).HasColumnName("GroupHomeIntroActivitiesContentID");
            entity.Property(e => e.GroupHomeIntroActivitiesId).HasColumnName("GroupHomeIntroActivitiesID");
            entity.Property(e => e.GroupHomeIntroActivitiesQuantity).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroActivitiesText).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.GroupHomeIntroActivities).WithMany(p => p.TblGroupHomeIntroActivitiesContents)
                .HasForeignKey(d => d.GroupHomeIntroActivitiesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GroupHomeIntroActivitiesContent_tbl_GroupHomeIntroActivities");
        });

        modelBuilder.Entity<TblGroupHomeIntroActivity>(entity =>
        {
            entity.HasKey(e => e.GroupHomeIntroActivitiesId);

            entity.ToTable("tbl_GroupHomeIntroActivities", "dbo", tb => tb.HasTrigger("GroupHomeIntroActivities_Content_trigger"));

            entity.Property(e => e.GroupHomeIntroActivitiesId).HasColumnName("GroupHomeIntroActivitiesID");
            entity.Property(e => e.GroupHomeIntroActivitiesQuantitySys).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroActivitiesTextSys).HasMaxLength(250);
        });

        modelBuilder.Entity<TblGroupLayout>(entity =>
        {
            entity.HasKey(e => e.GroupLayoutId);

            entity.ToTable("tbl_GroupLayout", "dbo");

            entity.Property(e => e.GroupLayoutId).HasColumnName("GroupLayoutID");
            entity.Property(e => e.GroupAddress).HasMaxLength(250);
            entity.Property(e => e.GroupCopyrights).HasMaxLength(250);
            entity.Property(e => e.GroupLogo).HasMaxLength(250);
            entity.Property(e => e.GroupMail).HasMaxLength(250);
            entity.Property(e => e.GroupPhone).HasMaxLength(250);
            entity.Property(e => e.GroupSummery).HasMaxLength(250);
        });

        modelBuilder.Entity<TblGroupNews>(entity =>
        {
            entity.HasKey(e => e.NewsId);

            entity.ToTable("tbl_GroupNews", "dbo", tb =>
                {
                    tb.HasTrigger("GroupNewsURL");
                    tb.HasTrigger("GroupNews_Content_trigger");
                });

            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LangId)
                .HasDefaultValue(1)
                .HasColumnName("LangID");
            entity.Property(e => e.NewsItemBanner).HasMaxLength(250);
            entity.Property(e => e.NewsItemBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Mobile");
            entity.Property(e => e.NewsItemBannerMobileHieght).HasColumnName("NewsItemBanner_MobileHieght");
            entity.Property(e => e.NewsItemBannerMobileWidth).HasColumnName("NewsItemBanner_MobileWidth");
            entity.Property(e => e.NewsItemBannerPhotoHieght).HasColumnName("NewsItemBannerPhoto_Hieght");
            entity.Property(e => e.NewsItemBannerPhotoWidth).HasColumnName("NewsItemBannerPhoto_Width");
            entity.Property(e => e.NewsItemBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Tablet");
            entity.Property(e => e.NewsItemBannerTabletHieght).HasColumnName("NewsItemBanner_TabletHieght");
            entity.Property(e => e.NewsItemBannerTabletWidth).HasColumnName("NewsItemBanner_TabletWidth");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsStatus).HasDefaultValue(true);
            entity.Property(e => e.NewsTitleSys)
                .HasMaxLength(250)
                .HasColumnName("NewsTitleSYS");
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<TblGroupNewsContent>(entity =>
        {
            entity.HasKey(e => e.NewsContentId);

            entity.ToTable("tbl_GroupNewsContent", "dbo");

            entity.Property(e => e.NewsContentId).HasColumnName("NewsContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.NewsDateTime)
                .HasMaxLength(250)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NewsDetails).HasMaxLength(250);
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsShortDescription).HasMaxLength(250);
            entity.Property(e => e.NewsTitle).HasMaxLength(250);

            entity.HasOne(d => d.News).WithMany(p => p.TblGroupNewsContents)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GroupNewsContent_tbl_GroupNews");
        });

        modelBuilder.Entity<TblGroupPage>(entity =>
        {
            entity.HasKey(e => e.GroupPagesId);

            entity.ToTable("tbl_GroupPages", "dbo", tb => tb.HasTrigger("GroupPage_Content_trigger"));

            entity.Property(e => e.GroupPagesId).HasColumnName("GroupPagesID");
            entity.Property(e => e.GroupAboutUsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_Banner");
            entity.Property(e => e.GroupAboutUsBannerHeight).HasColumnName("GroupAboutUs_Banner_Height");
            entity.Property(e => e.GroupAboutUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_BannerMobile");
            entity.Property(e => e.GroupAboutUsBannerMobileHeigh).HasColumnName("GroupAboutUs_BannerMobile_Heigh");
            entity.Property(e => e.GroupAboutUsBannerMobileWidth).HasColumnName("GroupAboutUs_BannerMobile_Width");
            entity.Property(e => e.GroupAboutUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_BannerTablet");
            entity.Property(e => e.GroupAboutUsBannerTabletHeight).HasColumnName("GroupAboutUs_BannerTablet_Height");
            entity.Property(e => e.GroupAboutUsBannerTabletWidth).HasColumnName("GroupAboutUs_BannerTablet_Width");
            entity.Property(e => e.GroupAboutUsBannerWidth).HasColumnName("GroupAboutUs_Banner_Width");
            entity.Property(e => e.GroupCarreerBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_Banner");
            entity.Property(e => e.GroupCarreerBannerHeight).HasColumnName("GroupCarreer_Banner_Height");
            entity.Property(e => e.GroupCarreerBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_BannerMobile");
            entity.Property(e => e.GroupCarreerBannerMobileHeight).HasColumnName("GroupCarreer_BannerMobile_Height");
            entity.Property(e => e.GroupCarreerBannerMobileWidth).HasColumnName("GroupCarreer_BannerMobile_Width");
            entity.Property(e => e.GroupCarreerBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_BannerTablet");
            entity.Property(e => e.GroupCarreerBannerTabletHeight).HasColumnName("GroupCarreer_BannerTablet_Height");
            entity.Property(e => e.GroupCarreerBannerTabletWidth).HasColumnName("GroupCarreer_BannerTablet_Width");
            entity.Property(e => e.GroupCarreerBannerWidth).HasColumnName("GroupCarreer_Banner_Width");
            entity.Property(e => e.GroupContactUsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_Banner");
            entity.Property(e => e.GroupContactUsBannerHeight).HasColumnName("GroupContactUs_Banner_Height");
            entity.Property(e => e.GroupContactUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_BannerMobile");
            entity.Property(e => e.GroupContactUsBannerMobileHeight).HasColumnName("GroupContactUs_BannerMobile_Height");
            entity.Property(e => e.GroupContactUsBannerMobileWidth).HasColumnName("GroupContactUs_BannerMobile_Width");
            entity.Property(e => e.GroupContactUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_BannerTablet");
            entity.Property(e => e.GroupContactUsBannerTabletHeight).HasColumnName("GroupContactUs_BannerTablet_Height");
            entity.Property(e => e.GroupContactUsBannerTabletWidth).HasColumnName("GroupContactUs_BannerTablet_Width");
            entity.Property(e => e.GroupContactUsBannerWidth).HasColumnName("GroupContactUs_Banner_Width");
            entity.Property(e => e.GroupFaqBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupFAQ_Banner");
            entity.Property(e => e.GroupFaqBannerHeight).HasColumnName("GroupFAQ_Banner_Height");
            entity.Property(e => e.GroupFaqBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupFAQ_BannerMobile");
            entity.Property(e => e.GroupFaqBannerMobileHeight).HasColumnName("GroupFAQ_BannerMobile_Height");
            entity.Property(e => e.GroupFaqBannerMobileWidth).HasColumnName("GroupFAQ_BannerMobile_Width");
            entity.Property(e => e.GroupFaqBannerTablet)
                .HasMaxLength(50)
                .HasColumnName("GroupFAQ_BannerTablet");
            entity.Property(e => e.GroupFaqBannerTabletHeight).HasColumnName("GroupFAQ_BannerTablet_Height");
            entity.Property(e => e.GroupFaqBannerTabletWidth).HasColumnName("GroupFAQ_BannerTablet_Width");
            entity.Property(e => e.GroupFaqBannerWidth).HasColumnName("GroupFAQ_Banner_Width");
            entity.Property(e => e.GroupHotelsRessortsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_Banner");
            entity.Property(e => e.GroupHotelsRessortsBannerHeight).HasColumnName("GroupHotelsRessorts_Banner_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_BannerMobile");
            entity.Property(e => e.GroupHotelsRessortsBannerMobileHeight).HasColumnName("GroupHotelsRessorts_BannerMobile_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerMobileWidth).HasColumnName("GroupHotelsRessorts_BannerMobile_Width");
            entity.Property(e => e.GroupHotelsRessortsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_BannerTablet");
            entity.Property(e => e.GroupHotelsRessortsBannerTabletHeight).HasColumnName("GroupHotelsRessorts_BannerTablet_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerTabletWidth).HasColumnName("GroupHotelsRessorts_BannerTablet_Width");
            entity.Property(e => e.GroupHotelsRessortsBannerWidth).HasColumnName("GroupHotelsRessorts_Banner_Width");
            entity.Property(e => e.GroupMeetingEventsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_Banner");
            entity.Property(e => e.GroupMeetingEventsBannerHeight).HasColumnName("GroupMeetingEvents_Banner_Height");
            entity.Property(e => e.GroupMeetingEventsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_BannerMobile");
            entity.Property(e => e.GroupMeetingEventsBannerMobileHeight).HasColumnName("GroupMeetingEvents_BannerMobile_Height");
            entity.Property(e => e.GroupMeetingEventsBannerMobileWidth).HasColumnName("GroupMeetingEvents_BannerMobile_Width");
            entity.Property(e => e.GroupMeetingEventsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_BannerTablet");
            entity.Property(e => e.GroupMeetingEventsBannerTabletHeight).HasColumnName("GroupMeetingEvents_BannerTablet_Height");
            entity.Property(e => e.GroupMeetingEventsBannerTabletWidth).HasColumnName("GroupMeetingEvents_BannerTablet_Width");
            entity.Property(e => e.GroupMeetingEventsBannerWidth).HasColumnName("GroupMeetingEvents_Banner_Width");
            entity.Property(e => e.GroupNewsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupNews_Banner");
            entity.Property(e => e.GroupNewsBannerHeight).HasColumnName("GroupNews_Banner_Height");
            entity.Property(e => e.GroupNewsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupNews_BannerMobile");
            entity.Property(e => e.GroupNewsBannerMobileHeight).HasColumnName("GroupNews_BannerMobile_Height");
            entity.Property(e => e.GroupNewsBannerMobileWidth).HasColumnName("GroupNews_BannerMobile_Width");
            entity.Property(e => e.GroupNewsBannerTablet)
                .HasMaxLength(50)
                .HasColumnName("GroupNews_BannerTablet");
            entity.Property(e => e.GroupNewsBannerTabletHeight).HasColumnName("GroupNews_BannerTablet_Height");
            entity.Property(e => e.GroupNewsBannerTabletWidth).HasColumnName("GroupNews_BannerTablet_Width");
            entity.Property(e => e.GroupNewsBannerWidth).HasColumnName("GroupNews_Banner_Width");
            entity.Property(e => e.GroupPrivacyBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_Banner");
            entity.Property(e => e.GroupPrivacyBannerHeight).HasColumnName("GroupPrivacy_Banner_Height");
            entity.Property(e => e.GroupPrivacyBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_BannerMobile");
            entity.Property(e => e.GroupPrivacyBannerMobileHeight).HasColumnName("GroupPrivacy_BannerMobile_Height");
            entity.Property(e => e.GroupPrivacyBannerMobileWidth).HasColumnName("GroupPrivacy_BannerMobile_Width");
            entity.Property(e => e.GroupPrivacyBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_BannerTablet");
            entity.Property(e => e.GroupPrivacyBannerTabletHeight).HasColumnName("GroupPrivacy_BannerTablet_Height");
            entity.Property(e => e.GroupPrivacyBannerTabletWidth).HasColumnName("GroupPrivacy_BannerTablet_Width");
            entity.Property(e => e.GroupPrivacyBannerWidth).HasColumnName("GroupPrivacy_Banner_Width");
            entity.Property(e => e.GroupTermsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_Banner");
            entity.Property(e => e.GroupTermsBannerHeight).HasColumnName("GroupTerms_Banner_Height");
            entity.Property(e => e.GroupTermsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_BannerMobile");
            entity.Property(e => e.GroupTermsBannerMobileHeight).HasColumnName("GroupTerms_BannerMobile_Height");
            entity.Property(e => e.GroupTermsBannerMobileWidth).HasColumnName("GroupTerms_BannerMobile_Width");
            entity.Property(e => e.GroupTermsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_BannerTablet");
            entity.Property(e => e.GroupTermsBannerTabletHeight).HasColumnName("GroupTerms_BannerTablet_Height");
            entity.Property(e => e.GroupTermsBannerTabletWidth).HasColumnName("GroupTerms_BannerTablet_Width");
            entity.Property(e => e.GroupTermsBannerWidth).HasColumnName("GroupTerms_Banner_Width");
        });

        modelBuilder.Entity<TblGroupPagesContent>(entity =>
        {
            entity.HasKey(e => e.GroupPagesContentId);

            entity.ToTable("tbl_GroupPagesContent", "dbo");

            entity.Property(e => e.GroupPagesContentId).HasColumnName("GroupPagesContentID");
            entity.Property(e => e.GroupAboutUs).HasColumnType("ntext");
            entity.Property(e => e.GroupAboutUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_MetatagDescription");
            entity.Property(e => e.GroupAboutUsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_MetatagTitle");
            entity.Property(e => e.GroupAboutUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_Title");
            entity.Property(e => e.GroupCareer).HasColumnType("ntext");
            entity.Property(e => e.GroupCareerMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_MetatagDescription");
            entity.Property(e => e.GroupCareerMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_MetatagTitle");
            entity.Property(e => e.GroupCareerTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_Title");
            entity.Property(e => e.GroupContactUs).HasColumnType("ntext");
            entity.Property(e => e.GroupContactUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_MetatagDescription");
            entity.Property(e => e.GroupContactUsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_MetatagTitle");
            entity.Property(e => e.GroupContactUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_Title");
            entity.Property(e => e.GroupFaq)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ");
            entity.Property(e => e.GroupFaqMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_MetatagDescription");
            entity.Property(e => e.GroupFaqMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_MetatagTitle");
            entity.Property(e => e.GroupFaqTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_Title");
            entity.Property(e => e.GroupHotelsRessorts).HasColumnType("ntext");
            entity.Property(e => e.GroupHotelsRessortsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_MetatagDescription");
            entity.Property(e => e.GroupHotelsRessortsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_MetatagTitle");
            entity.Property(e => e.GroupHotelsRessortsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_Title");
            entity.Property(e => e.GroupMeetingEvents).HasColumnType("ntext");
            entity.Property(e => e.GroupMeetingEventsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_MetatagDescription");
            entity.Property(e => e.GroupMeetingEventsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_MetatagTitle");
            entity.Property(e => e.GroupMeetingEventsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_Title");
            entity.Property(e => e.GroupNews).HasColumnType("ntext");
            entity.Property(e => e.GroupNewsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_MetatagDescription");
            entity.Property(e => e.GroupNewsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_MetatagTitle");
            entity.Property(e => e.GroupNewsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_Title");
            entity.Property(e => e.GroupOverview).HasColumnType("ntext");
            entity.Property(e => e.GroupPagesId).HasColumnName("GroupPagesID");
            entity.Property(e => e.GroupPrivacy).HasColumnType("ntext");
            entity.Property(e => e.GroupPrivacyMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_MetatagDescription");
            entity.Property(e => e.GroupPrivacyMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_MetatagTitle");
            entity.Property(e => e.GroupPrivacyTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_Title");
            entity.Property(e => e.GroupSummery).HasColumnType("ntext");
            entity.Property(e => e.GroupTerms).HasColumnType("ntext");
            entity.Property(e => e.GroupTermsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_MetatagDescription");
            entity.Property(e => e.GroupTermsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_MetatagTitle");
            entity.Property(e => e.GroupTermsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_Title");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasMaxLength(250);
            entity.Property(e => e.MetatagTitle).HasMaxLength(250);

            entity.HasOne(d => d.GroupPages).WithMany(p => p.TblGroupPagesContents)
                .HasForeignKey(d => d.GroupPagesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GroupPagesContent_tbl_GroupPages");
        });

        modelBuilder.Entity<TblGroupSlider>(entity =>
        {
            entity.HasKey(e => e.SliderGroupId);

            entity.ToTable("tbl_Group_Sliders", "dbo");

            entity.Property(e => e.SliderGroupId).HasColumnName("SliderGroupID");
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SliderButtonText).HasMaxLength(250);
            entity.Property(e => e.SliderMainText).HasMaxLength(250);
            entity.Property(e => e.SliderPhoto).HasMaxLength(250);
            entity.Property(e => e.SliderSubText).HasMaxLength(250);
            entity.Property(e => e.SliderbuttonUrl)
                .HasMaxLength(250)
                .HasColumnName("SliderbuttonURL");

            entity.HasOne(d => d.Lang).WithMany(p => p.TblGroupSliders)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("FK_tbl_Group_Sliders_Master_Languages");
        });

        modelBuilder.Entity<TblGroupSocial>(entity =>
        {
            entity.HasKey(e => e.GroupSocialId);

            entity.ToTable("tbl_GroupSocials", "dbo");

            entity.Property(e => e.GroupSocialId).HasColumnName("GroupSocialID");
            entity.Property(e => e.SocialClass).HasMaxLength(250);
            entity.Property(e => e.SocialColor).HasMaxLength(250);
            entity.Property(e => e.SocialName).HasMaxLength(250);
            entity.Property(e => e.SocialUrl)
                .HasMaxLength(250)
                .HasColumnName("SocialURL");
        });

        modelBuilder.Entity<TblGym>(entity =>
        {
            entity.HasKey(e => e.GymId);

            entity.ToTable("tbl_GYM", "dbo", tb => tb.HasTrigger("tbl_GYM_Content_trigger"));

            entity.Property(e => e.GymId).HasColumnName("gymID");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityStatus).HasDefaultValue(true);
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
        });

        modelBuilder.Entity<TblGymContent>(entity =>
        {
            entity.HasKey(e => e.GymContentId);

            entity.ToTable("tbl_GYM_Content", "dbo");

            entity.Property(e => e.GymContentId).HasColumnName("GymContentID");
            entity.Property(e => e.AgeRequirement)
                .HasColumnType("ntext")
                .HasColumnName("AGE_REQUIREMENT");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.Fees)
                .HasColumnType("ntext")
                .HasColumnName("FEES");
            entity.Property(e => e.GymId).HasColumnName("gymID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("ntext")
                .HasColumnName("OPENING_HOURS");
            entity.Property(e => e.PersonalTrainer)
                .HasColumnType("ntext")
                .HasColumnName("PERSONAL_TRAINER");

            entity.HasOne(d => d.Gym).WithMany(p => p.TblGymContents)
                .HasForeignKey(d => d.GymId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GYM_Content_tbl_GYM");
        });

        modelBuilder.Entity<TblGymGallery>(entity =>
        {
            entity.HasKey(e => e.FacilitiesFileId);

            entity.ToTable("tbl_GYM_Gallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.Gymid).HasColumnName("GYMID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblGymService>(entity =>
        {
            entity.HasKey(e => e.GymservicesId);

            entity.ToTable("tbl_GYM_Services", "dbo", tb => tb.HasTrigger("tbl_GYM_Services_Content_trigger"));

            entity.Property(e => e.GymservicesId).HasColumnName("GYMServicesID");
            entity.Property(e => e.SpaservicesPosition).HasColumnName("SPAServicesPosition");
            entity.Property(e => e.SpaservicesStatus).HasColumnName("SPAServicesStatus");
            entity.Property(e => e.SpaservicesSys)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesSYS");
        });

        modelBuilder.Entity<TblGymServicesContent>(entity =>
        {
            entity.HasKey(e => e.GymservicesContentId);

            entity.ToTable("tbl_GYM_Services_Content", "dbo");

            entity.Property(e => e.GymservicesContentId).HasColumnName("GYMServicesContentID");
            entity.Property(e => e.GymservicesDetails)
                .HasColumnType("ntext")
                .HasColumnName("GYMServicesDetails");
            entity.Property(e => e.GymservicesExtraNote)
                .HasColumnType("ntext")
                .HasColumnName("GYMServicesExtraNote");
            entity.Property(e => e.GymservicesId).HasColumnName("GYMServicesID");
            entity.Property(e => e.GymservicesName)
                .HasMaxLength(250)
                .HasColumnName("GYMServicesName");
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.Gymservices).WithMany(p => p.TblGymServicesContents)
                .HasForeignKey(d => d.GymservicesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_GYM_Services_Content_tbl_GYM_Services");
        });

        modelBuilder.Entity<TblHome>(entity =>
        {
            entity.HasKey(e => e.HomeId);

            entity.ToTable("tbl_Home", "dbo", tb => tb.HasTrigger("Home_Content_trigger"));

            entity.Property(e => e.HomeId).HasColumnName("HomeID");
            entity.Property(e => e.AboutUsPhoto).HasMaxLength(250);
            entity.Property(e => e.AwardBgphoto)
                .HasMaxLength(250)
                .HasColumnName("AwardBGPhoto");
            entity.Property(e => e.FooterBg)
                .HasMaxLength(250)
                .HasColumnName("FooterBG");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.SectionAboutPhoto1).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto2).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto3).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto4).HasMaxLength(250);
            entity.Property(e => e.SectionDiningPhoto1).HasMaxLength(250);
            entity.Property(e => e.SectionDiningPhoto2).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingPhoto).HasMaxLength(250);
            entity.Property(e => e.SectionNewsLetterPhoto)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Photo");
            entity.Property(e => e.SectionOfferPhoto).HasMaxLength(250);
            entity.Property(e => e.SectionUpdateText).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingPhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<TblHomeContent>(entity =>
        {
            entity.HasKey(e => e.HomeContentId);

            entity.ToTable("tbl_Home_Content", "dbo");

            entity.Property(e => e.HomeContentId).HasColumnName("HomeContentID");
            entity.Property(e => e.AboutUsText).HasColumnType("ntext");
            entity.Property(e => e.AboutUsTitle).HasMaxLength(250);
            entity.Property(e => e.AwardText).HasColumnType("ntext");
            entity.Property(e => e.AwardTitle).HasMaxLength(250);
            entity.Property(e => e.BookingEngineUrl)
                .HasColumnType("ntext")
                .HasColumnName("BookingEngineURL");
            entity.Property(e => e.BtnCheckAvalibality)
                .HasMaxLength(250)
                .HasColumnName("btn_Check_Avalibality");
            entity.Property(e => e.BtnViewRoom)
                .HasMaxLength(250)
                .HasColumnName("btn_View_Room");
            entity.Property(e => e.ExploreTeamText).HasColumnType("ntext");
            entity.Property(e => e.ExploreTeamTitle).HasMaxLength(250);
            entity.Property(e => e.HomeId).HasColumnName("HomeID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.NewsletterText).HasColumnType("ntext");
            entity.Property(e => e.NewsletterTitle).HasMaxLength(250);
            entity.Property(e => e.SectionAboutBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionAboutBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionAboutBtnURL");
            entity.Property(e => e.SectionAboutText).HasColumnType("ntext");
            entity.Property(e => e.SectionAboutTitle).HasMaxLength(250);
            entity.Property(e => e.SectionActivitiesBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionActivitiesBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionActivitiesBtnURL");
            entity.Property(e => e.SectionActivitiesText).HasColumnType("ntext");
            entity.Property(e => e.SectionActivitiesTitle).HasMaxLength(250);
            entity.Property(e => e.SectionAwardsTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_Awards_Tittle");
            entity.Property(e => e.SectionDiningBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionDiningBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionDiningBtnURL");
            entity.Property(e => e.SectionDiningText).HasColumnType("ntext");
            entity.Property(e => e.SectionDiningTitle).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionMeetingBtnURL");
            entity.Property(e => e.SectionMeetingText).HasColumnType("ntext");
            entity.Property(e => e.SectionMeetingTitle).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionNewsBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionNewsBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionNewsBtnURL");
            entity.Property(e => e.SectionNewsLetterBtn)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_btn");
            entity.Property(e => e.SectionNewsLetterBtnPlaceholder)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_btn_placeholder");
            entity.Property(e => e.SectionNewsLetterSubTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Sub_Tittle");
            entity.Property(e => e.SectionNewsLetterText)
                .HasColumnType("ntext")
                .HasColumnName("Section_NewsLetter_Text");
            entity.Property(e => e.SectionNewsLetterTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Tittle");
            entity.Property(e => e.SectionNewsText).HasColumnType("ntext");
            entity.Property(e => e.SectionNewsTitle).HasMaxLength(250);
            entity.Property(e => e.SectionOfferBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionOfferBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionOfferBtnURL");
            entity.Property(e => e.SectionOfferText).HasColumnType("ntext");
            entity.Property(e => e.SectionOfferTitle).HasMaxLength(250);
            entity.Property(e => e.SectionOfferTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionRoomText).HasColumnType("ntext");
            entity.Property(e => e.SectionRoomTitle).HasMaxLength(250);
            entity.Property(e => e.SectionRoomTitleBack).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionWeddingBtnURL");
            entity.Property(e => e.SectionWeddingText).HasColumnType("ntext");
            entity.Property(e => e.SectionWeddingTitle).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitle1).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitle2).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitleText).HasColumnType("ntext");
            entity.Property(e => e.SectionWhyChooseUsText).HasMaxLength(250);
            entity.Property(e => e.SectionWhyChooseUsTittle).HasMaxLength(250);

            entity.HasOne(d => d.Home).WithMany(p => p.TblHomeContents)
                .HasForeignKey(d => d.HomeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Home_Content_tbl_Home");
        });

        modelBuilder.Entity<TblHomeDiscover>(entity =>
        {
            entity.HasKey(e => e.DiscoverId);

            entity.ToTable("tbl_Home_Discover", "dbo", tb => tb.HasTrigger("tbl_Home_Discover_Content_trigger"));

            entity.Property(e => e.DiscoverId).HasColumnName("DiscoverID");
            entity.Property(e => e.ItemPhoto).HasMaxLength(250);
            entity.Property(e => e.ItemPosition).HasDefaultValue(100);
            entity.Property(e => e.ItemStatus).HasDefaultValue(false);
            entity.Property(e => e.ItemTitleNameSys).HasMaxLength(250);
        });

        modelBuilder.Entity<TblHomeDiscoverContent>(entity =>
        {
            entity.HasKey(e => e.DiscoverContentId);

            entity.ToTable("tbl_Home_Discover_Content", "dbo");

            entity.Property(e => e.DiscoverContentId).HasColumnName("DiscoverContentID");
            entity.Property(e => e.DiscoverId).HasColumnName("DiscoverID");
            entity.Property(e => e.ItemTitleName).HasMaxLength(250);
            entity.Property(e => e.ItemUrl)
                .HasColumnType("ntext")
                .HasColumnName("ItemURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LangStatus).HasDefaultValue(false);

            entity.HasOne(d => d.Discover).WithMany(p => p.TblHomeDiscoverContents)
                .HasForeignKey(d => d.DiscoverId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Home_Discover_Content_tbl_Home_Discover");
        });

        modelBuilder.Entity<TblHomeWhyU>(entity =>
        {
            entity.HasKey(e => e.WhuUsId);

            entity.ToTable("tbl_Home_WhyUs", "dbo", tb => tb.HasTrigger("Home_WhyUs_Content_trigger"));

            entity.Property(e => e.WhuUsId).HasColumnName("WhuUsID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.WhuUsPhoto)
                .HasMaxLength(250)
                .HasDefaultValue("none.jpg");
            entity.Property(e => e.WhuUsPosition).HasDefaultValue(100);
            entity.Property(e => e.WhuUsStatus).HasDefaultValue(true);
            entity.Property(e => e.WhuUsTitleSys).HasMaxLength(250);
            entity.Property(e => e.WhyChooseUsclass)
                .HasMaxLength(250)
                .HasColumnName("WhyChooseUSClass");
        });

        modelBuilder.Entity<TblHomeWhyUsContent>(entity =>
        {
            entity.HasKey(e => e.WhuUsContentId);

            entity.ToTable("tbl_Home_WhyUs_Content", "dbo");

            entity.Property(e => e.WhuUsContentId).HasColumnName("WhuUsContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.WhuUsId).HasColumnName("WhuUsID");
            entity.Property(e => e.WhuUsText).HasColumnType("ntext");
            entity.Property(e => e.WhuUsTitle).HasMaxLength(250);

            entity.HasOne(d => d.WhuUs).WithMany(p => p.TblHomeWhyUsContents)
                .HasForeignKey(d => d.WhuUsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Home_WhyUs_Content_tbl_Home_WhyUs");
        });

        modelBuilder.Entity<TblHotelPartner>(entity =>
        {
            entity.HasKey(e => e.HotelPartnerId);

            entity.ToTable("tbl_HotelPartners", "dbo");

            entity.Property(e => e.HotelPartnerId).HasColumnName("HotelPartnerID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelPartnerPhoto).HasMaxLength(250);

            entity.HasOne(d => d.Hotel).WithMany(p => p.TblHotelPartners)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_HotelPartners_Hotels");
        });

        modelBuilder.Entity<TblHotels360>(entity =>
        {
            entity.HasKey(e => e.Item360id);

            entity.ToTable("tbl_Hotels_360", "dbo");

            entity.Property(e => e.Item360id).HasColumnName("item360id");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.Item360Url)
                .HasColumnType("ntext")
                .HasColumnName("item360URL");
            entity.Property(e => e.ItemStatus).HasDefaultValue(true);
            entity.Property(e => e.Itemdescription)
                .HasColumnType("ntext")
                .HasColumnName("itemdescription");
            entity.Property(e => e.Posturl)
                .HasColumnType("ntext")
                .HasColumnName("POSTURL");
        });

        modelBuilder.Entity<TblHotelsCreditCard>(entity =>
        {
            entity.HasKey(e => e.HotelCreditCardId);

            entity.ToTable("tbl_Hotels_CreditCards", "dbo");

            entity.Property(e => e.HotelCreditCardId).HasColumnName("HotelCreditCardID");
            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
        });

        modelBuilder.Entity<TblHotelsFacility>(entity =>
        {
            entity.HasKey(e => e.FacilitiesPerHotelId);

            entity.ToTable("tbl_HotelsFacilities", "dbo");

            entity.Property(e => e.FacilitiesPerHotelId).HasColumnName("FacilitiesPerHotelID");
            entity.Property(e => e.HotelFacilitiesItemId).HasColumnName("HotelFacilitiesItemID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
        });

        modelBuilder.Entity<TblHotelsNearBy>(entity =>
        {
            entity.HasKey(e => e.HotelNearById);

            entity.ToTable("tbl_Hotels_NearBy", "dbo", tb => tb.HasTrigger("NearBy_Content_trigger"));

            entity.Property(e => e.HotelNearById).HasColumnName("HotelNearByID");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNearByNameSys).HasMaxLength(250);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblHotelsNearByContent>(entity =>
        {
            entity.HasKey(e => e.HotelNearByContentId);

            entity.ToTable("tbl_Hotels_NearBy_Content", "dbo");

            entity.Property(e => e.HotelNearByContentId).HasColumnName("HotelNearByContentID");
            entity.Property(e => e.HotelNearByDistanceUnit).HasMaxLength(250);
            entity.Property(e => e.HotelNearById).HasColumnName("HotelNearByID");
            entity.Property(e => e.HotelNearByName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.HotelNearBy).WithMany(p => p.TblHotelsNearByContents)
                .HasForeignKey(d => d.HotelNearById)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Hotels_NearBy_Content_tbl_Hotels_NearBy");
        });

        modelBuilder.Entity<TblHotelsSocialMedium>(entity =>
        {
            entity.HasKey(e => e.SocialId).HasName("PK_tbl_HotelSocialMedia");

            entity.ToTable("tbl_Hotels_SocialMedia", "dbo");

            entity.Property(e => e.SocialId).HasColumnName("SocialID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.SocialClass).HasMaxLength(250);
            entity.Property(e => e.SocialColor).HasMaxLength(250);
            entity.Property(e => e.SocialName).HasMaxLength(250);
            entity.Property(e => e.SocialUrl)
                .HasMaxLength(250)
                .HasColumnName("SocialURL");
        });

        modelBuilder.Entity<TblHotelsSpokenLanguage>(entity =>
        {
            entity.HasKey(e => e.HotelSpokenLanguageId);

            entity.ToTable("tbl_Hotels_SpokenLanguages", "dbo");

            entity.Property(e => e.HotelSpokenLanguageId).HasColumnName("HotelSpokenLanguageID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.SpokenLanguagesId).HasColumnName("SpokenLanguagesID");
        });

        modelBuilder.Entity<TblJob>(entity =>
        {
            entity.HasKey(e => e.JobId);

            entity.ToTable("tbl_Jobs", "dbo", tb =>
                {
                    tb.HasTrigger("Craeers_Content_trigger");
                    tb.HasTrigger("JobURL");
                });

            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.JobNameSys)
                .HasMaxLength(250)
                .HasColumnName("Job_Name_Sys");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(250)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobUrl)
                .HasMaxLength(250)
                .HasColumnName("JobURL");
            entity.Property(e => e.PostingDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Posting_Date");
        });

        modelBuilder.Entity<TblJobsContent>(entity =>
        {
            entity.HasKey(e => e.JobContentId);

            entity.ToTable("tbl_Jobs_Content", "dbo");

            entity.Property(e => e.JobContentId).HasColumnName("JobContentID");
            entity.Property(e => e.JobCategory)
                .HasMaxLength(250)
                .HasColumnName("Job_Category");
            entity.Property(e => e.JobDetails).HasColumnType("ntext");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.JobSchedule).HasMaxLength(250);
            entity.Property(e => e.JobSummery).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.PositionType)
                .HasMaxLength(250)
                .HasColumnName("Position_Type");

            entity.HasOne(d => d.Job).WithMany(p => p.TblJobsContents)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Jobs_Content_tbl_Jobs");
        });

        modelBuilder.Entity<TblMasterBookingCurrency>(entity =>
        {
            entity.HasKey(e => e.BookingCurrencyCode);

            entity.ToTable("tbl_MasterBookingCurrency", "dbo");

            entity.Property(e => e.BookingCurrencyCode).HasMaxLength(50);
            entity.Property(e => e.BookingCurrencyName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMasterBookingLanguage>(entity =>
        {
            entity.HasKey(e => e.BookingLangId);

            entity.ToTable("tbl_MasterBookingLanguage", "dbo");

            entity.Property(e => e.BookingLangId)
                .HasMaxLength(50)
                .HasColumnName("BookingLangID");
            entity.Property(e => e.BookingLangName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMasterCreditCard>(entity =>
        {
            entity.HasKey(e => e.CreditCardId);

            entity.ToTable("tbl_Master_CreditCards", "dbo", tb => tb.HasTrigger("tbl_Master_CreditCards_Content_trigger"));

            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");
            entity.Property(e => e.CreditCardIcon).HasMaxLength(250);
            entity.Property(e => e.CreditCardNameSys)
                .HasMaxLength(250)
                .HasColumnName("CreditCardNameSYS");
        });

        modelBuilder.Entity<TblMasterCreditCardsContent>(entity =>
        {
            entity.HasKey(e => e.CreditCardContentId);

            entity.ToTable("tbl_Master_CreditCards_Content", "dbo");

            entity.Property(e => e.CreditCardContentId).HasColumnName("CreditCardContentID");
            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");
            entity.Property(e => e.CreditCardName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.CreditCard).WithMany(p => p.TblMasterCreditCardsContents)
                .HasForeignKey(d => d.CreditCardId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_CreditCards_Content_tbl_Master_CreditCards");
        });

        modelBuilder.Entity<TblMasterHotelFacilitiesContent>(entity =>
        {
            entity.HasKey(e => e.HotelFacilitiesContentId);

            entity.ToTable("tbl_Master_HotelFacilities_Content", "dbo");

            entity.Property(e => e.HotelFacilitiesContentId).HasColumnName("HotelFacilitiesContentID");
            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.HotelFacilities).WithMany(p => p.TblMasterHotelFacilitiesContents)
                .HasForeignKey(d => d.HotelFacilitiesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_HotelFacilities_Content_tbl_Master_HotelFacilities");
        });

        modelBuilder.Entity<TblMasterHotelFacilitiesItem>(entity =>
        {
            entity.HasKey(e => e.HotelFacilitiesItemId);

            entity.ToTable("tbl_Master_HotelFacilities_Items", "dbo", tb => tb.HasTrigger("tbl_Master_HotelFacilities_Items_trigger"));

            entity.Property(e => e.HotelFacilitiesItemId).HasColumnName("HotelFacilitiesItemID");
            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesItemNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesItemPosition).HasDefaultValue(1);
            entity.Property(e => e.HotelFacilitiesItemStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<TblMasterHotelFacilitiesItemsContent>(entity =>
        {
            entity.HasKey(e => e.HotelFacilitiesItemContentId);

            entity.ToTable("tbl_Master_HotelFacilities_Items_Content", "dbo");

            entity.Property(e => e.HotelFacilitiesItemContentId).HasColumnName("HotelFacilitiesItemContentID");
            entity.Property(e => e.HotelFacilitiesItemExtraText).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesItemId).HasColumnName("HotelFacilitiesItemID");
            entity.Property(e => e.HotelFacilitiesItemName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");

            entity.HasOne(d => d.HotelFacilitiesItem).WithMany(p => p.TblMasterHotelFacilitiesItemsContents)
                .HasForeignKey(d => d.HotelFacilitiesItemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_HotelFacilities_Items_Content_tbl_Master_HotelFacilities_Items");
        });

        modelBuilder.Entity<TblMasterHotelFacility>(entity =>
        {
            entity.HasKey(e => e.HotelFacilitiesId);

            entity.ToTable("tbl_Master_HotelFacilities", "dbo", tb => tb.HasTrigger("tbl_Master_HotelFacilities_Content_trigger"));

            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesIcon).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesNameSys).HasMaxLength(250);
        });

        modelBuilder.Entity<TblMasterHotelType>(entity =>
        {
            entity.HasKey(e => e.HotelTypeId);

            entity.ToTable("tbl_Master_HotelTypes", "dbo", tb => tb.HasTrigger("tbl_Master_HotelTypes_trigger"));

            entity.Property(e => e.HotelTypeId).HasColumnName("HotelTypeID");
            entity.Property(e => e.HotelTypeNameSys)
                .HasMaxLength(250)
                .HasColumnName("HotelTypeName_Sys");
        });

        modelBuilder.Entity<TblMasterHotelTypesContent>(entity =>
        {
            entity.HasKey(e => e.HotelTypeContentId);

            entity.ToTable("tbl_Master_HotelTypes_Content", "dbo");

            entity.Property(e => e.HotelTypeContentId).HasColumnName("HotelTypeContentID");
            entity.Property(e => e.HotelTypeId).HasColumnName("HotelTypeID");
            entity.Property(e => e.HotelTypeName).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
        });

        modelBuilder.Entity<TblMasterRoomAmenitiesCategoriesContent>(entity =>
        {
            entity.HasKey(e => e.RoomAmenitiesCategoryContentId);

            entity.ToTable("tbl_Master_RoomAmenities_Categories_Content", "dbo");

            entity.Property(e => e.RoomAmenitiesCategoryContentId).HasColumnName("RoomAmenitiesCategoryContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.RoomAmenitiesCategoryId).HasColumnName("RoomAmenitiesCategoryID");
            entity.Property(e => e.RoomAmenitiesCategoryName).HasMaxLength(250);

            entity.HasOne(d => d.RoomAmenitiesCategory).WithMany(p => p.TblMasterRoomAmenitiesCategoriesContents)
                .HasForeignKey(d => d.RoomAmenitiesCategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_RoomAmenities_Categories_Content_tbl_Master_RoomAmenities_Categories");
        });

        modelBuilder.Entity<TblMasterRoomAmenitiesCategory>(entity =>
        {
            entity.HasKey(e => e.RoomAmenitiesCategoryId);

            entity.ToTable("tbl_Master_RoomAmenities_Categories", "dbo", tb => tb.HasTrigger("Master_RoomAmenities_Categories"));

            entity.Property(e => e.RoomAmenitiesCategoryId).HasColumnName("RoomAmenitiesCategoryID");
            entity.Property(e => e.RoomAmenitiesCategoryNameSys).HasMaxLength(250);
        });

        modelBuilder.Entity<TblMasterRoomAmenitiesContent>(entity =>
        {
            entity.HasKey(e => e.RoomAmenitiesContentId);

            entity.ToTable("tbl_Master_RoomAmenities_Content", "dbo");

            entity.Property(e => e.RoomAmenitiesContentId).HasColumnName("RoomAmenitiesContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.RoomAmenitiesId).HasColumnName("RoomAmenitiesID");
            entity.Property(e => e.RoomAmenitiesName).HasMaxLength(250);

            entity.HasOne(d => d.RoomAmenities).WithMany(p => p.TblMasterRoomAmenitiesContents)
                .HasForeignKey(d => d.RoomAmenitiesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_RoomAmenities_Content_tbl_Master_RoomAmenities");
        });

        modelBuilder.Entity<TblMasterRoomAmenity>(entity =>
        {
            entity.HasKey(e => e.RoomAmenitiesId);

            entity.ToTable("tbl_Master_RoomAmenities", "dbo", tb => tb.HasTrigger("Master_RoomAmenitie_trigger"));

            entity.Property(e => e.RoomAmenitiesId).HasColumnName("RoomAmenitiesID");
            entity.Property(e => e.RoomAmenitiesCategoryId).HasColumnName("RoomAmenitiesCategoryID");
            entity.Property(e => e.RoomAmenitiesIconFont).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesPosition).HasDefaultValue(1);
            entity.Property(e => e.RoomAmenitiesStatus).HasDefaultValue(true);
            entity.Property(e => e.RoomAmenitiesSys).HasMaxLength(250);
        });

        modelBuilder.Entity<TblMasterSiteType>(entity =>
        {
            entity.HasKey(e => e.SiteTypeId);

            entity.ToTable("tbl_Master_SiteTypes", "dbo");

            entity.Property(e => e.SiteTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SiteTypeID");
            entity.Property(e => e.SiteTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMasterSpokenLanguage>(entity =>
        {
            entity.HasKey(e => e.SpokenLanguagesId);

            entity.ToTable("tbl_Master_SpokenLanguages", "dbo", tb => tb.HasTrigger("tbl_Master_SpokenLanguages_Content_trigger"));

            entity.Property(e => e.SpokenLanguagesId).HasColumnName("SpokenLanguagesID");
            entity.Property(e => e.SpokenLanguagesFlag).HasMaxLength(250);
            entity.Property(e => e.SpokenLanguagesSys)
                .HasMaxLength(250)
                .HasColumnName("SpokenLanguagesSYS");
        });

        modelBuilder.Entity<TblMasterSpokenLanguagesContent>(entity =>
        {
            entity.HasKey(e => e.SpokenLanguagesContentId);

            entity.ToTable("tbl_Master_SpokenLanguages_Content", "dbo");

            entity.Property(e => e.SpokenLanguagesContentId).HasColumnName("SpokenLanguagesContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SpokenLanguages).HasMaxLength(250);
            entity.Property(e => e.SpokenLanguagesId).HasColumnName("SpokenLanguagesID");

            entity.HasOne(d => d.SpokenLanguagesNavigation).WithMany(p => p.TblMasterSpokenLanguagesContents)
                .HasForeignKey(d => d.SpokenLanguagesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Master_SpokenLanguages_Content_tbl_Master_SpokenLanguages");
        });

        modelBuilder.Entity<TblMeetingsEvent>(entity =>
        {
            entity.HasKey(e => e.FacilityId);

            entity.ToTable("tbl_MeetingsEvents", "dbo", tb =>
                {
                    tb.HasTrigger("MeetingsEventsURL");
                    tb.HasTrigger("Meetings_Content_trigger");
                });

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityPhotoHome).HasMaxLength(250);
            entity.Property(e => e.FacilityStatus).HasDefaultValue(true);
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMoreDetails).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblMeetingsEventsContent>(entity =>
        {
            entity.HasKey(e => e.FacilityContentId);

            entity.ToTable("tbl_MeetingsEvents_Content", "dbo");

            entity.Property(e => e.FacilityContentId).HasColumnName("FacilityContentID");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilityStatusLang).HasDefaultValue(false);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MeetingCapacity).HasColumnType("ntext");
            entity.Property(e => e.MeetingCellingHeight).HasMaxLength(250);
            entity.Property(e => e.MeetingLength).HasMaxLength(250);
            entity.Property(e => e.MeetingSize).HasMaxLength(250);
            entity.Property(e => e.MeetingWidths).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");

            entity.HasOne(d => d.Facility).WithMany(p => p.TblMeetingsEventsContents)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_MeetingsEvents_Content_tbl_MeetingsEvents");
        });

        modelBuilder.Entity<TblMeetingsEventsGallery>(entity =>
        {
            entity.HasKey(e => e.FacilitiesFileId);

            entity.ToTable("tbl_MeetingsEvents_Gallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.FacilitiesId).HasColumnName("FacilitiesID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);

            entity.HasOne(d => d.Facilities).WithMany(p => p.TblMeetingsEventsGalleries)
                .HasForeignKey(d => d.FacilitiesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_MeetingsEvents_Gallery_tbl_MeetingsEvents");
        });

        modelBuilder.Entity<TblMeetingsEventsShape>(entity =>
        {
            entity.HasKey(e => e.MeetingStyleId);

            entity.ToTable("tbl_MeetingsEvents_Shapes", "dbo", tb => tb.HasTrigger("tbl_MeetingsEvents_Shapes_Content_trigger"));

            entity.Property(e => e.MeetingStyleId).HasColumnName("MeetingStyleID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.MeetingStyleNameSys).HasMaxLength(250);
            entity.Property(e => e.MeetingStylePhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<TblMeetingsEventsShapesContent>(entity =>
        {
            entity.HasKey(e => e.MeetingStyleContentId);

            entity.ToTable("tbl_MeetingsEvents_Shapes_Content", "dbo");

            entity.Property(e => e.MeetingStyleContentId).HasColumnName("MeetingStyleContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MeetingStyleBestFor).HasColumnType("ntext");
            entity.Property(e => e.MeetingStyleDescription).HasColumnType("ntext");
            entity.Property(e => e.MeetingStyleId).HasColumnName("MeetingStyleID");
            entity.Property(e => e.MeetingStyleName).HasMaxLength(250);

            entity.HasOne(d => d.MeetingStyle).WithMany(p => p.TblMeetingsEventsShapesContents)
                .HasForeignKey(d => d.MeetingStyleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_MeetingsEvents_Shapes_Content_tbl_MeetingsEvents_Shapes");
        });

        modelBuilder.Entity<TblNews>(entity =>
        {
            entity.HasKey(e => e.NewsId);

            entity.ToTable("tbl_News", "dbo", tb =>
                {
                    tb.HasTrigger("NewsURL");
                    tb.HasTrigger("News_Content_trigger");
                });

            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LangId)
                .HasDefaultValue(1)
                .HasColumnName("LangID");
            entity.Property(e => e.NewsItemBanner).HasMaxLength(250);
            entity.Property(e => e.NewsItemBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Mobile");
            entity.Property(e => e.NewsItemBannerMobileHieght).HasColumnName("NewsItemBanner_MobileHieght");
            entity.Property(e => e.NewsItemBannerMobileWidth).HasColumnName("NewsItemBanner_MobileWidth");
            entity.Property(e => e.NewsItemBannerPhotoHieght).HasColumnName("NewsItemBannerPhoto_Hieght");
            entity.Property(e => e.NewsItemBannerPhotoWidth).HasColumnName("NewsItemBannerPhoto_Width");
            entity.Property(e => e.NewsItemBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Tablet");
            entity.Property(e => e.NewsItemBannerTabletHieght).HasColumnName("NewsItemBanner_TabletHieght");
            entity.Property(e => e.NewsItemBannerTabletWidth).HasColumnName("NewsItemBanner_TabletWidth");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsStatus).HasDefaultValue(true);
            entity.Property(e => e.NewsTitleSys)
                .HasMaxLength(250)
                .HasColumnName("NewsTitleSYS");
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<TblNewsContent>(entity =>
        {
            entity.HasKey(e => e.NewsContentId);

            entity.ToTable("tbl_NewsContent", "dbo");

            entity.Property(e => e.NewsContentId).HasColumnName("NewsContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.NewsDateTime)
                .HasMaxLength(250)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NewsDetails).HasMaxLength(250);
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsShortDescription).HasMaxLength(250);
            entity.Property(e => e.NewsTitle).HasMaxLength(250);

            entity.HasOne(d => d.News).WithMany(p => p.TblNewsContents)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_NewsContent_tbl_News");
        });

        modelBuilder.Entity<TblNewsGallery>(entity =>
        {
            entity.HasKey(e => e.NewsFileId);

            entity.ToTable("tbl_News_Gallery", "dbo");

            entity.Property(e => e.NewsFileId).HasColumnName("NewsFileID");
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblOffer>(entity =>
        {
            entity.HasKey(e => e.Offerid);

            entity.ToTable("tbl_Offers", "dbo", tb =>
                {
                    tb.HasTrigger("OfferURL");
                    tb.HasTrigger("Offer_Content_trigger");
                });

            entity.Property(e => e.Offerid).HasColumnName("offerid");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DateEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.DateStart).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsChildAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDisplayDates).HasDefaultValue(true);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.OfferBanner).HasMaxLength(250);
            entity.Property(e => e.OfferNameSys)
                .HasMaxLength(250)
                .HasColumnName("OfferNameSYS");
            entity.Property(e => e.OfferPhoto).HasMaxLength(250);
            entity.Property(e => e.OfferUrl)
                .HasMaxLength(250)
                .HasColumnName("OfferURL");
            entity.Property(e => e.PromoCode).HasMaxLength(250);
        });

        modelBuilder.Entity<TblOffersContent>(entity =>
        {
            entity.HasKey(e => e.OfferContentId);

            entity.ToTable("tbl_Offers_Content", "dbo");

            entity.Property(e => e.OfferContentId).HasColumnName("OfferContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.OfferDescription).HasColumnType("ntext");
            entity.Property(e => e.OfferId).HasColumnName("OfferID");
            entity.Property(e => e.OfferInclude).HasColumnType("ntext");
            entity.Property(e => e.OfferName).HasMaxLength(250);
            entity.Property(e => e.OfferSubTitle1).HasColumnType("ntext");
            entity.Property(e => e.OfferSubTitle2).HasColumnType("ntext");
            entity.Property(e => e.OfferTerms).HasColumnType("ntext");
            entity.Property(e => e.OfferUrl)
                .HasColumnType("ntext")
                .HasColumnName("OfferURL");
            entity.Property(e => e.ValidityText).HasColumnType("ntext");

            entity.HasOne(d => d.Offer).WithMany(p => p.TblOffersContents)
                .HasForeignKey(d => d.OfferId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Offers_Content_tbl_Offers");
        });

        modelBuilder.Entity<TblPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("tbl_Pages", "dbo", tb =>
                {
                    tb.HasTrigger("PageURL");
                    tb.HasTrigger("Pages_Content");
                });

            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.PageBanner).HasMaxLength(250);
            entity.Property(e => e.PageNameSys).HasMaxLength(250);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(250)
                .HasColumnName("PageURL");
            entity.Property(e => e.Updatetext).HasMaxLength(250);
        });

        modelBuilder.Entity<TblPagesBanner>(entity =>
        {
            entity.HasKey(e => e.PageBannerId);

            entity.ToTable("tbl_Pages_Banners", "dbo");

            entity.Property(e => e.PageBannerId).HasColumnName("PageBannerID");
            entity.Property(e => e.BannerFile).HasMaxLength(250);
            entity.Property(e => e.BannerStatus).HasDefaultValue(false);
            entity.Property(e => e.PageId).HasColumnName("PageID");
        });

        modelBuilder.Entity<TblPagesContent>(entity =>
        {
            entity.HasKey(e => e.PageContentId);

            entity.ToTable("tbl_Pages_Content", "dbo");

            entity.Property(e => e.PageContentId).HasColumnName("PageContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.PageDetails).HasColumnType("ntext");
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.PageMetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.PageMetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.PageTitle).HasMaxLength(250);

            entity.HasOne(d => d.Page).WithMany(p => p.TblPagesContents)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Pages_Content_tbl_Pages");
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.HasKey(e => e.ServicesId);

            entity.ToTable("tbl_Services", "dbo", tb => tb.HasTrigger("tbl_Services_Content_trigger"));

            entity.Property(e => e.ServicesId).HasColumnName("ServicesID");
            entity.Property(e => e.ServiceNameSys)
                .HasMaxLength(250)
                .HasColumnName("ServiceNameSYS");
            entity.Property(e => e.ServicesPhotos)
                .HasMaxLength(250)
                .HasDefaultValue("none.jpg");
            entity.Property(e => e.ServicesStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<TblServicesContent>(entity =>
        {
            entity.HasKey(e => e.ServicesContentId);

            entity.ToTable("tbl_Services_Content", "dbo");

            entity.Property(e => e.ServicesContentId).HasColumnName("ServicesContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.ServicesId).HasColumnName("ServicesID");
            entity.Property(e => e.ServicesName).HasMaxLength(250);

            entity.HasOne(d => d.Services).WithMany(p => p.TblServicesContents)
                .HasForeignKey(d => d.ServicesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Services_Content_tbl_Services");
        });

        modelBuilder.Entity<TblServicesHotel>(entity =>
        {
            entity.HasKey(e => e.HotelServicesId);

            entity.ToTable("tbl_Services_Hotels", "dbo");

            entity.Property(e => e.HotelServicesId).HasColumnName("HotelServicesID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.ServicesId).HasColumnName("ServicesID");
        });

        modelBuilder.Entity<TblSiteConfiguration>(entity =>
        {
            entity.HasKey(e => e.SiteId);

            entity.ToTable("tbl_Site_Configurations", "dbo");

            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.BingVerification).HasMaxLength(250);
            entity.Property(e => e.BusinessName).HasMaxLength(250);
            entity.Property(e => e.ContactUsEmail).HasMaxLength(250);
            entity.Property(e => e.EmailTemplateContactUs)
                .HasColumnType("ntext")
                .HasColumnName("EmailTemplateContactUS");
            entity.Property(e => e.EmailTemplateNewsletter).HasColumnType("ntext");
            entity.Property(e => e.EmailTemplateProductRequest).HasColumnType("ntext");
            entity.Property(e => e.EnableAwards).HasDefaultValue(false);
            entity.Property(e => e.EnableBlog).HasDefaultValue(false);
            entity.Property(e => e.EnableCareer).HasDefaultValue(false);
            entity.Property(e => e.EnableMeeting).HasDefaultValue(false);
            entity.Property(e => e.EnableNews).HasDefaultValue(false);
            entity.Property(e => e.EnableOffers).HasDefaultValue(false);
            entity.Property(e => e.EnablePriceStartFrom).HasDefaultValue(false);
            entity.Property(e => e.EnableSocialMedia).HasDefaultValue(false);
            entity.Property(e => e.EnbaleFaq)
                .HasDefaultValue(false)
                .HasColumnName("EnbaleFAQ");
            entity.Property(e => e.EnbaleTeams).HasDefaultValue(false);
            entity.Property(e => e.FacebookVerification).HasColumnType("ntext");
            entity.Property(e => e.Faqemail)
                .HasMaxLength(250)
                .HasColumnName("FAQEmail");
            entity.Property(e => e.GoogleSearchConsole).HasColumnType("ntext");
            entity.Property(e => e.GoogleTagMangerKey).HasMaxLength(250);
            entity.Property(e => e.LicenseKey).HasMaxLength(250);
            entity.Property(e => e.MeetingRequestEmail).HasMaxLength(250);
            entity.Property(e => e.PinterestVerification).HasColumnType("ntext");
            entity.Property(e => e.SiteTypeId)
                .HasDefaultValue(1)
                .HasColumnName("SiteTypeID");
            entity.Property(e => e.SiteUrl)
                .HasMaxLength(250)
                .HasColumnName("SiteURL");
            entity.Property(e => e.Smtpemail)
                .HasMaxLength(250)
                .HasColumnName("SMTPEmail");
            entity.Property(e => e.Smtphost)
                .HasMaxLength(250)
                .HasColumnName("SMTPHost");
            entity.Property(e => e.Smtppassword)
                .HasMaxLength(250)
                .HasColumnName("SMTPPassword");
            entity.Property(e => e.Smtpport)
                .HasMaxLength(250)
                .HasColumnName("SMTPPort");
            entity.Property(e => e.Smtpsecure)
                .HasMaxLength(250)
                .HasColumnName("SMTPSecure");
            entity.Property(e => e.Smtpusername)
                .HasMaxLength(250)
                .HasColumnName("SMTPUsername");
            entity.Property(e => e.TestEmailReciever).HasMaxLength(250);
            entity.Property(e => e.Vkverification)
                .HasMaxLength(250)
                .HasColumnName("VKVerification");
            entity.Property(e => e.YandexVerification).HasColumnType("ntext");
        });

        modelBuilder.Entity<TblSiteContact>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("tbl_SiteContacts", "dbo");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SiteAddress).HasColumnType("ntext");
            entity.Property(e => e.SiteEmail).HasMaxLength(250);
            entity.Property(e => e.SiteFax).HasMaxLength(250);
            entity.Property(e => e.SiteMobile).HasMaxLength(250);
            entity.Property(e => e.SiteTel).HasMaxLength(250);
        });

        modelBuilder.Entity<TblSiteSocial>(entity =>
        {
            entity.HasKey(e => e.SocialId);

            entity.ToTable("tbl_SiteSocials", "dbo");

            entity.Property(e => e.SocialId).HasColumnName("SocialID");
            entity.Property(e => e.SocialClass).HasMaxLength(250);
            entity.Property(e => e.SocialColor).HasMaxLength(250);
            entity.Property(e => e.SocialName).HasMaxLength(250);
            entity.Property(e => e.SocialUrl)
                .HasMaxLength(250)
                .HasColumnName("SocialURL");
        });

        modelBuilder.Entity<TblSlider>(entity =>
        {
            entity.HasKey(e => e.SliderId);

            entity.ToTable("tbl_Sliders", "dbo");

            entity.Property(e => e.SliderId).HasColumnName("SliderID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDisplayContent).HasDefaultValue(false);
            entity.Property(e => e.LangId)
                .HasDefaultValue(1)
                .HasColumnName("LangID");
            entity.Property(e => e.SliderButtonText).HasMaxLength(250);
            entity.Property(e => e.SliderMainText).HasMaxLength(250);
            entity.Property(e => e.SliderPhoto).HasMaxLength(250);
            entity.Property(e => e.SliderStatus).HasDefaultValue(false);
            entity.Property(e => e.SliderSubText).HasMaxLength(250);
            entity.Property(e => e.SliderbuttonUrl)
                .HasMaxLength(250)
                .HasColumnName("SliderbuttonURL");
        });

        modelBuilder.Entity<TblSpa>(entity =>
        {
            entity.HasKey(e => e.SpaId);

            entity.ToTable("tbl_Spa", "dbo", tb =>
                {
                    tb.HasTrigger("SPAURL");
                    tb.HasTrigger("tbl_Spa_Content_trigger");
                });

            entity.Property(e => e.SpaId).HasColumnName("SpaID");
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityStatus).HasDefaultValue(true);
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblSpaContent>(entity =>
        {
            entity.HasKey(e => e.SpaContentId);

            entity.ToTable("tbl_Spa_Content", "dbo");

            entity.Property(e => e.SpaContentId).HasColumnName("SpaContentID");
            entity.Property(e => e.AgeRequirement)
                .HasColumnType("ntext")
                .HasColumnName("AGE_REQUIREMENT");
            entity.Property(e => e.CancellationPolicy)
                .HasColumnType("ntext")
                .HasColumnName("CANCELLATION_POLICY");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("ntext")
                .HasColumnName("OPENING_HOURS");
            entity.Property(e => e.SpaArrival)
                .HasColumnType("ntext")
                .HasColumnName("SPA_ARRIVAL");
            entity.Property(e => e.SpaId).HasColumnName("SpaID");

            entity.HasOne(d => d.Spa).WithMany(p => p.TblSpaContents)
                .HasForeignKey(d => d.SpaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Spa_Content_tbl_Spa");
        });

        modelBuilder.Entity<TblSpaGallery>(entity =>
        {
            entity.HasKey(e => e.FacilitiesFileId);

            entity.ToTable("tbl_SPA_Gallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoPosition).HasDefaultValue(1);
            entity.Property(e => e.PhotoStatus).HasDefaultValue(false);
            entity.Property(e => e.Spaid).HasColumnName("SPAID");
        });

        modelBuilder.Entity<TblSpaService>(entity =>
        {
            entity.HasKey(e => e.SpaservicesId);

            entity.ToTable("tbl_SPA_Services", "dbo", tb => tb.HasTrigger("tbl_SPA_Services_Content_trigger"));

            entity.Property(e => e.SpaservicesId).HasColumnName("SPAServicesID");
            entity.Property(e => e.SpaservicesPosition).HasColumnName("SPAServicesPosition");
            entity.Property(e => e.SpaservicesStatus).HasColumnName("SPAServicesStatus");
            entity.Property(e => e.SpaservicesSys)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesSYS");
            entity.Property(e => e.SpaservicesTypeId).HasColumnName("SPAServicesTypeID");
        });

        modelBuilder.Entity<TblSpaServicesContent>(entity =>
        {
            entity.HasKey(e => e.SpaservicesContentId);

            entity.ToTable("tbl_SPA_Services_Content", "dbo");

            entity.Property(e => e.SpaservicesContentId).HasColumnName("SPAServicesContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SpaservicesDetails)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesDetails");
            entity.Property(e => e.SpaservicesExtraNote)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesExtraNote");
            entity.Property(e => e.SpaservicesId).HasColumnName("SPAServicesID");
            entity.Property(e => e.SpaservicesName)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesName");
            entity.Property(e => e.SpaservicesPrice)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesPrice");
            entity.Property(e => e.SpaservicesTime)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesTime");

            entity.HasOne(d => d.Spaservices).WithMany(p => p.TblSpaServicesContents)
                .HasForeignKey(d => d.SpaservicesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_SPA_Services_Content_tbl_SPA_Services");
        });

        modelBuilder.Entity<TblSpaServicesType>(entity =>
        {
            entity.HasKey(e => e.SpaservicesTypeId);

            entity.ToTable("tbl_SPA_Services_Types", "dbo", tb => tb.HasTrigger("tbl_SPA_Services_Types_Content_trigger"));

            entity.Property(e => e.SpaservicesTypeId).HasColumnName("SPAServicesTypeID");
            entity.Property(e => e.SpaId).HasColumnName("SpaID");
            entity.Property(e => e.SpaservicesTypeNameSys)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesTypeNameSYS");
            entity.Property(e => e.SpaservicesTypePosition).HasColumnName("SPAServicesTypePosition");
            entity.Property(e => e.SpaservicesTypeStatus).HasColumnName("SPAServicesTypeStatus");
        });

        modelBuilder.Entity<TblSpaServicesTypesContent>(entity =>
        {
            entity.HasKey(e => e.SpaservicesTypeContentId);

            entity.ToTable("tbl_SPA_Services_Types_Content", "dbo");

            entity.Property(e => e.SpaservicesTypeContentId).HasColumnName("SPAServicesTypeContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.SpaservicesTypeExtraText)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesTypeExtraText");
            entity.Property(e => e.SpaservicesTypeId).HasColumnName("SPAServicesTypeID");
            entity.Property(e => e.SpaservicesTypeName)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesTypeName");

            entity.HasOne(d => d.SpaservicesType).WithMany(p => p.TblSpaServicesTypesContents)
                .HasForeignKey(d => d.SpaservicesTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_SPA_Services_Types_Content_tbl_SPA_Services_Types");
        });

        modelBuilder.Entity<TblTeam>(entity =>
        {
            entity.HasKey(e => e.TeamId);

            entity.ToTable("tbl_Teams", "dbo", tb =>
                {
                    tb.HasTrigger("tbl_TeamsURL");
                    tb.HasTrigger("tbl_Teams_Content_trigger");
                });

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMoreDetails).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.TeamEmail).HasMaxLength(250);
            entity.Property(e => e.TeamMobile).HasMaxLength(250);
            entity.Property(e => e.TeamNameSys).HasMaxLength(250);
            entity.Property(e => e.TeamPhoto).HasMaxLength(250);
            entity.Property(e => e.TeamPosition).HasDefaultValue(100);
            entity.Property(e => e.TeamStatus).HasDefaultValue(false);
            entity.Property(e => e.TeamUrl)
                .HasMaxLength(250)
                .HasColumnName("TeamURL");
        });

        modelBuilder.Entity<TblTeamsContent>(entity =>
        {
            entity.HasKey(e => e.TeamContentId);

            entity.ToTable("tbl_Teams_Content", "dbo");

            entity.Property(e => e.TeamContentId).HasColumnName("TeamContentID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.TeamDetails).HasColumnType("ntext");
            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TeamName).HasMaxLength(250);
            entity.Property(e => e.TeamTitlePosition).HasMaxLength(250);

            entity.HasOne(d => d.Team).WithMany(p => p.TblTeamsContents)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tbl_Teams_Content_tbl_Teams");
        });

        modelBuilder.Entity<VwAward>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Awards", "dbo");

            entity.Property(e => e.AwardDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AwardDescription)
                .HasColumnType("ntext")
                .HasColumnName("awardDescription");
            entity.Property(e => e.AwardYearCategorId).HasColumnName("AwardYearCategorID");
            entity.Property(e => e.Awardcontentid).HasColumnName("awardcontentid");
            entity.Property(e => e.Awardid).HasColumnName("awardid");
            entity.Property(e => e.Awardphoto)
                .HasMaxLength(250)
                .HasColumnName("awardphoto");
            entity.Property(e => e.Awardposition).HasColumnName("awardposition");
            entity.Property(e => e.Awardstatus).HasColumnName("awardstatus");
            entity.Property(e => e.Awardtitle)
                .HasMaxLength(250)
                .HasColumnName("awardtitle");
            entity.Property(e => e.Awardtitlesys)
                .HasMaxLength(250)
                .HasColumnName("awardtitlesys");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ExternalLink).HasColumnType("ntext");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.Langid).HasColumnName("langid");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwAwardsFilter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Awards_Filters", "dbo");

            entity.Property(e => e.AwardYearCategorId).HasColumnName("AwardYearCategorID");
            entity.Property(e => e.AwardYearCategoryName).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
        });

        modelBuilder.Entity<VwBlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Blogs", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.NewsBanner).HasMaxLength(250);
            entity.Property(e => e.NewsDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.NewsDetails).HasColumnType("ntext");
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsShortDescription).HasColumnType("ntext");
            entity.Property(e => e.NewsTitle).HasMaxLength(250);
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<VwDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Documents", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DcoumentDescription).HasColumnType("ntext");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DocumentName).HasMaxLength(250);
            entity.Property(e => e.DocumentType).HasMaxLength(250);
            entity.Property(e => e.DocumentUrl)
                .HasColumnType("ntext")
                .HasColumnName("DocumentURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwExtraPage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ExtraPages", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.PageBanner).HasMaxLength(250);
            entity.Property(e => e.PageContentId).HasColumnName("PageContentID");
            entity.Property(e => e.PageDetails).HasColumnType("ntext");
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.PageMetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.PageMetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.PageNameSys).HasMaxLength(250);
            entity.Property(e => e.PageTitle).HasMaxLength(250);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(250)
                .HasColumnName("PageURL");
        });

        modelBuilder.Entity<VwFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Facilities", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityClassIcon).HasMaxLength(250);
            entity.Property(e => e.FacilityContentId).HasColumnName("FacilityContentID");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityPhotoHome).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
        });

        modelBuilder.Entity<VwFaq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FAQ", "dbo");

            entity.Property(e => e.Answer).HasColumnType("ntext");
            entity.Property(e => e.DeletedDateQuestion).HasColumnType("smalldatetime");
            entity.Property(e => e.FaqsectionId).HasColumnName("FAQSectionID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.Question).HasColumnType("ntext");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.SectionName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwFaqActiveSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FAQ_ActiveSection", "dbo");

            entity.Property(e => e.FaqsectionId).HasColumnName("FAQSectionID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SectionName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwFaqSection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FAQ_Sections", "dbo");

            entity.Property(e => e.FaqsectionId).HasColumnName("FAQSectionID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SectionName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwFooterText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FooterText", "dbo");

            entity.Property(e => e.FooterContentId).HasColumnName("FooterContentID");
            entity.Property(e => e.FooterId).HasColumnName("FooterID");
            entity.Property(e => e.FooterText).HasColumnType("ntext");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Gallery", "dbo");

            entity.Property(e => e.GallerySectionContentId).HasColumnName("GallerySectionContentID");
            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.GallerySectionName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGalleryActive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GalleryActive", "dbo");

            entity.Property(e => e.GallerySectionContentId).HasColumnName("GallerySectionContentID");
            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.GallerySectionName)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGalleryPhoto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GalleryPhotos", "dbo");

            entity.Property(e => e.GallerySectionId).HasColumnName("GallerySectionID");
            entity.Property(e => e.GallerySectionNameSys)
                .HasMaxLength(250)
                .HasColumnName("GallerySectionNameSYS");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.PhotoContentId).HasColumnName("PhotoContentID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.PhotoTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGroupFaq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GroupFAQ", "dbo");

            entity.Property(e => e.GroupFaqanswers).HasColumnName("GroupFAQAnswers");
            entity.Property(e => e.GroupFaqanswersSys).HasColumnName("GroupFAQAnswersSys");
            entity.Property(e => e.GroupFaqcontentId).HasColumnName("GroupFAQContentID");
            entity.Property(e => e.GroupFaqid).HasColumnName("GroupFAQID");
            entity.Property(e => e.GroupFaqposition).HasColumnName("GroupFAQPosition");
            entity.Property(e => e.GroupFaqquestion).HasColumnName("GroupFAQQuestion");
            entity.Property(e => e.GroupFaqquestionSys).HasColumnName("GroupFAQQuestionSys");
            entity.Property(e => e.GroupFaqstatus).HasColumnName("GroupFAQStatus");
            entity.Property(e => e.GroupFaqstatusLang).HasColumnName("GroupFAQStatusLang");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGroupHome>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GroupHome", "dbo");

            entity.Property(e => e.GroupContactUsIcon).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsSummery).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsTitle).HasMaxLength(250);
            entity.Property(e => e.GroupContactUsTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeContentId).HasColumnName("GroupHomeContentID");
            entity.Property(e => e.GroupHomeHotelTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeHotelTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeId).HasColumnName("GroupHomeID");
            entity.Property(e => e.GroupHomeIntroButton).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroButtonUrl).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeNewsTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeNewsTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomePhoto1).HasMaxLength(250);
            entity.Property(e => e.GroupHomePhoto1Height).HasColumnName("GroupHomePhoto1_Height");
            entity.Property(e => e.GroupHomePhoto1Width).HasColumnName("GroupHomePhoto1_Width");
            entity.Property(e => e.GroupHomePhoto2).HasMaxLength(250);
            entity.Property(e => e.GroupHomePhoto2Height).HasColumnName("GroupHomePhoto2_Height");
            entity.Property(e => e.GroupHomePhoto2Width).HasColumnName("GroupHomePhoto2_Width");
            entity.Property(e => e.GroupHomeSecondSectionButton).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionButtonUrl).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionSubText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeSecondSectionTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBanner).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerHeight).HasColumnName("GroupHomeVideoSectionBanner_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerMobile).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerMobileHeight).HasColumnName("GroupHomeVideoSectionBannerMobile_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerMobileWidth).HasColumnName("GroupHomeVideoSectionBannerMobile_Width");
            entity.Property(e => e.GroupHomeVideoSectionBannerTablet).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionBannerTabletHeight).HasColumnName("GroupHomeVideoSectionBannerTablet_Height");
            entity.Property(e => e.GroupHomeVideoSectionBannerTabletWidth).HasColumnName("GroupHomeVideoSectionBannerTablet_Width");
            entity.Property(e => e.GroupHomeVideoSectionBannerWidth).HasColumnName("GroupHomeVideoSectionBanner_Width");
            entity.Property(e => e.GroupHomeVideoSectionTitle).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoSectionTitleTop).HasMaxLength(250);
            entity.Property(e => e.GroupHomeVideoUrl).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGroupHomeIntroActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GroupHomeIntroActivities", "dbo");

            entity.Property(e => e.GroupHomeIntroActivitiesContentId).HasColumnName("GroupHomeIntroActivitiesContentID");
            entity.Property(e => e.GroupHomeIntroActivitiesId).HasColumnName("GroupHomeIntroActivitiesID");
            entity.Property(e => e.GroupHomeIntroActivitiesQuantity).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroActivitiesQuantitySys).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroActivitiesText).HasMaxLength(250);
            entity.Property(e => e.GroupHomeIntroActivitiesTextSys).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGroupNews>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GroupNews", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.NewsContentId).HasColumnName("NewsContentID");
            entity.Property(e => e.NewsDateTime).HasMaxLength(250);
            entity.Property(e => e.NewsDetails).HasMaxLength(250);
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsItemBanner).HasMaxLength(250);
            entity.Property(e => e.NewsItemBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Mobile");
            entity.Property(e => e.NewsItemBannerMobileHieght).HasColumnName("NewsItemBanner_MobileHieght");
            entity.Property(e => e.NewsItemBannerMobileWidth).HasColumnName("NewsItemBanner_MobileWidth");
            entity.Property(e => e.NewsItemBannerPhotoHieght).HasColumnName("NewsItemBannerPhoto_Hieght");
            entity.Property(e => e.NewsItemBannerPhotoWidth).HasColumnName("NewsItemBannerPhoto_Width");
            entity.Property(e => e.NewsItemBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Tablet");
            entity.Property(e => e.NewsItemBannerTabletHieght).HasColumnName("NewsItemBanner_TabletHieght");
            entity.Property(e => e.NewsItemBannerTabletWidth).HasColumnName("NewsItemBanner_TabletWidth");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsShortDescription).HasMaxLength(250);
            entity.Property(e => e.NewsTitle).HasMaxLength(250);
            entity.Property(e => e.NewsTitleSys)
                .HasMaxLength(250)
                .HasColumnName("NewsTitleSYS");
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<VwGroupPage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GroupPages", "dbo");

            entity.Property(e => e.GroupAboutUs).HasColumnType("ntext");
            entity.Property(e => e.GroupAboutUsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_Banner");
            entity.Property(e => e.GroupAboutUsBannerHeight).HasColumnName("GroupAboutUs_Banner_Height");
            entity.Property(e => e.GroupAboutUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_BannerMobile");
            entity.Property(e => e.GroupAboutUsBannerMobileHeigh).HasColumnName("GroupAboutUs_BannerMobile_Heigh");
            entity.Property(e => e.GroupAboutUsBannerMobileWidth).HasColumnName("GroupAboutUs_BannerMobile_Width");
            entity.Property(e => e.GroupAboutUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupAboutUs_BannerTablet");
            entity.Property(e => e.GroupAboutUsBannerTabletHeight).HasColumnName("GroupAboutUs_BannerTablet_Height");
            entity.Property(e => e.GroupAboutUsBannerTabletWidth).HasColumnName("GroupAboutUs_BannerTablet_Width");
            entity.Property(e => e.GroupAboutUsBannerWidth).HasColumnName("GroupAboutUs_Banner_Width");
            entity.Property(e => e.GroupAboutUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_MetatagDescription");
            entity.Property(e => e.GroupAboutUsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_MetatagTitle");
            entity.Property(e => e.GroupAboutUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupAboutUs_Title");
            entity.Property(e => e.GroupCareer).HasColumnType("ntext");
            entity.Property(e => e.GroupCareerMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_MetatagDescription");
            entity.Property(e => e.GroupCareerMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_MetatagTitle");
            entity.Property(e => e.GroupCareerTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupCareer_Title");
            entity.Property(e => e.GroupCarreerBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_Banner");
            entity.Property(e => e.GroupCarreerBannerHeight).HasColumnName("GroupCarreer_Banner_Height");
            entity.Property(e => e.GroupCarreerBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_BannerMobile");
            entity.Property(e => e.GroupCarreerBannerMobileHeight).HasColumnName("GroupCarreer_BannerMobile_Height");
            entity.Property(e => e.GroupCarreerBannerMobileWidth).HasColumnName("GroupCarreer_BannerMobile_Width");
            entity.Property(e => e.GroupCarreerBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupCarreer_BannerTablet");
            entity.Property(e => e.GroupCarreerBannerTabletHeight).HasColumnName("GroupCarreer_BannerTablet_Height");
            entity.Property(e => e.GroupCarreerBannerTabletWidth).HasColumnName("GroupCarreer_BannerTablet_Width");
            entity.Property(e => e.GroupCarreerBannerWidth).HasColumnName("GroupCarreer_Banner_Width");
            entity.Property(e => e.GroupContactUs).HasColumnType("ntext");
            entity.Property(e => e.GroupContactUsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_Banner");
            entity.Property(e => e.GroupContactUsBannerHeight).HasColumnName("GroupContactUs_Banner_Height");
            entity.Property(e => e.GroupContactUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_BannerMobile");
            entity.Property(e => e.GroupContactUsBannerMobileHeight).HasColumnName("GroupContactUs_BannerMobile_Height");
            entity.Property(e => e.GroupContactUsBannerMobileWidth).HasColumnName("GroupContactUs_BannerMobile_Width");
            entity.Property(e => e.GroupContactUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupContactUs_BannerTablet");
            entity.Property(e => e.GroupContactUsBannerTabletHeight).HasColumnName("GroupContactUs_BannerTablet_Height");
            entity.Property(e => e.GroupContactUsBannerTabletWidth).HasColumnName("GroupContactUs_BannerTablet_Width");
            entity.Property(e => e.GroupContactUsBannerWidth).HasColumnName("GroupContactUs_Banner_Width");
            entity.Property(e => e.GroupContactUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_MetatagDescription");
            entity.Property(e => e.GroupContactUsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_MetatagTitle");
            entity.Property(e => e.GroupContactUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupContactUs_Title");
            entity.Property(e => e.GroupFaq)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ");
            entity.Property(e => e.GroupFaqBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupFAQ_Banner");
            entity.Property(e => e.GroupFaqBannerHeight).HasColumnName("GroupFAQ_Banner_Height");
            entity.Property(e => e.GroupFaqBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupFAQ_BannerMobile");
            entity.Property(e => e.GroupFaqBannerMobileHeight).HasColumnName("GroupFAQ_BannerMobile_Height");
            entity.Property(e => e.GroupFaqBannerMobileWidth).HasColumnName("GroupFAQ_BannerMobile_Width");
            entity.Property(e => e.GroupFaqBannerTablet)
                .HasMaxLength(50)
                .HasColumnName("GroupFAQ_BannerTablet");
            entity.Property(e => e.GroupFaqBannerTabletHeight).HasColumnName("GroupFAQ_BannerTablet_Height");
            entity.Property(e => e.GroupFaqBannerTabletWidth).HasColumnName("GroupFAQ_BannerTablet_Width");
            entity.Property(e => e.GroupFaqBannerWidth).HasColumnName("GroupFAQ_Banner_Width");
            entity.Property(e => e.GroupFaqMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_MetatagDescription");
            entity.Property(e => e.GroupFaqMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_MetatagTitle");
            entity.Property(e => e.GroupFaqTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupFAQ_Title");
            entity.Property(e => e.GroupHotelsRessorts).HasColumnType("ntext");
            entity.Property(e => e.GroupHotelsRessortsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_Banner");
            entity.Property(e => e.GroupHotelsRessortsBannerHeight).HasColumnName("GroupHotelsRessorts_Banner_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_BannerMobile");
            entity.Property(e => e.GroupHotelsRessortsBannerMobileHeight).HasColumnName("GroupHotelsRessorts_BannerMobile_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerMobileWidth).HasColumnName("GroupHotelsRessorts_BannerMobile_Width");
            entity.Property(e => e.GroupHotelsRessortsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupHotelsRessorts_BannerTablet");
            entity.Property(e => e.GroupHotelsRessortsBannerTabletHeight).HasColumnName("GroupHotelsRessorts_BannerTablet_Height");
            entity.Property(e => e.GroupHotelsRessortsBannerTabletWidth).HasColumnName("GroupHotelsRessorts_BannerTablet_Width");
            entity.Property(e => e.GroupHotelsRessortsBannerWidth).HasColumnName("GroupHotelsRessorts_Banner_Width");
            entity.Property(e => e.GroupHotelsRessortsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_MetatagDescription");
            entity.Property(e => e.GroupHotelsRessortsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_MetatagTitle");
            entity.Property(e => e.GroupHotelsRessortsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupHotelsRessorts_Title");
            entity.Property(e => e.GroupMeetingEvents).HasColumnType("ntext");
            entity.Property(e => e.GroupMeetingEventsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_Banner");
            entity.Property(e => e.GroupMeetingEventsBannerHeight).HasColumnName("GroupMeetingEvents_Banner_Height");
            entity.Property(e => e.GroupMeetingEventsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_BannerMobile");
            entity.Property(e => e.GroupMeetingEventsBannerMobileHeight).HasColumnName("GroupMeetingEvents_BannerMobile_Height");
            entity.Property(e => e.GroupMeetingEventsBannerMobileWidth).HasColumnName("GroupMeetingEvents_BannerMobile_Width");
            entity.Property(e => e.GroupMeetingEventsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupMeetingEvents_BannerTablet");
            entity.Property(e => e.GroupMeetingEventsBannerTabletHeight).HasColumnName("GroupMeetingEvents_BannerTablet_Height");
            entity.Property(e => e.GroupMeetingEventsBannerTabletWidth).HasColumnName("GroupMeetingEvents_BannerTablet_Width");
            entity.Property(e => e.GroupMeetingEventsBannerWidth).HasColumnName("GroupMeetingEvents_Banner_Width");
            entity.Property(e => e.GroupMeetingEventsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_MetatagDescription");
            entity.Property(e => e.GroupMeetingEventsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_MetatagTitle");
            entity.Property(e => e.GroupMeetingEventsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupMeetingEvents_Title");
            entity.Property(e => e.GroupNews).HasColumnType("ntext");
            entity.Property(e => e.GroupNewsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupNews_Banner");
            entity.Property(e => e.GroupNewsBannerHeight).HasColumnName("GroupNews_Banner_Height");
            entity.Property(e => e.GroupNewsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupNews_BannerMobile");
            entity.Property(e => e.GroupNewsBannerMobileHeight).HasColumnName("GroupNews_BannerMobile_Height");
            entity.Property(e => e.GroupNewsBannerMobileWidth).HasColumnName("GroupNews_BannerMobile_Width");
            entity.Property(e => e.GroupNewsBannerTablet)
                .HasMaxLength(50)
                .HasColumnName("GroupNews_BannerTablet");
            entity.Property(e => e.GroupNewsBannerTabletHeight).HasColumnName("GroupNews_BannerTablet_Height");
            entity.Property(e => e.GroupNewsBannerTabletWidth).HasColumnName("GroupNews_BannerTablet_Width");
            entity.Property(e => e.GroupNewsBannerWidth).HasColumnName("GroupNews_Banner_Width");
            entity.Property(e => e.GroupNewsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_MetatagDescription");
            entity.Property(e => e.GroupNewsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_MetatagTitle");
            entity.Property(e => e.GroupNewsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupNews_Title");
            entity.Property(e => e.GroupOverview).HasColumnType("ntext");
            entity.Property(e => e.GroupPagesContentId).HasColumnName("GroupPagesContentID");
            entity.Property(e => e.GroupPrivacy).HasColumnType("ntext");
            entity.Property(e => e.GroupPrivacyBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_Banner");
            entity.Property(e => e.GroupPrivacyBannerHeight).HasColumnName("GroupPrivacy_Banner_Height");
            entity.Property(e => e.GroupPrivacyBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_BannerMobile");
            entity.Property(e => e.GroupPrivacyBannerMobileHeight).HasColumnName("GroupPrivacy_BannerMobile_Height");
            entity.Property(e => e.GroupPrivacyBannerMobileWidth).HasColumnName("GroupPrivacy_BannerMobile_Width");
            entity.Property(e => e.GroupPrivacyBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupPrivacy_BannerTablet");
            entity.Property(e => e.GroupPrivacyBannerTabletHeight).HasColumnName("GroupPrivacy_BannerTablet_Height");
            entity.Property(e => e.GroupPrivacyBannerTabletWidth).HasColumnName("GroupPrivacy_BannerTablet_Width");
            entity.Property(e => e.GroupPrivacyBannerWidth).HasColumnName("GroupPrivacy_Banner_Width");
            entity.Property(e => e.GroupPrivacyMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_MetatagDescription");
            entity.Property(e => e.GroupPrivacyMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_MetatagTitle");
            entity.Property(e => e.GroupPrivacyTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupPrivacy_Title");
            entity.Property(e => e.GroupSummery).HasColumnType("ntext");
            entity.Property(e => e.GroupTerms).HasColumnType("ntext");
            entity.Property(e => e.GroupTermsBanner)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_Banner");
            entity.Property(e => e.GroupTermsBannerHeight).HasColumnName("GroupTerms_Banner_Height");
            entity.Property(e => e.GroupTermsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_BannerMobile");
            entity.Property(e => e.GroupTermsBannerMobileHeight).HasColumnName("GroupTerms_BannerMobile_Height");
            entity.Property(e => e.GroupTermsBannerMobileWidth).HasColumnName("GroupTerms_BannerMobile_Width");
            entity.Property(e => e.GroupTermsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("GroupTerms_BannerTablet");
            entity.Property(e => e.GroupTermsBannerTabletHeight).HasColumnName("GroupTerms_BannerTablet_Height");
            entity.Property(e => e.GroupTermsBannerTabletWidth).HasColumnName("GroupTerms_BannerTablet_Width");
            entity.Property(e => e.GroupTermsBannerWidth).HasColumnName("GroupTerms_Banner_Width");
            entity.Property(e => e.GroupTermsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_MetatagDescription");
            entity.Property(e => e.GroupTermsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_MetatagTitle");
            entity.Property(e => e.GroupTermsTitle)
                .HasColumnType("ntext")
                .HasColumnName("GroupTerms_Title");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasMaxLength(250);
            entity.Property(e => e.MetatagTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<VwGym>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GYM", "dbo");

            entity.Property(e => e.AgeRequirement)
                .HasColumnType("ntext")
                .HasColumnName("AGE_REQUIREMENT");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fees)
                .HasColumnType("ntext")
                .HasColumnName("FEES");
            entity.Property(e => e.GymContentId).HasColumnName("GymContentID");
            entity.Property(e => e.GymId).HasColumnName("gymID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("ntext")
                .HasColumnName("OPENING_HOURS");
            entity.Property(e => e.PersonalTrainer)
                .HasColumnType("ntext")
                .HasColumnName("PERSONAL_TRAINER");
        });

        modelBuilder.Entity<VwGymService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GYM_Services", "dbo");

            entity.Property(e => e.GymservicesContentId).HasColumnName("GYMServicesContentID");
            entity.Property(e => e.GymservicesDetails)
                .HasColumnType("ntext")
                .HasColumnName("GYMServicesDetails");
            entity.Property(e => e.GymservicesExtraNote)
                .HasColumnType("ntext")
                .HasColumnName("GYMServicesExtraNote");
            entity.Property(e => e.GymservicesId).HasColumnName("GYMServicesID");
            entity.Property(e => e.GymservicesName)
                .HasMaxLength(250)
                .HasColumnName("GYMServicesName");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SpaservicesPosition).HasColumnName("SPAServicesPosition");
            entity.Property(e => e.SpaservicesStatus).HasColumnName("SPAServicesStatus");
            entity.Property(e => e.SpaservicesSys)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesSYS");
        });

        modelBuilder.Entity<VwHome>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Home", "dbo");

            entity.Property(e => e.AboutUsPhoto).HasMaxLength(250);
            entity.Property(e => e.AboutUsText).HasColumnType("ntext");
            entity.Property(e => e.AboutUsTitle).HasMaxLength(250);
            entity.Property(e => e.AwardBgphoto)
                .HasMaxLength(250)
                .HasColumnName("AwardBGPhoto");
            entity.Property(e => e.AwardText).HasColumnType("ntext");
            entity.Property(e => e.AwardTitle).HasMaxLength(250);
            entity.Property(e => e.BookingEngineUrl)
                .HasColumnType("ntext")
                .HasColumnName("BookingEngineURL");
            entity.Property(e => e.BtnCheckAvalibality)
                .HasMaxLength(250)
                .HasColumnName("btn_Check_Avalibality");
            entity.Property(e => e.BtnViewRoom)
                .HasMaxLength(250)
                .HasColumnName("btn_View_Room");
            entity.Property(e => e.ExploreTeamText).HasColumnType("ntext");
            entity.Property(e => e.ExploreTeamTitle).HasMaxLength(250);
            entity.Property(e => e.FooterBg)
                .HasMaxLength(250)
                .HasColumnName("FooterBG");
            entity.Property(e => e.HomeContentId).HasColumnName("HomeContentID");
            entity.Property(e => e.HomeId).HasColumnName("HomeID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.NewsletterText).HasColumnType("ntext");
            entity.Property(e => e.NewsletterTitle).HasMaxLength(250);
            entity.Property(e => e.SectionAboutBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionAboutBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionAboutBtnURL");
            entity.Property(e => e.SectionAboutPhoto1).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto2).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto3).HasMaxLength(250);
            entity.Property(e => e.SectionAboutPhoto4).HasMaxLength(250);
            entity.Property(e => e.SectionAboutText).HasColumnType("ntext");
            entity.Property(e => e.SectionAboutTitle).HasMaxLength(250);
            entity.Property(e => e.SectionActivitiesBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionActivitiesBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionActivitiesBtnURL");
            entity.Property(e => e.SectionActivitiesText).HasColumnType("ntext");
            entity.Property(e => e.SectionActivitiesTitle).HasMaxLength(250);
            entity.Property(e => e.SectionAwardsTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_Awards_Tittle");
            entity.Property(e => e.SectionDiningBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionDiningBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionDiningBtnURL");
            entity.Property(e => e.SectionDiningPhoto1).HasMaxLength(250);
            entity.Property(e => e.SectionDiningPhoto2).HasMaxLength(250);
            entity.Property(e => e.SectionDiningText).HasColumnType("ntext");
            entity.Property(e => e.SectionDiningTitle).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionMeetingBtnURL");
            entity.Property(e => e.SectionMeetingPhoto).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingText).HasColumnType("ntext");
            entity.Property(e => e.SectionMeetingTitle).HasMaxLength(250);
            entity.Property(e => e.SectionMeetingTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionNewsBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionNewsBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionNewsBtnURL");
            entity.Property(e => e.SectionNewsLetterBtn)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_btn");
            entity.Property(e => e.SectionNewsLetterBtnPlaceholder)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_btn_placeholder");
            entity.Property(e => e.SectionNewsLetterPhoto)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Photo");
            entity.Property(e => e.SectionNewsLetterSubTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Sub_Tittle");
            entity.Property(e => e.SectionNewsLetterText)
                .HasColumnType("ntext")
                .HasColumnName("Section_NewsLetter_Text");
            entity.Property(e => e.SectionNewsLetterTittle)
                .HasMaxLength(250)
                .HasColumnName("Section_NewsLetter_Tittle");
            entity.Property(e => e.SectionNewsText).HasColumnType("ntext");
            entity.Property(e => e.SectionNewsTitle).HasMaxLength(250);
            entity.Property(e => e.SectionOfferBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionOfferBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionOfferBtnURL");
            entity.Property(e => e.SectionOfferPhoto).HasMaxLength(250);
            entity.Property(e => e.SectionOfferText).HasColumnType("ntext");
            entity.Property(e => e.SectionOfferTitle).HasMaxLength(250);
            entity.Property(e => e.SectionOfferTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionRoomText).HasColumnType("ntext");
            entity.Property(e => e.SectionRoomTitle).HasMaxLength(250);
            entity.Property(e => e.SectionRoomTitleBack).HasMaxLength(250);
            entity.Property(e => e.SectionUpdateText).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingBtnText).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingBtnUrl)
                .HasColumnType("ntext")
                .HasColumnName("SectionWeddingBtnURL");
            entity.Property(e => e.SectionWeddingPhoto).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingText).HasColumnType("ntext");
            entity.Property(e => e.SectionWeddingTitle).HasMaxLength(250);
            entity.Property(e => e.SectionWeddingTopTitle).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitle1).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitle2).HasMaxLength(250);
            entity.Property(e => e.SectionWelcomeTitleText).HasColumnType("ntext");
            entity.Property(e => e.SectionWhyChooseUsText).HasMaxLength(250);
            entity.Property(e => e.SectionWhyChooseUsTittle).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHomeDiscover>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Home_Discover", "dbo");

            entity.Property(e => e.DiscoverContentId).HasColumnName("DiscoverContentID");
            entity.Property(e => e.DiscoverId).HasColumnName("DiscoverID");
            entity.Property(e => e.ItemPhoto).HasMaxLength(250);
            entity.Property(e => e.ItemTitleName).HasMaxLength(250);
            entity.Property(e => e.ItemTitleNameSys).HasMaxLength(250);
            entity.Property(e => e.ItemUrl)
                .HasColumnType("ntext")
                .HasColumnName("ItemURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHomeWhyU>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Home_WhyUs", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.WhuUsContentId).HasColumnName("WhuUsContentID");
            entity.Property(e => e.WhuUsId).HasColumnName("WhuUsID");
            entity.Property(e => e.WhuUsPhoto).HasMaxLength(250);
            entity.Property(e => e.WhuUsText).HasColumnType("ntext");
            entity.Property(e => e.WhuUsTitle).HasMaxLength(250);
            entity.Property(e => e.WhuUsTitleSys).HasMaxLength(250);
            entity.Property(e => e.WhyChooseUsclass)
                .HasMaxLength(250)
                .HasColumnName("WhyChooseUSClass");
        });

        modelBuilder.Entity<VwHotel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Hotels", "dbo");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DestinationBanner).HasMaxLength(250);
            entity.Property(e => e.DestinationContentId).HasColumnName("DestinationContentID");
            entity.Property(e => e.DestinationDetails).HasColumnType("ntext");
            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.DestinationIntro).HasColumnType("ntext");
            entity.Property(e => e.DestinationName).HasMaxLength(250);
            entity.Property(e => e.DestinationPhoto).HasMaxLength(250);
            entity.Property(e => e.DestinationUrl)
                .HasMaxLength(250)
                .HasColumnName("DestinationURL");
            entity.Property(e => e.HotelAboutUs)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us");
            entity.Property(e => e.HotelAboutUsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner");
            entity.Property(e => e.HotelAboutUsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile");
            entity.Property(e => e.HotelAboutUsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerMobileHieght).HasColumnName("HotelAbout_us_BannerMobile_Hieght");
            entity.Property(e => e.HotelAboutUsBannerMobileWidth).HasColumnName("HotelAbout_us_BannerMobile_Width");
            entity.Property(e => e.HotelAboutUsBannerPhotoHieght).HasColumnName("HotelAbout_us_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAboutUsBannerPhotoWidth).HasColumnName("HotelAbout_us_BannerPhoto_Width");
            entity.Property(e => e.HotelAboutUsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet");
            entity.Property(e => e.HotelAboutUsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAboutUsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAbout_us_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAboutUsBannerTabletHieght).HasColumnName("HotelAbout_us_BannerTablet_Hieght");
            entity.Property(e => e.HotelAboutUsBannerTabletWidth).HasColumnName("HotelAbout_us_BannerTablet_Width");
            entity.Property(e => e.HotelAboutUsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_MetaTagTitle");
            entity.Property(e => e.HotelAboutUsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_MetatagDescription");
            entity.Property(e => e.HotelAboutUsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAbout_us_Title");
            entity.Property(e => e.HotelAccommodation).HasColumnType("ntext");
            entity.Property(e => e.HotelAccommodationBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner");
            entity.Property(e => e.HotelAccommodationBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile");
            entity.Property(e => e.HotelAccommodationBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerMobileHieght).HasColumnName("HotelAccommodation_BannerMobile_Hieght");
            entity.Property(e => e.HotelAccommodationBannerMobileWidth).HasColumnName("HotelAccommodation_BannerMobile_Width");
            entity.Property(e => e.HotelAccommodationBannerPhotoHieght).HasColumnName("HotelAccommodation_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAccommodationBannerPhotoWidth).HasColumnName("HotelAccommodation_BannerPhoto_Width");
            entity.Property(e => e.HotelAccommodationBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet");
            entity.Property(e => e.HotelAccommodationBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAccommodationBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAccommodationBannerTabletHieght).HasColumnName("HotelAccommodation_BannerTablet_Hieght");
            entity.Property(e => e.HotelAccommodationBannerTabletWidth).HasColumnName("HotelAccommodation_BannerTablet_Width");
            entity.Property(e => e.HotelAccommodationMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagDescription");
            entity.Property(e => e.HotelAccommodationMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagTitle");
            entity.Property(e => e.HotelAccommodationTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_Title");
            entity.Property(e => e.HotelAddress).HasColumnType("ntext");
            entity.Property(e => e.HotelAllInclusive).HasColumnType("ntext");
            entity.Property(e => e.HotelAllInclusiveBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner");
            entity.Property(e => e.HotelAllInclusiveBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile");
            entity.Property(e => e.HotelAllInclusiveBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerMobileHieght).HasColumnName("HotelAllInclusive_BannerMobile_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerMobileWidth).HasColumnName("HotelAllInclusive_BannerMobile_Width");
            entity.Property(e => e.HotelAllInclusiveBannerPhotoHieght).HasColumnName("HotelAllInclusive_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerPhotoWidth).HasColumnName("HotelAllInclusive_BannerPhoto_Width");
            entity.Property(e => e.HotelAllInclusiveBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet");
            entity.Property(e => e.HotelAllInclusiveBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAllInclusiveBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAllInclusive_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAllInclusiveBannerTabletHieght).HasColumnName("HotelAllInclusive_BannerTablet_Hieght");
            entity.Property(e => e.HotelAllInclusiveBannerTabletWidth).HasColumnName("HotelAllInclusive_BannerTablet_Width");
            entity.Property(e => e.HotelAllInclusiveMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_MetatagDescription");
            entity.Property(e => e.HotelAllInclusiveMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_MetatagTitle");
            entity.Property(e => e.HotelAllInclusiveTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAllInclusive_Title");
            entity.Property(e => e.HotelAwardBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner");
            entity.Property(e => e.HotelAwardBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerHieght).HasColumnName("HotelAward_Banner_Hieght");
            entity.Property(e => e.HotelAwardBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile");
            entity.Property(e => e.HotelAwardBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerMobileHieght).HasColumnName("HotelAward_BannerMobile_Hieght");
            entity.Property(e => e.HotelAwardBannerMobileWidth).HasColumnName("HotelAward_BannerMobile_Width");
            entity.Property(e => e.HotelAwardBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet");
            entity.Property(e => e.HotelAwardBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelAwardBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelAward_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelAwardBannerTabletHieght).HasColumnName("HotelAward_BannerTablet_Hieght");
            entity.Property(e => e.HotelAwardBannerTabletWidth).HasColumnName("HotelAward_BannerTablet_Width");
            entity.Property(e => e.HotelAwardBannerWidth).HasColumnName("HotelAward_Banner_Width");
            entity.Property(e => e.HotelAwards).HasColumnType("ntext");
            entity.Property(e => e.HotelAwardsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_MetatagDescription");
            entity.Property(e => e.HotelAwardsMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_MetatagTitle");
            entity.Property(e => e.HotelAwardsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAwards_Title");
            entity.Property(e => e.HotelBlog).HasColumnType("ntext");
            entity.Property(e => e.HotelBlogBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner");
            entity.Property(e => e.HotelBlogBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile");
            entity.Property(e => e.HotelBlogBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerMobileHieght).HasColumnName("HotelBlog_BannerMobile_Hieght");
            entity.Property(e => e.HotelBlogBannerMobileWidth).HasColumnName("HotelBlog_BannerMobile_Width");
            entity.Property(e => e.HotelBlogBannerPhotoHieght).HasColumnName("HotelBlog_BannerPhoto_Hieght");
            entity.Property(e => e.HotelBlogBannerPhotoWidth).HasColumnName("HotelBlog_BannerPhoto_Width");
            entity.Property(e => e.HotelBlogBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet");
            entity.Property(e => e.HotelBlogBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelBlogBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelBlog_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelBlogBannerTabletHieght).HasColumnName("HotelBlog_BannerTablet_Hieght");
            entity.Property(e => e.HotelBlogBannerTabletWidth).HasColumnName("HotelBlog_BannerTablet_Width");
            entity.Property(e => e.HotelBlogMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_MetaTagTitle");
            entity.Property(e => e.HotelBlogMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_MetatagDescription");
            entity.Property(e => e.HotelBlogTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelBlog_Title");
            entity.Property(e => e.HotelBookingUrl)
                .HasColumnType("ntext")
                .HasColumnName("HotelBookingURL");
            entity.Property(e => e.HotelCareer).HasColumnType("ntext");
            entity.Property(e => e.HotelCareerBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner");
            entity.Property(e => e.HotelCareerBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile");
            entity.Property(e => e.HotelCareerBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerMobileHieght).HasColumnName("HotelCareer_BannerMobile_Hieght");
            entity.Property(e => e.HotelCareerBannerMobileWidth).HasColumnName("HotelCareer_BannerMobile_Width");
            entity.Property(e => e.HotelCareerBannerPhotoHieght).HasColumnName("HotelCareer_BannerPhoto_Hieght");
            entity.Property(e => e.HotelCareerBannerPhotoWidth).HasColumnName("HotelCareer_BannerPhoto_Width");
            entity.Property(e => e.HotelCareerBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet");
            entity.Property(e => e.HotelCareerBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelCareerBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCareer_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelCareerBannerTabletHieght).HasColumnName("HotelCareer_BannerTablet_Hieght");
            entity.Property(e => e.HotelCareerBannerTabletWidth).HasColumnName("HotelCareer_BannerTablet_Width");
            entity.Property(e => e.HotelCareerMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_MetaTagTitle");
            entity.Property(e => e.HotelCareerMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_MetatagDescription");
            entity.Property(e => e.HotelCareerTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCareer_Title");
            entity.Property(e => e.HotelContact).HasColumnType("ntext");
            entity.Property(e => e.HotelContactBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner");
            entity.Property(e => e.HotelContactBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerHieght).HasColumnName("HotelContact_Banner_Hieght");
            entity.Property(e => e.HotelContactBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile");
            entity.Property(e => e.HotelContactBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerMobileHieght).HasColumnName("HotelContact_BannerMobile_Hieght");
            entity.Property(e => e.HotelContactBannerMobileWidth).HasColumnName("HotelContact_BannerMobile_Width");
            entity.Property(e => e.HotelContactBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet");
            entity.Property(e => e.HotelContactBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelContactBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelContactBannerTabletHieght).HasColumnName("HotelContact_BannerTablet_Hieght");
            entity.Property(e => e.HotelContactBannerTabletWidth).HasColumnName("HotelContact_BannerTablet_Width");
            entity.Property(e => e.HotelContactBannerWidth).HasColumnName("HotelContact_Banner_Width");
            entity.Property(e => e.HotelContactMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_MetaTagTitle");
            entity.Property(e => e.HotelContactMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_MetatagDescription");
            entity.Property(e => e.HotelContactThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks");
            entity.Property(e => e.HotelContactThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner");
            entity.Property(e => e.HotelContactThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerHight).HasColumnName("HotelContact_Thanks_Banner_Hight");
            entity.Property(e => e.HotelContactThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile");
            entity.Property(e => e.HotelContactThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerMobileHight).HasColumnName("HotelContact_Thanks_BannerMobile_Hight");
            entity.Property(e => e.HotelContactThanksBannerMobileWidth).HasColumnName("HotelContact_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelContactThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet");
            entity.Property(e => e.HotelContactThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelContactThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelContact_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelContactThanksBannerTabletHight).HasColumnName("HotelContact_Thanks_BannerTablet_Hight");
            entity.Property(e => e.HotelContactThanksBannerTabletWidth).HasColumnName("HotelContact_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelContactThanksBannerWidth).HasColumnName("HotelContact_Thanks_Banner_Width");
            entity.Property(e => e.HotelContactThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelContactThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_MetatagDescription");
            entity.Property(e => e.HotelContactThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Thanks_Title");
            entity.Property(e => e.HotelContactTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelContact_Title");
            entity.Property(e => e.HotelContactUsIcon).HasColumnType("ntext");
            entity.Property(e => e.HotelContactUsSummery).HasMaxLength(250);
            entity.Property(e => e.HotelContactUsTitle).HasMaxLength(250);
            entity.Property(e => e.HotelContactUsTitleTop).HasMaxLength(250);
            entity.Property(e => e.HotelContentId).HasColumnName("HotelContentID");
            entity.Property(e => e.HotelCovid).HasColumnType("ntext");
            entity.Property(e => e.HotelCovidBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner");
            entity.Property(e => e.HotelCovidBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile");
            entity.Property(e => e.HotelCovidBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerMobileHieght).HasColumnName("HotelCovid_BannerMobile_Hieght");
            entity.Property(e => e.HotelCovidBannerMobileWidth).HasColumnName("HotelCovid_BannerMobile_Width");
            entity.Property(e => e.HotelCovidBannerPhotoHieght).HasColumnName("HotelCovid_BannerPhoto_Hieght");
            entity.Property(e => e.HotelCovidBannerPhotoWidth).HasColumnName("HotelCovid_BannerPhoto_Width");
            entity.Property(e => e.HotelCovidBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet");
            entity.Property(e => e.HotelCovidBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelCovidBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelCovid_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelCovidBannerTabletHieght).HasColumnName("HotelCovid_BannerTablet_Hieght");
            entity.Property(e => e.HotelCovidBannerTabletWidth).HasColumnName("HotelCovid_BannerTablet_Width");
            entity.Property(e => e.HotelCovidMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_MetaTagTitle");
            entity.Property(e => e.HotelCovidMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_MetatagDescription");
            entity.Property(e => e.HotelCovidTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelCovid_Title");
            entity.Property(e => e.HotelDining).HasColumnType("ntext");
            entity.Property(e => e.HotelDiningBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner");
            entity.Property(e => e.HotelDiningBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerHieght).HasColumnName("HotelDining_Banner_Hieght");
            entity.Property(e => e.HotelDiningBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile");
            entity.Property(e => e.HotelDiningBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerMobileHieght).HasColumnName("HotelDining_BannerMobile_Hieght");
            entity.Property(e => e.HotelDiningBannerMobileWidth).HasColumnName("HotelDining_BannerMobile_Width");
            entity.Property(e => e.HotelDiningBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet");
            entity.Property(e => e.HotelDiningBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelDiningBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelDining_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelDiningBannerTabletHieght).HasColumnName("HotelDining_BannerTablet_Hieght");
            entity.Property(e => e.HotelDiningBannerTabletWidth).HasColumnName("HotelDining_BannerTablet_Width");
            entity.Property(e => e.HotelDiningBannerWidth).HasColumnName("HotelDining_Banner_Width");
            entity.Property(e => e.HotelDiningMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_MetatagDescription");
            entity.Property(e => e.HotelDiningMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_MetatagTitle");
            entity.Property(e => e.HotelDiningTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelDining_Title");
            entity.Property(e => e.HotelEmail).HasMaxLength(250);
            entity.Property(e => e.HotelFacilities).HasColumnType("ntext");
            entity.Property(e => e.HotelFacilitiesBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner");
            entity.Property(e => e.HotelFacilitiesBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerHieght).HasColumnName("HotelFacilities_Banner_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile");
            entity.Property(e => e.HotelFacilitiesBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerMobileHieght).HasColumnName("HotelFacilities_BannerMobile_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerMobileWidth).HasColumnName("HotelFacilities_BannerMobile_Width");
            entity.Property(e => e.HotelFacilitiesBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet");
            entity.Property(e => e.HotelFacilitiesBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFacilitiesBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFacilities_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFacilitiesBannerTabletHieght).HasColumnName("HotelFacilities_BannerTablet_Hieght");
            entity.Property(e => e.HotelFacilitiesBannerTabletWidth).HasColumnName("HotelFacilities_BannerTablet_Width");
            entity.Property(e => e.HotelFacilitiesBannerWidth).HasColumnName("HotelFacilities_Banner_Width");
            entity.Property(e => e.HotelFacilitiesMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_MetatagDescription");
            entity.Property(e => e.HotelFacilitiesMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_MetatagTitle");
            entity.Property(e => e.HotelFacilitiesTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFacilities_Title");
            entity.Property(e => e.HotelFactsheet).HasMaxLength(250);
            entity.Property(e => e.HotelFaq)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ");
            entity.Property(e => e.HotelFaqBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner");
            entity.Property(e => e.HotelFaqBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile");
            entity.Property(e => e.HotelFaqBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerMobileHieght).HasColumnName("HotelFAQ_BannerMobile_Hieght");
            entity.Property(e => e.HotelFaqBannerMobileWidth).HasColumnName("HotelFAQ_BannerMobile_Width");
            entity.Property(e => e.HotelFaqBannerPhotoHieght).HasColumnName("HotelFAQ_BannerPhoto_Hieght");
            entity.Property(e => e.HotelFaqBannerPhotoWidth).HasColumnName("HotelFAQ_BannerPhoto_Width");
            entity.Property(e => e.HotelFaqBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet");
            entity.Property(e => e.HotelFaqBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFaqBannerTabletHieght).HasColumnName("HotelFAQ_BannerTablet_Hieght");
            entity.Property(e => e.HotelFaqBannerTabletWidth).HasColumnName("HotelFAQ_BannerTablet_Width");
            entity.Property(e => e.HotelFaqMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_MetaTagTitle");
            entity.Property(e => e.HotelFaqMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_MetatagDescription");
            entity.Property(e => e.HotelFaqThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks");
            entity.Property(e => e.HotelFaqThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner");
            entity.Property(e => e.HotelFaqThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile");
            entity.Property(e => e.HotelFaqThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerMobileHieght).HasColumnName("HotelFAQ_Thanks_BannerMobile_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerMobileWidth).HasColumnName("HotelFAQ_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelFaqThanksBannerPhotoHieght).HasColumnName("HotelFAQ_Thanks_BannerPhoto_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerPhotoWidth).HasColumnName("HotelFAQ_Thanks_BannerPhoto_Width");
            entity.Property(e => e.HotelFaqThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet");
            entity.Property(e => e.HotelFaqThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelFaqThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelFAQ_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelFaqThanksBannerTabletHieght).HasColumnName("HotelFAQ_Thanks_BannerTablet_Hieght");
            entity.Property(e => e.HotelFaqThanksBannerTabletWidth).HasColumnName("HotelFAQ_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelFaqThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelFaqThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_MetatagDescription");
            entity.Property(e => e.HotelFaqThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Thanks_Title");
            entity.Property(e => e.HotelFaqTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelFAQ_Title");
            entity.Property(e => e.HotelFax).HasMaxLength(250);
            entity.Property(e => e.HotelGallery).HasColumnType("ntext");
            entity.Property(e => e.HotelGalleryBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner");
            entity.Property(e => e.HotelGalleryBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerHieght).HasColumnName("HotelGallery_Banner_Hieght");
            entity.Property(e => e.HotelGalleryBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile");
            entity.Property(e => e.HotelGalleryBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerMobileHieght).HasColumnName("HotelGallery_BannerMobile_Hieght");
            entity.Property(e => e.HotelGalleryBannerMobileWidth).HasColumnName("HotelGallery_BannerMobile_Width");
            entity.Property(e => e.HotelGalleryBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet");
            entity.Property(e => e.HotelGalleryBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelGalleryBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelGallery_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelGalleryBannerTabletHieght).HasColumnName("HotelGallery_BannerTablet_Hieght");
            entity.Property(e => e.HotelGalleryBannerTabletWidth).HasColumnName("HotelGallery_BannerTablet_Width");
            entity.Property(e => e.HotelGalleryBannerWidth).HasColumnName("HotelGallery_Banner_Width");
            entity.Property(e => e.HotelGalleryMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_MetatagDescription");
            entity.Property(e => e.HotelGalleryMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_MetatagTitle");
            entity.Property(e => e.HotelGalleryTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelGallery_Title");
            entity.Property(e => e.HotelGetDirectionLink).HasColumnType("ntext");
            entity.Property(e => e.HotelGoogleMap).HasColumnType("ntext");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelLocation).HasColumnType("ntext");
            entity.Property(e => e.HotelLocationBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner");
            entity.Property(e => e.HotelLocationBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile");
            entity.Property(e => e.HotelLocationBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerMobileHieght).HasColumnName("HotelLocation_BannerMobile_Hieght");
            entity.Property(e => e.HotelLocationBannerMobileWidth).HasColumnName("HotelLocation_BannerMobile_Width");
            entity.Property(e => e.HotelLocationBannerPhotoHieght).HasColumnName("HotelLocation_BannerPhoto_Hieght");
            entity.Property(e => e.HotelLocationBannerPhotoWidth).HasColumnName("HotelLocation_BannerPhoto_Width");
            entity.Property(e => e.HotelLocationBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet");
            entity.Property(e => e.HotelLocationBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelLocationBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelLocation_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelLocationBannerTabletHieght).HasColumnName("HotelLocation_BannerTablet_Hieght");
            entity.Property(e => e.HotelLocationBannerTabletWidth).HasColumnName("HotelLocation_BannerTablet_Width");
            entity.Property(e => e.HotelLocationMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_MetatagDescription");
            entity.Property(e => e.HotelLocationMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_MetatagTitle");
            entity.Property(e => e.HotelLocationTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelLocation_Title");
            entity.Property(e => e.HotelLogo).HasMaxLength(250);
            entity.Property(e => e.HotelLogoColored)
                .HasMaxLength(250)
                .HasColumnName("HotelLogo_Colored");
            entity.Property(e => e.HotelMeeitngThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeitng_Thanks_MetatagDescription");
            entity.Property(e => e.HotelMeeting).HasColumnType("ntext");
            entity.Property(e => e.HotelMeetingBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner");
            entity.Property(e => e.HotelMeetingBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerHieght).HasColumnName("HotelMeeting_Banner_Hieght");
            entity.Property(e => e.HotelMeetingBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile");
            entity.Property(e => e.HotelMeetingBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerMobileHieght).HasColumnName("HotelMeeting_BannerMobile_Hieght");
            entity.Property(e => e.HotelMeetingBannerMobileWidth).HasColumnName("HotelMeeting_BannerMobile_Width");
            entity.Property(e => e.HotelMeetingBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet");
            entity.Property(e => e.HotelMeetingBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingBannerTabletHieght).HasColumnName("HotelMeeting_BannerTablet_Hieght");
            entity.Property(e => e.HotelMeetingBannerTabletWidth).HasColumnName("HotelMeeting_BannerTablet_Width");
            entity.Property(e => e.HotelMeetingBannerWidth).HasColumnName("HotelMeeting_Banner_Width");
            entity.Property(e => e.HotelMeetingMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_MetatagDescription");
            entity.Property(e => e.HotelMeetingMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_MetatagTitle");
            entity.Property(e => e.HotelMeetingThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks");
            entity.Property(e => e.HotelMeetingThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner");
            entity.Property(e => e.HotelMeetingThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerHieght).HasColumnName("HotelMeeting_Thanks_Banner_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile");
            entity.Property(e => e.HotelMeetingThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerMobileHieght).HasColumnName("HotelMeeting_Thanks_BannerMobile_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerMobileWidth).HasColumnName("HotelMeeting_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelMeetingThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet");
            entity.Property(e => e.HotelMeetingThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelMeetingThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelMeeting_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelMeetingThanksBannerTabletHieght).HasColumnName("HotelMeeting_Thanks_BannerTablet_Hieght");
            entity.Property(e => e.HotelMeetingThanksBannerTabletWidth).HasColumnName("HotelMeeting_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelMeetingThanksBannerWidth).HasColumnName("HotelMeeting_Thanks_Banner_Width");
            entity.Property(e => e.HotelMeetingThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelMeetingThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Thanks_Title");
            entity.Property(e => e.HotelMeetingTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelMeeting_Title");
            entity.Property(e => e.HotelMobile).HasMaxLength(250);
            entity.Property(e => e.HotelName).HasMaxLength(250);
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelNear).HasColumnType("ntext");
            entity.Property(e => e.HotelNearBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNear_Banner");
            entity.Property(e => e.HotelNearBannerHieght).HasColumnName("HotelNear_Banner_Hieght");
            entity.Property(e => e.HotelNearBannerWidth).HasColumnName("HotelNear_Banner_Width");
            entity.Property(e => e.HotelNearMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_MetatagDescription");
            entity.Property(e => e.HotelNearMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_MetatagTitle");
            entity.Property(e => e.HotelNearTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNear_Title");
            entity.Property(e => e.HotelNews).HasColumnType("ntext");
            entity.Property(e => e.HotelNewsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner");
            entity.Property(e => e.HotelNewsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile");
            entity.Property(e => e.HotelNewsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerMobileHieght).HasColumnName("HotelNews_BannerMobile_Hieght");
            entity.Property(e => e.HotelNewsBannerMobileWidth).HasColumnName("HotelNews_BannerMobile_Width");
            entity.Property(e => e.HotelNewsBannerPhotoHieght).HasColumnName("HotelNews_BannerPhoto_Hieght");
            entity.Property(e => e.HotelNewsBannerPhotoWidth).HasColumnName("HotelNews_BannerPhoto_Width");
            entity.Property(e => e.HotelNewsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet");
            entity.Property(e => e.HotelNewsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNews_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelNewsBannerTabletHieght).HasColumnName("HotelNews_BannerTablet_Hieght");
            entity.Property(e => e.HotelNewsBannerTabletWidth).HasColumnName("HotelNews_BannerTablet_Width");
            entity.Property(e => e.HotelNewsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_MetaTagTitle");
            entity.Property(e => e.HotelNewsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_MetatagDescription");
            entity.Property(e => e.HotelNewsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNews_Title");
            entity.Property(e => e.HotelNewsletterThanks)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks");
            entity.Property(e => e.HotelNewsletterThanksBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner");
            entity.Property(e => e.HotelNewsletterThanksBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerHight).HasColumnName("HotelNewsletter_Thanks_Banner_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileHight).HasColumnName("HotelNewsletter_Thanks_BannerMobile_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerMobileWidth).HasColumnName("HotelNewsletter_Thanks_BannerMobile_Width");
            entity.Property(e => e.HotelNewsletterThanksBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelNewsletter_Thanks_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletHight).HasColumnName("HotelNewsletter_Thanks_BannerTablet_Hight");
            entity.Property(e => e.HotelNewsletterThanksBannerTabletWidth).HasColumnName("HotelNewsletter_Thanks_BannerTablet_Width");
            entity.Property(e => e.HotelNewsletterThanksBannerWidth).HasColumnName("HotelNewsletter_Thanks_Banner_Width");
            entity.Property(e => e.HotelNewsletterThanksMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_MetaTagTitle");
            entity.Property(e => e.HotelNewsletterThanksMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_MetatagDescription");
            entity.Property(e => e.HotelNewsletterThanksTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelNewsletter_Thanks_Title");
            entity.Property(e => e.HotelOfferBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner");
            entity.Property(e => e.HotelOfferBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerHieght).HasColumnName("HotelOffer_Banner_Hieght");
            entity.Property(e => e.HotelOfferBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile");
            entity.Property(e => e.HotelOfferBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerMobileHieght).HasColumnName("HotelOffer_BannerMobile_Hieght");
            entity.Property(e => e.HotelOfferBannerMobileWidth).HasColumnName("HotelOffer_BannerMobile_Width");
            entity.Property(e => e.HotelOfferBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet");
            entity.Property(e => e.HotelOfferBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelOfferBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelOffer_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelOfferBannerTabletHieght).HasColumnName("HotelOffer_BannerTablet_Hieght");
            entity.Property(e => e.HotelOfferBannerTabletWidth).HasColumnName("HotelOffer_BannerTablet_Width");
            entity.Property(e => e.HotelOfferBannerWidth).HasColumnName("HotelOffer_Banner_Width");
            entity.Property(e => e.HotelOffers).HasColumnType("ntext");
            entity.Property(e => e.HotelOffersMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_MetatagDescription");
            entity.Property(e => e.HotelOffersMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_MetatagTitle");
            entity.Property(e => e.HotelOffersTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelOffers_Title");
            entity.Property(e => e.HotelOverview).HasColumnType("ntext");
            entity.Property(e => e.HotelPhone).HasMaxLength(250);
            entity.Property(e => e.HotelPhoto).HasMaxLength(250);
            entity.Property(e => e.HotelPhotoGroup)
                .HasMaxLength(250)
                .HasColumnName("HotelPhoto_Group");
            entity.Property(e => e.HotelPhotoGroupHeight).HasColumnName("HotelPhoto_Group_Height");
            entity.Property(e => e.HotelPhotoGroupWidth).HasColumnName("HotelPhoto_Group_Width");
            entity.Property(e => e.HotelPmscode)
                .HasMaxLength(250)
                .HasColumnName("HotelPMSCode");
            entity.Property(e => e.HotelPrivacy).HasColumnType("ntext");
            entity.Property(e => e.HotelPrivacyBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner");
            entity.Property(e => e.HotelPrivacyBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile");
            entity.Property(e => e.HotelPrivacyBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerMobileHieght).HasColumnName("HotelPrivacy_BannerMobile_Hieght");
            entity.Property(e => e.HotelPrivacyBannerMobileWidth).HasColumnName("HotelPrivacy_BannerMobile_Width");
            entity.Property(e => e.HotelPrivacyBannerPhotoHieght).HasColumnName("HotelPrivacy_BannerPhoto_Hieght");
            entity.Property(e => e.HotelPrivacyBannerPhotoWidth).HasColumnName("HotelPrivacy_BannerPhoto_Width");
            entity.Property(e => e.HotelPrivacyBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet");
            entity.Property(e => e.HotelPrivacyBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelPrivacyBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelPrivacy_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelPrivacyBannerTabletHieght).HasColumnName("HotelPrivacy_BannerTablet_Hieght");
            entity.Property(e => e.HotelPrivacyBannerTabletWidth).HasColumnName("HotelPrivacy_BannerTablet_Width");
            entity.Property(e => e.HotelPrivacyMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_MetaTagTitle");
            entity.Property(e => e.HotelPrivacyMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_MetatagDescription");
            entity.Property(e => e.HotelPrivacyTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelPrivacy_Title");
            entity.Property(e => e.HotelSocial).HasColumnType("ntext");
            entity.Property(e => e.HotelSocialBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelSocial_Banner");
            entity.Property(e => e.HotelSocialBannerHieght).HasColumnName("HotelSocial_Banner_Hieght");
            entity.Property(e => e.HotelSocialBannerWidth).HasColumnName("HotelSocial_Banner_Width");
            entity.Property(e => e.HotelSocialMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_MetatagDescription");
            entity.Property(e => e.HotelSocialMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_MetatagTitle");
            entity.Property(e => e.HotelSocialTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelSocial_Title");
            entity.Property(e => e.HotelSummery).HasColumnType("ntext");
            entity.Property(e => e.HotelTeam).HasColumnType("ntext");
            entity.Property(e => e.HotelTeamBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner");
            entity.Property(e => e.HotelTeamBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerHieght).HasColumnName("HotelTeam_Banner_Hieght");
            entity.Property(e => e.HotelTeamBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile");
            entity.Property(e => e.HotelTeamBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerMobileHieght).HasColumnName("HotelTeam_BannerMobile_Hieght");
            entity.Property(e => e.HotelTeamBannerMobileWidth).HasColumnName("HotelTeam_BannerMobile_Width");
            entity.Property(e => e.HotelTeamBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet");
            entity.Property(e => e.HotelTeamBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelTeamBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTeam_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelTeamBannerTabletHieght).HasColumnName("HotelTeam_BannerTablet_Hieght");
            entity.Property(e => e.HotelTeamBannerTabletWidth).HasColumnName("HotelTeam_BannerTablet_Width");
            entity.Property(e => e.HotelTeamBannerWidth).HasColumnName("HotelTeam_Banner_Width");
            entity.Property(e => e.HotelTeamMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_MetatagDescription");
            entity.Property(e => e.HotelTeamMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_MetatagTitle");
            entity.Property(e => e.HotelTeamTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTeam_Title");
            entity.Property(e => e.HotelTermsConditions)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions");
            entity.Property(e => e.HotelTermsConditionsBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner");
            entity.Property(e => e.HotelTermsConditionsBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile");
            entity.Property(e => e.HotelTermsConditionsBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerMobileHieght).HasColumnName("HotelTerms_Conditions_BannerMobile_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerMobileWidth).HasColumnName("HotelTerms_Conditions_BannerMobile_Width");
            entity.Property(e => e.HotelTermsConditionsBannerPhotoHieght).HasColumnName("HotelTerms_Conditions_BannerPhoto_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerPhotoWidth).HasColumnName("HotelTerms_Conditions_BannerPhoto_Width");
            entity.Property(e => e.HotelTermsConditionsBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet");
            entity.Property(e => e.HotelTermsConditionsBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelTermsConditionsBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelTerms_Conditions_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelTermsConditionsBannerTabletHieght).HasColumnName("HotelTerms_Conditions_BannerTablet_Hieght");
            entity.Property(e => e.HotelTermsConditionsBannerTabletWidth).HasColumnName("HotelTerms_Conditions_BannerTablet_Width");
            entity.Property(e => e.HotelTermsConditionsMetaTagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_MetaTagTitle");
            entity.Property(e => e.HotelTermsConditionsMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_MetatagDescription");
            entity.Property(e => e.HotelTermsConditionsTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelTerms_Conditions_Title");
            entity.Property(e => e.HotelTypeContentId).HasColumnName("HotelTypeContentID");
            entity.Property(e => e.HotelTypeId).HasColumnName("HotelTypeID");
            entity.Property(e => e.HotelTypeName).HasMaxLength(250);
            entity.Property(e => e.HotelTypeNameSys)
                .HasMaxLength(250)
                .HasColumnName("HotelTypeName_Sys");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.HotelWellness).HasColumnType("ntext");
            entity.Property(e => e.HotelWellnessBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner");
            entity.Property(e => e.HotelWellnessBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_Banner_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile");
            entity.Property(e => e.HotelWellnessBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerMobile_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerMobileHieght).HasColumnName("HotelWellness_BannerMobile_Hieght");
            entity.Property(e => e.HotelWellnessBannerMobileWidth).HasColumnName("HotelWellness_BannerMobile_Width");
            entity.Property(e => e.HotelWellnessBannerPhotoHieght).HasColumnName("HotelWellness_BannerPhoto_Hieght");
            entity.Property(e => e.HotelWellnessBannerPhotoWidth).HasColumnName("HotelWellness_BannerPhoto_Width");
            entity.Property(e => e.HotelWellnessBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet");
            entity.Property(e => e.HotelWellnessBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet_ColorOverlayFrom");
            entity.Property(e => e.HotelWellnessBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("HotelWellness_BannerTablet_ColorOverlayTo");
            entity.Property(e => e.HotelWellnessBannerTabletHieght).HasColumnName("HotelWellness_BannerTablet_Hieght");
            entity.Property(e => e.HotelWellnessBannerTabletWidth).HasColumnName("HotelWellness_BannerTablet_Width");
            entity.Property(e => e.HotelWellnessMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_MetatagDescription");
            entity.Property(e => e.HotelWellnessMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_MetatagTitle");
            entity.Property(e => e.HotelWellnessTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelWellness_Title");
            entity.Property(e => e.HotelWhatsAppNumber).HasMaxLength(250);
            entity.Property(e => e.HotelYouTube).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LangIdmasterHotelTypes).HasColumnName("LangIDMasterHotelTypes");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasMaxLength(250);
            entity.Property(e => e.MetatagTitle).HasMaxLength(250);
            entity.Property(e => e.ReservationEmail).HasMaxLength(250);
            entity.Property(e => e.TripAdvisorKey).HasMaxLength(250);
            entity.Property(e => e.TripAdvisorUrl)
                .HasColumnType("ntext")
                .HasColumnName("TripAdvisorURL");
        });

        modelBuilder.Entity<VwHotelsCreditCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Hotels_CreditCards", "dbo");

            entity.Property(e => e.BookingCurrency).HasMaxLength(250);
            entity.Property(e => e.BookingLang).HasMaxLength(250);
            entity.Property(e => e.CreditCardContentId).HasColumnName("CreditCardContentID");
            entity.Property(e => e.CreditCardIcon).HasMaxLength(250);
            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");
            entity.Property(e => e.CreditCardName).HasMaxLength(250);
            entity.Property(e => e.HotelCreditCardId).HasColumnName("HotelCreditCardID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHotelsDestinationCm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HotelsDestinationCMS", "dbo");

            entity.Property(e => e.DestinationHotel).HasMaxLength(502);
            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.DestinationNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelFax).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHotelsFacilitiesGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HotelsFacilitiesGallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.FacilitiesId).HasColumnName("FacilitiesID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHotelsFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HotelsFacilities", "dbo");

            entity.Property(e => e.FacilitiesPerHotelId).HasColumnName("FacilitiesPerHotelID");
            entity.Property(e => e.HotelFacilitiesIcon).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesItemContentId).HasColumnName("HotelFacilitiesItemContentID");
            entity.Property(e => e.HotelFacilitiesItemExtraText).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesItemId).HasColumnName("HotelFacilitiesItemID");
            entity.Property(e => e.HotelFacilitiesItemName).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesName).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwHotelsNearBy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Hotels_NearBy", "dbo");

            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNearByContentId).HasColumnName("HotelNearByContentID");
            entity.Property(e => e.HotelNearByDistanceUnit).HasMaxLength(250);
            entity.Property(e => e.HotelNearById).HasColumnName("HotelNearByID");
            entity.Property(e => e.HotelNearByName).HasMaxLength(250);
            entity.Property(e => e.HotelNearByNameSys).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwHotelsSpokenLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Hotels_SpokenLanguages", "dbo");

            entity.Property(e => e.BookingCurrency).HasMaxLength(250);
            entity.Property(e => e.BookingLang).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelSpokenLanguageId).HasColumnName("HotelSpokenLanguageID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SpokenLanguages).HasMaxLength(250);
            entity.Property(e => e.SpokenLanguagesContentId).HasColumnName("SpokenLanguagesContentID");
            entity.Property(e => e.SpokenLanguagesFlag).HasMaxLength(250);
            entity.Property(e => e.SpokenLanguagesId).HasColumnName("SpokenLanguagesID");
        });

        modelBuilder.Entity<VwJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Jobs", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.JobCategory)
                .HasMaxLength(250)
                .HasColumnName("Job_Category");
            entity.Property(e => e.JobContentId).HasColumnName("JobContentID");
            entity.Property(e => e.JobDetails).HasColumnType("ntext");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.JobNameSys)
                .HasMaxLength(250)
                .HasColumnName("Job_Name_Sys");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(250)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobSchedule).HasMaxLength(250);
            entity.Property(e => e.JobSummery).HasColumnType("ntext");
            entity.Property(e => e.JobUrl)
                .HasMaxLength(250)
                .HasColumnName("JobURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.PositionType)
                .HasMaxLength(250)
                .HasColumnName("Position_Type");
            entity.Property(e => e.PostingDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Posting_Date");
        });

        modelBuilder.Entity<VwMasterHotelFacilitiesItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Master_HotelFacilities_Items", "dbo");

            entity.Property(e => e.BookingCurrency).HasMaxLength(250);
            entity.Property(e => e.BookingLang).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesContentId).HasColumnName("HotelFacilitiesContentID");
            entity.Property(e => e.HotelFacilitiesIcon).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesItemContentId).HasColumnName("HotelFacilitiesItemContentID");
            entity.Property(e => e.HotelFacilitiesItemExtraText).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesItemId).HasColumnName("HotelFacilitiesItemID");
            entity.Property(e => e.HotelFacilitiesItemName).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesItemNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesName).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesNameSys).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwMasterHotelFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Master_HotelFacilities", "dbo");

            entity.Property(e => e.BookingCurrency).HasMaxLength(250);
            entity.Property(e => e.BookingLang).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesContentId).HasColumnName("HotelFacilitiesContentID");
            entity.Property(e => e.HotelFacilitiesIcon).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesId).HasColumnName("HotelFacilitiesID");
            entity.Property(e => e.HotelFacilitiesName).HasMaxLength(250);
            entity.Property(e => e.HotelFacilitiesNameSys).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwMasterRoomAmenity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Master_RoomAmenities", "dbo");

            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesContentId).HasColumnName("RoomAmenitiesContentID");
            entity.Property(e => e.RoomAmenitiesIconFont).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesId).HasColumnName("RoomAmenitiesID");
            entity.Property(e => e.RoomAmenitiesName).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesSys).HasMaxLength(250);
        });

        modelBuilder.Entity<VwMasterRoomTypeCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Master_RoomTypeCategory", "dbo");

            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.RoomTypeCategoryId).HasColumnName("RoomTypeCategoryID");
            entity.Property(e => e.RoomTypeCategoryLangId).HasColumnName("RoomTypeCategoryLangID");
            entity.Property(e => e.RoomTypeCategoryName).HasMaxLength(250);
        });

        modelBuilder.Entity<VwMeetingsEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MeetingsEvents", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityContentId).HasColumnName("FacilityContentID");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilityPhotoHome).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.MeetingCapacity).HasColumnType("ntext");
            entity.Property(e => e.MeetingCellingHeight).HasMaxLength(250);
            entity.Property(e => e.MeetingLength).HasMaxLength(250);
            entity.Property(e => e.MeetingSize).HasMaxLength(250);
            entity.Property(e => e.MeetingWidths).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
        });

        modelBuilder.Entity<VwMeetingsEventsGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MeetingsEvents_Gallery", "dbo");

            entity.Property(e => e.FacilitiesFileId).HasColumnName("FacilitiesFileID");
            entity.Property(e => e.FacilitiesId).HasColumnName("FacilitiesID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
        });

        modelBuilder.Entity<VwMeetingsEventsShape>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MeetingsEvents_Shapes", "dbo");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageClass).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.MeetingStyleBestFor).HasColumnType("ntext");
            entity.Property(e => e.MeetingStyleContentId).HasColumnName("MeetingStyleContentID");
            entity.Property(e => e.MeetingStyleDescription).HasColumnType("ntext");
            entity.Property(e => e.MeetingStyleId).HasColumnName("MeetingStyleID");
            entity.Property(e => e.MeetingStyleName).HasMaxLength(250);
            entity.Property(e => e.MeetingStyleNameSys).HasMaxLength(250);
            entity.Property(e => e.MeetingStylePhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<VwNews>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_News", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.NewsContentId).HasColumnName("NewsContentID");
            entity.Property(e => e.NewsDateTime).HasMaxLength(250);
            entity.Property(e => e.NewsDetails).HasMaxLength(250);
            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsItemBanner).HasMaxLength(250);
            entity.Property(e => e.NewsItemBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Mobile");
            entity.Property(e => e.NewsItemBannerMobileHieght).HasColumnName("NewsItemBanner_MobileHieght");
            entity.Property(e => e.NewsItemBannerMobileWidth).HasColumnName("NewsItemBanner_MobileWidth");
            entity.Property(e => e.NewsItemBannerPhotoHieght).HasColumnName("NewsItemBannerPhoto_Hieght");
            entity.Property(e => e.NewsItemBannerPhotoWidth).HasColumnName("NewsItemBannerPhoto_Width");
            entity.Property(e => e.NewsItemBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("NewsItemBanner_Tablet");
            entity.Property(e => e.NewsItemBannerTabletHieght).HasColumnName("NewsItemBanner_TabletHieght");
            entity.Property(e => e.NewsItemBannerTabletWidth).HasColumnName("NewsItemBanner_TabletWidth");
            entity.Property(e => e.NewsPhoto).HasMaxLength(250);
            entity.Property(e => e.NewsShortDescription).HasMaxLength(250);
            entity.Property(e => e.NewsTitle).HasMaxLength(250);
            entity.Property(e => e.NewsTitleSys)
                .HasMaxLength(250)
                .HasColumnName("NewsTitleSYS");
            entity.Property(e => e.NewsUrl)
                .HasMaxLength(250)
                .HasColumnName("NewsURL");
        });

        modelBuilder.Entity<VwOffer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Offers", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.DateStart).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.OfferBanner).HasMaxLength(250);
            entity.Property(e => e.OfferBookingUrl)
                .HasColumnType("ntext")
                .HasColumnName("OfferBookingURL");
            entity.Property(e => e.OfferContentId).HasColumnName("OfferContentID");
            entity.Property(e => e.OfferDescription).HasColumnType("ntext");
            entity.Property(e => e.OfferInclude).HasColumnType("ntext");
            entity.Property(e => e.OfferName).HasMaxLength(250);
            entity.Property(e => e.OfferNameSys)
                .HasMaxLength(250)
                .HasColumnName("OfferNameSYS");
            entity.Property(e => e.OfferPhoto).HasMaxLength(250);
            entity.Property(e => e.OfferSubTitle1).HasColumnType("ntext");
            entity.Property(e => e.OfferSubTitle2).HasColumnType("ntext");
            entity.Property(e => e.OfferTerms).HasColumnType("ntext");
            entity.Property(e => e.OfferUrl)
                .HasMaxLength(250)
                .HasColumnName("OfferURL");
            entity.Property(e => e.Offerid).HasColumnName("offerid");
            entity.Property(e => e.PromoCode).HasMaxLength(250);
            entity.Property(e => e.ValidityText).HasColumnType("ntext");
        });

        modelBuilder.Entity<VwPage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Pages", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.PageBanner).HasMaxLength(250);
            entity.Property(e => e.PageContentId).HasColumnName("PageContentID");
            entity.Property(e => e.PageDetails).HasColumnType("ntext");
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.PageMetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.PageMetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.PageNameSys).HasMaxLength(250);
            entity.Property(e => e.PageTitle).HasMaxLength(250);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(250)
                .HasColumnName("PageURL");
            entity.Property(e => e.Updatetext).HasMaxLength(250);
        });

        modelBuilder.Entity<VwRestaurant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Restaurants", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DressCode).HasColumnType("ntext");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.Openinghours).HasColumnType("ntext");
            entity.Property(e => e.RestaurantBanner).HasMaxLength(250);
            entity.Property(e => e.RestaurantBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerHieghtMobile).HasColumnName("RestaurantBannerHieght_Mobile");
            entity.Property(e => e.RestaurantBannerHieghtTablet).HasColumnName("RestaurantBannerHieght_Tablet");
            entity.Property(e => e.RestaurantBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile");
            entity.Property(e => e.RestaurantBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet");
            entity.Property(e => e.RestaurantBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.RestaurantBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RestaurantBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.RestaurantBannerWidthMobile).HasColumnName("RestaurantBannerWidth_Mobile");
            entity.Property(e => e.RestaurantBannerWidthTablet).HasColumnName("RestaurantBannerWidth_Tablet");
            entity.Property(e => e.RestaurantCategoryId).HasColumnName("RestaurantCategoryID");
            entity.Property(e => e.RestaurantContentId).HasColumnName("RestaurantContentID");
            entity.Property(e => e.RestaurantCuisine).HasMaxLength(250);
            entity.Property(e => e.RestaurantDetails).HasColumnType("ntext");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.RestaurantMenu).HasMaxLength(250);
            entity.Property(e => e.RestaurantName).HasMaxLength(250);
            entity.Property(e => e.RestaurantNameSys).HasMaxLength(250);
            entity.Property(e => e.RestaurantNote).HasColumnType("ntext");
            entity.Property(e => e.RestaurantOpenFor).HasMaxLength(250);
            entity.Property(e => e.RestaurantPhoto).HasMaxLength(250);
            entity.Property(e => e.RestaurantPhotoHome).HasMaxLength(250);
            entity.Property(e => e.RestaurantSummery).HasColumnType("ntext");
            entity.Property(e => e.RestaurantTypeId).HasColumnName("RestaurantTypeID");
            entity.Property(e => e.RestaurantUrl)
                .HasMaxLength(250)
                .HasColumnName("RestaurantURL");
            entity.Property(e => e.RestaurantsTypeBanner).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypeBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Mobile");
            entity.Property(e => e.RestaurantsTypeBannerMobileHieght).HasColumnName("RestaurantsTypeBanner_MobileHieght");
            entity.Property(e => e.RestaurantsTypeBannerMobileWidth).HasColumnName("RestaurantsTypeBanner_MobileWidth");
            entity.Property(e => e.RestaurantsTypeBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Tablet");
            entity.Property(e => e.RestaurantsTypeBannerTabletHieght).HasColumnName("RestaurantsTypeBanner_TabletHieght");
            entity.Property(e => e.RestaurantsTypeBannerTabletWidth).HasColumnName("RestaurantsTypeBanner_TabletWidth");
            entity.Property(e => e.RestaurantsTypeIntro).HasColumnType("ntext");
            entity.Property(e => e.RestaurantsTypeName).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypePhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<VwRestaurantsGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Restaurants_Gallery", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.RestaurantFileId).HasColumnName("RestaurantFileID");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
        });

        modelBuilder.Entity<VwRestaurantsType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Restaurants_Types", "dbo");

            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypeBanner).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypeBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Mobile");
            entity.Property(e => e.RestaurantsTypeBannerMobileHieght).HasColumnName("RestaurantsTypeBanner_MobileHieght");
            entity.Property(e => e.RestaurantsTypeBannerMobileWidth).HasColumnName("RestaurantsTypeBanner_MobileWidth");
            entity.Property(e => e.RestaurantsTypeBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RestaurantsTypeBanner_Tablet");
            entity.Property(e => e.RestaurantsTypeBannerTabletHieght).HasColumnName("RestaurantsTypeBanner_TabletHieght");
            entity.Property(e => e.RestaurantsTypeBannerTabletWidth).HasColumnName("RestaurantsTypeBanner_TabletWidth");
            entity.Property(e => e.RestaurantsTypeId).HasColumnName("RestaurantsTypeID");
            entity.Property(e => e.RestaurantsTypeIntro).HasColumnType("ntext");
            entity.Property(e => e.RestaurantsTypeLangId).HasColumnName("RestaurantsTypeLangID");
            entity.Property(e => e.RestaurantsTypeName).HasMaxLength(250);
            entity.Property(e => e.RestaurantsTypePhoto).HasMaxLength(250);
        });

        modelBuilder.Entity<VwRoom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Rooms", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.FilterBy).HasMaxLength(250);
            entity.Property(e => e.HotelAccommodation).HasColumnType("ntext");
            entity.Property(e => e.HotelAccommodationBanner)
                .HasMaxLength(250)
                .HasColumnName("HotelAccommodation_Banner");
            entity.Property(e => e.HotelAccommodationBannerPhotoHieght).HasColumnName("HotelAccommodation_BannerPhoto_Hieght");
            entity.Property(e => e.HotelAccommodationBannerPhotoWidth).HasColumnName("HotelAccommodation_BannerPhoto_Width");
            entity.Property(e => e.HotelAccommodationMetatagDescription)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagDescription");
            entity.Property(e => e.HotelAccommodationMetatagTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_MetatagTitle");
            entity.Property(e => e.HotelAccommodationTitle)
                .HasColumnType("ntext")
                .HasColumnName("HotelAccommodation_Title");
            entity.Property(e => e.HotelContentId).HasColumnName("HotelContentID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelName).HasMaxLength(250);
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.MaxOccupancy).HasMaxLength(250);
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.RoomBanner).HasMaxLength(250);
            entity.Property(e => e.RoomBannerAltTag).HasMaxLength(250);
            entity.Property(e => e.RoomBannerColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_ColorOverlayTo");
            entity.Property(e => e.RoomBannerHieghtMobile).HasColumnName("RoomBannerHieght_Mobile");
            entity.Property(e => e.RoomBannerHieghtTablet).HasColumnName("RoomBannerHieght_Tablet");
            entity.Property(e => e.RoomBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile");
            entity.Property(e => e.RoomBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.RoomBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet");
            entity.Property(e => e.RoomBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.RoomBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("RoomBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.RoomBannerWidthMobile).HasColumnName("RoomBannerWidth_Mobile");
            entity.Property(e => e.RoomBannerWidthTablet).HasColumnName("RoomBannerWidth_Tablet");
            entity.Property(e => e.RoomBed).HasMaxLength(250);
            entity.Property(e => e.RoomContentId).HasColumnName("RoomContentID");
            entity.Property(e => e.RoomDetails).HasColumnType("ntext");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomName).HasMaxLength(250);
            entity.Property(e => e.RoomNameSys).HasMaxLength(250);
            entity.Property(e => e.RoomPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomPhotoHome).HasMaxLength(250);
            entity.Property(e => e.RoomPmscode)
                .HasMaxLength(250)
                .HasColumnName("RoomPMSCode");
            entity.Property(e => e.RoomSize).HasMaxLength(250);
            entity.Property(e => e.RoomSummery).HasColumnType("ntext");
            entity.Property(e => e.RoomTypeCategoryId).HasColumnName("RoomTypeCategoryID");
            entity.Property(e => e.RoomTypeCategoryName).HasMaxLength(250);
            entity.Property(e => e.RoomUrl)
                .HasMaxLength(250)
                .HasColumnName("RoomURL");
            entity.Property(e => e.RoomView).HasMaxLength(250);
            entity.Property(e => e.StartingFromCodeLang).HasColumnType("ntext");
        });

        modelBuilder.Entity<VwRoomsAmenity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RoomsAmenities", "dbo");

            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesCategoryContentId).HasColumnName("RoomAmenitiesCategoryContentID");
            entity.Property(e => e.RoomAmenitiesCategoryId).HasColumnName("RoomAmenitiesCategoryID");
            entity.Property(e => e.RoomAmenitiesCategoryName).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesId).HasColumnName("RoomAmenitiesID");
            entity.Property(e => e.RoomAmenitiesName).HasMaxLength(250);
            entity.Property(e => e.RoomAmenitiesPhoto).HasMaxLength(250);
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomRoomAmenitiesId).HasColumnName("Room_RoomAmenitiesID");
        });

        modelBuilder.Entity<VwRoomsGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RoomsGallery", "dbo");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.PhotoFile).HasMaxLength(250);
            entity.Property(e => e.PhotoFormat).HasMaxLength(250);
            entity.Property(e => e.RoomFileId).HasColumnName("RoomFileID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomUrl)
                .HasMaxLength(250)
                .HasColumnName("RoomURL");
        });

        modelBuilder.Entity<VwSiteContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SiteContacts", "dbo");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SiteAddress).HasColumnType("ntext");
            entity.Property(e => e.SiteEmail).HasMaxLength(250);
            entity.Property(e => e.SiteFax).HasMaxLength(250);
            entity.Property(e => e.SiteMobile).HasMaxLength(250);
            entity.Property(e => e.SiteTel).HasMaxLength(250);
        });

        modelBuilder.Entity<VwSlider>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Sliders", "dbo");

            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SliderButtonText).HasMaxLength(250);
            entity.Property(e => e.SliderId).HasColumnName("SliderID");
            entity.Property(e => e.SliderMainText).HasMaxLength(250);
            entity.Property(e => e.SliderPhoto).HasMaxLength(250);
            entity.Property(e => e.SliderSubText).HasMaxLength(250);
            entity.Property(e => e.SliderbuttonUrl)
                .HasMaxLength(250)
                .HasColumnName("SliderbuttonURL");
        });

        modelBuilder.Entity<VwSpa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SPA", "dbo");

            entity.Property(e => e.AgeRequirement)
                .HasColumnType("ntext")
                .HasColumnName("AGE_REQUIREMENT");
            entity.Property(e => e.CancellationPolicy)
                .HasColumnType("ntext")
                .HasColumnName("CANCELLATION_POLICY");
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FacilityBanner).HasMaxLength(250);
            entity.Property(e => e.FacilityBannerHieghtMobile).HasColumnName("FacilityBannerHieght_Mobile");
            entity.Property(e => e.FacilityBannerHieghtTablet).HasColumnName("FacilityBannerHieght_Tablet");
            entity.Property(e => e.FacilityBannerMobile)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile");
            entity.Property(e => e.FacilityBannerMobileColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerMobileColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Mobile_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerTablet)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet");
            entity.Property(e => e.FacilityBannerTabletColorOverlayFrom)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayFrom");
            entity.Property(e => e.FacilityBannerTabletColorOverlayTo)
                .HasMaxLength(250)
                .HasColumnName("FacilityBanner_Tablet_ColorOverlayTo");
            entity.Property(e => e.FacilityBannerWidthMobile).HasColumnName("FacilityBannerWidth_Mobile");
            entity.Property(e => e.FacilityBannerWidthTablet).HasColumnName("FacilityBannerWidth_Tablet");
            entity.Property(e => e.FacilityDetails).HasColumnType("ntext");
            entity.Property(e => e.FacilityName).HasMaxLength(250);
            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityPhoto).HasMaxLength(250);
            entity.Property(e => e.FacilitySummery).HasColumnType("ntext");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.Fb360url)
                .HasColumnType("ntext")
                .HasColumnName("FB360URL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.MetatagDescription).HasColumnType("ntext");
            entity.Property(e => e.MetatagTitle).HasColumnType("ntext");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("ntext")
                .HasColumnName("OPENING_HOURS");
            entity.Property(e => e.SpaArrival)
                .HasColumnType("ntext")
                .HasColumnName("SPA_ARRIVAL");
            entity.Property(e => e.SpaContentId).HasColumnName("SpaContentID");
            entity.Property(e => e.SpaId).HasColumnName("SpaID");
        });

        modelBuilder.Entity<VwSpaService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SPA_Services", "dbo");

            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SpaId).HasColumnName("SpaID");
            entity.Property(e => e.SpaservicesContentId).HasColumnName("SPAServicesContentID");
            entity.Property(e => e.SpaservicesDetails)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesDetails");
            entity.Property(e => e.SpaservicesExtraNote)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesExtraNote");
            entity.Property(e => e.SpaservicesId).HasColumnName("SPAServicesID");
            entity.Property(e => e.SpaservicesName)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesName");
            entity.Property(e => e.SpaservicesPosition).HasColumnName("SPAServicesPosition");
            entity.Property(e => e.SpaservicesPrice)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesPrice");
            entity.Property(e => e.SpaservicesStatus).HasColumnName("SPAServicesStatus");
            entity.Property(e => e.SpaservicesTime)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesTime");
            entity.Property(e => e.SpaservicesTypeId).HasColumnName("SPAServicesTypeID");
            entity.Property(e => e.SpaservicesTypeName)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesTypeName");
            entity.Property(e => e.SpaservicesTypePosition).HasColumnName("SPAServicesTypePosition");
        });

        modelBuilder.Entity<VwSpaServicesType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SPA_Services_Types", "dbo");

            entity.Property(e => e.FacilityNameSys)
                .HasMaxLength(250)
                .HasColumnName("FacilityNameSYS");
            entity.Property(e => e.FacilityUrl)
                .HasMaxLength(250)
                .HasColumnName("FacilityURL");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.SpaId).HasColumnName("SpaID");
            entity.Property(e => e.SpaservicesTypeContentId).HasColumnName("SPAServicesTypeContentID");
            entity.Property(e => e.SpaservicesTypeExtraText)
                .HasColumnType("ntext")
                .HasColumnName("SPAServicesTypeExtraText");
            entity.Property(e => e.SpaservicesTypeId).HasColumnName("SPAServicesTypeID");
            entity.Property(e => e.SpaservicesTypeName)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesTypeName");
            entity.Property(e => e.SpaservicesTypeNameSys)
                .HasMaxLength(250)
                .HasColumnName("SPAServicesTypeNameSYS");
            entity.Property(e => e.SpaservicesTypePosition).HasColumnName("SPAServicesTypePosition");
            entity.Property(e => e.SpaservicesTypeStatus).HasColumnName("SPAServicesTypeStatus");
        });

        modelBuilder.Entity<VwTeam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Teams", "dbo");

            entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.HotelNameSys).HasMaxLength(250);
            entity.Property(e => e.HotelUrl)
                .HasMaxLength(250)
                .HasColumnName("HotelURL");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.LanguageAbbreviation).HasMaxLength(250);
            entity.Property(e => e.LanguageFlag).HasMaxLength(250);
            entity.Property(e => e.LanguageName).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.TeamContentId).HasColumnName("TeamContentID");
            entity.Property(e => e.TeamDetails).HasColumnType("ntext");
            entity.Property(e => e.TeamEmail).HasMaxLength(250);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TeamMobile).HasMaxLength(250);
            entity.Property(e => e.TeamName).HasMaxLength(250);
            entity.Property(e => e.TeamNameSys).HasMaxLength(250);
            entity.Property(e => e.TeamPhoto).HasMaxLength(250);
            entity.Property(e => e.TeamTitlePosition).HasMaxLength(250);
            entity.Property(e => e.TeamUrl)
                .HasMaxLength(250)
                .HasColumnName("TeamURL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

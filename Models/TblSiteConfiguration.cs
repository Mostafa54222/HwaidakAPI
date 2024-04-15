using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblSiteConfiguration
{
    public int SiteId { get; set; }

    public string GoogleTagMangerKey { get; set; }

    public string FacebookVerification { get; set; }

    public string YandexVerification { get; set; }

    public string GoogleSearchConsole { get; set; }

    public string ContactUsEmail { get; set; }

    public string Faqemail { get; set; }

    public string MeetingRequestEmail { get; set; }

    public string BingVerification { get; set; }

    public string Vkverification { get; set; }

    public string Smtpemail { get; set; }

    public string Smtpsecure { get; set; }

    public string Smtphost { get; set; }

    public string Smtpport { get; set; }

    public string Smtpusername { get; set; }

    public string Smtppassword { get; set; }

    public string TestEmailReciever { get; set; }

    public string BusinessName { get; set; }

    public string SiteUrl { get; set; }

    public string LicenseKey { get; set; }

    public bool? ReviewsApproval { get; set; }

    public bool? ReviewStatus { get; set; }

    public string EmailTemplateContactUs { get; set; }

    public string EmailTemplateNewsletter { get; set; }

    public string EmailTemplateProductRequest { get; set; }

    public bool? EnbaleFaq { get; set; }

    public bool? EnbaleTeams { get; set; }

    public bool? EnableBlog { get; set; }

    public bool? EnableSocialMedia { get; set; }

    public bool? EnableNews { get; set; }

    public bool? EnableAwards { get; set; }

    public bool? EnableMeeting { get; set; }

    public bool? EnableCareer { get; set; }

    public bool? EnableOffers { get; set; }

    public bool? EnableOnlineBooking { get; set; }

    public bool? EnableOnlineCheckIn { get; set; }

    public string PinterestVerification { get; set; }

    public int? SiteTypeId { get; set; }

    public bool? EnablePriceStartFrom { get; set; }
}

using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblHomeContent
{
    public int HomeContentId { get; set; }

    public int? LangId { get; set; }

    public int? HomeId { get; set; }

    public string SectionWelcomeTitle1 { get; set; }

    public string SectionWelcomeTitle2 { get; set; }

    public string SectionWelcomeTitleText { get; set; }

    public string SectionAboutTitle { get; set; }

    public string SectionAboutText { get; set; }

    public string SectionAboutBtnText { get; set; }

    public string SectionAboutBtnUrl { get; set; }

    public string SectionRoomTitleBack { get; set; }

    public string SectionRoomTitle { get; set; }

    public string SectionRoomText { get; set; }

    public string SectionOfferTopTitle { get; set; }

    public string SectionOfferTitle { get; set; }

    public string SectionOfferText { get; set; }

    public string SectionOfferBtnText { get; set; }

    public string SectionOfferBtnUrl { get; set; }

    public string SectionActivitiesTitle { get; set; }

    public string SectionActivitiesText { get; set; }

    public string SectionActivitiesBtnText { get; set; }

    public string SectionActivitiesBtnUrl { get; set; }

    public string SectionMeetingTopTitle { get; set; }

    public string SectionMeetingTitle { get; set; }

    public string SectionMeetingText { get; set; }

    public string SectionMeetingBtnText { get; set; }

    public string SectionMeetingBtnUrl { get; set; }

    public string SectionNewsTitle { get; set; }

    public string SectionNewsText { get; set; }

    public string SectionNewsBtnText { get; set; }

    public string SectionNewsBtnUrl { get; set; }

    public string ExploreTeamText { get; set; }

    public string ExploreTeamTitle { get; set; }

    public string AwardTitle { get; set; }

    public string AwardText { get; set; }

    public string NewsletterTitle { get; set; }

    public string NewsletterText { get; set; }

    public string AboutUsText { get; set; }

    public string AboutUsTitle { get; set; }

    public string BookingEngineUrl { get; set; }

    public string SectionDiningTitle { get; set; }

    public string SectionDiningText { get; set; }

    public string SectionDiningBtnText { get; set; }

    public string SectionDiningBtnUrl { get; set; }

    public string SectionWeddingTopTitle { get; set; }

    public string SectionWeddingTitle { get; set; }

    public string SectionWeddingText { get; set; }

    public string SectionWeddingBtnText { get; set; }

    public string SectionWeddingBtnUrl { get; set; }

    public string SectionWhyChooseUsTittle { get; set; }

    public string SectionWhyChooseUsText { get; set; }

    public string SectionNewsLetterTittle { get; set; }

    public string SectionNewsLetterSubTittle { get; set; }

    public string SectionNewsLetterText { get; set; }

    public string SectionAwardsTittle { get; set; }

    public string BtnCheckAvalibality { get; set; }

    public string BtnViewRoom { get; set; }

    public string SectionNewsLetterBtn { get; set; }

    public string SectionNewsLetterBtnPlaceholder { get; set; }

    public virtual TblHome Home { get; set; }
}

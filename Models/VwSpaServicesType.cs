using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class VwSpaServicesType
{
    public int SpaservicesTypeId { get; set; }

    public string SpaservicesTypeNameSys { get; set; }

    public bool? SpaservicesTypeStatus { get; set; }

    public int? SpaservicesTypePosition { get; set; }

    public int SpaservicesTypeContentId { get; set; }

    public string SpaservicesTypeName { get; set; }

    public int? LangId { get; set; }

    public string LanguageName { get; set; }

    public string LanguageFlag { get; set; }

    public string LanguageAbbreviation { get; set; }

    public string SpaservicesTypeExtraText { get; set; }

    public int? SpaId { get; set; }

    public int? HotelId { get; set; }

    public string FacilityUrl { get; set; }

    public string FacilityNameSys { get; set; }
}

using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGallerySectionsPhotosContent
{
    public int PhotoContentId { get; set; }

    public int? PhotoId { get; set; }

    public int? LangId { get; set; }

    public string PhotoTitle { get; set; }

    public virtual TblGallerySectionsPhoto Photo { get; set; }
}

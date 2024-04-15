using System;
using System.Collections.Generic;

namespace HwaidakAPI.Models;

public partial class TblGallerySection
{
    public int GallerySectionId { get; set; }

    public string GallerySectionNameSys { get; set; }

    public bool? GalleryStatus { get; set; }

    public int? GalleryPosition { get; set; }

    public int? HotelId { get; set; }

    public virtual ICollection<TblGallerySectionsContent> TblGallerySectionsContents { get; set; } = new List<TblGallerySectionsContent>();
}

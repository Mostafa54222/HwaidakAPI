
namespace HwaidakAPI.DTOs.Responses.Gallery
{
    public class GetGalleryResponse
    {
        public MainResponse PageDetails { get; set; }
        public List<GetGalleryPhotos> Galleries { get; set; }
    }
}

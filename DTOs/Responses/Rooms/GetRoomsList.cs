namespace HwaidakAPI.DTOs.Responses.Rooms
{
    public class GetRoomsList
    {
        public MainResponse PageDetails { get; set; }
        public List<GetRoom> RoomsList { get; set; }
    }
}

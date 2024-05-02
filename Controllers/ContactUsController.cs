using AutoMapper;
using HwaidakAPI.DTOs;
using HwaidakAPI.Errors;
using HwaidakAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HwaidakAPI.DTOs.Responses.ContactUs;
using HwaidakAPI.OPModels;
using HwaidakAPI.Helpers;

namespace HwaidakAPI.Controllers
{
    public class ContactUsController : BaseApiController
    {
        private readonly HwaidakHotelsWsdbContext _context;
        private readonly HwaidakHotelsOpedbContext _opContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _email;

        //private readonly IEmailSender _email;

        public ContactUsController(HwaidakHotelsWsdbContext context, HwaidakHotelsOpedbContext opContext, IMapper mapper, IConfiguration configuration, IEmailSender email)
        {
            _context = context;
            _opContext = opContext;
            _mapper = mapper;
            _configuration = configuration;
            _email = email;
        }

        [HttpGet("{languageCode}/{hotelUrl}")]
        public async Task<ActionResult<ContactResponse>> GetHotelContactUs(string hotelUrl, string languageCode = "en")
        {
            var hotel = await _context.VwHotels.Where(x => x.HotelUrl == hotelUrl && x.HotelStatus == true && x.LanguageAbbreviation == languageCode).FirstOrDefaultAsync();
            if (hotel == null) return NotFound(new ApiResponse(404, "there is no hotel with this name"));
            
            MainResponse pagedetails = new MainResponse
            {
                PageTitle = hotel.HotelContactTitle,
                PageBannerPC = _configuration["ImagesLink"] + hotel.HotelContactBanner,
                PageBannerMobile = _configuration["ImagesLink"] + hotel.HotelContactBannerMobile,
                PageBannerTablet = _configuration["ImagesLink"] + hotel.HotelContactBannerTablet,
                PageText = hotel.HotelContact,
                PageMetatagTitle = hotel.HotelContactMetaTagTitle,
                PageMetatagDescription = hotel.HotelContactMetatagDescription
            };

            var contactsDto = _mapper.Map<GetContactHotel>(hotel);



            ContactResponse model = new()
            {
                PageDetails = pagedetails,
                ContactDetails = contactsDto
            };


            return Ok(model);
        }


        [HttpPost("ContactUs-Submit")]

        public async Task<ActionResult<TblRequestsContact>> CreateContactUs(ContactUsRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();

                return BadRequest(errors);
            }

            var entity = new TblRequestsContact
            {

                CustomerName = request.CustomerName,
                CustomerEmail = request.CustomerEmail,
                CustomerPhone = request.CustomerPhone,
                CustomerMessage = request.CustomerMessage

            };


            var item = await _opContext.TblRequestsContacts.AddAsync(entity);
            await _opContext.SaveChangesAsync();
            if (item == null)
                return BadRequest("ContactUs not save to DB");




            #region Send Mail
            string body =
                @"<table  style='border:1px solid #ccc;text-align: left;border-collapse: collapse;width: 100%;'>
                       <tbody>";



            body +=
            @"<tr style='border: 1px solid #ccc;text-align: left;padding: 15px;'>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;width:200px;background-color:#ddd;'>Customer Name: </td>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;'> " + entity.CustomerName + @" </td>
                       </tr>";




            body +=
            @"<tr style='border: 1px solid #ccc;text-align: left;padding: 15px;'>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;width:200px;background-color:#ddd;'>Customer Email: </td>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;'> " + entity.CustomerEmail + @" </td>
                       </tr>";

            body +=
            @"<tr style='border: 1px solid #ccc;text-align: left;padding: 15px;'>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;width:200px;background-color:#ddd;'>Customer Mobile: </td>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;'> " + entity.CustomerPhone + @" </td>
                       </tr>";
            body +=
           @"<tr style='border: 1px solid #ccc;text-align: left;padding: 15px;'>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;width:200px;background-color:#ddd;'>Customer Email: </td>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;'> " + entity.CustomerEmail + @" </td>
                       </tr>";



            body +=
            @"<tr style='border: 1px solid #ccc;text-align: left;padding: 15px;'>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;width:200px;background-color:#ddd;'>Message: </td>
                       <td style='border: 1px solid #ccc;text-align: left;padding: 15px;'> " + entity.CustomerMessage + @" </td>
                       </tr>";
            body += @"</tbody></table> ";
            #endregion



            //_email.SendMail("do_not_reply@cleoparksharm.com", "fo.sharmdreams@jazhotels.com", "ContactUs Request", body);
            //_email.SendMail("do_not_reply@cleoparksharm.com", "ahmed.taha@titegypt.com", "ContactUs Request", body);

            try
            {
                //SendMail("do_not_reply@cleoparksharm.com", "abdallah.abdelnasser@titegypt.com", "Booking Request", body);
                Console.WriteLine("Order is created and email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
            }


            return Ok(entity);
        }

    }
}

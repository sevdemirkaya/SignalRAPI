using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;
using SignalR.DtoLayer.BookingDto;
using System.ComponentModel.DataAnnotations;

namespace SignalRWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,

            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var booking = new Booking
            {
                Mail = updateBookingDto.Mail,
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date
            };

            _bookingService.UpdateBooking(booking);
            return Ok("Rezervasyon güncellendi");
        }
        [HttpGet("GetBooking")]
        [HttpPost("ResultBooking")]
        [HttpGet("GetBookingID")]
        public IActionResult GetBookingID(GetBookingDto getBookingDto)
        {
            var booking = new Booking
            {
                Mail = getBookingDto.Mail,
                BookingID = getBookingDto.BookingID,
                Name = getBookingDto.Name,
                PersonCount = getBookingDto.PersonCount,
                Phone = getBookingDto.Phone,
                Date = getBookingDto.Date
            };

            var list = _bookingService.TGetListAll(); // ← düzeltildi
            return Ok("Rezervasyon sonucu işlendi");
        }

        [HttpGet("booking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id); // ← düzeltildi
            return Ok(value);
        }
    }
}


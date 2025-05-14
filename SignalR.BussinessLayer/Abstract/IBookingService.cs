using SignalR.EntityLayer.Entities;

namespace SignalR.BussinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void UpdateBooking(Booking booking);
    }
}

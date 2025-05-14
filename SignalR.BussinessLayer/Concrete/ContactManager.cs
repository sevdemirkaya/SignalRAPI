using SignalR.BussinessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BussinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactService _contactDal;
        public void TAdd(Contact entity)
        {
            _contactDal.TAdd(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.TDelete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.TGetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.TGetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.TUpdate(entity);
        }
    }
}

using SignalR.EntityLayer.Entities;

namespace SignalR.BussinessLayer.Abstract
{
    public interface IContactService : IGenericService <Contact>
    {
        public interface IContactService
        {
            
            void TAdd(Contact entity);
            void TDelete(Contact entity);
            Contact GetByID(int id);
            List<Contact> TGetListAll();
            void TUpdate(Contact entity);
        }


    }
}

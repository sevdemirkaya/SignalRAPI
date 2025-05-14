using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.EntityFramework;
using SignalR.EntityLayer.Entities;

namespace SignalR.BussinessLayer.Concrete
{
    public class CategoryManager(ICategoryDal _categoryDal) : ICategoryService
    {

        private readonly ICategoryDal _categoryDal = _categoryDal;

      
        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }

}

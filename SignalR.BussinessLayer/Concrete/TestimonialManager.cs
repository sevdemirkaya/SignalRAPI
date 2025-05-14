using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialService _testimonialDal;
        public void TAdd(Testimonial entity)
        {
            _testimonialDal.TAdd(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.TDelete(entity);
        }

        public Testimonial TGetByID(int id)
        {
            
             return _testimonialDal.TGetByID(id);

        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDal.TGetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.TUpdate(entity);
        }
    }
}

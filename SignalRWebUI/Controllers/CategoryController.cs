using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoryController (ICategoryService _categoryService, IMapper _mapper)
        {
            mapper = _mapper;
            categoryService = _categoryService;
        }
    }
}

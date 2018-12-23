using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Base.Api
{
    public abstract class BaseController : Controller
    {
        protected readonly IMapper mapper;

        public BaseController(IMapper mapper)
        {
            this.mapper = mapper;
        }
    }
}

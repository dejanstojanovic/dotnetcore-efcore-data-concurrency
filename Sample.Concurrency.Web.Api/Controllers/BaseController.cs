using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sample.Concurrency.Data.UnitsOfWork;

namespace Sample.Concurrency.Web.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected IUnitOfWork unitOfWork;
        protected IMapper mapper;
        public BaseController(IUnitOfWork unitOfWork, IMapper mapper) {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
    }
}
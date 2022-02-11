using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class MainController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}

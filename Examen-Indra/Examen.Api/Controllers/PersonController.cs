using Examen.Api.Contracts;
using Examen.Application.Person;
using Examen.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [ApiVersion("1.0")]
    public class PersonController : MainController
    {
        [HttpGet(ApiRoutes.ListPersons)]
        public async Task<ActionResult<IEnumerable<PersonViewModel>>> ListPersons()
        {
            var response = await Mediator.Send(new ListPersons.Request { });
            return Ok(response);
        }

        [HttpGet(ApiRoutes.ListPerson)]
        public async Task<ActionResult<PersonViewModel>> ListPerson(Guid id)
        {
            var response = await Mediator.Send(new ListPerson.Request { Id = id });
            return Ok(response);
        }

        [HttpPost(ApiRoutes.InsertPerson)]
        public async Task<ActionResult<PersonViewModel>> InsertPerson(InsertPerson.Request request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPut(ApiRoutes.UpdatePerson)]
        public async Task<ActionResult<PersonViewModel>> UpdatePerson(UpdatePerson.Request request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete(ApiRoutes.DeletePerson)]
        public async Task<ActionResult<PersonViewModel>> DeletePerson(Guid id)
        {
            var response = await Mediator.Send(new DeletePerson.Request { Id = id });
            return Ok(response);
        }
    }
}

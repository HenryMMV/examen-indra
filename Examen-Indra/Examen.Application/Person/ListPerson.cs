using AutoMapper;
using Examen.Application.ViewModels;
using Examen.Domain.Interfaces;
using MediatR;

namespace Examen.Application.Person
{
    public class ListPerson
    {
        public class Request : IRequest<PersonViewModel>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Request, PersonViewModel>
        {
            private readonly IPersonRepository _personRepository;
            private readonly IMapper _mapper;

            public Handler(IPersonRepository personRepository, IMapper mapper)
            {
                _personRepository = personRepository;
                _mapper = mapper;
            }

            public async Task<PersonViewModel> Handle(Request request, CancellationToken cancellationToken)
            {
                var person = await _personRepository.ListPerson(request.Id);
                return _mapper.Map<PersonViewModel>(person);
            }
        }
    }
}

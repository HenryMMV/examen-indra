using AutoMapper;
using Examen.Application.ViewModels;
using Examen.Domain.Interfaces;
using FluentValidation;
using MediatR;

namespace Examen.Application.Person
{
    public class UpdatePerson
    {
        public class Request : IRequest<PersonViewModel>
        {
            public string? LastName { get; set; }
            public string? FirstName { get; set; }
            public int? Document { get; set; }
            public string? DocumentNumber { get; set; }
            public DateTime? BirthDate { get; set; }
            public int? Gender { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
        }

        public class Validator : AbstractValidator<Request>
        {

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
                var person = _mapper.Map<Domain.Models.Person>(request);
                var response = await _personRepository.UpdatePerson(person);
                return _mapper.Map<PersonViewModel>(response);
            }
        }
    }
}

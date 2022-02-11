﻿using AutoMapper;
using Examen.Application.ViewModels;
using Examen.Domain.Interfaces;
using MediatR;

namespace Examen.Application.Person
{
    public class ListPersons
    {
        public class Request : IRequest<IEnumerable<PersonViewModel>>
        {

        }

        public class Handler : IRequestHandler<Request, IEnumerable<PersonViewModel>>
        {
            private readonly IPersonRepository _personRepository;
            private readonly IMapper _mapper;

            public Handler(IPersonRepository personRepository, IMapper mapper)
            {
                _personRepository = personRepository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<PersonViewModel>> Handle(Request request, CancellationToken cancellationToken)
            {
                var persons = await _personRepository.ListPersons();
                return _mapper.Map<IEnumerable<PersonViewModel>>(persons);
            }
        }
    }
}

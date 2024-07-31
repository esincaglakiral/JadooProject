﻿using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.DestinationResult;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;

        public GetDestinationQueryHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetDestinationQueryResult> Handle()
        {
            var values = _repository.GetList();
            var mappedValues = _mapper.Map<List<GetDestinationQueryResult>>(values);
            return mappedValues;
        }
    }
}
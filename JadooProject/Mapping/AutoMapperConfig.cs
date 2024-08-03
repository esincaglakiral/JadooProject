
using AutoMapper;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.BrandCommand;
using JadooProject.Features.CQRS.Commands.DestinationCommand;
using JadooProject.Features.CQRS.Commands.FeatureCommand;
using JadooProject.Features.CQRS.Commands.ManuelCommand;
using JadooProject.Features.CQRS.Commands.NewsCommand;
using JadooProject.Features.CQRS.Results.BrandResult;
using JadooProject.Features.CQRS.Results.DestinationResult;
using JadooProject.Features.CQRS.Results.FeatureResult;
using JadooProject.Features.CQRS.Results.ManuelResult;
using JadooProject.Features.CQRS.Results.NewsResult;
using JadooProject.Features.Mediator.Commands.ServiceCommands;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using JadooProject.Features.Mediator.Results.DestinationResults;
using JadooProject.Features.Mediator.Results.ServiceResult;
using JadooProject.Features.Mediator.Results.TestimonialResult;

namespace JadooProject.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Destination, GetDestinationQueryResult>().ReverseMap();
            CreateMap<Destination, GetDestinationByIdQueryResult>().ReverseMap();
            CreateMap<Destination, CreateDestinationCommand>().ReverseMap();
            CreateMap<Destination, UpdateDestinationCommand>().ReverseMap();
            CreateMap<Destination, GetDestinationDashboardQueryResult>().ReverseMap();
            CreateMap<Destination, GetDestinationHomeQueryResult>().ReverseMap();
            CreateMap<Destination, GetLatestDestinationQueryResult>().ReverseMap();
            CreateMap<Destination, GetDestinationDetailsQueryResult>().ReverseMap();
            CreateMap<Destination, GetDefaultDestinationQueryResult>().ReverseMap();

            CreateMap<GetDestinationByIdQueryResult, UpdateDestinationCommand>();



            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<GetBrandByIdQueryResult, UpdateBrandCommand>().ReverseMap();


            CreateMap<Service, GetServiceQueryResult>().ReverseMap();
            CreateMap<Service, GetServiceByIdQueryResult>().ReverseMap();
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();



            CreateMap<Feature, GetFeatureQueryResult>().ReverseMap();
            CreateMap<Feature, GetFeatureByIdQueryResult>().ReverseMap();
            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();
            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();
            CreateMap<GetFeatureByIdQueryResult, UpdateFeatureCommand>().ReverseMap();




            CreateMap<Manuel, GetManuelQueryResult>().ReverseMap();
            CreateMap<Manuel, GetManuelByIdQueryResult>().ReverseMap();
            CreateMap<Manuel, CreateManuelCommand>().ReverseMap();
            CreateMap<Manuel, UpdateManuelCommand>().ReverseMap();
            CreateMap<UpdateManuelCommand, GetManuelByIdQueryResult>().ReverseMap();


            CreateMap<News, GetNewsQueryResult>().ReverseMap();
            CreateMap<News, GetNewsByIdQueryResult>().ReverseMap();
            CreateMap<News, UpdateNewsCommand>().ReverseMap();
            CreateMap<UpdateNewsCommand, GetNewsByIdQueryResult>().ReverseMap();



            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdQueryResult>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialForDashboardQueryResult>().ReverseMap();
            CreateMap<UpdateTestimonialCommand, GetTestimonialByIdQueryResult>().ReverseMap();
        }

    }
}

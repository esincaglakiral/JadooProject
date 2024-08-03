using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Concrete;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Handlers;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using JadooProject.Features.CQRS.Handlers.NewsHandlers;
using JadooProject.Features.Mediator.Handlers.DestinationHandlers;
using JadooProject.Features.Mediator.Handlers.TestimonialHandlers;

namespace JadooProject.Extensions
{
    public static class ServiceExtension
    {
        public static void AddServiceHandlers(this IServiceCollection services)
        {

            //Destination Handlerlarımızı scope ediyoruz
            services.AddScoped<GetDestinationQueryHandler>();  //bütün handler'arımızı burada scope ediyoruz
            services.AddScoped<GetDestinationByIdQueryHandler>();
            services.AddScoped<CreateDestinationCommandHandler>();
            services.AddScoped<RemoveDestinationCommandHandler>();
            services.AddScoped<UpdateDestinationCommandHandler>();
            services.AddScoped<GetLatestDestinationQueryHandler>();
            services.AddScoped<GetDestinationDashboardQueryHandler>();
            services.AddScoped<GetDestinationHomeQueryHandler>();
            services.AddScoped<GetDefaultDestinationQueryHandler>();
            services.AddScoped<Features.Mediator.Handlers.DestinationHandlers.GetDestinationDetailsQueryHandler>();




            //Brand Handlerlarımızı scope ediyoruz
            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();





            //Manuel Handlerlarımızı scope ediyoruz
            services.AddScoped<GetManuelQueryHandler>();
            services.AddScoped<CreateManuelCommandHandler>();
            services.AddScoped<GetManuelByIdQueryHandler>();
            services.AddScoped<UpdateManuelCommandHandler>();
            services.AddScoped<RemoveManuelCommandHandler>();





            //Feature Handlerlarımızı scope ediyoruz
            services.AddScoped<GetFeatureQueryHandler>();
            services.AddScoped<GetFeatureByIdQueryHandler>();
            services.AddScoped<UpdateFeatureCommandHandler>();
            services.AddScoped<CreateFeatureCommandHandler>();
            services.AddScoped<RemoveFeatureCommandHandler>();




            //Testimonial Handlerlarımızı scope ediyoruz
            services.AddScoped<GetTestimonialQueryHandler>();
            services.AddScoped<CreateTestimonialCommandHandler>();
            services.AddScoped<GetTestimonialByIdQueryHandler>();
            services.AddScoped<UpdateTestimonialCommandHandler>();
            services.AddScoped<RemoveTestimonialCommandHandler>();
            services.AddScoped<GetTestimonialForDashboardQueryHandler>();



            //News Handlerlarımızı scope ediyoruz
            services.AddScoped<GetNewsQueryHandler>();
            services.AddScoped<GetNewsByIdQueryHandler>();
            services.AddScoped<UpdateNewsCommandHandler>();
            services.AddScoped<CreateNewsCommandHandler>();
            services.AddScoped<RemoveNewsCommandHandler>();




            //Dashboard Handlerımızı scope ediyoruz
            services.AddScoped<GetDashboardQueryHandler>();

        }
    }
}

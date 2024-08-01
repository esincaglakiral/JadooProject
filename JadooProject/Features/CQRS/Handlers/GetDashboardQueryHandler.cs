using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DashboardResult;

namespace JadooProject.Features.CQRS.Handlers
{
    public class GetDashboardQueryHandler
    {

        private readonly IDestinationDal _destinationDal;
        private readonly IBrandDal _brandDal;
        private readonly IFeatureDal _featureDal;
        private readonly IServiceDal _serviceDal;
        private readonly ITestimonialDal _testimonialDal;
        private readonly INewsDal _newsDal;

        public GetDashboardQueryHandler(IDestinationDal destinationDal, IBrandDal brandDal, IFeatureDal featureDal, IServiceDal serviceDal, ITestimonialDal testimonialDal, INewsDal newsDal)
        {
            _destinationDal = destinationDal;
            _brandDal = brandDal;
            _featureDal = featureDal;
            _serviceDal = serviceDal;
            _testimonialDal = testimonialDal;
            _newsDal = newsDal;
        }



        public GetDashboardQueryResult Handle()
        {
            return new GetDashboardQueryResult()
            {
                DestinationCount = _destinationDal.GetDestinationCount(),
                BrandCount = _brandDal.GetBrandCount(),
                FeatureCount = _featureDal.GetFeatureCount(),
                ServiceCount = _serviceDal.GetServiceCount(),
                TestimonailCount = _testimonialDal.GetTestimonailCount(),
                NewsCount = _newsDal.GetNewsCount(),

            };
        }
    }
}
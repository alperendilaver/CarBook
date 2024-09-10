using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarsWithPricingQueryHandler
	{
		private readonly ICarRepository _carRepository;
        public GetCarsWithPricingQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetCarsWithPricingQueryResult>> Handle()
        {
            var entities =await _carRepository.GetCarsWithPricing();
            return entities.Select(x => new GetCarsWithPricingQueryResult
            {
                Amount = x.Amount,
                BigImageUrl = x.Car.BigImageUrl,
                BrandName = x.Car.Brand.Name,
                CarPricingId = x.CarPricingId,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
                PricingName = x.Pricing.Name
            }).ToList();
        }
    }
}

using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarWithBrandQueryHandler
	{
		private readonly ICarRepository _carRepository;

		public GetCarWithBrandQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}
		public async Task<List<GetCarWithBrandQueryResult>> Handle()
		{
			var values = await _carRepository.GetCarsWithBrand();
			return values.Select(x => new GetCarWithBrandQueryResult { BigImageUrl = x.BigImageUrl,
				BrandName = x.Brand.Name,
				CarId = x.CarId,
				CoverImageUrl = x.CoverImageUrl,
				Fuel = x.Fuel,
				Km = x.Km,
				Luggage = x.Luggage,
				Model = x.Model,
				Seats = x.Seats,
				Transmission = x.Transmission
			}).ToList();
		}
	}
}

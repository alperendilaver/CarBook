using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarWithBrandHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarWithBrandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetLast5CarWithBrandQueryResult>> Handle()
        {
            var values =await _carRepository.GetLast5CarsWithBrand();
            return values.Select(x => new GetLast5CarWithBrandQueryResult
            {
                BigImageUrl = x.BigImageUrl,
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

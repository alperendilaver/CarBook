using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarRepositories
{
	public interface ICarRepository
	{
		public Task<List<Car>> GetCarsWithBrand(); 
		public Task<List<Car>> GetLast5CarsWithBrand();
		public Task<List<CarPricing>> GetCarsWithPricing();
	}
}

using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarRepositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarRepositories
{
	public class CarRepository : ICarRepository
	{

		private readonly CarBookContext _context;

		public CarRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<Car>> GetCarsWithBrand()
		{
			return await _context.Cars.Include(x => x.Brand).ToListAsync();
		}

		public async Task<List<CarPricing>> GetCarsWithPricing()
		{
			return await _context.CarPricings.Include(x=>x.Car).ThenInclude(x=>x.Brand).Include(x=>x.Pricing).ToListAsync();
		}

		public async Task<List<Car>> GetLast5CarsWithBrand()
        {
			return await _context.Cars.Include(x => x.Brand).OrderByDescending(x=>x.CarId).Take(5).ToListAsync();
        }
    }
}

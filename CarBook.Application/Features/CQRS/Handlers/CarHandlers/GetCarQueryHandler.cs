﻿using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarQueryHandler
	{
		private readonly IRepository<Car> _repository;

		public GetCarQueryHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCategoryQueryResult>> Handle()
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x=>new GetCategoryQueryResult
			{BigImageUrl = x.BigImageUrl,
			BrandId = x.BrandId,
			CoverImageUrl = x.CoverImageUrl,
			CarId = x.CarId,
			Fuel = x.Fuel,
			Km = x.Km,
			Luggage = x.Luggage,
			Model = x.Model,
			Seats = x.Seats,
			Transmission = x.Transmission}).ToList();
		}
	}
}

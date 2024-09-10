﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
	public class GetCarsWithPricingQueryResult
	{
        public int CarPricingId { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
		public string CoverImageUrl { get; set; }
        public decimal Amount { get; set; }
        public string PricingName { get; set; }
        public string BigImageUrl { get; set; }
	}
}

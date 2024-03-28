﻿using Microsoft.AspNetCore.Mvc;
using PackWiseAPI.Entities;
using PackWiseAPI.Repositories;
using System.Security.AccessControl;

namespace PackWiseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectTrip : Controller
    {
        private readonly ITripCategoryService tripCategoryService;
        public SelectTrip(ITripCategoryService tripCategoryService)
        {
            this.tripCategoryService = tripCategoryService;
        }
        [HttpGet("{CategoryName}")]
        public async Task<List<TripCategory>> selectTrip(String CategoryName)
        {
            var selectTrip = await tripCategoryService.SelectTrip(CategoryName);
            if (selectTrip == null)
            {
                //return NotFound();
            }

            return selectTrip;



        }

    }
}


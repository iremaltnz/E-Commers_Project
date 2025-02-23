﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("list")]
        public IActionResult Get()
        {

            var result = _categoryService.CategoryList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.CategoryAdd(category);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }


        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.CategoryDelete(category);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.CategoryUpdate(category);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }
    }
}

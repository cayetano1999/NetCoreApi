using Data.Base;
using Data.Models;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _bookService;

        public BookController(IBook bookService)
        {
            this._bookService = bookService;
        }

        [HttpGet ("{id}")]
        [Route ("api/book/getBook")]
        public  IActionResult Get(int id)
        {
            var result = _bookService.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BookEntity b)
        {
            var result = await _bookService.Add(b);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] BookEntity b)
        {
            var result = await _bookService.Update(b);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _bookService.Delete(Id);
            return Ok(result);
        }

    }
}

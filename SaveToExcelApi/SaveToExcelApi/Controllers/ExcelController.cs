using System;
using Microsoft.AspNetCore.Mvc;
using GemBox.Spreadsheet;
using DataAccess;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace SaveToExcelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Successful");           
        }
        [HttpPost]
        public IActionResult Post([FromBody] List<User> data)
        {
            ExcelWriter.Write(data);
            return Ok("Successful");
        }
    }
}
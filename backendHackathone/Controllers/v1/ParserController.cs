using backendHackathone.PresentLayer.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace backendHackathone.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ParserController : Controller
    {
        private readonly IExcelParser _parser;

        public ParserController(IExcelParser excelParser)
        {
            _parser = excelParser;
        }

        [HttpPost("Parse")]
        public JsonResult Parse(IFormFile file)
        {
            using (var stream = new MemoryStream())
            {
                file.CopyTo(stream);
                var userTable = _parser.Parse(stream);
                return Json(userTable);
            }
        }
    }
}

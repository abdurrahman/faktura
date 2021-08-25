using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Faktura.WepApi.Controllers
{
    public class MetaController : BaseController
    {
        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            var assembly = typeof(Startup).Assembly;

            var creationDate = System.IO.File.GetCreationTime(assembly.Location);
            var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

            return Ok($"Version: {version}, Last Updated: {creationDate}");
        }
    }
}
using DomainModel.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using static DomainModel.Storage.Storage;

namespace WebApp.Controllers
{
    public class ImportExportController : ControllerBase
    {
        public IActionResult Save(Format format)
        {
            var contentType = GetContentType(format);
            var file = Storage.Instance.Save(format);
            return File(file.ToArray(), contentType.mime, $"Lab_6 JSON Data {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm")}{contentType.format}");
        }

        [HttpPost]
        public IActionResult Load(IFormFile file, Format format)
        {
            if (CheckFileFormat(file.ContentType, format))
            {
                Storage.Instance.Load(file, format);
                return Ok();
            }
            return NotFound($"Выбраный файл не соответсвует формату {format.ToString().ToUpper()}");
        }

        private (string mime, string format) GetContentType(Format format)
        {
            switch (format)
            {
                case Format.bin:
                    return ("application/octet-stream", ".bin");
                case Format.xml:
                    return ("text/xml", ".xml");
                case Format.json:
                    return ("application/json", ".json");
                default:
                    return (string.Empty, string.Empty);

            }
        }

        private bool CheckFileFormat(string contentType, Format format)
        {
            var type = GetContentType(format);
            return type.mime == contentType;
        }
    }
}

using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadingDemo.Models;
//using UploadingDemo.Services;

namespace UploadingDemo.Controllers
{
  public class HomeController : Controller
  {

    IConfiguration Configuration;

    public HomeController(IConfiguration config)
    {
      Configuration = config;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(Document document, IFormFile file)
    {

      BlobContainerClient container = new BlobContainerClient(Configuration.GetConnectionString("AzureBlob"), "attachments");
      await container.CreateIfNotExistsAsync();
      BlobClient blob = container.GetBlobClient(file.FileName);
      using var stream = file.OpenReadStream();

      BlobUploadOptions options = new BlobUploadOptions()
      {
        HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
      };


      if (!blob.Exists())
      {
        await blob.UploadAsync(stream, options);
      }

      document.Url = blob.Uri.ToString();

      //Document document = new Document()
      //{
      //  PNmae = name,
      //  Price = price,
      //  Url = blob.Uri.ToString()
      //};
      stream.Close();
      // Upload the file
      return View(document);
    }


  }
}

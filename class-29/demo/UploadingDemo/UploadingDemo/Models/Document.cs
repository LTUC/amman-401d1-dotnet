using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UploadingDemo.Models
{
  public class Document
  {    public string Url { get; set; }
    public string PNmae{ get; set; }
    public int Price{ get; set; }

  }

}

using Microsoft.AspNetCore.Mvc;

namespace ST10045251_CLDV6212_POE.Controllers
{
    public class ProductImages : Controller
    {
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            var storageConnectionString = "<Your Azure Storage Connection String>";
            var blobService = new BlobService(storageConnectionString, "product-images");

            await blobService.UploadImageAsync(file, file.FileName);

            return RedirectToAction("Index");
        }
    }
}

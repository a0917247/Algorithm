using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class QRcodeController : Controller
    {
        public ActionResult Index(QRcodeViewModel model)
        {
            return View(model) ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUrlEncodeQRCode(QRcodeViewModel model)
        {
            return Json(new
            {
                success = true,
                Url = "data:image/png;base64," + CreateUrlEncodeQRCodeBase64(model.url)
            });
        }

        public string CreateUrlEncodeQRCodeBase64(string URL)
        {
            // 建立 QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(URL, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            ImageConverter converter = new ImageConverter();
            var result = Convert.ToBase64String((byte[])converter.ConvertTo(qrCodeImage, typeof(byte[])));
            return result;
        }
    }
}
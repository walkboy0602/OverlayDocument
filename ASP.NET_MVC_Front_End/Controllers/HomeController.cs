using System.Web.Mvc;
using static MvcSample.Helpers.Constant;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Url = Request.Url;
            return View();
        }


        public ActionResult Doc(DocumentType documentType)
        {

            switch (documentType)
            {
                case DocumentType.Doc:
                    ViewBag.DocumentFile = "demo.docx";
                    break;
                case DocumentType.Ppt:
                    ViewBag.DocumentFile = "sample.pptx";
                    break;
                case DocumentType.Xls:
                    ViewBag.DocumentFile = "sample.xlsx";
                    break;
                case DocumentType.Pdf:
                    ViewBag.DocumentFile = "candy.pdf";
                    break;
            }

            return View();
        }

        public ActionResult Comment()
        {
            return View();
        }
    }
}
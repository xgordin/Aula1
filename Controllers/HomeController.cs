using System.Web.Mvc;

namespace Aula1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Teste() {

            return View("Index");//posso chamar uma action dentro da view

        }
    }
}